namespace bookstore
{
    partial class ZbirkaPosodobi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZbirkaPosodobi));
            this.posodobiButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainLinkButton = new System.Windows.Forms.Button();
            this.opisLabel = new System.Windows.Forms.Label();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.imeLabel = new System.Windows.Forms.Label();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // posodobiButton
            // 
            this.posodobiButton.BackColor = System.Drawing.Color.AliceBlue;
            this.posodobiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.posodobiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.posodobiButton.Location = new System.Drawing.Point(123, 303);
            this.posodobiButton.Name = "posodobiButton";
            this.posodobiButton.Size = new System.Drawing.Size(119, 41);
            this.posodobiButton.TabIndex = 74;
            this.posodobiButton.Text = "Posodobi zbirko";
            this.posodobiButton.UseVisualStyleBackColor = false;
            this.posodobiButton.Click += new System.EventHandler(this.posodobiButton_Click);
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
            this.mainLinkButton.TabIndex = 73;
            this.mainLinkButton.UseVisualStyleBackColor = true;
            this.mainLinkButton.Click += new System.EventHandler(this.mainLinkButton_Click);
            // 
            // opisLabel
            // 
            this.opisLabel.AutoSize = true;
            this.opisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisLabel.Location = new System.Drawing.Point(42, 152);
            this.opisLabel.Name = "opisLabel";
            this.opisLabel.Size = new System.Drawing.Size(54, 24);
            this.opisLabel.TabIndex = 78;
            this.opisLabel.Text = "Opis:";
            // 
            // opisTextBox
            // 
            this.opisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisTextBox.Location = new System.Drawing.Point(161, 152);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(162, 104);
            this.opisTextBox.TabIndex = 77;
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeLabel.Location = new System.Drawing.Point(42, 80);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(101, 24);
            this.imeLabel.TabIndex = 76;
            this.imeLabel.Text = "Ime zbirke:";
            // 
            // imeTextBox
            // 
            this.imeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeTextBox.Location = new System.Drawing.Point(161, 80);
            this.imeTextBox.Multiline = true;
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(162, 28);
            this.imeTextBox.TabIndex = 75;
            // 
            // ZbirkaPosodobi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(358, 378);
            this.Controls.Add(this.opisLabel);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(this.imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.posodobiButton);
            this.Controls.Add(this.mainLinkButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZbirkaPosodobi";
            this.Text = "BookStore";
            this.Load += new System.EventHandler(this.ZbirkaPosodobi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button posodobiButton;
        private System.Windows.Forms.Button mainLinkButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label opisLabel;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.TextBox imeTextBox;
    }
}