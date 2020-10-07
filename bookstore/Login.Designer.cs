namespace bookstore
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.prijavaLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailLoginTextBox = new System.Windows.Forms.TextBox();
            this.gesloLabel = new System.Windows.Forms.Label();
            this.gesloLoginTextBox = new System.Windows.Forms.TextBox();
            this.prijavaButton = new System.Windows.Forms.Button();
            this.registracijaLinkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licencaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bookworm.png");
            this.imageList1.Images.SetKeyName(1, "icons8-cancel-50.png");
            // 
            // prijavaLabel
            // 
            this.prijavaLabel.AutoSize = true;
            this.prijavaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prijavaLabel.Location = new System.Drawing.Point(172, 129);
            this.prijavaLabel.Name = "prijavaLabel";
            this.prijavaLabel.Size = new System.Drawing.Size(72, 24);
            this.prijavaLabel.TabIndex = 1;
            this.prijavaLabel.Text = "Prijava";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLabel.Location = new System.Drawing.Point(77, 180);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(62, 24);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email:";
            // 
            // emailLoginTextBox
            // 
            this.emailLoginTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLoginTextBox.Location = new System.Drawing.Point(176, 180);
            this.emailLoginTextBox.Multiline = true;
            this.emailLoginTextBox.Name = "emailLoginTextBox";
            this.emailLoginTextBox.Size = new System.Drawing.Size(198, 28);
            this.emailLoginTextBox.TabIndex = 3;
            // 
            // gesloLabel
            // 
            this.gesloLabel.AutoSize = true;
            this.gesloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gesloLabel.Location = new System.Drawing.Point(77, 233);
            this.gesloLabel.Name = "gesloLabel";
            this.gesloLabel.Size = new System.Drawing.Size(64, 24);
            this.gesloLabel.TabIndex = 6;
            this.gesloLabel.Text = "Geslo:";
            // 
            // gesloLoginTextBox
            // 
            this.gesloLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gesloLoginTextBox.Location = new System.Drawing.Point(176, 233);
            this.gesloLoginTextBox.Multiline = true;
            this.gesloLoginTextBox.Name = "gesloLoginTextBox";
            this.gesloLoginTextBox.PasswordChar = '*';
            this.gesloLoginTextBox.Size = new System.Drawing.Size(198, 28);
            this.gesloLoginTextBox.TabIndex = 5;
            // 
            // prijavaButton
            // 
            this.prijavaButton.BackColor = System.Drawing.Color.AliceBlue;
            this.prijavaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prijavaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prijavaButton.Location = new System.Drawing.Point(154, 353);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(119, 33);
            this.prijavaButton.TabIndex = 15;
            this.prijavaButton.Text = "Prijavi se";
            this.prijavaButton.UseVisualStyleBackColor = false;
            this.prijavaButton.Click += new System.EventHandler(this.prijavaButton_Click);
            // 
            // registracijaLinkButton
            // 
            this.registracijaLinkButton.BackColor = System.Drawing.Color.AliceBlue;
            this.registracijaLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registracijaLinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registracijaLinkButton.Location = new System.Drawing.Point(224, 290);
            this.registracijaLinkButton.Name = "registracijaLinkButton";
            this.registracijaLinkButton.Size = new System.Drawing.Size(119, 33);
            this.registracijaLinkButton.TabIndex = 16;
            this.registracijaLinkButton.Text = "Registracija";
            this.registracijaLinkButton.UseVisualStyleBackColor = false;
            this.registracijaLinkButton.Click += new System.EventHandler(this.registracijaLinkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(51, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Še nisi registiran?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bookstore.Properties.Resources.bookworm__1_;
            this.pictureBox1.Location = new System.Drawing.Point(176, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 69);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(81, 26);
            // 
            // yToolStripMenuItem
            // 
            this.yToolStripMenuItem.Name = "yToolStripMenuItem";
            this.yToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.yToolStripMenuItem.Text = "y";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacijeToolStripMenuItem,
            this.zapriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 27);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informacijeToolStripMenuItem
            // 
            this.informacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNasToolStripMenuItem,
            this.licencaToolStripMenuItem});
            this.informacijeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.informacijeToolStripMenuItem.Name = "informacijeToolStripMenuItem";
            this.informacijeToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.informacijeToolStripMenuItem.Text = "Informacije";
            // 
            // oNasToolStripMenuItem
            // 
            this.oNasToolStripMenuItem.Name = "oNasToolStripMenuItem";
            this.oNasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oNasToolStripMenuItem.Text = "O nas";
            this.oNasToolStripMenuItem.Click += new System.EventHandler(this.oNasToolStripMenuItem_Click);
            // 
            // licencaToolStripMenuItem
            // 
            this.licencaToolStripMenuItem.Name = "licencaToolStripMenuItem";
            this.licencaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registracijaLinkButton);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.gesloLabel);
            this.Controls.Add(this.gesloLoginTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailLoginTextBox);
            this.Controls.Add(this.prijavaLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "BookStore";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label prijavaLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailLoginTextBox;
        private System.Windows.Forms.Label gesloLabel;
        private System.Windows.Forms.TextBox gesloLoginTextBox;
        private System.Windows.Forms.Button prijavaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yToolStripMenuItem;
        public System.Windows.Forms.Button registracijaLinkButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licencaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapriToolStripMenuItem;
    }
}