namespace bookstore
{
    partial class AvtorPosodobi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvtorPosodobi));
            this.posodobiButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.priimekLabel = new System.Windows.Forms.Label();
            this.priimekTextBox = new System.Windows.Forms.TextBox();
            this.imeLabel = new System.Windows.Forms.Label();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prikaziButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainLinkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // posodobiButton
            // 
            this.posodobiButton.BackColor = System.Drawing.Color.AliceBlue;
            this.posodobiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.posodobiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.posodobiButton.Location = new System.Drawing.Point(211, 450);
            this.posodobiButton.Name = "posodobiButton";
            this.posodobiButton.Size = new System.Drawing.Size(119, 41);
            this.posodobiButton.TabIndex = 38;
            this.posodobiButton.Text = "Posodobi avtorja";
            this.posodobiButton.UseVisualStyleBackColor = false;
            this.posodobiButton.Click += new System.EventHandler(this.posodobiButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(64, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 4);
            this.panel1.TabIndex = 37;
            // 
            // priimekLabel
            // 
            this.priimekLabel.AutoSize = true;
            this.priimekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priimekLabel.Location = new System.Drawing.Point(138, 288);
            this.priimekLabel.Name = "priimekLabel";
            this.priimekLabel.Size = new System.Drawing.Size(77, 24);
            this.priimekLabel.TabIndex = 36;
            this.priimekLabel.Text = "Priimek:";
            // 
            // priimekTextBox
            // 
            this.priimekTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priimekTextBox.Location = new System.Drawing.Point(268, 284);
            this.priimekTextBox.Multiline = true;
            this.priimekTextBox.Name = "priimekTextBox";
            this.priimekTextBox.Size = new System.Drawing.Size(135, 28);
            this.priimekTextBox.TabIndex = 35;
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeLabel.Location = new System.Drawing.Point(138, 200);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(46, 24);
            this.imeLabel.TabIndex = 34;
            this.imeLabel.Text = "Ime:";
            // 
            // imeTextBox
            // 
            this.imeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeTextBox.Location = new System.Drawing.Point(268, 200);
            this.imeTextBox.Multiline = true;
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(135, 28);
            this.imeTextBox.TabIndex = 33;
            // 
            // prikaziButton
            // 
            this.prikaziButton.BackColor = System.Drawing.Color.AliceBlue;
            this.prikaziButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prikaziButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikaziButton.Location = new System.Drawing.Point(211, 103);
            this.prikaziButton.Name = "prikaziButton";
            this.prikaziButton.Size = new System.Drawing.Size(119, 43);
            this.prikaziButton.TabIndex = 54;
            this.prikaziButton.Text = "Prikazi podatke";
            this.prikaziButton.UseVisualStyleBackColor = false;
            this.prikaziButton.Click += new System.EventHandler(this.prikaziButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idLabel.Location = new System.Drawing.Point(127, 38);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(91, 24);
            this.idLabel.TabIndex = 53;
            this.idLabel.Text = "ID avtorja:";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idTextBox.Location = new System.Drawing.Point(256, 38);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(135, 28);
            this.idTextBox.TabIndex = 52;
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
            // AvtorPosodobi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(539, 557);
            this.Controls.Add(this.mainLinkButton);
            this.Controls.Add(this.prikaziButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.posodobiButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.priimekLabel);
            this.Controls.Add(this.priimekTextBox);
            this.Controls.Add(this.imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AvtorPosodobi";
            this.Text = "BookStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button posodobiButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label priimekLabel;
        private System.Windows.Forms.TextBox priimekTextBox;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.Button prikaziButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button mainLinkButton;
    }
}