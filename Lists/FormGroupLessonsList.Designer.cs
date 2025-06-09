namespace SchoolLabs
{
    partial class FormGroupLessonsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroupLessonsList));
            System.Windows.Forms.Label iD_занятияLabel;
            System.Windows.Forms.Label iD_группыLabel;
            System.Windows.Forms.Label iD_преподавателяLabel;
            System.Windows.Forms.Label iD_администратораLabel;
            System.Windows.Forms.Label дата_и_времяLabel;
            System.Windows.Forms.Label статус_занятияLabel;
            System.Windows.Forms.Label статус_занятияLabel1;
            this.schoolDataSet = new SchoolLabs.SchoolDataSet();
            this.групповое_занятиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.групповое_занятиеTableAdapter = new SchoolLabs.SchoolDataSetTableAdapters.Групповое_занятиеTableAdapter();
            this.tableAdapterManager = new SchoolLabs.SchoolDataSetTableAdapters.TableAdapterManager();
            this.групповое_занятиеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.групповое_занятиеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_занятияTextBox = new System.Windows.Forms.TextBox();
            this.iD_группыTextBox = new System.Windows.Forms.TextBox();
            this.iD_преподавателяTextBox = new System.Windows.Forms.TextBox();
            this.iD_администратораTextBox = new System.Windows.Forms.TextBox();
            this.дата_и_времяDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.статус_занятияTextBox = new System.Windows.Forms.TextBox();
            this.статус_занятияComboBox = new System.Windows.Forms.ComboBox();
            iD_занятияLabel = new System.Windows.Forms.Label();
            iD_группыLabel = new System.Windows.Forms.Label();
            iD_преподавателяLabel = new System.Windows.Forms.Label();
            iD_администратораLabel = new System.Windows.Forms.Label();
            дата_и_времяLabel = new System.Windows.Forms.Label();
            статус_занятияLabel = new System.Windows.Forms.Label();
            статус_занятияLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.групповое_занятиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.групповое_занятиеBindingNavigator)).BeginInit();
            this.групповое_занятиеBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "SchoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // групповое_занятиеBindingSource
            // 
            this.групповое_занятиеBindingSource.DataMember = "Групповое занятие";
            this.групповое_занятиеBindingSource.DataSource = this.schoolDataSet;
            // 
            // групповое_занятиеTableAdapter
            // 
            this.групповое_занятиеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SchoolLabs.SchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АдминистраторTableAdapter = null;
            this.tableAdapterManager.ГруппаTableAdapter = null;
            this.tableAdapterManager.Групповое_занятиеTableAdapter = this.групповое_занятиеTableAdapter;
            this.tableAdapterManager.ДоговорTableAdapter = null;
            this.tableAdapterManager.Индивидуальное_занятиеTableAdapter = null;
            this.tableAdapterManager.ПосещениеTableAdapter = null;
            this.tableAdapterManager.ПреподавательTableAdapter = null;
            this.tableAdapterManager.Состав_группыTableAdapter = null;
            this.tableAdapterManager.УченикTableAdapter = null;
            // 
            // групповое_занятиеBindingNavigator
            // 
            this.групповое_занятиеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.групповое_занятиеBindingNavigator.BindingSource = this.групповое_занятиеBindingSource;
            this.групповое_занятиеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.групповое_занятиеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.групповое_занятиеBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.групповое_занятиеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.групповое_занятиеBindingNavigatorSaveItem});
            this.групповое_занятиеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.групповое_занятиеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.групповое_занятиеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.групповое_занятиеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.групповое_занятиеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.групповое_занятиеBindingNavigator.Name = "групповое_занятиеBindingNavigator";
            this.групповое_занятиеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.групповое_занятиеBindingNavigator.Size = new System.Drawing.Size(805, 27);
            this.групповое_занятиеBindingNavigator.TabIndex = 0;
            this.групповое_занятиеBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // групповое_занятиеBindingNavigatorSaveItem
            // 
            this.групповое_занятиеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.групповое_занятиеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("групповое_занятиеBindingNavigatorSaveItem.Image")));
            this.групповое_занятиеBindingNavigatorSaveItem.Name = "групповое_занятиеBindingNavigatorSaveItem";
            this.групповое_занятиеBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.групповое_занятиеBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.групповое_занятиеBindingNavigatorSaveItem.Click += new System.EventHandler(this.групповое_занятиеBindingNavigatorSaveItem_Click_2);
            // 
            // iD_занятияLabel
            // 
            iD_занятияLabel.AutoSize = true;
            iD_занятияLabel.Location = new System.Drawing.Point(12, 56);
            iD_занятияLabel.Name = "iD_занятияLabel";
            iD_занятияLabel.Size = new System.Drawing.Size(79, 16);
            iD_занятияLabel.TabIndex = 1;
            iD_занятияLabel.Text = "ID занятия:";
            // 
            // iD_занятияTextBox
            // 
            this.iD_занятияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.групповое_занятиеBindingSource, "ID_занятия", true));
            this.iD_занятияTextBox.Location = new System.Drawing.Point(165, 50);
            this.iD_занятияTextBox.Name = "iD_занятияTextBox";
            this.iD_занятияTextBox.Size = new System.Drawing.Size(200, 22);
            this.iD_занятияTextBox.TabIndex = 2;
            // 
            // iD_группыLabel
            // 
            iD_группыLabel.AutoSize = true;
            iD_группыLabel.Location = new System.Drawing.Point(12, 111);
            iD_группыLabel.Name = "iD_группыLabel";
            iD_группыLabel.Size = new System.Drawing.Size(73, 16);
            iD_группыLabel.TabIndex = 3;
            iD_группыLabel.Text = "ID группы:";
            // 
            // iD_группыTextBox
            // 
            this.iD_группыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.групповое_занятиеBindingSource, "ID_группы", true));
            this.iD_группыTextBox.Location = new System.Drawing.Point(165, 105);
            this.iD_группыTextBox.Name = "iD_группыTextBox";
            this.iD_группыTextBox.Size = new System.Drawing.Size(200, 22);
            this.iD_группыTextBox.TabIndex = 4;
            // 
            // iD_преподавателяLabel
            // 
            iD_преподавателяLabel.AutoSize = true;
            iD_преподавателяLabel.Location = new System.Drawing.Point(12, 175);
            iD_преподавателяLabel.Name = "iD_преподавателяLabel";
            iD_преподавателяLabel.Size = new System.Drawing.Size(128, 16);
            iD_преподавателяLabel.TabIndex = 5;
            iD_преподавателяLabel.Text = "ID преподавателя:";
            iD_преподавателяLabel.Click += new System.EventHandler(this.iD_преподавателяLabel_Click);
            // 
            // iD_преподавателяTextBox
            // 
            this.iD_преподавателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.групповое_занятиеBindingSource, "ID_преподавателя", true));
            this.iD_преподавателяTextBox.Location = new System.Drawing.Point(165, 169);
            this.iD_преподавателяTextBox.Name = "iD_преподавателяTextBox";
            this.iD_преподавателяTextBox.Size = new System.Drawing.Size(200, 22);
            this.iD_преподавателяTextBox.TabIndex = 6;
            // 
            // iD_администратораLabel
            // 
            iD_администратораLabel.AutoSize = true;
            iD_администратораLabel.Location = new System.Drawing.Point(12, 237);
            iD_администратораLabel.Name = "iD_администратораLabel";
            iD_администратораLabel.Size = new System.Drawing.Size(136, 16);
            iD_администратораLabel.TabIndex = 7;
            iD_администратораLabel.Text = "ID администратора:";
            // 
            // iD_администратораTextBox
            // 
            this.iD_администратораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.групповое_занятиеBindingSource, "ID_администратора", true));
            this.iD_администратораTextBox.Location = new System.Drawing.Point(165, 231);
            this.iD_администратораTextBox.Name = "iD_администратораTextBox";
            this.iD_администратораTextBox.Size = new System.Drawing.Size(200, 22);
            this.iD_администратораTextBox.TabIndex = 8;
            // 
            // дата_и_времяLabel
            // 
            дата_и_времяLabel.AutoSize = true;
            дата_и_времяLabel.Location = new System.Drawing.Point(12, 300);
            дата_и_времяLabel.Name = "дата_и_времяLabel";
            дата_и_времяLabel.Size = new System.Drawing.Size(96, 16);
            дата_и_времяLabel.TabIndex = 9;
            дата_и_времяLabel.Text = "Дата и время:";
            // 
            // дата_и_времяDateTimePicker
            // 
            this.дата_и_времяDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.групповое_занятиеBindingSource, "Дата_и_время", true));
            this.дата_и_времяDateTimePicker.Location = new System.Drawing.Point(165, 294);
            this.дата_и_времяDateTimePicker.Name = "дата_и_времяDateTimePicker";
            this.дата_и_времяDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_и_времяDateTimePicker.TabIndex = 10;
            // 
            // статус_занятияLabel
            // 
            статус_занятияLabel.AutoSize = true;
            статус_занятияLabel.Location = new System.Drawing.Point(12, 368);
            статус_занятияLabel.Name = "статус_занятияLabel";
            статус_занятияLabel.Size = new System.Drawing.Size(112, 16);
            статус_занятияLabel.TabIndex = 11;
            статус_занятияLabel.Text = "Статус занятия:";
            // 
            // статус_занятияTextBox
            // 
            this.статус_занятияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.групповое_занятиеBindingSource, "Статус_занятия", true));
            this.статус_занятияTextBox.Location = new System.Drawing.Point(165, 362);
            this.статус_занятияTextBox.Name = "статус_занятияTextBox";
            this.статус_занятияTextBox.Size = new System.Drawing.Size(200, 22);
            this.статус_занятияTextBox.TabIndex = 12;
            // 
            // статус_занятияLabel1
            // 
            статус_занятияLabel1.AutoSize = true;
            статус_занятияLabel1.Location = new System.Drawing.Point(536, 148);
            статус_занятияLabel1.Name = "статус_занятияLabel1";
            статус_занятияLabel1.Size = new System.Drawing.Size(112, 16);
            статус_занятияLabel1.TabIndex = 13;
            статус_занятияLabel1.Text = "Статус занятия:";
            // 
            // статус_занятияComboBox
            // 
            this.статус_занятияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.групповое_занятиеBindingSource, "Статус_занятия", true));
            this.статус_занятияComboBox.FormattingEnabled = true;
            this.статус_занятияComboBox.Items.AddRange(new object[] {
            "planned",
            "complited",
            "canceled"});
            this.статус_занятияComboBox.Location = new System.Drawing.Point(490, 194);
            this.статус_занятияComboBox.Name = "статус_занятияComboBox";
            this.статус_занятияComboBox.Size = new System.Drawing.Size(200, 24);
            this.статус_занятияComboBox.TabIndex = 14;
            this.статус_занятияComboBox.SelectedIndexChanged += new System.EventHandler(this.статус_занятияComboBox_SelectedIndexChanged);
            // 
            // FormGroupLessonsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(статус_занятияLabel1);
            this.Controls.Add(this.статус_занятияComboBox);
            this.Controls.Add(iD_занятияLabel);
            this.Controls.Add(this.iD_занятияTextBox);
            this.Controls.Add(iD_группыLabel);
            this.Controls.Add(this.iD_группыTextBox);
            this.Controls.Add(iD_преподавателяLabel);
            this.Controls.Add(this.iD_преподавателяTextBox);
            this.Controls.Add(iD_администратораLabel);
            this.Controls.Add(this.iD_администратораTextBox);
            this.Controls.Add(дата_и_времяLabel);
            this.Controls.Add(this.дата_и_времяDateTimePicker);
            this.Controls.Add(статус_занятияLabel);
            this.Controls.Add(this.статус_занятияTextBox);
            this.Controls.Add(this.групповое_занятиеBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGroupLessonsList";
            this.Text = "Групповые занятия";
            this.Load += new System.EventHandler(this.FormGroupLessonsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.групповое_занятиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.групповое_занятиеBindingNavigator)).EndInit();
            this.групповое_занятиеBindingNavigator.ResumeLayout(false);
            this.групповое_занятиеBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource групповое_занятиеBindingSource;
        private SchoolDataSetTableAdapters.Групповое_занятиеTableAdapter групповое_занятиеTableAdapter;
        private SchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator групповое_занятиеBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton групповое_занятиеBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_занятияTextBox;
        private System.Windows.Forms.TextBox iD_группыTextBox;
        private System.Windows.Forms.TextBox iD_преподавателяTextBox;
        private System.Windows.Forms.TextBox iD_администратораTextBox;
        private System.Windows.Forms.DateTimePicker дата_и_времяDateTimePicker;
        private System.Windows.Forms.TextBox статус_занятияTextBox;
        private System.Windows.Forms.ComboBox статус_занятияComboBox;
    }
}