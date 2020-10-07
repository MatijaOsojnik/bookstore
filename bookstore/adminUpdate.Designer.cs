namespace bookstore
{
    partial class adminUpdate
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
            this.datumIzdajeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.zalozbaComboBox = new System.Windows.Forms.ComboBox();
            this.avtorComboBox = new System.Windows.Forms.ComboBox();
            this.avtorLabel = new System.Windows.Forms.Label();
            this.posodobitevButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zalozbaLabel = new System.Windows.Forms.Label();
            this.datumIzdajeLabel = new System.Windows.Forms.Label();
            this.straniLabel = new System.Windows.Forms.Label();
            this.straniTextBox = new System.Windows.Forms.TextBox();
            this.opisLabel = new System.Windows.Forms.Label();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.naslovLabel = new System.Windows.Forms.Label();
            this.naslovTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.prikaziGumb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datumIzdajeDatePicker
            // 
            this.datumIzdajeDatePicker.CustomFormat = "yyyy-MM-dd";
            this.datumIzdajeDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumIzdajeDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datumIzdajeDatePicker.Location = new System.Drawing.Point(253, 334);
            this.datumIzdajeDatePicker.Name = "datumIzdajeDatePicker";
            this.datumIzdajeDatePicker.Size = new System.Drawing.Size(218, 26);
            this.datumIzdajeDatePicker.TabIndex = 48;
            this.datumIzdajeDatePicker.Value = new System.DateTime(2020, 2, 11, 0, 0, 0, 0);
            // 
            // zalozbaComboBox
            // 
            this.zalozbaComboBox.FormattingEnabled = true;
            this.zalozbaComboBox.Location = new System.Drawing.Point(254, 424);
            this.zalozbaComboBox.Name = "zalozbaComboBox";
            this.zalozbaComboBox.Size = new System.Drawing.Size(135, 21);
            this.zalozbaComboBox.TabIndex = 47;
            // 
            // avtorComboBox
            // 
            this.avtorComboBox.FormattingEnabled = true;
            this.avtorComboBox.Location = new System.Drawing.Point(254, 381);
            this.avtorComboBox.Name = "avtorComboBox";
            this.avtorComboBox.Size = new System.Drawing.Size(135, 21);
            this.avtorComboBox.TabIndex = 46;
            // 
            // avtorLabel
            // 
            this.avtorLabel.AutoSize = true;
            this.avtorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.avtorLabel.Location = new System.Drawing.Point(124, 378);
            this.avtorLabel.Name = "avtorLabel";
            this.avtorLabel.Size = new System.Drawing.Size(58, 24);
            this.avtorLabel.TabIndex = 45;
            this.avtorLabel.Text = "Avtor:";
            // 
            // posodobitevButton
            // 
            this.posodobitevButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.posodobitevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.posodobitevButton.Location = new System.Drawing.Point(208, 494);
            this.posodobitevButton.Name = "posodobitevButton";
            this.posodobitevButton.Size = new System.Drawing.Size(119, 41);
            this.posodobitevButton.TabIndex = 44;
            this.posodobitevButton.Text = "Posodobi knjigo";
            this.posodobitevButton.UseVisualStyleBackColor = false;
            this.posodobitevButton.Click += new System.EventHandler(this.posodobitevButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(61, 475);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 4);
            this.panel1.TabIndex = 43;
            // 
            // zalozbaLabel
            // 
            this.zalozbaLabel.AutoSize = true;
            this.zalozbaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zalozbaLabel.Location = new System.Drawing.Point(123, 421);
            this.zalozbaLabel.Name = "zalozbaLabel";
            this.zalozbaLabel.Size = new System.Drawing.Size(82, 24);
            this.zalozbaLabel.TabIndex = 42;
            this.zalozbaLabel.Text = "Zalozba:";
            // 
            // datumIzdajeLabel
            // 
            this.datumIzdajeLabel.AutoSize = true;
            this.datumIzdajeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumIzdajeLabel.Location = new System.Drawing.Point(124, 330);
            this.datumIzdajeLabel.Name = "datumIzdajeLabel";
            this.datumIzdajeLabel.Size = new System.Drawing.Size(123, 24);
            this.datumIzdajeLabel.TabIndex = 41;
            this.datumIzdajeLabel.Text = "Datum izdaje:";
            // 
            // straniLabel
            // 
            this.straniLabel.AutoSize = true;
            this.straniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.straniLabel.Location = new System.Drawing.Point(124, 285);
            this.straniLabel.Name = "straniLabel";
            this.straniLabel.Size = new System.Drawing.Size(119, 24);
            this.straniLabel.TabIndex = 40;
            this.straniLabel.Text = "Stevilo strani:";
            // 
            // straniTextBox
            // 
            this.straniTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.straniTextBox.Location = new System.Drawing.Point(254, 285);
            this.straniTextBox.Multiline = true;
            this.straniTextBox.Name = "straniTextBox";
            this.straniTextBox.Size = new System.Drawing.Size(135, 28);
            this.straniTextBox.TabIndex = 39;
            // 
            // opisLabel
            // 
            this.opisLabel.AutoSize = true;
            this.opisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisLabel.Location = new System.Drawing.Point(123, 189);
            this.opisLabel.Name = "opisLabel";
            this.opisLabel.Size = new System.Drawing.Size(54, 24);
            this.opisLabel.TabIndex = 38;
            this.opisLabel.Text = "Opis:";
            // 
            // opisTextBox
            // 
            this.opisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisTextBox.Location = new System.Drawing.Point(253, 189);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(217, 77);
            this.opisTextBox.TabIndex = 37;
            // 
            // naslovLabel
            // 
            this.naslovLabel.AutoSize = true;
            this.naslovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslovLabel.Location = new System.Drawing.Point(124, 144);
            this.naslovLabel.Name = "naslovLabel";
            this.naslovLabel.Size = new System.Drawing.Size(72, 24);
            this.naslovLabel.TabIndex = 36;
            this.naslovLabel.Text = "Naslov:";
            // 
            // naslovTextBox
            // 
            this.naslovTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslovTextBox.Location = new System.Drawing.Point(253, 144);
            this.naslovTextBox.Multiline = true;
            this.naslovTextBox.Name = "naslovTextBox";
            this.naslovTextBox.Size = new System.Drawing.Size(135, 28);
            this.naslovTextBox.TabIndex = 35;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idLabel.Location = new System.Drawing.Point(124, 12);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(87, 24);
            this.idLabel.TabIndex = 50;
            this.idLabel.Text = "ID knjige:";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idTextBox.Location = new System.Drawing.Point(253, 12);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(135, 28);
            this.idTextBox.TabIndex = 49;
            // 
            // prikaziGumb
            // 
            this.prikaziGumb.BackColor = System.Drawing.Color.CornflowerBlue;
            this.prikaziGumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikaziGumb.Location = new System.Drawing.Point(208, 68);
            this.prikaziGumb.Name = "prikaziGumb";
            this.prikaziGumb.Size = new System.Drawing.Size(119, 43);
            this.prikaziGumb.TabIndex = 51;
            this.prikaziGumb.Text = "Prikazi podatke";
            this.prikaziGumb.UseVisualStyleBackColor = false;
            this.prikaziGumb.Click += new System.EventHandler(this.prikaziGumb_Click);
            // 
            // adminUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 557);
            this.Controls.Add(this.prikaziGumb);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.datumIzdajeDatePicker);
            this.Controls.Add(this.zalozbaComboBox);
            this.Controls.Add(this.avtorComboBox);
            this.Controls.Add(this.avtorLabel);
            this.Controls.Add(this.posodobitevButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zalozbaLabel);
            this.Controls.Add(this.datumIzdajeLabel);
            this.Controls.Add(this.straniLabel);
            this.Controls.Add(this.straniTextBox);
            this.Controls.Add(this.opisLabel);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(this.naslovLabel);
            this.Controls.Add(this.naslovTextBox);
            this.Name = "adminUpdate";
            this.Text = "adminUpdate";
            this.Load += new System.EventHandler(this.adminUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datumIzdajeDatePicker;
        private System.Windows.Forms.ComboBox zalozbaComboBox;
        private System.Windows.Forms.ComboBox avtorComboBox;
        private System.Windows.Forms.Label avtorLabel;
        private System.Windows.Forms.Button posodobitevButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label zalozbaLabel;
        private System.Windows.Forms.Label datumIzdajeLabel;
        private System.Windows.Forms.Label straniLabel;
        private System.Windows.Forms.TextBox straniTextBox;
        private System.Windows.Forms.Label opisLabel;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.Label naslovLabel;
        private System.Windows.Forms.TextBox naslovTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button prikaziGumb;
    }
}