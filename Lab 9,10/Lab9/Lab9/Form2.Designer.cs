namespace Lab9
{
    partial class Form2
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
            System.Windows.Forms.Label asurnameLabel;
            System.Windows.Forms.Label anameLabel;
            System.Windows.Forms.Label alastnameLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.books22DataSet = new Lab9.Books22DataSet();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorTableAdapter = new Lab9.Books22DataSetTableAdapters.authorTableAdapter();
            this.tableAdapterManager = new Lab9.Books22DataSetTableAdapters.TableAdapterManager();
            this.authorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.authorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.asurnameTextBox = new System.Windows.Forms.TextBox();
            this.anameTextBox = new System.Windows.Forms.TextBox();
            this.alastnameTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            asurnameLabel = new System.Windows.Forms.Label();
            anameLabel = new System.Windows.Forms.Label();
            alastnameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.books22DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingNavigator)).BeginInit();
            this.authorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // asurnameLabel
            // 
            asurnameLabel.AutoSize = true;
            asurnameLabel.Location = new System.Drawing.Point(65, 124);
            asurnameLabel.Name = "asurnameLabel";
            asurnameLabel.Size = new System.Drawing.Size(70, 17);
            asurnameLabel.TabIndex = 2;
            asurnameLabel.Text = "Фамилия";
            // 
            // anameLabel
            // 
            anameLabel.AutoSize = true;
            anameLabel.Location = new System.Drawing.Point(65, 168);
            anameLabel.Name = "anameLabel";
            anameLabel.Size = new System.Drawing.Size(35, 17);
            anameLabel.TabIndex = 4;
            anameLabel.Text = "Имя";
            // 
            // alastnameLabel
            // 
            alastnameLabel.AutoSize = true;
            alastnameLabel.Location = new System.Drawing.Point(65, 218);
            alastnameLabel.Name = "alastnameLabel";
            alastnameLabel.Size = new System.Drawing.Size(71, 17);
            alastnameLabel.TabIndex = 6;
            alastnameLabel.Text = "Отчество";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(65, 268);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(111, 17);
            birthdayLabel.TabIndex = 8;
            birthdayLabel.Text = "Дата рождения";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(99, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Авторы\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // books22DataSet
            // 
            this.books22DataSet.DataSetName = "Books22DataSet";
            this.books22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "author";
            this.authorBindingSource.DataSource = this.books22DataSet;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.authorTableAdapter = this.authorTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookTableAdapter = null;
            this.tableAdapterManager.buyersTableAdapter = null;
            this.tableAdapterManager.publishTableAdapter = null;
            this.tableAdapterManager.purch_bookTableAdapter = null;
            this.tableAdapterManager.purchaseTableAdapter = null;
            this.tableAdapterManager.tTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lab9.Books22DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // authorBindingNavigator
            // 
            this.authorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.authorBindingNavigator.BindingSource = this.authorBindingSource;
            this.authorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.authorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.authorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.authorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.authorBindingNavigatorSaveItem});
            this.authorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.authorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.authorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.authorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.authorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.authorBindingNavigator.Name = "authorBindingNavigator";
            this.authorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.authorBindingNavigator.Size = new System.Drawing.Size(443, 31);
            this.authorBindingNavigator.TabIndex = 1;
            this.authorBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // authorBindingNavigatorSaveItem
            // 
            this.authorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.authorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("authorBindingNavigatorSaveItem.Image")));
            this.authorBindingNavigatorSaveItem.Name = "authorBindingNavigatorSaveItem";
            this.authorBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.authorBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.authorBindingNavigatorSaveItem.Click += new System.EventHandler(this.authorBindingNavigatorSaveItem_Click);
            // 
            // asurnameTextBox
            // 
            this.asurnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "asurname", true));
            this.asurnameTextBox.Location = new System.Drawing.Point(179, 124);
            this.asurnameTextBox.Name = "asurnameTextBox";
            this.asurnameTextBox.Size = new System.Drawing.Size(141, 22);
            this.asurnameTextBox.TabIndex = 3;
            // 
            // anameTextBox
            // 
            this.anameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "aname", true));
            this.anameTextBox.Location = new System.Drawing.Point(179, 168);
            this.anameTextBox.Name = "anameTextBox";
            this.anameTextBox.Size = new System.Drawing.Size(141, 22);
            this.anameTextBox.TabIndex = 5;
            // 
            // alastnameTextBox
            // 
            this.alastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorBindingSource, "alastname", true));
            this.alastnameTextBox.Location = new System.Drawing.Point(179, 215);
            this.alastnameTextBox.Name = "alastnameTextBox";
            this.alastnameTextBox.Size = new System.Drawing.Size(141, 22);
            this.alastnameTextBox.TabIndex = 7;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.authorBindingSource, "birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(191, 263);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.birthdayDateTimePicker.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Отчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(alastnameLabel);
            this.Controls.Add(this.alastnameTextBox);
            this.Controls.Add(anameLabel);
            this.Controls.Add(this.anameTextBox);
            this.Controls.Add(asurnameLabel);
            this.Controls.Add(this.asurnameTextBox);
            this.Controls.Add(this.authorBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Таблица \"Авторы\"";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.books22DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingNavigator)).EndInit();
            this.authorBindingNavigator.ResumeLayout(false);
            this.authorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Books22DataSet books22DataSet;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private Books22DataSetTableAdapters.authorTableAdapter authorTableAdapter;
        private Books22DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator authorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton authorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox asurnameTextBox;
        private System.Windows.Forms.TextBox anameTextBox;
        private System.Windows.Forms.TextBox alastnameTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}