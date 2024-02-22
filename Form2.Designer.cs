namespace Database
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
            this.textBoxNewFIO = new System.Windows.Forms.TextBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.buttonSaveChange = new System.Windows.Forms.Button();
            this.buttonCancleChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNewFIO
            // 
            this.textBoxNewFIO.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNewFIO.Location = new System.Drawing.Point(188, 76);
            this.textBoxNewFIO.Name = "textBoxNewFIO";
            this.textBoxNewFIO.ReadOnly = true;
            this.textBoxNewFIO.Size = new System.Drawing.Size(171, 20);
            this.textBoxNewFIO.TabIndex = 0;
            this.textBoxNewFIO.Text = "Введите новое ФИО";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(188, 103);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(171, 20);
            this.textBoxFIO.TabIndex = 1;
            // 
            // buttonSaveChange
            // 
            this.buttonSaveChange.Location = new System.Drawing.Point(283, 149);
            this.buttonSaveChange.Name = "buttonSaveChange";
            this.buttonSaveChange.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveChange.TabIndex = 2;
            this.buttonSaveChange.Text = "Сохранить";
            this.buttonSaveChange.UseVisualStyleBackColor = true;
            this.buttonSaveChange.Click += new System.EventHandler(this.buttonSaveChange_Click);
            // 
            // buttonCancleChange
            // 
            this.buttonCancleChange.Location = new System.Drawing.Point(188, 149);
            this.buttonCancleChange.Name = "buttonCancleChange";
            this.buttonCancleChange.Size = new System.Drawing.Size(75, 23);
            this.buttonCancleChange.TabIndex = 3;
            this.buttonCancleChange.Text = "Отмена";
            this.buttonCancleChange.UseVisualStyleBackColor = true;
            this.buttonCancleChange.Click += new System.EventHandler(this.buttonCancleChange_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 227);
            this.Controls.Add(this.buttonCancleChange);
            this.Controls.Add(this.buttonSaveChange);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.textBoxNewFIO);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewFIO;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Button buttonSaveChange;
        private System.Windows.Forms.Button buttonCancleChange;
    }
}