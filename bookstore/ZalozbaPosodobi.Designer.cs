namespace bookstore
{
    partial class ZalozbaPosodobi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZalozbaPosodobi));
            this.prikaziButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.posodobiButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.opisLabel = new System.Windows.Forms.Label();
            this.imeLabel = new System.Windows.Forms.Label();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.mainLinkButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // prikaziButton
            // 
            this.prikaziButton.BackColor = System.Drawing.Color.AliceBlue;
            this.prikaziButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prikaziButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikaziButton.Location = new System.Drawing.Point(210, 110);
            this.prikaziButton.Name = "prikaziButton";
            this.prikaziButton.Size = new System.Drawing.Size(119, 43);
            this.prikaziButton.TabIndex = 63;
            this.prikaziButton.Text = "Prikazi podatke";
            this.prikaziButton.UseVisualStyleBackColor = false;
            this.prikaziButton.Click += new System.EventHandler(this.prikaziButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idLabel.Location = new System.Drawing.Point(126, 45);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(102, 24);
            this.idLabel.TabIndex = 62;
            this.idLabel.Text = "ID založbe:";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idTextBox.Location = new System.Drawing.Point(255, 45);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(135, 28);
            this.idTextBox.TabIndex = 61;
            // 
            // posodobiButton
            // 
            this.posodobiButton.BackColor = System.Drawing.Color.AliceBlue;
            this.posodobiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.posodobiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.posodobiButton.Location = new System.Drawing.Point(210, 457);
            this.posodobiButton.Name = "posodobiButton";
            this.posodobiButton.Size = new System.Drawing.Size(119, 43);
            this.posodobiButton.TabIndex = 60;
            this.posodobiButton.Text = "Posodobi založbo";
            this.posodobiButton.UseVisualStyleBackColor = false;
            this.posodobiButton.Click += new System.EventHandler(this.posodobiButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(63, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 4);
            this.panel1.TabIndex = 59;
            // 
            // opisLabel
            // 
            this.opisLabel.AutoSize = true;
            this.opisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisLabel.Location = new System.Drawing.Point(137, 295);
            this.opisLabel.Name = "opisLabel";
            this.opisLabel.Size = new System.Drawing.Size(54, 24);
            this.opisLabel.TabIndex = 58;
            this.opisLabel.Text = "Opis:";
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeLabel.Location = new System.Drawing.Point(137, 207);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(46, 24);
            this.imeLabel.TabIndex = 56;
            this.imeLabel.Text = "Ime:";
            // 
            // imeTextBox
            // 
            this.imeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeTextBox.Location = new System.Drawing.Point(267, 207);
            this.imeTextBox.Multiline = true;
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(135, 28);
            this.imeTextBox.TabIndex = 55;
            // 
            // opisTextBox
            // 
            this.opisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisTextBox.Location = new System.Drawing.Point(267, 295);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(182, 95);
            this.opisTextBox.TabIndex = 64;
            // 
            // mainLinkButton
            // 
            this.mainLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainLinkButton.ImageIndex = 0;
            this.mainLinkButton.ImageList = this.imageList1;
            this.mainLinkButton.Location = new System.Drawing.Point(12, 12);
            this.mainLinkButton.Name = "mainLinkButton";
            this.mainLinkButton.Size = new System.Drawing.Size(42, 40);
            this.mainLinkButton.TabIndex = 65;
            this.mainLinkButton.UseVisualStyleBackColor = true;
            this.mainLinkButton.Click += new System.EventHandler(this.mainLinkButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-left-32.png");
            // 
            // ZalozbaPosodobi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(539, 557);
            this.Controls.Add(this.mainLinkButton);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(this.prikaziButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.posodobiButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.opisLabel);
            this.Controls.Add(this.imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZalozbaPosodobi";
            this.Text = "BookStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prikaziButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button posodobiButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label opisLabel;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.Button mainLinkButton;
        private System.Windows.Forms.ImageList imageList1;
    }
}