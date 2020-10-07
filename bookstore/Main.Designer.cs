namespace bookstore
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pozdravLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.bookstoreUserDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookstoreUserData = new bookstore.bookstoreUserData();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avtorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zalozbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uporabnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posodobiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigaUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avtorUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zalozbaUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uporabnikUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licencaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izpisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.izbiraComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.userIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreUserDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreUserData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pozdravLabel
            // 
            this.pozdravLabel.AutoSize = true;
            this.pozdravLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pozdravLabel.Location = new System.Drawing.Point(52, 51);
            this.pozdravLabel.Name = "pozdravLabel";
            this.pozdravLabel.Size = new System.Drawing.Size(82, 16);
            this.pozdravLabel.TabIndex = 1;
            this.pozdravLabel.Text = "Pozdravljen,";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userNameLabel.Location = new System.Drawing.Point(135, 51);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(71, 16);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Uporabnik";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(405, 277);
            this.dataGridViewMain.TabIndex = 3;
            this.dataGridViewMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellContentClick);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.posodobiToolStripMenuItem,
            this.informacijeToolStripMenuItem,
            this.zapriToolStripMenuItem,
            this.izpisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knjigaToolStripMenuItem,
            this.avtorToolStripMenuItem,
            this.zalozbaToolStripMenuItem,
            this.toolStripSeparator1,
            this.uporabnikToolStripMenuItem});
            this.novoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // knjigaToolStripMenuItem
            // 
            this.knjigaToolStripMenuItem.Name = "knjigaToolStripMenuItem";
            this.knjigaToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.knjigaToolStripMenuItem.Text = "&Knjiga";
            this.knjigaToolStripMenuItem.Click += new System.EventHandler(this.knjigaToolStripMenuItem_Click);
            // 
            // avtorToolStripMenuItem
            // 
            this.avtorToolStripMenuItem.Name = "avtorToolStripMenuItem";
            this.avtorToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.avtorToolStripMenuItem.Text = "&Avtor";
            this.avtorToolStripMenuItem.Click += new System.EventHandler(this.avtorToolStripMenuItem_Click);
            // 
            // zalozbaToolStripMenuItem
            // 
            this.zalozbaToolStripMenuItem.Name = "zalozbaToolStripMenuItem";
            this.zalozbaToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.zalozbaToolStripMenuItem.Text = "&Zalozba";
            this.zalozbaToolStripMenuItem.Click += new System.EventHandler(this.zalozbaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // uporabnikToolStripMenuItem
            // 
            this.uporabnikToolStripMenuItem.Name = "uporabnikToolStripMenuItem";
            this.uporabnikToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.uporabnikToolStripMenuItem.Text = "&Uporabnik";
            this.uporabnikToolStripMenuItem.Click += new System.EventHandler(this.uporabnikToolStripMenuItem_Click);
            // 
            // posodobiToolStripMenuItem
            // 
            this.posodobiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knjigaUpdateToolStripMenuItem,
            this.avtorUpdateToolStripMenuItem,
            this.zalozbaUpdateToolStripMenuItem,
            this.toolStripSeparator2,
            this.uporabnikUpdateToolStripMenuItem});
            this.posodobiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.posodobiToolStripMenuItem.Name = "posodobiToolStripMenuItem";
            this.posodobiToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.posodobiToolStripMenuItem.Text = "Posodobi";
            // 
            // knjigaUpdateToolStripMenuItem
            // 
            this.knjigaUpdateToolStripMenuItem.Name = "knjigaUpdateToolStripMenuItem";
            this.knjigaUpdateToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.knjigaUpdateToolStripMenuItem.Text = "&Knjiga";
            this.knjigaUpdateToolStripMenuItem.Click += new System.EventHandler(this.knjigaUpdateToolStripMenuItem_Click);
            // 
            // avtorUpdateToolStripMenuItem
            // 
            this.avtorUpdateToolStripMenuItem.Name = "avtorUpdateToolStripMenuItem";
            this.avtorUpdateToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.avtorUpdateToolStripMenuItem.Text = "&Avtor";
            this.avtorUpdateToolStripMenuItem.Click += new System.EventHandler(this.avtorUpdateToolStripMenuItem_Click);
            // 
            // zalozbaUpdateToolStripMenuItem
            // 
            this.zalozbaUpdateToolStripMenuItem.Name = "zalozbaUpdateToolStripMenuItem";
            this.zalozbaUpdateToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.zalozbaUpdateToolStripMenuItem.Text = "&Zalozba";
            this.zalozbaUpdateToolStripMenuItem.Click += new System.EventHandler(this.zalozbaUpdateToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // uporabnikUpdateToolStripMenuItem
            // 
            this.uporabnikUpdateToolStripMenuItem.Name = "uporabnikUpdateToolStripMenuItem";
            this.uporabnikUpdateToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.uporabnikUpdateToolStripMenuItem.Text = "&Uporabnik";
            this.uporabnikUpdateToolStripMenuItem.Click += new System.EventHandler(this.uporabnikUpdateToolStripMenuItem_Click);
            // 
            // informacijeToolStripMenuItem
            // 
            this.informacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNasToolStripMenuItem,
            this.licencaToolStripMenuItem});
            this.informacijeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.informacijeToolStripMenuItem.Name = "informacijeToolStripMenuItem";
            this.informacijeToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.informacijeToolStripMenuItem.Text = "Informacije";
            // 
            // oNasToolStripMenuItem
            // 
            this.oNasToolStripMenuItem.Name = "oNasToolStripMenuItem";
            this.oNasToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.oNasToolStripMenuItem.Text = "O nas";
            this.oNasToolStripMenuItem.Click += new System.EventHandler(this.oNasToolStripMenuItem_Click);
            // 
            // licencaToolStripMenuItem
            // 
            this.licencaToolStripMenuItem.Name = "licencaToolStripMenuItem";
            this.licencaToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.licencaToolStripMenuItem.Text = "Licenca";
            this.licencaToolStripMenuItem.Click += new System.EventHandler(this.licencaToolStripMenuItem_Click);
            // 
            // zapriToolStripMenuItem
            // 
            this.zapriToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.zapriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.zapriToolStripMenuItem.Name = "zapriToolStripMenuItem";
            this.zapriToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.zapriToolStripMenuItem.Text = "Zapri";
            this.zapriToolStripMenuItem.Click += new System.EventHandler(this.ZapriToolStripMenuItem_Click);
            // 
            // izpisToolStripMenuItem
            // 
            this.izpisToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.izpisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.izpisToolStripMenuItem.Name = "izpisToolStripMenuItem";
            this.izpisToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.izpisToolStripMenuItem.Text = "Izpis";
            this.izpisToolStripMenuItem.Click += new System.EventHandler(this.IzpisToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-cancel-50.png");
            this.imageList1.Images.SetKeyName(1, "icons8-delete-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-edit-50.png");
            this.imageList1.Images.SetKeyName(3, "icons8-find-user-male-50.png");
            this.imageList1.Images.SetKeyName(4, "icons8-ok-50.png");
            this.imageList1.Images.SetKeyName(5, "icons8-plus-50.png");
            this.imageList1.Images.SetKeyName(6, "icons8-refresh-50.png");
            this.imageList1.Images.SetKeyName(7, "icons8-search-50.png");
            // 
            // izbiraComboBox
            // 
            this.izbiraComboBox.BackColor = System.Drawing.Color.AliceBlue;
            this.izbiraComboBox.Items.AddRange(new object[] {
            "Uporabniki",
            "Knjige",
            "Avtorji",
            "Zalozbe"});
            this.izbiraComboBox.Location = new System.Drawing.Point(269, 110);
            this.izbiraComboBox.Name = "izbiraComboBox";
            this.izbiraComboBox.Size = new System.Drawing.Size(121, 21);
            this.izbiraComboBox.TabIndex = 10;
            this.izbiraComboBox.SelectedIndexChanged += new System.EventHandler(this.searchButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchButton.ImageIndex = 7;
            this.searchButton.ImageList = this.imageList1;
            this.searchButton.Location = new System.Drawing.Point(195, 99);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(40, 40);
            this.searchButton.TabIndex = 9;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteButton.ImageIndex = 1;
            this.deleteButton.ImageList = this.imageList1;
            this.deleteButton.Location = new System.Drawing.Point(132, 99);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(40, 40);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.editButton.ImageIndex = 2;
            this.editButton.ImageList = this.imageList1;
            this.editButton.Location = new System.Drawing.Point(71, 99);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(40, 40);
            this.editButton.TabIndex = 7;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addButton.ImageIndex = 5;
            this.addButton.ImageList = this.imageList1;
            this.addButton.Location = new System.Drawing.Point(12, 99);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(40, 40);
            this.addButton.TabIndex = 4;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // userIcon
            // 
            this.userIcon.Image = ((System.Drawing.Image)(resources.GetObject("userIcon.Image")));
            this.userIcon.Location = new System.Drawing.Point(12, 41);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(34, 36);
            this.userIcon.TabIndex = 0;
            this.userIcon.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.izbiraComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.pozdravLabel);
            this.Controls.Add(this.userIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "BookStore";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreUserDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreUserData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.Label pozdravLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.BindingSource bookstoreUserDataBindingSource;
        private bookstoreUserData bookstoreUserData;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avtorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zalozbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem posodobiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigaUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avtorUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zalozbaUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacijeToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox izbiraComboBox;
        private System.Windows.Forms.ToolStripMenuItem oNasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uporabnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem uporabnikUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izpisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licencaToolStripMenuItem;
    }
}