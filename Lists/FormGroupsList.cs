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
    public partial class FormGroupsList : Form
    {
        public FormGroupsList()
        {
            InitializeComponent();
        }

        private void группаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void FormGroupsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.schoolDataSet.Группа);

        }

        private static FormGroupsList f;

        public static FormGroupsList fg
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new FormGroupsList();
                }
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
