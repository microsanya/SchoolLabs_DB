using SchoolLabs.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLabs.Connections
{
    public partial class FormIndividualTimetable : Form
    {
        public FormIndividualTimetable()
        {
            InitializeComponent();
        }

        private void ученикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ученикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void ученикBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ученикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void FormIndividualTimetable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Индивидуальное_занятие". При необходимости она может быть перемещена или удалена.
            this.индивидуальное_занятиеTableAdapter.Fill(this.schoolDataSet.Индивидуальное_занятие);

            foreach (var row in schoolDataSet.Индивидуальное_занятие)
                row.Текущая_дата = DateTime.Today;

            foreach(DataRow row in schoolDataSet.Индивидуальное_занятие.Rows)
{
                if (row["Дата_и_время"] != DBNull.Value)
                {
                    DateTime дата = (DateTime)row["Дата_и_время"];
                    int дней = (дата - DateTime.Today).Days;
                    row["Дней до занятия"] = дней;
                }
            }

            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Ученик". При необходимости она может быть перемещена или удалена.
            this.ученикTableAdapter.Fill(this.schoolDataSet.Ученик);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private static FormIndividualTimetable f;

        public static FormIndividualTimetable fgi
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new FormIndividualTimetable();
                }
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void ученикBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.ученикBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.schoolDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.индивидуальное_занятиеBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.schoolDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
