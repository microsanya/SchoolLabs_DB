namespace SchoolLabs
{
    partial class FormSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSQL));
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonAdmins = new System.Windows.Forms.RadioButton();
            this.radioButtonContracts = new System.Windows.Forms.RadioButton();
            this.radioButtonStudents = new System.Windows.Forms.RadioButton();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.labelContract = new System.Windows.Forms.Label();
            this.textBoxContract = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonDet_Admins = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Students = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_NO = new System.Windows.Forms.RadioButton();
            this.buttonF_select = new System.Windows.Forms.Button();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.labelStudent = new System.Windows.Forms.Label();
            this.textBoxStudent = new System.Windows.Forms.TextBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.radioButtonInsert_Teacher = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate_Teacher = new System.Windows.Forms.RadioButton();
            this.radioButtonDelete_Teacher = new System.Windows.Forms.RadioButton();
            this.labelId_teacher = new System.Windows.Forms.Label();
            this.textBoxId_teacher = new System.Windows.Forms.TextBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.panelTeacher = new System.Windows.Forms.Panel();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.checkBoxActivity = new System.Windows.Forms.CheckBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonOpenPhoto_teacher = new System.Windows.Forms.Button();
            this.openFileDialogTeacher = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewTeacher = new System.Windows.Forms.DataGridView();
            this.buttonSelectTeachers = new System.Windows.Forms.Button();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            this.groupBoxSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.tabPageSubquery.SuspendLayout();
            this.groupBoxSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.tabPageDML.SuspendLayout();
            this.groupBoxDML.SuspendLayout();
            this.panelTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubquery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(800, 625);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(792, 596);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 25);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(792, 421);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonStudents);
            this.groupBoxSelect.Controls.Add(this.radioButtonContracts);
            this.groupBoxSelect.Controls.Add(this.radioButtonAdmins);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(786, 70);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonAdmins
            // 
            this.radioButtonAdmins.AutoSize = true;
            this.radioButtonAdmins.Location = new System.Drawing.Point(6, 30);
            this.radioButtonAdmins.Name = "radioButtonAdmins";
            this.radioButtonAdmins.Size = new System.Drawing.Size(140, 20);
            this.radioButtonAdmins.TabIndex = 0;
            this.radioButtonAdmins.TabStop = true;
            this.radioButtonAdmins.Text = "Администраторы";
            this.radioButtonAdmins.UseVisualStyleBackColor = true;
            this.radioButtonAdmins.CheckedChanged += new System.EventHandler(this.radioButtonAdmins_CheckedChanged);
            // 
            // radioButtonContracts
            // 
            this.radioButtonContracts.AutoSize = true;
            this.radioButtonContracts.Location = new System.Drawing.Point(207, 30);
            this.radioButtonContracts.Name = "radioButtonContracts";
            this.radioButtonContracts.Size = new System.Drawing.Size(92, 20);
            this.radioButtonContracts.TabIndex = 1;
            this.radioButtonContracts.TabStop = true;
            this.radioButtonContracts.Text = "Договоры";
            this.radioButtonContracts.UseVisualStyleBackColor = true;
            this.radioButtonContracts.CheckedChanged += new System.EventHandler(this.radioButtonContracts_CheckedChanged);
            // 
            // radioButtonStudents
            // 
            this.radioButtonStudents.AutoSize = true;
            this.radioButtonStudents.Location = new System.Drawing.Point(362, 30);
            this.radioButtonStudents.Name = "radioButtonStudents";
            this.radioButtonStudents.Size = new System.Drawing.Size(274, 20);
            this.radioButtonStudents.TabIndex = 5;
            this.radioButtonStudents.TabStop = true;
            this.radioButtonStudents.Text = "Ученики+Договоры+Администраторы";
            this.radioButtonStudents.UseVisualStyleBackColor = true;
            this.radioButtonStudents.CheckedChanged += new System.EventHandler(this.radioButtonStudents_CheckedChanged);
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 73);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.RowHeadersWidth = 51;
            this.dataGridViewSelect.RowTemplate.Height = 24;
            this.dataGridViewSelect.Size = new System.Drawing.Size(786, 520);
            this.dataGridViewSelect.TabIndex = 7;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.buttonF_select);
            this.groupBoxFSelect.Controls.Add(this.groupBoxDet);
            this.groupBoxFSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFSelect.Controls.Add(this.textBoxContract);
            this.groupBoxFSelect.Controls.Add(this.labelContract);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(786, 199);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "Прибыль с договоров";
            // 
            // labelContract
            // 
            this.labelContract.AutoSize = true;
            this.labelContract.Location = new System.Drawing.Point(6, 35);
            this.labelContract.Name = "labelContract";
            this.labelContract.Size = new System.Drawing.Size(192, 16);
            this.labelContract.TabIndex = 0;
            this.labelContract.Text = "Краткое описание договора";
            // 
            // textBoxContract
            // 
            this.textBoxContract.Location = new System.Drawing.Point(215, 32);
            this.textBoxContract.Name = "textBoxContract";
            this.textBoxContract.Size = new System.Drawing.Size(218, 22);
            this.textBoxContract.TabIndex = 1;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(9, 87);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(187, 20);
            this.checkBoxMore.TabIndex = 2;
            this.checkBoxMore.Text = "Выбрать прибыль более";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(9, 144);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(322, 20);
            this.checkBoxOrder.TabIndex = 3;
            this.checkBoxOrder.Text = "Включить сортировку по убыванию прибыли";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(215, 85);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(218, 22);
            this.textBoxMore.TabIndex = 4;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButtonDet_NO);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Students);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Admins);
            this.groupBoxDet.Location = new System.Drawing.Point(451, 21);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(329, 143);
            this.groupBoxDet.TabIndex = 5;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация прибыли с договоров";
            // 
            // radioButtonDet_Admins
            // 
            this.radioButtonDet_Admins.AutoSize = true;
            this.radioButtonDet_Admins.Location = new System.Drawing.Point(6, 21);
            this.radioButtonDet_Admins.Name = "radioButtonDet_Admins";
            this.radioButtonDet_Admins.Size = new System.Drawing.Size(310, 20);
            this.radioButtonDet_Admins.TabIndex = 0;
            this.radioButtonDet_Admins.TabStop = true;
            this.radioButtonDet_Admins.Text = "Прибыль с договоров по администраторам";
            this.radioButtonDet_Admins.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_Students
            // 
            this.radioButtonDet_Students.AutoSize = true;
            this.radioButtonDet_Students.Location = new System.Drawing.Point(6, 64);
            this.radioButtonDet_Students.Name = "radioButtonDet_Students";
            this.radioButtonDet_Students.Size = new System.Drawing.Size(255, 20);
            this.radioButtonDet_Students.TabIndex = 1;
            this.radioButtonDet_Students.TabStop = true;
            this.radioButtonDet_Students.Text = "Прибыль с договоров по ученикам";
            this.radioButtonDet_Students.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_NO
            // 
            this.radioButtonDet_NO.AutoSize = true;
            this.radioButtonDet_NO.Location = new System.Drawing.Point(6, 108);
            this.radioButtonDet_NO.Name = "radioButtonDet_NO";
            this.radioButtonDet_NO.Size = new System.Drawing.Size(143, 20);
            this.radioButtonDet_NO.TabIndex = 2;
            this.radioButtonDet_NO.TabStop = true;
            this.radioButtonDet_NO.Text = "Нет детализации";
            this.radioButtonDet_NO.UseVisualStyleBackColor = true;
            // 
            // buttonF_select
            // 
            this.buttonF_select.Location = new System.Drawing.Point(280, 163);
            this.buttonF_select.Name = "buttonF_select";
            this.buttonF_select.Size = new System.Drawing.Size(169, 27);
            this.buttonF_select.TabIndex = 6;
            this.buttonF_select.Text = "Прибыль с договоров";
            this.buttonF_select.UseVisualStyleBackColor = true;
            this.buttonF_select.Click += new System.EventHandler(this.buttonF_select_Click);
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 202);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.RowHeadersWidth = 51;
            this.dataGridViewFSelect.RowTemplate.Height = 24;
            this.dataGridViewFSelect.Size = new System.Drawing.Size(786, 216);
            this.dataGridViewFSelect.TabIndex = 1;
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 25);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(792, 421);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Примеры подзапросов";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxStudent);
            this.groupBoxSubquery.Controls.Add(this.labelStudent);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(786, 119);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(42, 39);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(223, 20);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(284, 38);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(240, 20);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некореллированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(79, 84);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(96, 16);
            this.labelStudent.TabIndex = 2;
            this.labelStudent.Text = "ФИО ученика";
            // 
            // textBoxStudent
            // 
            this.textBoxStudent.Location = new System.Drawing.Point(181, 78);
            this.textBoxStudent.Name = "textBoxStudent";
            this.textBoxStudent.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudent.TabIndex = 3;
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(378, 78);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(205, 23);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(3, 122);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.RowHeadersWidth = 51;
            this.dataGridViewSubquery.RowTemplate.Height = 24;
            this.dataGridViewSubquery.Size = new System.Drawing.Size(786, 296);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.buttonSelectTeachers);
            this.tabPageDML.Controls.Add(this.dataGridViewTeacher);
            this.tabPageDML.Controls.Add(this.panelTeacher);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 25);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(792, 596);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.textBoxId_teacher);
            this.groupBoxDML.Controls.Add(this.labelId_teacher);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete_Teacher);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate_Teacher);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert_Teacher);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(786, 142);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // radioButtonInsert_Teacher
            // 
            this.radioButtonInsert_Teacher.AutoSize = true;
            this.radioButtonInsert_Teacher.Location = new System.Drawing.Point(6, 31);
            this.radioButtonInsert_Teacher.Name = "radioButtonInsert_Teacher";
            this.radioButtonInsert_Teacher.Size = new System.Drawing.Size(270, 20);
            this.radioButtonInsert_Teacher.TabIndex = 0;
            this.radioButtonInsert_Teacher.TabStop = true;
            this.radioButtonInsert_Teacher.Text = "Добавить данные по преподавателю";
            this.radioButtonInsert_Teacher.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdate_Teacher
            // 
            this.radioButtonUpdate_Teacher.AutoSize = true;
            this.radioButtonUpdate_Teacher.Location = new System.Drawing.Point(6, 72);
            this.radioButtonUpdate_Teacher.Name = "radioButtonUpdate_Teacher";
            this.radioButtonUpdate_Teacher.Size = new System.Drawing.Size(367, 20);
            this.radioButtonUpdate_Teacher.TabIndex = 1;
            this.radioButtonUpdate_Teacher.TabStop = true;
            this.radioButtonUpdate_Teacher.Text = "Изменить данные по преподавателю с заданным ID";
            this.radioButtonUpdate_Teacher.UseVisualStyleBackColor = true;
            // 
            // radioButtonDelete_Teacher
            // 
            this.radioButtonDelete_Teacher.AutoSize = true;
            this.radioButtonDelete_Teacher.Location = new System.Drawing.Point(6, 110);
            this.radioButtonDelete_Teacher.Name = "radioButtonDelete_Teacher";
            this.radioButtonDelete_Teacher.Size = new System.Drawing.Size(357, 20);
            this.radioButtonDelete_Teacher.TabIndex = 2;
            this.radioButtonDelete_Teacher.TabStop = true;
            this.radioButtonDelete_Teacher.Text = "Удалить данные по преподавателю с заданным ID";
            this.radioButtonDelete_Teacher.UseVisualStyleBackColor = true;
            this.radioButtonDelete_Teacher.CheckedChanged += new System.EventHandler(this.radioButtonDelete_Teacher_CheckedChanged);
            // 
            // labelId_teacher
            // 
            this.labelId_teacher.AutoSize = true;
            this.labelId_teacher.Location = new System.Drawing.Point(408, 33);
            this.labelId_teacher.Name = "labelId_teacher";
            this.labelId_teacher.Size = new System.Drawing.Size(129, 16);
            this.labelId_teacher.TabIndex = 3;
            this.labelId_teacher.Text = "ID_преподавателя";
            // 
            // textBoxId_teacher
            // 
            this.textBoxId_teacher.Location = new System.Drawing.Point(556, 30);
            this.textBoxId_teacher.Name = "textBoxId_teacher";
            this.textBoxId_teacher.Size = new System.Drawing.Size(224, 22);
            this.textBoxId_teacher.TabIndex = 4;
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(499, 88);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(165, 23);
            this.buttonExecuteDML.TabIndex = 5;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // panelTeacher
            // 
            this.panelTeacher.Controls.Add(this.buttonOpenPhoto_teacher);
            this.panelTeacher.Controls.Add(this.textBoxPhone);
            this.panelTeacher.Controls.Add(this.textBoxNumber);
            this.panelTeacher.Controls.Add(this.textBoxFIO);
            this.panelTeacher.Controls.Add(this.pictureBoxPhoto);
            this.panelTeacher.Controls.Add(this.checkBoxActivity);
            this.panelTeacher.Controls.Add(this.labelPhoto);
            this.panelTeacher.Controls.Add(this.labelPhone);
            this.panelTeacher.Controls.Add(this.labelNumber);
            this.panelTeacher.Controls.Add(this.labelFIO);
            this.panelTeacher.Location = new System.Drawing.Point(3, 151);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size = new System.Drawing.Size(786, 214);
            this.panelTeacher.TabIndex = 1;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(5, 21);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(38, 16);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(5, 68);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(187, 16);
            this.labelNumber.TabIndex = 1;
            this.labelNumber.Text = "Номер трудового договора";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(5, 117);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(67, 16);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Телефон";
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(553, 21);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(89, 16);
            this.labelPhoto.TabIndex = 3;
            this.labelPhoto.Text = "Фотография";
            // 
            // checkBoxActivity
            // 
            this.checkBoxActivity.AutoSize = true;
            this.checkBoxActivity.Location = new System.Drawing.Point(8, 166);
            this.checkBoxActivity.Name = "checkBoxActivity";
            this.checkBoxActivity.Size = new System.Drawing.Size(154, 20);
            this.checkBoxActivity.TabIndex = 4;
            this.checkBoxActivity.Text = "Cтатус активности";
            this.checkBoxActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxActivity.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(512, 40);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(177, 129);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 5;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(223, 21);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(185, 22);
            this.textBoxFIO.TabIndex = 6;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(223, 62);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(185, 22);
            this.textBoxNumber.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(223, 111);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(185, 22);
            this.textBoxPhone.TabIndex = 8;
            // 
            // buttonOpenPhoto_teacher
            // 
            this.buttonOpenPhoto_teacher.Location = new System.Drawing.Point(468, 175);
            this.buttonOpenPhoto_teacher.Name = "buttonOpenPhoto_teacher";
            this.buttonOpenPhoto_teacher.Size = new System.Drawing.Size(260, 24);
            this.buttonOpenPhoto_teacher.TabIndex = 9;
            this.buttonOpenPhoto_teacher.Text = "Открыть фото преподавателя";
            this.buttonOpenPhoto_teacher.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto_teacher.Click += new System.EventHandler(this.buttonOpenPhoto_teacher_Click);
            // 
            // openFileDialogTeacher
            // 
            this.openFileDialogTeacher.FileName = "openFileDialog1";
            // 
            // dataGridViewTeacher
            // 
            this.dataGridViewTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacher.Location = new System.Drawing.Point(3, 412);
            this.dataGridViewTeacher.Name = "dataGridViewTeacher";
            this.dataGridViewTeacher.RowHeadersWidth = 51;
            this.dataGridViewTeacher.RowTemplate.Height = 24;
            this.dataGridViewTeacher.Size = new System.Drawing.Size(789, 181);
            this.dataGridViewTeacher.TabIndex = 2;
            // 
            // buttonSelectTeachers
            // 
            this.buttonSelectTeachers.Location = new System.Drawing.Point(268, 371);
            this.buttonSelectTeachers.Name = "buttonSelectTeachers";
            this.buttonSelectTeachers.Size = new System.Drawing.Size(254, 35);
            this.buttonSelectTeachers.TabIndex = 3;
            this.buttonSelectTeachers.Text = "Показать список преподавателей";
            this.buttonSelectTeachers.UseVisualStyleBackColor = true;
            this.buttonSelectTeachers.Click += new System.EventHandler(this.buttonSelectTeachers_Click);
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.tabControlSQL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            this.tabPageSelect.ResumeLayout(false);
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.tabPageSubquery.ResumeLayout(false);
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.tabPageDML.ResumeLayout(false);
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.panelTeacher.ResumeLayout(false);
            this.panelTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonStudents;
        private System.Windows.Forms.RadioButton radioButtonContracts;
        private System.Windows.Forms.RadioButton radioButtonAdmins;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.RadioButton radioButtonDet_NO;
        private System.Windows.Forms.RadioButton radioButtonDet_Students;
        private System.Windows.Forms.RadioButton radioButtonDet_Admins;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.TextBox textBoxContract;
        private System.Windows.Forms.Label labelContract;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.Button buttonF_select;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.TextBox textBoxStudent;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.RadioButton radioButtonDelete_Teacher;
        private System.Windows.Forms.RadioButton radioButtonUpdate_Teacher;
        private System.Windows.Forms.RadioButton radioButtonInsert_Teacher;
        private System.Windows.Forms.Panel panelTeacher;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.TextBox textBoxId_teacher;
        private System.Windows.Forms.Label labelId_teacher;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.CheckBox checkBoxActivity;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Button buttonOpenPhoto_teacher;
        private System.Windows.Forms.OpenFileDialog openFileDialogTeacher;
        private System.Windows.Forms.Button buttonSelectTeachers;
        private System.Windows.Forms.DataGridView dataGridViewTeacher;
    }
}