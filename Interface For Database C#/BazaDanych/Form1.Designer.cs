namespace BazaDanych
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.serialeDataSet = new BazaDanych.serialeDataSet();
            this.gatunekBox = new System.Windows.Forms.ListBox();
            this.gatunekLabel = new System.Windows.Forms.Label();
            this.serialnazwaLabel = new System.Windows.Forms.Label();
            this.tytulBox = new System.Windows.Forms.ListBox();
            this.studioLabel = new System.Windows.Forms.Label();
            this.studioBox = new System.Windows.Forms.ListBox();
            this.addSerialButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.liczbasezonowLabel = new System.Windows.Forms.Label();
            this.czastrwaniaLabel = new System.Windows.Forms.Label();
            this.liczbasezonowBox = new System.Windows.Forms.ListBox();
            this.czastrwaniaBox = new System.Windows.Forms.ListBox();
            this.editSerialButton = new System.Windows.Forms.Button();
            this.deleteSerialButton = new System.Windows.Forms.Button();
            this.editSerialBox = new System.Windows.Forms.TextBox();
            this.editTytulCheck = new System.Windows.Forms.CheckBox();
            this.editLiczbasezonowCheck = new System.Windows.Forms.CheckBox();
            this.editCzastrwaniaCheck = new System.Windows.Forms.CheckBox();
            this.gatunekAddButton = new System.Windows.Forms.Button();
            this.gatunekDeleteButton = new System.Windows.Forms.Button();
            this.gatunekCombo = new System.Windows.Forms.ComboBox();
            this.selectGatunekLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studioCombo = new System.Windows.Forms.ComboBox();
            this.selectStudioLabel = new System.Windows.Forms.Label();
            this.deleteStudioButton = new System.Windows.Forms.Button();
            this.addStudioButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.krajBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButtonCountry = new System.Windows.Forms.Button();
            this.KrajCombo = new System.Windows.Forms.ComboBox();
            this.deleteButtonCountry = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.addCountryButton = new System.Windows.Forms.Button();
            this.addButtonStudio = new System.Windows.Forms.Button();
            this.addGatunekButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serialeDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialeDataSet
            // 
            this.serialeDataSet.DataSetName = "serialeDataSet";
            this.serialeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gatunekBox
            // 
            this.gatunekBox.FormattingEnabled = true;
            this.gatunekBox.Location = new System.Drawing.Point(389, 140);
            this.gatunekBox.Name = "gatunekBox";
            this.gatunekBox.Size = new System.Drawing.Size(119, 82);
            this.gatunekBox.TabIndex = 0;
            this.gatunekBox.SelectedIndexChanged += new System.EventHandler(this.gatunekBox_SelectedIndexChanged);
            // 
            // gatunekLabel
            // 
            this.gatunekLabel.AutoSize = true;
            this.gatunekLabel.Location = new System.Drawing.Point(386, 124);
            this.gatunekLabel.Name = "gatunekLabel";
            this.gatunekLabel.Size = new System.Drawing.Size(48, 13);
            this.gatunekLabel.TabIndex = 1;
            this.gatunekLabel.Text = "Gatunek";
            this.gatunekLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // serialnazwaLabel
            // 
            this.serialnazwaLabel.AutoSize = true;
            this.serialnazwaLabel.Location = new System.Drawing.Point(5, 16);
            this.serialnazwaLabel.Name = "serialnazwaLabel";
            this.serialnazwaLabel.Size = new System.Drawing.Size(30, 13);
            this.serialnazwaLabel.TabIndex = 6;
            this.serialnazwaLabel.Text = "Tytul";
            // 
            // tytulBox
            // 
            this.tytulBox.FormattingEnabled = true;
            this.tytulBox.Location = new System.Drawing.Point(8, 32);
            this.tytulBox.Name = "tytulBox";
            this.tytulBox.Size = new System.Drawing.Size(165, 251);
            this.tytulBox.TabIndex = 5;
            this.tytulBox.SelectedIndexChanged += new System.EventHandler(this.tytulBox_SelectedIndexChanged);
            // 
            // studioLabel
            // 
            this.studioLabel.AutoSize = true;
            this.studioLabel.Location = new System.Drawing.Point(386, 225);
            this.studioLabel.Name = "studioLabel";
            this.studioLabel.Size = new System.Drawing.Size(37, 13);
            this.studioLabel.TabIndex = 10;
            this.studioLabel.Text = "Studio";
            // 
            // studioBox
            // 
            this.studioBox.FormattingEnabled = true;
            this.studioBox.Location = new System.Drawing.Point(389, 241);
            this.studioBox.Name = "studioBox";
            this.studioBox.Size = new System.Drawing.Size(119, 95);
            this.studioBox.TabIndex = 9;
            // 
            // addSerialButton
            // 
            this.addSerialButton.Location = new System.Drawing.Point(6, 296);
            this.addSerialButton.Name = "addSerialButton";
            this.addSerialButton.Size = new System.Drawing.Size(70, 23);
            this.addSerialButton.TabIndex = 20;
            this.addSerialButton.Text = "Dodaj";
            this.addSerialButton.UseVisualStyleBackColor = true;
            this.addSerialButton.Click += new System.EventHandler(this.addSerialButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(664, 32);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 21;
            this.refreshButton.Text = "Odśwież";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // liczbasezonowLabel
            // 
            this.liczbasezonowLabel.AutoSize = true;
            this.liczbasezonowLabel.Location = new System.Drawing.Point(183, 16);
            this.liczbasezonowLabel.Name = "liczbasezonowLabel";
            this.liczbasezonowLabel.Size = new System.Drawing.Size(83, 13);
            this.liczbasezonowLabel.TabIndex = 23;
            this.liczbasezonowLabel.Text = "Liczba sezonów";
            // 
            // czastrwaniaLabel
            // 
            this.czastrwaniaLabel.AutoSize = true;
            this.czastrwaniaLabel.Location = new System.Drawing.Point(297, 16);
            this.czastrwaniaLabel.Name = "czastrwaniaLabel";
            this.czastrwaniaLabel.Size = new System.Drawing.Size(67, 13);
            this.czastrwaniaLabel.TabIndex = 25;
            this.czastrwaniaLabel.Text = "Czas trwania";
            // 
            // liczbasezonowBox
            // 
            this.liczbasezonowBox.FormattingEnabled = true;
            this.liczbasezonowBox.Location = new System.Drawing.Point(179, 32);
            this.liczbasezonowBox.Name = "liczbasezonowBox";
            this.liczbasezonowBox.Size = new System.Drawing.Size(96, 251);
            this.liczbasezonowBox.TabIndex = 26;
            // 
            // czastrwaniaBox
            // 
            this.czastrwaniaBox.FormattingEnabled = true;
            this.czastrwaniaBox.Location = new System.Drawing.Point(281, 32);
            this.czastrwaniaBox.Name = "czastrwaniaBox";
            this.czastrwaniaBox.Size = new System.Drawing.Size(96, 251);
            this.czastrwaniaBox.TabIndex = 27;
            // 
            // editSerialButton
            // 
            this.editSerialButton.Location = new System.Drawing.Point(155, 63);
            this.editSerialButton.Name = "editSerialButton";
            this.editSerialButton.Size = new System.Drawing.Size(100, 23);
            this.editSerialButton.TabIndex = 28;
            this.editSerialButton.Text = "Edytuj";
            this.editSerialButton.UseVisualStyleBackColor = true;
            this.editSerialButton.Click += new System.EventHandler(this.editSerialButton_Click);
            // 
            // deleteSerialButton
            // 
            this.deleteSerialButton.Location = new System.Drawing.Point(94, 296);
            this.deleteSerialButton.Name = "deleteSerialButton";
            this.deleteSerialButton.Size = new System.Drawing.Size(77, 23);
            this.deleteSerialButton.TabIndex = 29;
            this.deleteSerialButton.Text = "Usuń";
            this.deleteSerialButton.UseVisualStyleBackColor = true;
            this.deleteSerialButton.Click += new System.EventHandler(this.deleteSerialButton_Click);
            // 
            // editSerialBox
            // 
            this.editSerialBox.BackColor = System.Drawing.Color.White;
            this.editSerialBox.Location = new System.Drawing.Point(155, 37);
            this.editSerialBox.Name = "editSerialBox";
            this.editSerialBox.Size = new System.Drawing.Size(100, 20);
            this.editSerialBox.TabIndex = 30;
            // 
            // editTytulCheck
            // 
            this.editTytulCheck.AutoSize = true;
            this.editTytulCheck.Location = new System.Drawing.Point(6, 23);
            this.editTytulCheck.Name = "editTytulCheck";
            this.editTytulCheck.Size = new System.Drawing.Size(79, 17);
            this.editTytulCheck.TabIndex = 32;
            this.editTytulCheck.Text = "Edytuj tytuł";
            this.editTytulCheck.UseVisualStyleBackColor = true;
            // 
            // editLiczbasezonowCheck
            // 
            this.editLiczbasezonowCheck.AutoSize = true;
            this.editLiczbasezonowCheck.Location = new System.Drawing.Point(6, 46);
            this.editLiczbasezonowCheck.Name = "editLiczbasezonowCheck";
            this.editLiczbasezonowCheck.Size = new System.Drawing.Size(130, 17);
            this.editLiczbasezonowCheck.TabIndex = 33;
            this.editLiczbasezonowCheck.Text = "Edytuj liczba sezonów";
            this.editLiczbasezonowCheck.UseVisualStyleBackColor = true;
            // 
            // editCzastrwaniaCheck
            // 
            this.editCzastrwaniaCheck.AutoSize = true;
            this.editCzastrwaniaCheck.Location = new System.Drawing.Point(6, 69);
            this.editCzastrwaniaCheck.Name = "editCzastrwaniaCheck";
            this.editCzastrwaniaCheck.Size = new System.Drawing.Size(117, 17);
            this.editCzastrwaniaCheck.TabIndex = 34;
            this.editCzastrwaniaCheck.Text = "Edytuj czas trwania";
            this.editCzastrwaniaCheck.UseVisualStyleBackColor = true;
            // 
            // gatunekAddButton
            // 
            this.gatunekAddButton.Location = new System.Drawing.Point(6, 19);
            this.gatunekAddButton.Name = "gatunekAddButton";
            this.gatunekAddButton.Size = new System.Drawing.Size(70, 21);
            this.gatunekAddButton.TabIndex = 35;
            this.gatunekAddButton.Text = "Dodaj";
            this.gatunekAddButton.UseVisualStyleBackColor = true;
            this.gatunekAddButton.Click += new System.EventHandler(this.gatunekAddButton_Click);
            // 
            // gatunekDeleteButton
            // 
            this.gatunekDeleteButton.Location = new System.Drawing.Point(6, 44);
            this.gatunekDeleteButton.Name = "gatunekDeleteButton";
            this.gatunekDeleteButton.Size = new System.Drawing.Size(70, 21);
            this.gatunekDeleteButton.TabIndex = 36;
            this.gatunekDeleteButton.Text = "Usuń";
            this.gatunekDeleteButton.UseVisualStyleBackColor = true;
            this.gatunekDeleteButton.Click += new System.EventHandler(this.gatunekDeleteButton_Click);
            // 
            // gatunekCombo
            // 
            this.gatunekCombo.FormattingEnabled = true;
            this.gatunekCombo.Location = new System.Drawing.Point(79, 33);
            this.gatunekCombo.Name = "gatunekCombo";
            this.gatunekCombo.Size = new System.Drawing.Size(153, 21);
            this.gatunekCombo.TabIndex = 38;
            this.gatunekCombo.SelectedIndexChanged += new System.EventHandler(this.gatunekCombo_SelectedIndexChanged);
            // 
            // selectGatunekLabel
            // 
            this.selectGatunekLabel.AutoSize = true;
            this.selectGatunekLabel.Location = new System.Drawing.Point(78, 16);
            this.selectGatunekLabel.Name = "selectGatunekLabel";
            this.selectGatunekLabel.Size = new System.Drawing.Size(87, 13);
            this.selectGatunekLabel.TabIndex = 37;
            this.selectGatunekLabel.Text = "Wybierz gatunek";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editTytulCheck);
            this.groupBox1.Controls.Add(this.editSerialButton);
            this.groupBox1.Controls.Add(this.editSerialBox);
            this.groupBox1.Controls.Add(this.editLiczbasezonowCheck);
            this.groupBox1.Controls.Add(this.editCzastrwaniaCheck);
            this.groupBox1.Location = new System.Drawing.Point(383, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 89);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edytor";
            // 
            // studioCombo
            // 
            this.studioCombo.FormattingEnabled = true;
            this.studioCombo.Location = new System.Drawing.Point(79, 33);
            this.studioCombo.Name = "studioCombo";
            this.studioCombo.Size = new System.Drawing.Size(153, 21);
            this.studioCombo.TabIndex = 43;
            // 
            // selectStudioLabel
            // 
            this.selectStudioLabel.AutoSize = true;
            this.selectStudioLabel.Location = new System.Drawing.Point(78, 17);
            this.selectStudioLabel.Name = "selectStudioLabel";
            this.selectStudioLabel.Size = new System.Drawing.Size(76, 13);
            this.selectStudioLabel.TabIndex = 42;
            this.selectStudioLabel.Text = "Wybierz studio";
            this.selectStudioLabel.Click += new System.EventHandler(this.selectStudioLabel_Click);
            // 
            // deleteStudioButton
            // 
            this.deleteStudioButton.Location = new System.Drawing.Point(6, 46);
            this.deleteStudioButton.Name = "deleteStudioButton";
            this.deleteStudioButton.Size = new System.Drawing.Size(70, 21);
            this.deleteStudioButton.TabIndex = 41;
            this.deleteStudioButton.Text = "Usuń";
            this.deleteStudioButton.UseVisualStyleBackColor = true;
            // 
            // addStudioButton
            // 
            this.addStudioButton.Location = new System.Drawing.Point(6, 19);
            this.addStudioButton.Name = "addStudioButton";
            this.addStudioButton.Size = new System.Drawing.Size(70, 21);
            this.addStudioButton.TabIndex = 40;
            this.addStudioButton.Text = "Dodaj";
            this.addStudioButton.UseVisualStyleBackColor = true;
            this.addStudioButton.Click += new System.EventHandler(this.addStudioButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectGatunekLabel);
            this.groupBox2.Controls.Add(this.gatunekAddButton);
            this.groupBox2.Controls.Add(this.gatunekDeleteButton);
            this.groupBox2.Controls.Add(this.gatunekCombo);
            this.groupBox2.Location = new System.Drawing.Point(520, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 87);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edytor gatunek";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.selectStudioLabel);
            this.groupBox3.Controls.Add(this.addStudioButton);
            this.groupBox3.Controls.Add(this.studioCombo);
            this.groupBox3.Controls.Add(this.deleteStudioButton);
            this.groupBox3.Location = new System.Drawing.Point(520, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 95);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edytor studio";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.krajBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.gatunekBox);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.gatunekLabel);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.tytulBox);
            this.groupBox4.Controls.Add(this.deleteSerialButton);
            this.groupBox4.Controls.Add(this.serialnazwaLabel);
            this.groupBox4.Controls.Add(this.czastrwaniaBox);
            this.groupBox4.Controls.Add(this.studioBox);
            this.groupBox4.Controls.Add(this.liczbasezonowBox);
            this.groupBox4.Controls.Add(this.studioLabel);
            this.groupBox4.Controls.Add(this.refreshButton);
            this.groupBox4.Controls.Add(this.czastrwaniaLabel);
            this.groupBox4.Controls.Add(this.addSerialButton);
            this.groupBox4.Controls.Add(this.liczbasezonowLabel);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(794, 468);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seriale";
            // 
            // krajBox
            // 
            this.krajBox.FormattingEnabled = true;
            this.krajBox.Location = new System.Drawing.Point(389, 364);
            this.krajBox.Name = "krajBox";
            this.krajBox.Size = new System.Drawing.Size(119, 82);
            this.krajBox.TabIndex = 49;
            this.krajBox.SelectedIndexChanged += new System.EventHandler(this.krajBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Kraj produkcji";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.addButtonCountry);
            this.groupBox5.Controls.Add(this.KrajCombo);
            this.groupBox5.Controls.Add(this.deleteButtonCountry);
            this.groupBox5.Location = new System.Drawing.Point(526, 359);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(246, 87);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Edytor kraj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Wybierz kraj";
            // 
            // addButtonCountry
            // 
            this.addButtonCountry.Location = new System.Drawing.Point(6, 19);
            this.addButtonCountry.Name = "addButtonCountry";
            this.addButtonCountry.Size = new System.Drawing.Size(64, 21);
            this.addButtonCountry.TabIndex = 39;
            this.addButtonCountry.Text = "Dodaj";
            this.addButtonCountry.UseVisualStyleBackColor = true;
            this.addButtonCountry.Click += new System.EventHandler(this.addButtonCountry_Click);
            // 
            // KrajCombo
            // 
            this.KrajCombo.FormattingEnabled = true;
            this.KrajCombo.Location = new System.Drawing.Point(73, 33);
            this.KrajCombo.Name = "KrajCombo";
            this.KrajCombo.Size = new System.Drawing.Size(153, 21);
            this.KrajCombo.TabIndex = 42;
            // 
            // deleteButtonCountry
            // 
            this.deleteButtonCountry.Location = new System.Drawing.Point(7, 44);
            this.deleteButtonCountry.Name = "deleteButtonCountry";
            this.deleteButtonCountry.Size = new System.Drawing.Size(63, 21);
            this.deleteButtonCountry.TabIndex = 40;
            this.deleteButtonCountry.Text = "Usuń";
            this.deleteButtonCountry.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.addCountryButton);
            this.groupBox6.Controls.Add(this.addButtonStudio);
            this.groupBox6.Controls.Add(this.addGatunekButton);
            this.groupBox6.Location = new System.Drawing.Point(193, 296);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(171, 104);
            this.groupBox6.TabIndex = 47;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dodaj";
            // 
            // addCountryButton
            // 
            this.addCountryButton.Location = new System.Drawing.Point(6, 73);
            this.addCountryButton.Name = "addCountryButton";
            this.addCountryButton.Size = new System.Drawing.Size(128, 21);
            this.addCountryButton.TabIndex = 48;
            this.addCountryButton.Text = "Dodaj Kraj";
            this.addCountryButton.UseVisualStyleBackColor = true;
            this.addCountryButton.Click += new System.EventHandler(this.addCountryButton_Click);
            // 
            // addButtonStudio
            // 
            this.addButtonStudio.Location = new System.Drawing.Point(6, 46);
            this.addButtonStudio.Name = "addButtonStudio";
            this.addButtonStudio.Size = new System.Drawing.Size(128, 21);
            this.addButtonStudio.TabIndex = 47;
            this.addButtonStudio.Text = "Dodaj Studio";
            this.addButtonStudio.UseVisualStyleBackColor = true;
            this.addButtonStudio.Click += new System.EventHandler(this.button2_Click);
            // 
            // addGatunekButton
            // 
            this.addGatunekButton.Location = new System.Drawing.Point(6, 19);
            this.addGatunekButton.Name = "addGatunekButton";
            this.addGatunekButton.Size = new System.Drawing.Size(128, 21);
            this.addGatunekButton.TabIndex = 46;
            this.addGatunekButton.Text = "Dodaj Gatunek";
            this.addGatunekButton.UseVisualStyleBackColor = true;
            this.addGatunekButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 466);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serialeDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private serialeDataSet serialeDataSet;
        private System.Windows.Forms.ListBox gatunekBox;
        private System.Windows.Forms.Label gatunekLabel;
        private System.Windows.Forms.Label serialnazwaLabel;
        private System.Windows.Forms.ListBox tytulBox;
        private System.Windows.Forms.Label studioLabel;
        private System.Windows.Forms.ListBox studioBox;
        private System.Windows.Forms.Button addSerialButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label liczbasezonowLabel;
        private System.Windows.Forms.Label czastrwaniaLabel;
        private System.Windows.Forms.ListBox liczbasezonowBox;
        private System.Windows.Forms.ListBox czastrwaniaBox;
        private System.Windows.Forms.Button editSerialButton;
        private System.Windows.Forms.Button deleteSerialButton;
        private System.Windows.Forms.TextBox editSerialBox;
        private System.Windows.Forms.CheckBox editTytulCheck;
        private System.Windows.Forms.CheckBox editLiczbasezonowCheck;
        private System.Windows.Forms.CheckBox editCzastrwaniaCheck;
        private System.Windows.Forms.Button gatunekAddButton;
        private System.Windows.Forms.Button gatunekDeleteButton;
        private System.Windows.Forms.ComboBox gatunekCombo;
        private System.Windows.Forms.Label selectGatunekLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox studioCombo;
        private System.Windows.Forms.Label selectStudioLabel;
        private System.Windows.Forms.Button deleteStudioButton;
        private System.Windows.Forms.Button addStudioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button addGatunekButton;
        private System.Windows.Forms.Button addButtonStudio;
        private System.Windows.Forms.Button addCountryButton;
        private System.Windows.Forms.ListBox krajBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButtonCountry;
        private System.Windows.Forms.ComboBox KrajCombo;
        private System.Windows.Forms.Button deleteButtonCountry;
    }
}

