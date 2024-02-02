namespace Database
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowDate = new System.Windows.Forms.DataGridView();
            this.DepNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxOpen = new System.Windows.Forms.TextBox();
            this.textBoxClose = new System.Windows.Forms.TextBox();
            this.textBoxStartDep = new System.Windows.Forms.TextBox();
            this.ButtonAddData = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxForDel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDate)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowDate
            // 
            this.ShowDate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ShowDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepNumber,
            this.NameSur,
            this.OpenDate,
            this.CloseDate,
            this.DepStart});
            this.ShowDate.Location = new System.Drawing.Point(21, 109);
            this.ShowDate.Margin = new System.Windows.Forms.Padding(2);
            this.ShowDate.Name = "ShowDate";
            this.ShowDate.RowHeadersVisible = false;
            this.ShowDate.RowHeadersWidth = 51;
            this.ShowDate.RowTemplate.Height = 24;
            this.ShowDate.Size = new System.Drawing.Size(820, 254);
            this.ShowDate.TabIndex = 0;
            this.ShowDate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowDate_CellContentClick);
            // 
            // DepNumber
            // 
            this.DepNumber.HeaderText = "Номер вклада";
            this.DepNumber.MinimumWidth = 6;
            this.DepNumber.Name = "DepNumber";
            this.DepNumber.Width = 160;
            // 
            // NameSur
            // 
            this.NameSur.HeaderText = "Ф.И.О вкладчика";
            this.NameSur.MinimumWidth = 6;
            this.NameSur.Name = "NameSur";
            this.NameSur.Width = 170;
            // 
            // OpenDate
            // 
            this.OpenDate.HeaderText = "Дата открытия";
            this.OpenDate.MinimumWidth = 6;
            this.OpenDate.Name = "OpenDate";
            this.OpenDate.Width = 167;
            // 
            // CloseDate
            // 
            this.CloseDate.HeaderText = "Дата закрытия";
            this.CloseDate.MinimumWidth = 6;
            this.CloseDate.Name = "CloseDate";
            this.CloseDate.Width = 160;
            // 
            // DepStart
            // 
            this.DepStart.HeaderText = "Размер начального депозита";
            this.DepStart.MinimumWidth = 6;
            this.DepStart.Name = "DepStart";
            this.DepStart.Width = 160;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(135, 43);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(241, 43);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxOpen
            // 
            this.textBoxOpen.Location = new System.Drawing.Point(347, 43);
            this.textBoxOpen.Multiline = true;
            this.textBoxOpen.Name = "textBoxOpen";
            this.textBoxOpen.Size = new System.Drawing.Size(100, 20);
            this.textBoxOpen.TabIndex = 3;
            // 
            // textBoxClose
            // 
            this.textBoxClose.Location = new System.Drawing.Point(453, 43);
            this.textBoxClose.Multiline = true;
            this.textBoxClose.Name = "textBoxClose";
            this.textBoxClose.Size = new System.Drawing.Size(100, 20);
            this.textBoxClose.TabIndex = 4;
            // 
            // textBoxStartDep
            // 
            this.textBoxStartDep.Location = new System.Drawing.Point(559, 43);
            this.textBoxStartDep.Multiline = true;
            this.textBoxStartDep.Name = "textBoxStartDep";
            this.textBoxStartDep.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartDep.TabIndex = 5;
            // 
            // ButtonAddData
            // 
            this.ButtonAddData.Location = new System.Drawing.Point(680, 43);
            this.ButtonAddData.Name = "ButtonAddData";
            this.ButtonAddData.Size = new System.Drawing.Size(87, 20);
            this.ButtonAddData.TabIndex = 6;
            this.ButtonAddData.Text = "Добавить";
            this.ButtonAddData.UseVisualStyleBackColor = true;
            this.ButtonAddData.Click += new System.EventHandler(this.ButtonAddData_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(241, 69);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 7;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxForDel
            // 
            this.textBoxForDel.Location = new System.Drawing.Point(135, 72);
            this.textBoxForDel.Multiline = true;
            this.textBoxForDel.Name = "textBoxForDel";
            this.textBoxForDel.Size = new System.Drawing.Size(100, 20);
            this.textBoxForDel.TabIndex = 8;
            this.textBoxForDel.TextChanged += new System.EventHandler(this.textBoxForDel_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 526);
            this.Controls.Add(this.textBoxForDel);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.ButtonAddData);
            this.Controls.Add(this.textBoxStartDep);
            this.Controls.Add(this.textBoxClose);
            this.Controls.Add(this.textBoxOpen);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.ShowDate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Bank data base";
            ((System.ComponentModel.ISupportInitialize)(this.ShowDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ShowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSur;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CloseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepStart;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxOpen;
        private System.Windows.Forms.TextBox textBoxClose;
        private System.Windows.Forms.TextBox textBoxStartDep;
        private System.Windows.Forms.Button ButtonAddData;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxForDel;
    }
}

