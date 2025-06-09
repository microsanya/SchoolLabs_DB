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
    public partial class FormContractsList : Form
    {
        public FormContractsList()
        {
            InitializeComponent();
        }

        private void договорBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.договорBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void FormContractsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Договор". При необходимости она может быть перемещена или удалена.
            this.договорTableAdapter.Fill(this.schoolDataSet.Договор);

        }

        private static FormContractsList f;

        public static FormContractsList fс
        {
            get
            {
                if (f == null || f.IsDisposed)
                {
                    f = new FormContractsList();
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
