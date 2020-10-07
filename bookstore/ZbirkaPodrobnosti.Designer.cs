namespace bookstore
{
    partial class ZbirkaPodrobnosti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZbirkaPodrobnosti));
            this.zbirkaImeLabel = new System.Windows.Forms.Label();
            this.zbirkaDataGridView = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainLinkButton = new System.Windows.Forms.Button();
            this.knjigeGroupBox = new System.Windows.Forms.GroupBox();
            this.knjigeListBox = new System.Windows.Forms.ListBox();
            this.dodajZbirkoButton = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zbirkaDataGridView)).BeginInit();
            this.knjigeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // zbirkaImeLabel
            // 
            this.zbirkaImeLabel.AutoSize = true;
            this.zbirkaImeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zbirkaImeLabel.Location = new System.Drawing.Point(266, 19);
            this.zbirkaImeLabel.Name = "zbirkaImeLabel";
            this.zbirkaImeLabel.Size = new System.Drawing.Size(106, 24);
            this.zbirkaImeLabel.TabIndex = 0;
            this.zbirkaImeLabel.Text = "Ime zbirke";
            // 
            // zbirkaDataGridView
            // 
            this.zbirkaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zbirkaDataGridView.Location = new System.Drawing.Point(12, 72);
            this.zbirkaDataGridView.Name = "zbirkaDataGridView";
            this.zbirkaDataGridView.Size = new System.Drawing.Size(320, 249);
            this.zbirkaDataGridView.TabIndex = 1;
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
            this.mainLinkButton.TabIndex = 74;
            this.mainLinkButton.UseVisualStyleBackColor = true;
            this.mainLinkButton.Click += new System.EventHandler(this.mainLinkButton_Click);
            // 
            // knjigeGroupBox
            // 
            this.knjigeGroupBox.Controls.Add(this.knjigeListBox);
            this.knjigeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.knjigeGroupBox.Location = new System.Drawing.Point(385, 72);
            this.knjigeGroupBox.Name = "knjigeGroupBox";
            this.knjigeGroupBox.Size = new System.Drawing.Size(200, 249);
            this.knjigeGroupBox.TabIndex = 75;
            this.knjigeGroupBox.TabStop = false;
            this.knjigeGroupBox.Text = "Vse knjige";
            // 
            // knjigeListBox
            // 
            this.knjigeListBox.FormattingEnabled = true;
            this.knjigeListBox.Location = new System.Drawing.Point(6, 19);
            this.knjigeListBox.Name = "knjigeListBox";
            this.knjigeListBox.Size = new System.Drawing.Size(188, 225);
            this.knjigeListBox.TabIndex = 0;
            // 
            // dodajZbirkoButton
            // 
            this.dodajZbirkoButton.ImageIndex = 5;
            this.dodajZbirkoButton.ImageList = this.imageList2;
            this.dodajZbirkoButton.Location = new System.Drawing.Point(457, 337);
            this.dodajZbirkoButton.Name = "dodajZbirkoButton";
            this.dodajZbirkoButton.Size = new System.Drawing.Size(50, 50);
            this.dodajZbirkoButton.TabIndex = 76;
            this.dodajZbirkoButton.UseVisualStyleBackColor = true;
            this.dodajZbirkoButton.Click += new System.EventHandler(this.dodajZbirkoButton_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "icons8-cancel-50.png");
            this.imageList2.Images.SetKeyName(1, "icons8-delete-50.png");
            this.imageList2.Images.SetKeyName(2, "icons8-edit-50.png");
            this.imageList2.Images.SetKeyName(3, "icons8-find-user-male-50.png");
            this.imageList2.Images.SetKeyName(4, "icons8-ok-50.png");
            this.imageList2.Images.SetKeyName(5, "icons8-plus-50.png");
            this.imageList2.Images.SetKeyName(6, "icons8-refresh-50.png");
            this.imageList2.Images.SetKeyName(7, "icons8-search-50.png");
            this.imageList2.Images.SetKeyName(8, "topKnjiga.jpg");
            // 
            // deleteButton
            // 
            this.deleteButton.ImageIndex = 1;
            this.deleteButton.ImageList = this.imageList2;
            this.deleteButton.Location = new System.Drawing.Point(144, 337);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(50, 50);
            this.deleteButton.TabIndex = 77;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ZbirkaPodrobnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(609, 422);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dodajZbirkoButton);
            this.Controls.Add(this.knjigeGroupBox);
            this.Controls.Add(this.mainLinkButton);
            this.Controls.Add(this.zbirkaDataGridView);
            this.Controls.Add(this.zbirkaImeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZbirkaPodrobnosti";
            this.Text = "BookStore";
            this.Load += new System.EventHandler(this.ZbirkaPodrobnosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zbirkaDataGridView)).EndInit();
            this.knjigeGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zbirkaImeLabel;
        private System.Windows.Forms.DataGridView zbirkaDataGridView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button mainLinkButton;
        private System.Windows.Forms.GroupBox knjigeGroupBox;
        private System.Windows.Forms.ListBox knjigeListBox;
        private System.Windows.Forms.Button dodajZbirkoButton;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button deleteButton;
    }
}