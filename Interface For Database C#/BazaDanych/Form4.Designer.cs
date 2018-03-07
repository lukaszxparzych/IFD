namespace BazaDanych
{
    partial class Form4
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
            this.nazwaStudioBox = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.editStudio = new System.Windows.Forms.Button();
            this.deleteStudio = new System.Windows.Forms.Button();
            this.addStudio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nazwaStudioBox
            // 
            this.nazwaStudioBox.FormattingEnabled = true;
            this.nazwaStudioBox.Location = new System.Drawing.Point(12, 12);
            this.nazwaStudioBox.Name = "nazwaStudioBox";
            this.nazwaStudioBox.Size = new System.Drawing.Size(124, 121);
            this.nazwaStudioBox.TabIndex = 10;
            this.nazwaStudioBox.SelectedIndexChanged += new System.EventHandler(this.nazwaStudioBox_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 9;
            // 
            // editStudio
            // 
            this.editStudio.Location = new System.Drawing.Point(42, 199);
            this.editStudio.Name = "editStudio";
            this.editStudio.Size = new System.Drawing.Size(61, 23);
            this.editStudio.TabIndex = 8;
            this.editStudio.Text = "Edytuj";
            this.editStudio.UseVisualStyleBackColor = true;
            this.editStudio.Click += new System.EventHandler(this.editGatunek_Click);
            // 
            // deleteStudio
            // 
            this.deleteStudio.Location = new System.Drawing.Point(75, 143);
            this.deleteStudio.Name = "deleteStudio";
            this.deleteStudio.Size = new System.Drawing.Size(61, 23);
            this.deleteStudio.TabIndex = 7;
            this.deleteStudio.Text = "Usuń";
            this.deleteStudio.UseVisualStyleBackColor = true;
            this.deleteStudio.Click += new System.EventHandler(this.deleteStudio_Click);
            // 
            // addStudio
            // 
            this.addStudio.Location = new System.Drawing.Point(12, 143);
            this.addStudio.Name = "addStudio";
            this.addStudio.Size = new System.Drawing.Size(56, 23);
            this.addStudio.TabIndex = 6;
            this.addStudio.Text = "Dodaj";
            this.addStudio.UseVisualStyleBackColor = true;
            this.addStudio.Click += new System.EventHandler(this.addStudio_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 231);
            this.Controls.Add(this.nazwaStudioBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.editStudio);
            this.Controls.Add(this.deleteStudio);
            this.Controls.Add(this.addStudio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nazwaStudioBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button editStudio;
        private System.Windows.Forms.Button deleteStudio;
        private System.Windows.Forms.Button addStudio;
    }
}