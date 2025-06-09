using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLabs.Lists
{
    public partial class FormGroupTimetableList : Form
    {
        public FormGroupTimetableList()
        {
            InitializeComponent();
        }

        private void группаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void групповое_занятиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.групповое_занятиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void группаBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.группаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void FormGroupTimetableList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Преподаватель". При необходимости она может быть перемещена или удалена.
            this.преподавательTableAdapter.Fill(this.schoolDataSet.Преподаватель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Состав_группы". При необходимости она может быть перемещена или удалена.
            this.состав_группыTableAdapter.Fill(this.schoolDataSet.Состав_группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Посещение". При необходимости она может быть перемещена или удалена.
            this.посещениеTableAdapter.Fill(this.schoolDataSet.Посещение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Групповое_занятие". При необходимости она может быть перемещена или удалена.
            this.групповое_занятиеTableAdapter.Fill(this.schoolDataSet.Групповое_занятие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.schoolDataSet.Группа);

        }


        private static FormGroupTimetableList f;

        public static FormGroupTimetableList fgt
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new FormGroupTimetableList();
                }
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void статус_занятияComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = статус_занятияComboBox.SelectedItem.ToString();

            switch (selected)
            {
                case "planned":
                    статус_занятияComboBox.BackColor = Color.LightBlue;
                    статус_занятияComboBox.ForeColor = Color.Black;
                    break;
                case "complited":
                    статус_занятияComboBox.BackColor = Color.LightGreen;
                    статус_занятияComboBox.ForeColor = Color.Black;
                    break;
                case "canceled":
                    статус_занятияComboBox.BackColor = Color.LightPink;
                    статус_занятияComboBox.ForeColor = Color.Black;
                    break;
                default:
                    статус_занятияComboBox.BackColor = SystemColors.Window;
                    статус_занятияComboBox.ForeColor = SystemColors.WindowText;
                    break;
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.групповое_занятиеBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.schoolDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.посещениеBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.schoolDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            int id = -1;
            if
           (((DataRowView)групповое_занятиеBindingSource.Current)["ID_преподавателя"].ToString() !=
           "")
            {
                id =
               (int)(((DataRowView)групповое_занятиеBindingSource.Current)["ID_преподавателя"]);
            }
            id = FormTeachersList.ft.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)групповое_занятиеBindingSource.Current)["ID_преподавателя"]
               = id;
                групповое_занятиеBindingSource.EndEdit();
                преподавательTableAdapter.Fill(this.schoolDataSet.Преподаватель);
            }
        }
    }
}
