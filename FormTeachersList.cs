using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLabs
{
    public partial class FormTeachersList : Form
    {
        public FormTeachersList()
        {
            InitializeComponent();
        }

        private void преподавательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.преподавательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void FormTeachersList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Преподаватель". При необходимости она может быть перемещена или удалена.
            this.преподавательTableAdapter.Fill(this.schoolDataSet.Преподаватель);

        }

        private static FormTeachersList f;

        public static FormTeachersList ft
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new FormTeachersList();
                }
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void номер_трудового_договораTextBox_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^TD-\d{4}-\d{3}$";
            if (!Regex.IsMatch(номер_трудового_договораTextBox.Text, pattern))
            {
                errorProvider1.SetError(номер_трудового_договораTextBox, "Формат должен быть TD-1234-567");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(номер_трудового_договораTextBox, "");
            }
        }

        private void телефонTextBox_Validating(object sender, CancelEventArgs e)
        {
            string input = телефонTextBox.Text.Trim();

            if (input.Length < 10)
            {
                errorProvider1.SetError(телефонTextBox, "Телефон должен содержать минимум 10 цифр");
                e.Cancel = true;
                return;
            }

            if (!Regex.IsMatch(input, @"^\d+$"))
            {
                errorProvider1.SetError(телефонTextBox, "Телефон должен содержать только цифры");
                e.Cancel = true;
                return;
            }

            if (!input.StartsWith("8"))
            {
                errorProvider1.SetError(телефонTextBox, "Телефон должен начинаться с цифры 8");
                e.Cancel = true;
                return;
            }

            errorProvider1.SetError(телефонTextBox, "");
        }
    }
}
