namespace bookstore
{
    partial class MainUporabnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUporabnik));
            this.pozdravLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zbirkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licencaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izpisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.zbirkeGroupBox = new System.Windows.Forms.GroupBox();
            this.zbirkeListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.biografijaAvtor = new System.Windows.Forms.Label();
            this.biografijaNaslov = new System.Windows.Forms.Label();
            this.scifiAvtor = new System.Windows.Forms.Label();
            this.scifiNaslov = new System.Windows.Forms.Label();
            this.kriminalkaAvtor = new System.Windows.Forms.Label();
            this.kriminalkaNaslov = new System.Windows.Forms.Label();
            this.romanAvtor = new System.Windows.Forms.Label();
            this.romanNaslov = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scifiLabel = new System.Windows.Forms.Label();
            this.kriminalkeLabel = new System.Windows.Forms.Label();
            this.romaniLabel = new System.Windows.Forms.Label();
            this.knjigaMesecaGroupBox = new System.Windows.Forms.GroupBox();
            this.knjigaMesecaAvtor = new System.Windows.Forms.Label();
            this.knjigaMesecaNaslov = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchZbirkeButton = new System.Windows.Forms.Button();
            this.deleteZbirkoButton = new System.Windows.Forms.Button();
            this.editZbirkoButton = new System.Windows.Forms.Button();
            this.dodajZbirkoButton = new System.Windows.Forms.Button();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.drzaveTableAdapter1 = new bookstore.bookstoreUserDataTableAdapters.drzaveTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.zbirkeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.knjigaMesecaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pozdravLabel
            // 
            this.pozdravLabel.AutoSize = true;
            this.pozdravLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pozdravLabel.Location = new System.Drawing.Point(52, 52);
            this.pozdravLabel.Name = "pozdravLabel";
            this.pozdravLabel.Size = new System.Drawing.Size(82, 16);
            this.pozdravLabel.TabIndex = 6;
            this.pozdravLabel.Text = "Pozdravljen,";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userNameLabel.Location = new System.Drawing.Point(135, 52);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(71, 16);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "Uporabnik";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.informacijeToolStripMenuItem,
            this.zapriToolStripMenuItem,
            this.izpisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 27);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zbirkaToolStripMenuItem,
            this.urediToolStripMenuItem});
            this.dodajToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.dodajToolStripMenuItem.Text = "&Zbirka";
            // 
            // zbirkaToolStripMenuItem
            // 
            this.zbirkaToolStripMenuItem.Name = "zbirkaToolStripMenuItem";
            this.zbirkaToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.zbirkaToolStripMenuItem.Text = "&Novo";
            this.zbirkaToolStripMenuItem.Click += new System.EventHandler(this.zbirkaToolStripMenuItem_Click);
            // 
            // urediToolStripMenuItem
            // 
            this.urediToolStripMenuItem.Name = "urediToolStripMenuItem";
            this.urediToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.urediToolStripMenuItem.Text = "&Uredi";
            this.urediToolStripMenuItem.Click += new System.EventHandler(this.urediToolStripMenuItem_Click);
            // 
            // informacijeToolStripMenuItem
            // 
            this.informacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNasToolStripMenuItem,
            this.licencaToolStripMenuItem});
            this.informacijeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.informacijeToolStripMenuItem.Name = "informacijeToolStripMenuItem";
            this.informacijeToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.informacijeToolStripMenuItem.Text = "Informacije";
            // 
            // oNasToolStripMenuItem
            // 
            this.oNasToolStripMenuItem.Name = "oNasToolStripMenuItem";
            this.oNasToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.oNasToolStripMenuItem.Text = "O nas";
            this.oNasToolStripMenuItem.Click += new System.EventHandler(this.oNasToolStripMenuItem_Click);
            // 
            // licencaToolStripMenuItem
            // 
            this.licencaToolStripMenuItem.Name = "licencaToolStripMenuItem";
            this.licencaToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
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
            this.zapriToolStripMenuItem.Click += new System.EventHandler(this.zapriToolStripMenuItem_Click);
            // 
            // izpisToolStripMenuItem
            // 
            this.izpisToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.izpisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.izpisToolStripMenuItem.Name = "izpisToolStripMenuItem";
            this.izpisToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.izpisToolStripMenuItem.Text = "Izpis";
            this.izpisToolStripMenuItem.Click += new System.EventHandler(this.izpisToolStripMenuItem_Click);
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
            this.imageList1.Images.SetKeyName(8, "topKnjiga.jpg");
            // 
            // zbirkeGroupBox
            // 
            this.zbirkeGroupBox.Controls.Add(this.zbirkeListBox);
            this.zbirkeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zbirkeGroupBox.Location = new System.Drawing.Point(213, 96);
            this.zbirkeGroupBox.Name = "zbirkeGroupBox";
            this.zbirkeGroupBox.Size = new System.Drawing.Size(204, 181);
            this.zbirkeGroupBox.TabIndex = 15;
            this.zbirkeGroupBox.TabStop = false;
            this.zbirkeGroupBox.Text = "Tvoje zbirke";
            // 
            // zbirkeListBox
            // 
            this.zbirkeListBox.AccessibleName = "";
            this.zbirkeListBox.BackColor = System.Drawing.Color.FloralWhite;
            this.zbirkeListBox.FormattingEnabled = true;
            this.zbirkeListBox.Location = new System.Drawing.Point(6, 19);
            this.zbirkeListBox.Name = "zbirkeListBox";
            this.zbirkeListBox.Size = new System.Drawing.Size(192, 147);
            this.zbirkeListBox.TabIndex = 0;
            this.zbirkeListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.zbirkeListBox_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.biografijaAvtor);
            this.groupBox1.Controls.Add(this.biografijaNaslov);
            this.groupBox1.Controls.Add(this.scifiAvtor);
            this.groupBox1.Controls.Add(this.scifiNaslov);
            this.groupBox1.Controls.Add(this.kriminalkaAvtor);
            this.groupBox1.Controls.Add(this.kriminalkaNaslov);
            this.groupBox1.Controls.Add(this.romanAvtor);
            this.groupBox1.Controls.Add(this.romanNaslov);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.scifiLabel);
            this.groupBox1.Controls.Add(this.kriminalkeLabel);
            this.groupBox1.Controls.Add(this.romaniLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(3, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 342);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Priljubljeno";
            // 
            // biografijaAvtor
            // 
            this.biografijaAvtor.AutoSize = true;
            this.biografijaAvtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.biografijaAvtor.ForeColor = System.Drawing.Color.Azure;
            this.biografijaAvtor.Location = new System.Drawing.Point(9, 308);
            this.biografijaAvtor.Name = "biografijaAvtor";
            this.biografijaAvtor.Size = new System.Drawing.Size(44, 16);
            this.biografijaAvtor.TabIndex = 11;
            this.biografijaAvtor.Text = "Avtor";
            // 
            // biografijaNaslov
            // 
            this.biografijaNaslov.AutoSize = true;
            this.biografijaNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.biografijaNaslov.ForeColor = System.Drawing.Color.Azure;
            this.biografijaNaslov.Location = new System.Drawing.Point(9, 282);
            this.biografijaNaslov.Name = "biografijaNaslov";
            this.biografijaNaslov.Size = new System.Drawing.Size(57, 16);
            this.biografijaNaslov.TabIndex = 10;
            this.biografijaNaslov.Text = "Naslov";
            // 
            // scifiAvtor
            // 
            this.scifiAvtor.AutoSize = true;
            this.scifiAvtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scifiAvtor.ForeColor = System.Drawing.Color.Azure;
            this.scifiAvtor.Location = new System.Drawing.Point(9, 228);
            this.scifiAvtor.Name = "scifiAvtor";
            this.scifiAvtor.Size = new System.Drawing.Size(44, 16);
            this.scifiAvtor.TabIndex = 9;
            this.scifiAvtor.Text = "Avtor";
            // 
            // scifiNaslov
            // 
            this.scifiNaslov.AutoSize = true;
            this.scifiNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scifiNaslov.ForeColor = System.Drawing.Color.Azure;
            this.scifiNaslov.Location = new System.Drawing.Point(9, 202);
            this.scifiNaslov.Name = "scifiNaslov";
            this.scifiNaslov.Size = new System.Drawing.Size(57, 16);
            this.scifiNaslov.TabIndex = 8;
            this.scifiNaslov.Text = "Naslov";
            // 
            // kriminalkaAvtor
            // 
            this.kriminalkaAvtor.AutoSize = true;
            this.kriminalkaAvtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kriminalkaAvtor.ForeColor = System.Drawing.Color.Azure;
            this.kriminalkaAvtor.Location = new System.Drawing.Point(9, 147);
            this.kriminalkaAvtor.Name = "kriminalkaAvtor";
            this.kriminalkaAvtor.Size = new System.Drawing.Size(44, 16);
            this.kriminalkaAvtor.TabIndex = 7;
            this.kriminalkaAvtor.Text = "Avtor";
            // 
            // kriminalkaNaslov
            // 
            this.kriminalkaNaslov.AutoSize = true;
            this.kriminalkaNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kriminalkaNaslov.ForeColor = System.Drawing.Color.Azure;
            this.kriminalkaNaslov.Location = new System.Drawing.Point(9, 121);
            this.kriminalkaNaslov.Name = "kriminalkaNaslov";
            this.kriminalkaNaslov.Size = new System.Drawing.Size(57, 16);
            this.kriminalkaNaslov.TabIndex = 6;
            this.kriminalkaNaslov.Text = "Naslov";
            // 
            // romanAvtor
            // 
            this.romanAvtor.AutoSize = true;
            this.romanAvtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.romanAvtor.ForeColor = System.Drawing.Color.Azure;
            this.romanAvtor.Location = new System.Drawing.Point(9, 73);
            this.romanAvtor.Name = "romanAvtor";
            this.romanAvtor.Size = new System.Drawing.Size(44, 16);
            this.romanAvtor.TabIndex = 5;
            this.romanAvtor.Text = "Avtor";
            // 
            // romanNaslov
            // 
            this.romanNaslov.AutoSize = true;
            this.romanNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.romanNaslov.ForeColor = System.Drawing.Color.Azure;
            this.romanNaslov.Location = new System.Drawing.Point(9, 47);
            this.romanNaslov.Name = "romanNaslov";
            this.romanNaslov.Size = new System.Drawing.Size(57, 16);
            this.romanNaslov.TabIndex = 4;
            this.romanNaslov.Text = "Naslov";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(76, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Romani";
            // 
            // scifiLabel
            // 
            this.scifiLabel.AutoSize = true;
            this.scifiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scifiLabel.Location = new System.Drawing.Point(80, 172);
            this.scifiLabel.Name = "scifiLabel";
            this.scifiLabel.Size = new System.Drawing.Size(48, 15);
            this.scifiLabel.TabIndex = 2;
            this.scifiLabel.Text = "Sci-Fi ";
            // 
            // kriminalkeLabel
            // 
            this.kriminalkeLabel.AutoSize = true;
            this.kriminalkeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kriminalkeLabel.Location = new System.Drawing.Point(66, 94);
            this.kriminalkeLabel.Name = "kriminalkeLabel";
            this.kriminalkeLabel.Size = new System.Drawing.Size(76, 15);
            this.kriminalkeLabel.TabIndex = 1;
            this.kriminalkeLabel.Text = "Kriminalke";
            // 
            // romaniLabel
            // 
            this.romaniLabel.AutoSize = true;
            this.romaniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.romaniLabel.Location = new System.Drawing.Point(76, 19);
            this.romaniLabel.Name = "romaniLabel";
            this.romaniLabel.Size = new System.Drawing.Size(57, 15);
            this.romaniLabel.TabIndex = 0;
            this.romaniLabel.Text = "Romani";
            // 
            // knjigaMesecaGroupBox
            // 
            this.knjigaMesecaGroupBox.Controls.Add(this.knjigaMesecaAvtor);
            this.knjigaMesecaGroupBox.Controls.Add(this.knjigaMesecaNaslov);
            this.knjigaMesecaGroupBox.Controls.Add(this.pictureBox1);
            this.knjigaMesecaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.knjigaMesecaGroupBox.Location = new System.Drawing.Point(219, 330);
            this.knjigaMesecaGroupBox.Name = "knjigaMesecaGroupBox";
            this.knjigaMesecaGroupBox.Size = new System.Drawing.Size(200, 108);
            this.knjigaMesecaGroupBox.TabIndex = 16;
            this.knjigaMesecaGroupBox.TabStop = false;
            this.knjigaMesecaGroupBox.Text = "Knjiga Meseca";
            // 
            // knjigaMesecaAvtor
            // 
            this.knjigaMesecaAvtor.AutoSize = true;
            this.knjigaMesecaAvtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.knjigaMesecaAvtor.ForeColor = System.Drawing.Color.Azure;
            this.knjigaMesecaAvtor.Location = new System.Drawing.Point(87, 61);
            this.knjigaMesecaAvtor.Name = "knjigaMesecaAvtor";
            this.knjigaMesecaAvtor.Size = new System.Drawing.Size(44, 16);
            this.knjigaMesecaAvtor.TabIndex = 12;
            this.knjigaMesecaAvtor.Text = "Avtor";
            // 
            // knjigaMesecaNaslov
            // 
            this.knjigaMesecaNaslov.AutoSize = true;
            this.knjigaMesecaNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.knjigaMesecaNaslov.ForeColor = System.Drawing.Color.Azure;
            this.knjigaMesecaNaslov.Location = new System.Drawing.Point(87, 31);
            this.knjigaMesecaNaslov.Name = "knjigaMesecaNaslov";
            this.knjigaMesecaNaslov.Size = new System.Drawing.Size(57, 16);
            this.knjigaMesecaNaslov.TabIndex = 12;
            this.knjigaMesecaNaslov.Text = "Naslov";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // searchZbirkeButton
            // 
            this.searchZbirkeButton.BackColor = System.Drawing.Color.Transparent;
            this.searchZbirkeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchZbirkeButton.ImageIndex = 7;
            this.searchZbirkeButton.ImageList = this.imageList1;
            this.searchZbirkeButton.Location = new System.Drawing.Point(377, 283);
            this.searchZbirkeButton.Name = "searchZbirkeButton";
            this.searchZbirkeButton.Size = new System.Drawing.Size(40, 40);
            this.searchZbirkeButton.TabIndex = 12;
            this.searchZbirkeButton.UseVisualStyleBackColor = false;
            this.searchZbirkeButton.Click += new System.EventHandler(this.searchZbirkeButton_Click);
            // 
            // deleteZbirkoButton
            // 
            this.deleteZbirkoButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteZbirkoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteZbirkoButton.ImageIndex = 1;
            this.deleteZbirkoButton.ImageList = this.imageList1;
            this.deleteZbirkoButton.Location = new System.Drawing.Point(323, 283);
            this.deleteZbirkoButton.Name = "deleteZbirkoButton";
            this.deleteZbirkoButton.Size = new System.Drawing.Size(40, 40);
            this.deleteZbirkoButton.TabIndex = 11;
            this.deleteZbirkoButton.UseVisualStyleBackColor = false;
            this.deleteZbirkoButton.Click += new System.EventHandler(this.deleteZbirkoButton_Click);
            // 
            // editZbirkoButton
            // 
            this.editZbirkoButton.BackColor = System.Drawing.Color.Transparent;
            this.editZbirkoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.editZbirkoButton.ImageIndex = 2;
            this.editZbirkoButton.ImageList = this.imageList1;
            this.editZbirkoButton.Location = new System.Drawing.Point(268, 283);
            this.editZbirkoButton.Name = "editZbirkoButton";
            this.editZbirkoButton.Size = new System.Drawing.Size(40, 40);
            this.editZbirkoButton.TabIndex = 10;
            this.editZbirkoButton.UseVisualStyleBackColor = false;
            this.editZbirkoButton.Click += new System.EventHandler(this.editZbirkoButton_Click);
            // 
            // dodajZbirkoButton
            // 
            this.dodajZbirkoButton.ImageIndex = 5;
            this.dodajZbirkoButton.ImageList = this.imageList1;
            this.dodajZbirkoButton.Location = new System.Drawing.Point(213, 283);
            this.dodajZbirkoButton.Name = "dodajZbirkoButton";
            this.dodajZbirkoButton.Size = new System.Drawing.Size(40, 40);
            this.dodajZbirkoButton.TabIndex = 9;
            this.dodajZbirkoButton.UseVisualStyleBackColor = true;
            this.dodajZbirkoButton.Click += new System.EventHandler(this.dodajZbirkoButton_Click);
            // 
            // userIcon
            // 
            this.userIcon.Image = ((System.Drawing.Image)(resources.GetObject("userIcon.Image")));
            this.userIcon.Location = new System.Drawing.Point(12, 43);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(34, 35);
            this.userIcon.TabIndex = 3;
            this.userIcon.TabStop = false;
            // 
            // drzaveTableAdapter1
            // 
            this.drzaveTableAdapter1.ClearBeforeFill = true;
            // 
            // MainUporabnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.knjigaMesecaGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchZbirkeButton);
            this.Controls.Add(this.deleteZbirkoButton);
            this.Controls.Add(this.editZbirkoButton);
            this.Controls.Add(this.zbirkeGroupBox);
            this.Controls.Add(this.dodajZbirkoButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.pozdravLabel);
            this.Controls.Add(this.userIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUporabnik";
            this.Text = "BookStore";
            this.Load += new System.EventHandler(this.MainUporabnik_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.zbirkeGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.knjigaMesecaGroupBox.ResumeLayout(false);
            this.knjigaMesecaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.Label pozdravLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zbirkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izpisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem;
        private System.Windows.Forms.Button dodajZbirkoButton;
        private System.Windows.Forms.GroupBox zbirkeGroupBox;
        private System.Windows.Forms.ListBox zbirkeListBox;
        private System.Windows.Forms.ToolStripMenuItem licencaToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button editZbirkoButton;
        private System.Windows.Forms.Button deleteZbirkoButton;
        private System.Windows.Forms.Button searchZbirkeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label scifiLabel;
        private System.Windows.Forms.Label kriminalkeLabel;
        private System.Windows.Forms.Label romaniLabel;
        private System.Windows.Forms.Label biografijaAvtor;
        private System.Windows.Forms.Label biografijaNaslov;
        private System.Windows.Forms.Label scifiAvtor;
        private System.Windows.Forms.Label scifiNaslov;
        private System.Windows.Forms.Label kriminalkaAvtor;
        private System.Windows.Forms.Label kriminalkaNaslov;
        private System.Windows.Forms.Label romanAvtor;
        private System.Windows.Forms.Label romanNaslov;
        private System.Windows.Forms.GroupBox knjigaMesecaGroupBox;
        private System.Windows.Forms.Label knjigaMesecaAvtor;
        private System.Windows.Forms.Label knjigaMesecaNaslov;
        private System.Windows.Forms.PictureBox pictureBox1;
        private bookstoreUserDataTableAdapters.drzaveTableAdapter drzaveTableAdapter1;
    }
}