using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLabs.Properties;

namespace SchoolLabs
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КСУП, Глушенкова Александра Игоревна, группа 573-2, 2025", "О программе", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КСУП, Глушенкова Александра Игоревна, группа 573-2, 2025", "О программе",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КСУП, Глушенкова Александра Игоревна, группа 573-2, 2025", "О программе",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeachersList.ft.ShowForm();
        }

        private void toolStripButtonTeachers_Click(object sender, EventArgs e)
        {
            FormTeachersList.ft.ShowForm();
        }

        private void преподавателиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTeachersList.ft.ShowForm();
        }

        private void администраторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminsList.fa.ShowForm();
        }

        private void администраторыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAdminsList.fa.ShowForm();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            FormAdminsList.fa.ShowForm();
        }

        private void ученикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudentsList.fs.ShowForm();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            FormStudentsList.fs.ShowForm();
        }

        private void ученикиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormStudentsList.fs.ShowForm();
        }

        private void договорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContractsList.fс.ShowForm();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FormContractsList.fс.ShowForm();
        }

        private void договорыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormContractsList.fс.ShowForm();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGroupsList.fg.ShowForm();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FormGroupsList.fg.ShowForm();
        }

        private void группыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGroupsList.fg.ShowForm();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FormGroupLessonsList.fgg.ShowForm();
        }

        private void групповыеЗанятияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGroupLessonsList.fgg.ShowForm();
        }

        private void групповыеЗанятияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGroupLessonsList.fgg.ShowForm();
        }

        private void индивидуальныеЗанятияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIndividualLessonsList.fgi.ShowForm();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            FormIndividualLessonsList.fgi.ShowForm();
        }

        private void индивидуальныеЗанятияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormIndividualLessonsList.fgi.ShowForm();
        }
    }
}
