namespace SchoolLabs
{
    partial class FormContractsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContractsList));
            System.Windows.Forms.Label iD_договораLabel;
            System.Windows.Forms.Label iD_ученикаLabel;
            System.Windows.Forms.Label iD_администратораLabel;
            System.Windows.Forms.Label краткое_описаниеLabel;
            System.Windows.Forms.Label стоимость_услугLabel;
            System.Windows.Forms.Label количество_оплачиваемых_занятийLabel;
            this.schoolDataSet = new SchoolLabs.SchoolDataSet();
            this.договорBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договорTableAdapter = new SchoolLabs.SchoolDataSetTableAdapters.ДоговорTableAdapter();
            this.tableAdapterManager = new SchoolLabs.SchoolDataSetTableAdapters.TableAdapterManager();
            this.договорBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.договорBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_договораTextBox = new System.Windows.Forms.TextBox();
            this.iD_ученикаTextBox = new System.Windows.Forms.TextBox();
            this.iD_администратораTextBox = new System.Windows.Forms.TextBox();
            this.краткое_описаниеTextBox = new System.Windows.Forms.TextBox();
            this.стоимость_услугTextBox = new System.Windows.Forms.TextBox();
            this.количество_оплачиваемых_занятийTextBox = new System.Windows.Forms.TextBox();
            iD_договораLabel = new System.Windows.Forms.Label();
            iD_ученикаLabel = new System.Windows.Forms.Label();
            iD_администратораLabel = new System.Windows.Forms.Label();
            краткое_описаниеLabel = new System.Windows.Forms.Label();
            стоимость_услугLabel = new System.Windows.Forms.Label();
            количество_оплачиваемых_занятийLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingNavigator)).BeginInit();
            this.договорBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "SchoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // договорBindingSource
            // 
            this.договорBindingSource.DataMember = "Договор";
            this.договорBindingSource.DataSource = this.schoolDataSet;
            // 
            // договорTableAdapter
            // 
            this.договорTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SchoolLabs.SchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АдминистраторTableAdapter = null;
            this.tableAdapterManager.ГруппаTableAdapter = null;
            this.tableAdapterManager.Групповое_занятиеTableAdapter = null;
            this.tableAdapterManager.ДоговорTableAdapter = this.договорTableAdapter;
            this.tableAdapterManager.Индивидуальное_занятиеTableAdapter = null;
            this.tableAdapterManager.ПосещениеTableAdapter = null;
            this.tableAdapterManager.ПреподавательTableAdapter = null;
            this.tableAdapterManager.Состав_группыTableAdapter = null;
            this.tableAdapterManager.УченикTableAdapter = null;
            // 
            // договорBindingNavigator
            // 
            this.договорBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.договорBindingNavigator.BindingSource = this.договорBindingSource;
            this.договорBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.договорBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.договорBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.договорBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.договорBindingNavigatorSaveItem});
            this.договорBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.договорBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.договорBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.договорBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.договорBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.договорBindingNavigator.Name = "договорBindingNavigator";
            this.договорBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.договорBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.договорBindingNavigator.TabIndex = 0;
            this.договорBindingNavigator.Text = "bindingNavigator1";
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
            // договорBindingNavigatorSaveItem
            // 
            this.договорBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.договорBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("договорBindingNavigatorSaveItem.Image")));
            this.договорBindingNavigatorSaveItem.Name = "договорBindingNavigatorSaveItem";
            this.договорBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.договорBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.договорBindingNavigatorSaveItem.Click += new System.EventHandler(this.договорBindingNavigatorSaveItem_Click);
            // 
            // iD_договораLabel
            // 
            iD_договораLabel.AutoSize = true;
            iD_договораLabel.Location = new System.Drawing.Point(12, 54);
            iD_договораLabel.Name = "iD_договораLabel";
            iD_договораLabel.Size = new System.Drawing.Size(88, 16);
            iD_договораLabel.TabIndex = 1;
            iD_договораLabel.Text = "ID договора:";
            // 
            // iD_договораTextBox
            // 
            this.iD_договораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договорBindingSource, "ID_договора", true));
            this.iD_договораTextBox.Location = new System.Drawing.Point(288, 51);
            this.iD_договораTextBox.Name = "iD_договораTextBox";
            this.iD_договораTextBox.Size = new System.Drawing.Size(122, 22);
            this.iD_договораTextBox.TabIndex = 2;
            // 
            // iD_ученикаLabel
            // 
            iD_ученикаLabel.AutoSize = true;
            iD_ученикаLabel.Location = new System.Drawing.Point(12, 95);
            iD_ученикаLabel.Name = "iD_ученикаLabel";
            iD_ученикаLabel.Size = new System.Drawing.Size(81, 16);
            iD_ученикаLabel.TabIndex = 3;
            iD_ученикаLabel.Text = "ID ученика:";
            // 
            // iD_ученикаTextBox
            // 
            this.iD_ученикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договорBindingSource, "ID_ученика", true));
            this.iD_ученикаTextBox.Location = new System.Drawing.Point(288, 89);
            this.iD_ученикаTextBox.Name = "iD_ученикаTextBox";
            this.iD_ученикаTextBox.Size = new System.Drawing.Size(122, 22);
            this.iD_ученикаTextBox.TabIndex = 4;
            // 
            // iD_администратораLabel
            // 
            iD_администратораLabel.AutoSize = true;
            iD_администратораLabel.Location = new System.Drawing.Point(12, 140);
            iD_администратораLabel.Name = "iD_администратораLabel";
            iD_администратораLabel.Size = new System.Drawing.Size(136, 16);
            iD_администратораLabel.TabIndex = 5;
            iD_администратораLabel.Text = "ID администратора:";
            // 
            // iD_администратораTextBox
            // 
            this.iD_администратораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договорBindingSource, "ID_администратора", true));
            this.iD_администратораTextBox.Location = new System.Drawing.Point(288, 134);
            this.iD_администратораTextBox.Name = "iD_администратораTextBox";
            this.iD_администратораTextBox.Size = new System.Drawing.Size(122, 22);
            this.iD_администратораTextBox.TabIndex = 6;
            // 
            // краткое_описаниеLabel
            // 
            краткое_описаниеLabel.AutoSize = true;
            краткое_описаниеLabel.Location = new System.Drawing.Point(537, 51);
            краткое_описаниеLabel.Name = "краткое_описаниеLabel";
            краткое_описаниеLabel.Size = new System.Drawing.Size(130, 16);
            краткое_описаниеLabel.TabIndex = 7;
            краткое_описаниеLabel.Text = "Краткое описание:";
            // 
            // краткое_описаниеTextBox
            // 
            this.краткое_описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договорBindingSource, "Краткое_описание", true));
            this.краткое_описаниеTextBox.Location = new System.Drawing.Point(453, 89);
            this.краткое_описаниеTextBox.Multiline = true;
            this.краткое_описаниеTextBox.Name = "краткое_описаниеTextBox";
            this.краткое_описаниеTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.краткое_описаниеTextBox.Size = new System.Drawing.Size(302, 176);
            this.краткое_описаниеTextBox.TabIndex = 8;
            // 
            // стоимость_услугLabel
            // 
            стоимость_услугLabel.AutoSize = true;
            стоимость_услугLabel.Location = new System.Drawing.Point(12, 196);
            стоимость_услугLabel.Name = "стоимость_услугLabel";
            стоимость_услугLabel.Size = new System.Drawing.Size(120, 16);
            стоимость_услугLabel.TabIndex = 9;
            стоимость_услугLabel.Text = "Стоимость услуг:";
            // 
            // стоимость_услугTextBox
            // 
            this.стоимость_услугTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договорBindingSource, "Стоимость_услуг", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.стоимость_услугTextBox.Location = new System.Drawing.Point(288, 190);
            this.стоимость_услугTextBox.Name = "стоимость_услугTextBox";
            this.стоимость_услугTextBox.Size = new System.Drawing.Size(122, 22);
            this.стоимость_услугTextBox.TabIndex = 10;
            // 
            // количество_оплачиваемых_занятийLabel
            // 
            количество_оплачиваемых_занятийLabel.AutoSize = true;
            количество_оплачиваемых_занятийLabel.Location = new System.Drawing.Point(12, 249);
            количество_оплачиваемых_занятийLabel.Name = "количество_оплачиваемых_занятийLabel";
            количество_оплачиваемых_занятийLabel.Size = new System.Drawing.Size(244, 16);
            количество_оплачиваемых_занятийLabel.TabIndex = 11;
            количество_оплачиваемых_занятийLabel.Text = "Количество оплачиваемых занятий:";
            // 
            // количество_оплачиваемых_занятийTextBox
            // 
            this.количество_оплачиваемых_занятийTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договорBindingSource, "Количество_оплачиваемых_занятий", true));
            this.количество_оплачиваемых_занятийTextBox.Location = new System.Drawing.Point(288, 243);
            this.количество_оплачиваемых_занятийTextBox.Name = "количество_оплачиваемых_занятийTextBox";
            this.количество_оплачиваемых_занятийTextBox.Size = new System.Drawing.Size(122, 22);
            this.количество_оплачиваемых_занятийTextBox.TabIndex = 12;
            // 
            // FormContractsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iD_договораLabel);
            this.Controls.Add(this.iD_договораTextBox);
            this.Controls.Add(iD_ученикаLabel);
            this.Controls.Add(this.iD_ученикаTextBox);
            this.Controls.Add(iD_администратораLabel);
            this.Controls.Add(this.iD_администратораTextBox);
            this.Controls.Add(краткое_описаниеLabel);
            this.Controls.Add(this.краткое_описаниеTextBox);
            this.Controls.Add(стоимость_услугLabel);
            this.Controls.Add(this.стоимость_услугTextBox);
            this.Controls.Add(количество_оплачиваемых_занятийLabel);
            this.Controls.Add(this.количество_оплачиваемых_занятийTextBox);
            this.Controls.Add(this.договорBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContractsList";
            this.Text = "Договоры";
            this.Load += new System.EventHandler(this.FormContractsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договорBindingNavigator)).EndInit();
            this.договорBindingNavigator.ResumeLayout(false);
            this.договорBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource договорBindingSource;
        private SchoolDataSetTableAdapters.ДоговорTableAdapter договорTableAdapter;
        private SchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator договорBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton договорBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_договораTextBox;
        private System.Windows.Forms.TextBox iD_ученикаTextBox;
        private System.Windows.Forms.TextBox iD_администратораTextBox;
        private System.Windows.Forms.TextBox краткое_описаниеTextBox;
        private System.Windows.Forms.TextBox стоимость_услугTextBox;
        private System.Windows.Forms.TextBox количество_оплачиваемых_занятийTextBox;
    }
}