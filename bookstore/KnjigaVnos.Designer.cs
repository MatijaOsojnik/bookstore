namespace bookstore
{
    partial class KnjigaVnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnjigaVnos));
            this.avtorLabel = new System.Windows.Forms.Label();
            this.registracijaButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zalozbaLabel = new System.Windows.Forms.Label();
            this.datumIzdajeLabel = new System.Windows.Forms.Label();
            this.straniLabel = new System.Windows.Forms.Label();
            this.straniTextBox = new System.Windows.Forms.TextBox();
            this.opisLabel = new System.Windows.Forms.Label();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.naslovLabel = new System.Windows.Forms.Label();
            this.naslovTextBox = new System.Windows.Forms.TextBox();
            this.avtorComboBox = new System.Windows.Forms.ComboBox();
            this.bookstoreUserDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookstoreUserData = new bookstore.bookstoreUserData();
            this.uporabnikiTableAdapter = new bookstore.bookstoreUserDataTableAdapters.uporabnikiTableAdapter();
            this.zalozbaComboBox = new System.Windows.Forms.ComboBox();
            this.datumIzdajeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainLinkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreUserDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreUserData)).BeginInit();
            this.SuspendLayout();
            // 
            // avtorLabel
            // 
            this.avtorLabel.AutoSize = true;
            this.avtorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.avtorLabel.Location = new System.Drawing.Point(116, 286);
            this.avtorLabel.Name = "avtorLabel";
            this.avtorLabel.Size = new System.Drawing.Size(58, 24);
            this.avtorLabel.TabIndex = 31;
            this.avtorLabel.Text = "Avtor:";
            // 
            // registracijaButton
            // 
            this.registracijaButton.BackColor = System.Drawing.Color.AliceBlue;
            this.registracijaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registracijaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registracijaButton.Location = new System.Drawing.Point(200, 402);
            this.registracijaButton.Name = "registracijaButton";
            this.registracijaButton.Size = new System.Drawing.Size(119, 41);
            this.registracijaButton.TabIndex = 30;
            this.registracijaButton.Text = "Dodaj knjigo";
            this.registracijaButton.UseVisualStyleBackColor = false;
            this.registracijaButton.Click += new System.EventHandler(this.registracijaButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(53, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 4);
            this.panel1.TabIndex = 29;
            // 
            // zalozbaLabel
            // 
            this.zalozbaLabel.AutoSize = true;
            this.zalozbaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zalozbaLabel.Location = new System.Drawing.Point(115, 329);
            this.zalozbaLabel.Name = "zalozbaLabel";
            this.zalozbaLabel.Size = new System.Drawing.Size(82, 24);
            this.zalozbaLabel.TabIndex = 28;
            this.zalozbaLabel.Text = "Zalozba:";
            // 
            // datumIzdajeLabel
            // 
            this.datumIzdajeLabel.AutoSize = true;
            this.datumIzdajeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumIzdajeLabel.Location = new System.Drawing.Point(116, 238);
            this.datumIzdajeLabel.Name = "datumIzdajeLabel";
            this.datumIzdajeLabel.Size = new System.Drawing.Size(123, 24);
            this.datumIzdajeLabel.TabIndex = 25;
            this.datumIzdajeLabel.Text = "Datum izdaje:";
            // 
            // straniLabel
            // 
            this.straniLabel.AutoSize = true;
            this.straniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.straniLabel.Location = new System.Drawing.Point(116, 193);
            this.straniLabel.Name = "straniLabel";
            this.straniLabel.Size = new System.Drawing.Size(119, 24);
            this.straniLabel.TabIndex = 23;
            this.straniLabel.Text = "Stevilo strani:";
            // 
            // straniTextBox
            // 
            this.straniTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.straniTextBox.Location = new System.Drawing.Point(246, 193);
            this.straniTextBox.Multiline = true;
            this.straniTextBox.Name = "straniTextBox";
            this.straniTextBox.Size = new System.Drawing.Size(135, 28);
            this.straniTextBox.TabIndex = 22;
            // 
            // opisLabel
            // 
            this.opisLabel.AutoSize = true;
            this.opisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisLabel.Location = new System.Drawing.Point(116, 71);
            this.opisLabel.Name = "opisLabel";
            this.opisLabel.Size = new System.Drawing.Size(54, 24);
            this.opisLabel.TabIndex = 21;
            this.opisLabel.Text = "Opis:";
            // 
            // opisTextBox
            // 
            this.opisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisTextBox.Location = new System.Drawing.Point(246, 71);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(217, 104);
            this.opisTextBox.TabIndex = 20;
            // 
            // naslovLabel
            // 
            this.naslovLabel.AutoSize = true;
            this.naslovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslovLabel.Location = new System.Drawing.Point(116, 28);
            this.naslovLabel.Name = "naslovLabel";
            this.naslovLabel.Size = new System.Drawing.Size(72, 24);
            this.naslovLabel.TabIndex = 19;
            this.naslovLabel.Text = "Naslov:";
            // 
            // naslovTextBox
            // 
            this.naslovTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslovTextBox.Location = new System.Drawing.Point(246, 28);
            this.naslovTextBox.Multiline = true;
            this.naslovTextBox.Name = "naslovTextBox";
            this.naslovTextBox.Size = new System.Drawing.Size(135, 28);
            this.naslovTextBox.TabIndex = 18;
            // 
            // avtorComboBox
            // 
            this.avtorComboBox.FormattingEnabled = true;
            this.avtorComboBox.Location = new System.Drawing.Point(246, 289);
            this.avtorComboBox.Name = "avtorComboBox";
            this.avtorComboBox.Size = new System.Drawing.Size(135, 21);
            this.avtorComboBox.TabIndex = 32;
            // 
            // bookstoreUserDataBindingSource
            // 
            this.bookstoreUserDataBindingSource.DataSource = this.bookstoreUserData;
            this.bookstoreUserDataBindingSource.Position = 0;
            // 
            // bookstoreUserData
            // 
            this.bookstoreUserData.DataSetName = "bookstoreUserData";
            this.bookstoreUserData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uporabnikiTableAdapter
            // 
            this.uporabnikiTableAdapter.ClearBeforeFill = true;
            // 
            // zalozbaComboBox
            // 
            this.zalozbaComboBox.FormattingEnabled = true;
            this.zalozbaComboBox.Location = new System.Drawing.Point(246, 332);
            this.zalozbaComboBox.Name = "zalozbaComboBox";
            this.zalozbaComboBox.Size = new System.Drawing.Size(135, 21);
            this.zalozbaComboBox.TabIndex = 33;
            // 
            // datumIzdajeDatePicker
            // 
            this.datumIzdajeDatePicker.CustomFormat = "yyyy-MM-dd";
            this.datumIzdajeDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumIzdajeDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datumIzdajeDatePicker.Location = new System.Drawing.Point(245, 242);
            this.datumIzdajeDatePicker.Name = "datumIzdajeDatePicker";
            this.datumIzdajeDatePicker.Size = new System.Drawing.Size(218, 26);
            this.datumIzdajeDatePicker.TabIndex = 34;
            this.datumIzdajeDatePicker.Value = new System.DateTime(2020, 2, 11, 0, 0, 0, 0);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-left-32.png");
            // 
            // mainLinkButton
            // 
            this.mainLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainLinkButton.ImageIndex = 0;
            this.mainLinkButton.ImageList = this.imageList1;
            this.mainLinkButton.Location = new System.Drawing.Point(12, 12);
            this.mainLinkButton.Name = "mainLinkButton";
            this.mainLinkButton.Size = new System.Drawing.Size(42, 40);
            this.mainLinkButton.TabIndex = 68;
            this.mainLinkButton.UseVisualStyleBackColor = true;
            this.mainLinkButton.Click += new System.EventHandler(this.mainLinkButton_Click);
            // 
            // KnjigaVnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(521, 463);
            this.Controls.Add(this.mainLinkButton);
            this.Controls.Add(this.datumIzdajeDatePicker);
            this.Controls.Add(this.zalozbaComboBox);
            this.Controls.Add(this.avtorComboBox);
            this.Controls.Add(this.avtorLabel);
            this.Controls.Add(this.registracijaButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zalozbaLabel);
            this.Controls.Add(this.datumIzdajeLabel);
            this.Controls.Add(this.straniLabel);
            this.Controls.Add(this.straniTextBox);
            this.Controls.Add(this.opisLabel);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(this.naslovLabel);
            this.Controls.Add(this.naslovTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KnjigaVnos";
            this.Text = "BookStore";
            this.Load += new System.EventHandler(this.adminInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreUserDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreUserData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label avtorLabel;
        private System.Windows.Forms.Button registracijaButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label zalozbaLabel;
        private System.Windows.Forms.Label datumIzdajeLabel;
        private System.Windows.Forms.Label straniLabel;
        private System.Windows.Forms.TextBox straniTextBox;
        private System.Windows.Forms.Label opisLabel;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.Label naslovLabel;
        private System.Windows.Forms.TextBox naslovTextBox;
        private System.Windows.Forms.ComboBox avtorComboBox;
        private System.Windows.Forms.BindingSource bookstoreUserDataBindingSource;
        private bookstoreUserData bookstoreUserData;
        private bookstoreUserDataTableAdapters.uporabnikiTableAdapter uporabnikiTableAdapter;
        private System.Windows.Forms.ComboBox zalozbaComboBox;
        private System.Windows.Forms.DateTimePicker datumIzdajeDatePicker;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button mainLinkButton;
    }
}