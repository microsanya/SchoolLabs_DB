using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolLabs
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }


        DataTable FillDataGridView(string sqlSelect)
        {

            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.SchoolConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private static FormSQL f;

        public static FormSQL fsql
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new FormSQL();
                }
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void radioButtonAdmins_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Администратор");
        }

        private void radioButtonContracts_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"
            SELECT ID_договора, ID_ученика, ID_администратора, Краткое_описание, Стоимость_услуг, Количество_оплачиваемых_занятий
            FROM Договор
            WHERE ID_администратора = 1");
        }

        private void radioButtonStudents_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"
                SELECT 
                    Договор.ID_договора,
                    Договор.Краткое_описание,
                    Администратор.ФИО AS ФИО_администратора,
                    Ученик.ФИО_ученика AS ФИО_ученика,
                    Договор.Стоимость_услуг
                FROM 
                    Договор
                JOIN 
                    Администратор ON Договор.ID_администратора = Администратор.ID_администратора
                JOIN 
                    Ученик ON Договор.ID_ученика = Ученик.ID_ученика
                ");
        }


        private void buttonF_select_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxContract.Text))
            {
                MessageBox.Show("Обязательно укажите краткое описание необходимого договора.\n" +
                    "Допустим ввод первых символов.", "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            if (checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указана прибыль в условии", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }
            string sqlSelect = "";
            if (radioButtonDet_Admins.Checked)
                sqlSelect = @"SELECT 
                    d.*,
                    a.ФИО AS ФИО_администратора
                    FROM 
                        Договор d
                    JOIN 
                        Администратор a ON d.ID_администратора = a.ID_администратора
                    WHERE
                        d.Краткое_описание LIKE @short_description";
            else
            if (radioButtonDet_Students.Checked)
                sqlSelect = @"SELECT 
                        d.*,
                        u.ФИО_ученика AS ФИО_ученика
                    FROM 
                        Договор d
                    JOIN 
                        Ученик u ON d.ID_ученика = u.ID_ученика
                    WHERE 
                        d.Краткое_описание LIKE @short_description";
            else
                sqlSelect = @"SELECT 
                    d.*
                    FROM 
                        Договор d
                    WHERE
                        d.Краткое_описание LIKE @short_description";
            if (checkBoxMore.Checked)
                sqlSelect = "SELECT " +
                        "d.ID_договора," +
                        "d.ID_ученика," +
                        "d.ID_администратора," +
                        "d.Краткое_описание," +
                        "d.Стоимость_услуг," +
                        "d.Количество_оплачиваемых_занятий" +
                    " FROM " +
                        "Договор d" +
                    " GROUP BY " +
                        "d.ID_договора," +
                        "d.ID_ученика," +
                        "d.ID_администратора," +
                        "d.Краткое_описание," +
                        "d.Стоимость_услуг," +
                        "d.Количество_оплачиваемых_занятий" +
                        " HAVING d.Стоимость_услуг > @amount";
          
            if (checkBoxOrder.Checked)
                sqlSelect += " ORDER BY Стоимость_услуг desc";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.SchoolConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@short_description", textBoxContract.Text + "%");
            if (checkBoxMore.Checked)
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Money).Value =
                    Double.Parse(textBoxMore.Text);
                }
                catch
                {
                    MessageBox.Show("Прибыль в условии должна быть задана числом", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBoxMore.Checked = false;
                    return;
                }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStudent.Text))
            {
                MessageBox.Show("Обязательно укажите ФИО или часть ФИО ученика",
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.SchoolConnectionString);
            connection.Open();

            SqlCommand findIdCmd = new SqlCommand(@"
                SELECT TOP 1 ID_ученика 
                FROM Ученик 
                WHERE ФИО_ученика LIKE @name", connection);
            findIdCmd.Parameters.AddWithValue("@name", "%" + textBoxStudent.Text + "%");

            object result = findIdCmd.ExecuteScalar();

            if (result == null)
            {
                MessageBox.Show("Ученик не найден", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                return;
            }

            int studentId = Convert.ToInt32(result);

            string sqlSelect = "";

            if (radioButtonCorrelated.Checked)
            {
                sqlSelect = @"
            SELECT 
                u.ID_ученика,
                u.ФИО_ученика,
                d.ID_договора, 
                d.Краткое_описание, 
                d.Стоимость_услуг
            FROM 
                Ученик u
            JOIN 
                Договор d ON u.ID_ученика = d.ID_ученика
            WHERE 
                d.Стоимость_услуг > (
                    SELECT AVG(d2.Стоимость_услуг)
                    FROM Договор d2
                    WHERE d2.ID_ученика = u.ID_ученика)";
            }
            else if (radioButtonNoCorrelated.Checked)
            {
                sqlSelect = @"
            SELECT a.ФИО, d.ID_договора, d.Стоимость_услуг
            FROM Администратор a
            JOIN Договор d ON a.ID_администратора = d.ID_администратора
            WHERE a.ID_администратора = 
                (SELECT TOP 1 ID_администратора 
                 FROM Договор 
                 ORDER BY Стоимость_услуг DESC)";
            }
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return;
            }

            SqlCommand command = new SqlCommand(sqlSelect, connection);
            if (radioButtonCorrelated.Checked)
            {
                command.Parameters.AddWithValue("@studentId", studentId);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;

            connection.Close();

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нет значений!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        string fileImage = "";

        private void buttonOpenPhoto_teacher_Click(object sender, EventArgs e)
        {
            openFileDialogTeacher.Title = "Укажите файл для фото";
            if (openFileDialogTeacher.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogTeacher.FileName;
                try
                {
                    pictureBoxPhoto.Load(openFileDialogTeacher.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else fileImage = "";
        }

        void InsertTeacher()
        {
            if (String.IsNullOrEmpty(textBoxId_teacher.Text) ||
            String.IsNullOrEmpty(textBoxFIO.Text) ||
            String.IsNullOrEmpty(textBoxNumber.Text) ||
            String.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Заполните все обязательные поля: ID, ФИО, договор и телефон.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(textBoxId_teacher.Text, out id))
            {
                MessageBox.Show("Некорректное значение ID преподавателя!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool status = checkBoxActivity.Checked;

            string sqlInsert = @"
            INSERT INTO Преподаватель 
            (ФИО, Номер_трудового_договора, Телефон, Статус_активности, Фотография)
            VALUES (@fio, @contract, @phone, @status, @photo)";

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.SchoolConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;

            command.Parameters.AddWithValue("@fio", textBoxFIO.Text);
            command.Parameters.AddWithValue("@contract", textBoxNumber.Text);
            command.Parameters.AddWithValue("@phone", textBoxPhone.Text);
            command.Parameters.AddWithValue("@status", status);

            if (!String.IsNullOrEmpty(fileImage))
                command.Parameters.AddWithValue("@photo", File.ReadAllBytes(fileImage));
            else
            {
                command.Parameters.Add("@photo", SqlDbType.VarBinary);
                command.Parameters["@photo"].Value = DBNull.Value;
            }

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Преподаватель успешно добавлен!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка при добавлении преподавателя.\n" + err.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                buttonSelectTeachers_Click(this, EventArgs.Empty);
            }
        }

        void UpdateTeacher()
        {
            if (String.IsNullOrEmpty(textBoxId_teacher.Text))
            {
                MessageBox.Show("Обязательно укажите ID преподавателя для обновления данных.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(textBoxId_teacher.Text, out id))
            {
                MessageBox.Show("Некорректное значение ID!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sqlUpdate = "UPDATE Преподаватель SET {0} Статус_активности=@Status WHERE ID_преподавателя=@Id";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.SchoolConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();

            string sqlValues = "";

            if (!String.IsNullOrEmpty(textBoxFIO.Text))
                sqlValues += "ФИО=@FIO,";
            if (!String.IsNullOrEmpty(textBoxNumber.Text))
                sqlValues += "Номер_трудового_договора=@Contract,";
            if (!String.IsNullOrEmpty(textBoxPhone.Text))
                sqlValues += "Телефон=@Phone,";
            if (!String.IsNullOrEmpty(fileImage))
                sqlValues += "Фотография=@Photo,";

            if (sqlValues.EndsWith(","))
                sqlValues = sqlValues.Substring(0, sqlValues.Length - 1) + ",";

            command.CommandText = string.Format(sqlUpdate, sqlValues);

            if (!String.IsNullOrEmpty(textBoxFIO.Text))
                command.Parameters.AddWithValue("@FIO", textBoxFIO.Text);
            if (!String.IsNullOrEmpty(textBoxNumber.Text))
                command.Parameters.AddWithValue("@Contract", textBoxNumber.Text);
            if (!String.IsNullOrEmpty(textBoxPhone.Text))
                command.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
            if (!String.IsNullOrEmpty(fileImage))
                command.Parameters.AddWithValue("@Photo", File.ReadAllBytes(fileImage));

            command.Parameters.AddWithValue("@Status", checkBoxActivity.Checked);
            command.Parameters.AddWithValue("@Id", id);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("Данные преподавателя успешно обновлены.", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Преподаватель с указанным ID не найден.", "Инфо",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка при обновлении данных:\n" + err.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                buttonSelectTeachers_Click(this, EventArgs.Empty);
            }
        }


        void DeleteTeacher()
        {
            if (String.IsNullOrEmpty(textBoxId_teacher.Text))
            {
                MessageBox.Show("Обязательно укажите ID преподавателя, которого необходимо удалить",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(textBoxId_teacher.Text, out id))
            {
                MessageBox.Show("Некорректное значение ID преподавателя!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlDelete = @"DELETE FROM Преподаватель WHERE ID_преподавателя = @Id";

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.SchoolConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@Id", id);

            try
            {
                int result = command.ExecuteNonQuery();
                if (result == 0)
                {
                    MessageBox.Show("Преподаватель с таким ID не найден.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Преподаватель успешно удалён.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка удаления:\n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();

            buttonSelectTeachers_Click(this, EventArgs.Empty);
        }



        private void buttonSelectTeachers_Click(object sender, EventArgs e)
        {
            dataGridViewTeacher.DataSource =  FillDataGridView("SELECT * FROM Преподаватель");
            DataGridViewImageColumn column =
            (DataGridViewImageColumn)dataGridViewTeacher.Columns["Фотография"];
            column.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void radioButtonDelete_Teacher_CheckedChanged(object sender, EventArgs e)
        {
            panelTeacher.Visible = !radioButtonDelete_Teacher.Checked;
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert_Teacher.Checked)
                InsertTeacher();
            else
                if (radioButtonUpdate_Teacher.Checked)
                    UpdateTeacher();
                else
                    if (radioButtonDelete_Teacher.Checked)
                        DeleteTeacher();
            else
                MessageBox.Show("Вы не выбрали действие", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

}
