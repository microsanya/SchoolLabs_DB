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
    public partial class FormAdminsList : Form
    {
        public FormAdminsList()
        {
            InitializeComponent();
        }

        private void администраторBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.администраторBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void FormAdminsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Администратор". При необходимости она может быть перемещена или удалена.
            this.администраторTableAdapter.Fill(this.schoolDataSet.Администратор);

            this.администраторDataGridView.CellValidating += администраторDataGridView_CellValidating;
            this.администраторDataGridView.CellEndEdit += (s, ev) => tooltip.Hide(this);
            tooltip = new ToolTip();
            tooltip.IsBalloon = true;
            tooltip.ToolTipIcon = ToolTipIcon.Warning;
        }

        private static FormAdminsList f;

        public static FormAdminsList fa
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new FormAdminsList();
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

        private void администраторDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
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

        private void администраторDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
