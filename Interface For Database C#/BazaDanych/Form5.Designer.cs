namespace BazaDanych
{
    partial class Form5
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
            this.nazwaKrajBox = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.editKraj = new System.Windows.Forms.Button();
            this.deleteKraj = new System.Windows.Forms.Button();
            this.addKraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nazwaKrajBox
            // 
            this.nazwaKrajBox.FormattingEnabled = true;
            this.nazwaKrajBox.Location = new System.Drawing.Point(12, 12);
            this.nazwaKrajBox.Name = "nazwaKrajBox";
            this.nazwaKrajBox.Size = new System.Drawing.Size(124, 121);
            this.nazwaKrajBox.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 9;
            // 
            // editKraj
            // 
            this.editKraj.Location = new System.Drawing.Point(42, 199);
            this.editKraj.Name = "editKraj";
            this.editKraj.Size = new System.Drawing.Size(61, 23);
            this.editKraj.TabIndex = 8;
            this.editKraj.Text = "Edytuj";
            this.editKraj.UseVisualStyleBackColor = true;
            this.editKraj.Click += new System.EventHandler(this.editKraj_Click);
            // 
            // deleteKraj
            // 
            this.deleteKraj.Location = new System.Drawing.Point(75, 143);
            this.deleteKraj.Name = "deleteKraj";
            this.deleteKraj.Size = new System.Drawing.Size(61, 23);
            this.deleteKraj.TabIndex = 7;
            this.deleteKraj.Text = "Usuń";
            this.deleteKraj.UseVisualStyleBackColor = true;
            this.deleteKraj.Click += new System.EventHandler(this.deleteKraj_Click);
            // 
            // addKraj
            // 
            this.addKraj.Location = new System.Drawing.Point(12, 143);
            this.addKraj.Name = "addKraj";
            this.addKraj.Size = new System.Drawing.Size(56, 23);
            this.addKraj.TabIndex = 6;
            this.addKraj.Text = "Dodaj";
            this.addKraj.UseVisualStyleBackColor = true;
            this.addKraj.Click += new System.EventHandler(this.addGatunek_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 232);
            this.Controls.Add(this.nazwaKrajBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.editKraj);
            this.Controls.Add(this.deleteKraj);
            this.Controls.Add(this.addKraj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nazwaKrajBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button editKraj;
        private System.Windows.Forms.Button deleteKraj;
        private System.Windows.Forms.Button addKraj;
    }
}