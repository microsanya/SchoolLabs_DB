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
    public partial class FormIndividualLessonsList : Form
    {
        public FormIndividualLessonsList()
        {
            InitializeComponent();
        }

        private void индивидуальное_занятиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.индивидуальное_занятиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void FormIndividualLessonsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Индивидуальное_занятие". При необходимости она может быть перемещена или удалена.
            this.индивидуальное_занятиеTableAdapter.Fill(this.schoolDataSet.Индивидуальное_занятие);

        }

        private static FormIndividualLessonsList f;

        public static FormIndividualLessonsList fgi
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new FormIndividualLessonsList();
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
