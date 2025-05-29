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
    public partial class FormStudentsList : Form
    {
        public FormStudentsList()
        {
            InitializeComponent();
        }

        private void ученикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ученикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void FormStudentsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Ученик". При необходимости она может быть перемещена или удалена.
            this.ученикTableAdapter.Fill(this.schoolDataSet.Ученик);

            this.ученикDataGridView.CellValidating += ученикDataGridView_CellValidating;
            this.ученикDataGridView.CellEndEdit += (s, ev) => tooltip.Hide(this);
            tooltip = new ToolTip();
            tooltip.IsBalloon = true;
            tooltip.ToolTipIcon = ToolTipIcon.Warning;

        }

        private static FormStudentsList f;

        public static FormStudentsList fs
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new FormStudentsList();
                }
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private ToolTip tooltip = new ToolTip();

        private void ученикDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var dgv = sender as DataGridView;

            if (e.ColumnIndex == 2)
            {
                string value = e.FormattedValue?.ToString().Trim() ?? "";
                string errorMessage = null;

                if (value.Length < 10)
                    errorMessage = "Телефон должен содержать минимум 10 цифр";
                else if (!Regex.IsMatch(value, @"^\d+$"))
                    errorMessage = "Телефон должен содержать только цифры";
                else if (!value.StartsWith("8"))
                    errorMessage = "Телефон должен начинаться с 8";

                if (errorMessage != null)
                {
                    var cellRect = dgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    var cellPoint = dgv.PointToScreen(cellRect.Location);
                    var clientPoint = this.PointToClient(cellPoint);

                    tooltip.ToolTipTitle = "Ошибка ввода";
                    tooltip.Show(errorMessage, this, clientPoint.X + cellRect.Width / 2, clientPoint.Y - 20, 3000);

                    e.Cancel = true;
                }
                else
                {
                    tooltip.Hide(this);
                }
            }
        }
    }
}
