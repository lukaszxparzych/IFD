namespace BazaDanych
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
            this.serialLabel = new System.Windows.Forms.Label();
            this.tytulBox = new System.Windows.Forms.TextBox();
            this.liczbasezonowBox = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.czastrwaniaBox = new System.Windows.Forms.TextBox();
            this.tytulLabel = new System.Windows.Forms.Label();
            this.lsezonowLabel = new System.Windows.Forms.Label();
            this.czastrwaniaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serialLabel.Location = new System.Drawing.Point(75, 9);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(89, 31);
            this.serialLabel.TabIndex = 0;
            this.serialLabel.Text = "Serial";
            // 
            // tytulBox
            // 
            this.tytulBox.Location = new System.Drawing.Point(18, 63);
            this.tytulBox.Name = "tytulBox";
            this.tytulBox.Size = new System.Drawing.Size(100, 20);
            this.tytulBox.TabIndex = 1;
            this.tytulBox.TextChanged += new System.EventHandler(this.tytulBox_TextChanged);
            // 
            // liczbasezonowBox
            // 
            this.liczbasezonowBox.Location = new System.Drawing.Point(18, 102);
            this.liczbasezonowBox.Name = "liczbasezonowBox";
            this.liczbasezonowBox.Size = new System.Drawing.Size(100, 20);
            this.liczbasezonowBox.TabIndex = 2;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(145, 102);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 23);
            this.dodajButton.TabIndex = 3;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // czastrwaniaBox
            // 
            this.czastrwaniaBox.Location = new System.Drawing.Point(18, 141);
            this.czastrwaniaBox.Name = "czastrwaniaBox";
            this.czastrwaniaBox.Size = new System.Drawing.Size(100, 20);
            this.czastrwaniaBox.TabIndex = 4;
            // 
            // tytulLabel
            // 
            this.tytulLabel.AutoSize = true;
            this.tytulLabel.Location = new System.Drawing.Point(18, 47);
            this.tytulLabel.Name = "tytulLabel";
            this.tytulLabel.Size = new System.Drawing.Size(32, 13);
            this.tytulLabel.TabIndex = 6;
            this.tytulLabel.Text = "Tytuł";
            // 
            // lsezonowLabel
            // 
            this.lsezonowLabel.AutoSize = true;
            this.lsezonowLabel.Location = new System.Drawing.Point(16, 86);
            this.lsezonowLabel.Name = "lsezonowLabel";
            this.lsezonowLabel.Size = new System.Drawing.Size(83, 13);
            this.lsezonowLabel.TabIndex = 7;
            this.lsezonowLabel.Text = "Liczba sezonów";
            // 
            // czastrwaniaLabel
            // 
            this.czastrwaniaLabel.AutoSize = true;
            this.czastrwaniaLabel.Location = new System.Drawing.Point(18, 125);
            this.czastrwaniaLabel.Name = "czastrwaniaLabel";
            this.czastrwaniaLabel.Size = new System.Drawing.Size(67, 13);
            this.czastrwaniaLabel.TabIndex = 8;
            this.czastrwaniaLabel.Text = "Czas trwania";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 171);
            this.Controls.Add(this.czastrwaniaLabel);
            this.Controls.Add(this.lsezonowLabel);
            this.Controls.Add(this.tytulLabel);
            this.Controls.Add(this.czastrwaniaBox);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.liczbasezonowBox);
            this.Controls.Add(this.tytulBox);
            this.Controls.Add(this.serialLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serialLabel;
        private System.Windows.Forms.TextBox tytulBox;
        private System.Windows.Forms.TextBox liczbasezonowBox;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.TextBox czastrwaniaBox;
        private System.Windows.Forms.Label tytulLabel;
        private System.Windows.Forms.Label lsezonowLabel;
        private System.Windows.Forms.Label czastrwaniaLabel;
    }
}