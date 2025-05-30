using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLabs
{
    public partial class FormGroupLessonsList : Form
    {
        public FormGroupLessonsList()
        {
            InitializeComponent();
        }

        private void групповое_занятиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.групповое_занятиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void групповое_занятиеBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.групповое_занятиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void групповое_занятиеBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.групповое_занятиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void FormGroupLessonsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Групповое_занятие". При необходимости она может быть перемещена или удалена.
            this.групповое_занятиеTableAdapter.Fill(this.schoolDataSet.Групповое_занятие);

        }

        private void iD_преподавателяLabel_Click(object sender, EventArgs e)
        {

        }

        private static FormGroupLessonsList f;

        public static FormGroupLessonsList fgg
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new FormGroupLessonsList();
                }
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
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
