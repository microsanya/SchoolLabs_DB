namespace SchoolLabs
{
    partial class FormTeachersList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_преподавателяLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label номер_трудового_договораLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label статус_активностиLabel;
            System.Windows.Forms.Label фотографияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeachersList));
            this.schoolDataSet = new SchoolLabs.SchoolDataSet();
            this.преподавательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.преподавательTableAdapter = new SchoolLabs.SchoolDataSetTableAdapters.ПреподавательTableAdapter();
            this.tableAdapterManager = new SchoolLabs.SchoolDataSetTableAdapters.TableAdapterManager();
            this.преподавательBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.преподавательBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_преподавателяTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.номер_трудового_договораTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.статус_активностиCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.фотографияPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonOpenPhoto = new System.Windows.Forms.Button();
            this.openFileDialogPhoto = new System.Windows.Forms.OpenFileDialog();
            iD_преподавателяLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            номер_трудового_договораLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            статус_активностиLabel = new System.Windows.Forms.Label();
            фотографияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавательBindingNavigator)).BeginInit();
            this.преподавательBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фотографияPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_преподавателяLabel
            // 
            iD_преподавателяLabel.AutoSize = true;
            iD_преподавателяLabel.Location = new System.Drawing.Point(20, 69);
            iD_преподавателяLabel.Name = "iD_преподавателяLabel";
            iD_преподавателяLabel.Size = new System.Drawing.Size(128, 16);
            iD_преподавателяLabel.TabIndex = 1;
            iD_преподавателяLabel.Text = "ID преподавателя:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(20, 113);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(41, 16);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // номер_трудового_договораLabel
            // 
            номер_трудового_договораLabel.AutoSize = true;
            номер_трудового_договораLabel.Location = new System.Drawing.Point(20, 166);
            номер_трудового_договораLabel.Name = "номер_трудового_договораLabel";
            номер_трудового_договораLabel.Size = new System.Drawing.Size(190, 16);
            номер_трудового_договораLabel.TabIndex = 5;
            номер_трудового_договораLabel.Text = "Номер трудового договора:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(20, 219);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(70, 16);
            телефонLabel.TabIndex = 7;
            телефонLabel.Text = "Телефон:";
            // 
            // статус_активностиLabel
            // 
            статус_активностиLabel.AutoSize = true;
            статус_активностиLabel.Location = new System.Drawing.Point(20, 269);
            статус_активностиLabel.Name = "статус_активностиLabel";
            статус_активностиLabel.Size = new System.Drawing.Size(135, 16);
            статус_активностиLabel.TabIndex = 9;
            статус_активностиLabel.Text = "Статус активности:";
            // 
            // фотографияLabel
            // 
            фотографияLabel.AutoSize = true;
            фотографияLabel.Location = new System.Drawing.Point(372, 264);
            фотографияLabel.Name = "фотографияLabel";
            фотографияLabel.Size = new System.Drawing.Size(92, 16);
            фотографияLabel.TabIndex = 11;
            фотографияLabel.Text = "Фотография:";
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "SchoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // преподавательBindingSource
            // 
            this.преподавательBindingSource.DataMember = "Преподаватель";
            this.преподавательBindingSource.DataSource = this.schoolDataSet;
            // 
            // преподавательTableAdapter
            // 
            this.преподавательTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SchoolLabs.SchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АдминистраторTableAdapter = null;
            this.tableAdapterManager.ГруппаTableAdapter = null;
            this.tableAdapterManager.Групповое_занятиеTableAdapter = null;
            this.tableAdapterManager.ДоговорTableAdapter = null;
            this.tableAdapterManager.Индивидуальное_занятиеTableAdapter = null;
            this.tableAdapterManager.ПосещениеTableAdapter = null;
            this.tableAdapterManager.ПреподавательTableAdapter = this.преподавательTableAdapter;
            this.tableAdapterManager.Состав_группыTableAdapter = null;
            this.tableAdapterManager.УченикTableAdapter = null;
            // 
            // преподавательBindingNavigator
            // 
            this.преподавательBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.преподавательBindingNavigator.BindingSource = this.преподавательBindingSource;
            this.преподавательBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.преподавательBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.преподавательBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.преподавательBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.преподавательBindingNavigatorSaveItem});
            this.преподавательBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.преподавательBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.преподавательBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.преподавательBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.преподавательBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.преподавательBindingNavigator.Name = "преподавательBindingNavigator";
            this.преподавательBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.преподавательBindingNavigator.Size = new System.Drawing.Size(828, 27);
            this.преподавательBindingNavigator.TabIndex = 0;
            this.преподавательBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // преподавательBindingNavigatorSaveItem
            // 
            this.преподавательBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.преподавательBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("преподавательBindingNavigatorSaveItem.Image")));
            this.преподавательBindingNavigatorSaveItem.Name = "преподавательBindingNavigatorSaveItem";
            this.преподавательBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.преподавательBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.преподавательBindingNavigatorSaveItem.Click += new System.EventHandler(this.преподавательBindingNavigatorSaveItem_Click);
            // 
            // iD_преподавателяTextBox
            // 
            this.iD_преподавателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.преподавательBindingSource, "ID_преподавателя", true));
            this.iD_преподавателяTextBox.Location = new System.Drawing.Point(237, 63);
            this.iD_преподавателяTextBox.Name = "iD_преподавателяTextBox";
            this.iD_преподавателяTextBox.Size = new System.Drawing.Size(539, 22);
            this.iD_преподавателяTextBox.TabIndex = 2;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.преподавательBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(237, 107);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(539, 22);
            this.фИОTextBox.TabIndex = 4;
            // 
            // номер_трудового_договораTextBox
            // 
            this.номер_трудового_договораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.преподавательBindingSource, "Номер_трудового_договора", true));
            this.номер_трудового_договораTextBox.Location = new System.Drawing.Point(237, 160);
            this.номер_трудового_договораTextBox.Name = "номер_трудового_договораTextBox";
            this.номер_трудового_договораTextBox.Size = new System.Drawing.Size(539, 22);
            this.номер_трудового_договораTextBox.TabIndex = 6;
            this.номер_трудового_договораTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.номер_трудового_договораTextBox_Validating);
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.преподавательBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(237, 213);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(539, 22);
            this.телефонTextBox.TabIndex = 8;
            this.телефонTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.телефонTextBox_Validating);
            // 
            // статус_активностиCheckBox
            // 
            this.статус_активностиCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.преподавательBindingSource, "Фотография", true));
            this.статус_активностиCheckBox.Location = new System.Drawing.Point(237, 264);
            this.статус_активностиCheckBox.Name = "статус_активностиCheckBox";
            this.статус_активностиCheckBox.Size = new System.Drawing.Size(342, 21);
            this.статус_активностиCheckBox.TabIndex = 10;
            this.статус_активностиCheckBox.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // фотографияPictureBox
            // 
            this.фотографияPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.преподавательBindingSource, "Фотография", true));
            this.фотографияPictureBox.Location = new System.Drawing.Point(529, 264);
            this.фотографияPictureBox.Name = "фотографияPictureBox";
            this.фотографияPictureBox.Size = new System.Drawing.Size(146, 159);
            this.фотографияPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.фотографияPictureBox.TabIndex = 12;
            this.фотографияPictureBox.TabStop = false;
            // 
            // buttonOpenPhoto
            // 
            this.buttonOpenPhoto.Location = new System.Drawing.Point(322, 304);
            this.buttonOpenPhoto.Name = "buttonOpenPhoto";
            this.buttonOpenPhoto.Size = new System.Drawing.Size(190, 27);
            this.buttonOpenPhoto.TabIndex = 13;
            this.buttonOpenPhoto.Text = "Открыть фото";
            this.buttonOpenPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenPhoto.Click += new System.EventHandler(this.buttonOpenPhoto_Click);
            // 
            // openFileDialogPhoto
            // 
            this.openFileDialogPhoto.FileName = "openFileDialog1";
            // 
            // FormTeachersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.buttonOpenPhoto);
            this.Controls.Add(фотографияLabel);
            this.Controls.Add(this.фотографияPictureBox);
            this.Controls.Add(iD_преподавателяLabel);
            this.Controls.Add(this.iD_преподавателяTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(номер_трудового_договораLabel);
            this.Controls.Add(this.номер_трудового_договораTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(статус_активностиLabel);
            this.Controls.Add(this.статус_активностиCheckBox);
            this.Controls.Add(this.преподавательBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTeachersList";
            this.Text = "Преподаватели";
            this.Load += new System.EventHandler(this.FormTeachersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавательBindingNavigator)).EndInit();
            this.преподавательBindingNavigator.ResumeLayout(false);
            this.преподавательBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фотографияPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource преподавательBindingSource;
        private SchoolDataSetTableAdapters.ПреподавательTableAdapter преподавательTableAdapter;
        private SchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator преподавательBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton преподавательBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_преподавателяTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox номер_трудового_договораTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.CheckBox статус_активностиCheckBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox фотографияPictureBox;
        private System.Windows.Forms.Button buttonOpenPhoto;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhoto;
    }
}