namespace BazaDanych
{
    partial class Form3
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
            this.addGatunek = new System.Windows.Forms.Button();
            this.deleteGatunek = new System.Windows.Forms.Button();
            this.editGatunek = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nazwaGatunekBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addGatunek
            // 
            this.addGatunek.Location = new System.Drawing.Point(13, 144);
            this.addGatunek.Name = "addGatunek";
            this.addGatunek.Size = new System.Drawing.Size(56, 23);
            this.addGatunek.TabIndex = 1;
            this.addGatunek.Text = "Dodaj";
            this.addGatunek.UseVisualStyleBackColor = true;
            this.addGatunek.Click += new System.EventHandler(this.addGatunek_Click);
            // 
            // deleteGatunek
            // 
            this.deleteGatunek.Location = new System.Drawing.Point(76, 144);
            this.deleteGatunek.Name = "deleteGatunek";
            this.deleteGatunek.Size = new System.Drawing.Size(61, 23);
            this.deleteGatunek.TabIndex = 2;
            this.deleteGatunek.Text = "Usuń";
            this.deleteGatunek.UseVisualStyleBackColor = true;
            this.deleteGatunek.Click += new System.EventHandler(this.deleteGatunek_Click);
            // 
            // editGatunek
            // 
            this.editGatunek.Location = new System.Drawing.Point(43, 200);
            this.editGatunek.Name = "editGatunek";
            this.editGatunek.Size = new System.Drawing.Size(61, 23);
            this.editGatunek.TabIndex = 3;
            this.editGatunek.Text = "Edytuj";
            this.editGatunek.UseVisualStyleBackColor = true;
            this.editGatunek.Click += new System.EventHandler(this.editGatunek_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 4;
            // 
            // nazwaGatunekBox
            // 
            this.nazwaGatunekBox.FormattingEnabled = true;
            this.nazwaGatunekBox.Location = new System.Drawing.Point(13, 13);
            this.nazwaGatunekBox.Name = "nazwaGatunekBox";
            this.nazwaGatunekBox.Size = new System.Drawing.Size(124, 121);
            this.nazwaGatunekBox.TabIndex = 5;
            this.nazwaGatunekBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 242);
            this.Controls.Add(this.nazwaGatunekBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.editGatunek);
            this.Controls.Add(this.deleteGatunek);
            this.Controls.Add(this.addGatunek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addGatunek;
        private System.Windows.Forms.Button deleteGatunek;
        private System.Windows.Forms.Button editGatunek;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox nazwaGatunekBox;
    }
}