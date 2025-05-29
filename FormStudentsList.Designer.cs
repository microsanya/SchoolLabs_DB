namespace SchoolLabs
{
    partial class FormStudentsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentsList));
            this.schoolDataSet = new SchoolLabs.SchoolDataSet();
            this.ученикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ученикTableAdapter = new SchoolLabs.SchoolDataSetTableAdapters.УченикTableAdapter();
            this.tableAdapterManager = new SchoolLabs.SchoolDataSetTableAdapters.TableAdapterManager();
            this.ученикBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ученикBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ученикDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикBindingNavigator)).BeginInit();
            this.ученикBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ученикDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "SchoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ученикBindingSource
            // 
            this.ученикBindingSource.DataMember = "Ученик";
            this.ученикBindingSource.DataSource = this.schoolDataSet;
            // 
            // ученикTableAdapter
            // 
            this.ученикTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ПреподавательTableAdapter = null;
            this.tableAdapterManager.Состав_группыTableAdapter = null;
            this.tableAdapterManager.УченикTableAdapter = this.ученикTableAdapter;
            // 
            // ученикBindingNavigator
            // 
            this.ученикBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ученикBindingNavigator.BindingSource = this.ученикBindingSource;
            this.ученикBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ученикBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ученикBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ученикBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ученикBindingNavigatorSaveItem});
            this.ученикBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ученикBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ученикBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ученикBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ученикBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ученикBindingNavigator.Name = "ученикBindingNavigator";
            this.ученикBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ученикBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.ученикBindingNavigator.TabIndex = 0;
            this.ученикBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
            // ученикBindingNavigatorSaveItem
            // 
            this.ученикBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ученикBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ученикBindingNavigatorSaveItem.Image")));
            this.ученикBindingNavigatorSaveItem.Name = "ученикBindingNavigatorSaveItem";
            this.ученикBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.ученикBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ученикBindingNavigatorSaveItem.Click += new System.EventHandler(this.ученикBindingNavigatorSaveItem_Click);
            // 
            // ученикDataGridView
            // 
            this.ученикDataGridView.AutoGenerateColumns = false;
            this.ученикDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ученикDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.ученикDataGridView.DataSource = this.ученикBindingSource;
            this.ученикDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ученикDataGridView.Location = new System.Drawing.Point(0, 31);
            this.ученикDataGridView.Name = "ученикDataGridView";
            this.ученикDataGridView.RowHeadersWidth = 51;
            this.ученикDataGridView.RowTemplate.Height = 24;
            this.ученикDataGridView.Size = new System.Drawing.Size(800, 419);
            this.ученикDataGridView.TabIndex = 1;
            this.ученикDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ученикDataGridView_CellValidating);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_ученика";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_ученика";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО_ученика";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО_ученика";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn3.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ФИО_законного_представителя";
            this.dataGridViewTextBoxColumn4.HeaderText = "ФИО_законного_представителя";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Статус_активности";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Статус_активности";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // FormStudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ученикDataGridView);
            this.Controls.Add(this.ученикBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStudentsList";
            this.Text = "Ученики";
            this.Load += new System.EventHandler(this.FormStudentsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ученикBindingNavigator)).EndInit();
            this.ученикBindingNavigator.ResumeLayout(false);
            this.ученикBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ученикDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SchoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource ученикBindingSource;
        private SchoolDataSetTableAdapters.УченикTableAdapter ученикTableAdapter;
        private SchoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ученикBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ученикBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ученикDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}