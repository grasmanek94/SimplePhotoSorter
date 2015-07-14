namespace PhotoSorting
{
    partial class PhotoSortForm
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
            this.Panel = new System.Windows.Forms.Panel();
            this.NewFolder = new System.Windows.Forms.Button();
            this.SortedFolders = new System.Windows.Forms.ListBox();
            this.MovePicture = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.RotateRight = new System.Windows.Forms.Button();
            this.RotateLeft = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Controls.Add(this.Picture);
            this.Panel.Location = new System.Drawing.Point(250, 0);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(764, 734);
            this.Panel.TabIndex = 0;
            // 
            // NewFolder
            // 
            this.NewFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewFolder.Location = new System.Drawing.Point(13, 588);
            this.NewFolder.Name = "NewFolder";
            this.NewFolder.Size = new System.Drawing.Size(231, 31);
            this.NewFolder.TabIndex = 2;
            this.NewFolder.Text = "Nieuwe Map...";
            this.NewFolder.UseVisualStyleBackColor = true;
            this.NewFolder.Click += new System.EventHandler(this.NewFolder_Click);
            // 
            // SortedFolders
            // 
            this.SortedFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SortedFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SortedFolders.FormattingEnabled = true;
            this.SortedFolders.ItemHeight = 16;
            this.SortedFolders.Location = new System.Drawing.Point(12, 12);
            this.SortedFolders.Name = "SortedFolders";
            this.SortedFolders.ScrollAlwaysVisible = true;
            this.SortedFolders.Size = new System.Drawing.Size(231, 564);
            this.SortedFolders.TabIndex = 3;
            this.SortedFolders.SelectedIndexChanged += new System.EventHandler(this.SortedFolders_SelectedIndexChanged);
            // 
            // MovePicture
            // 
            this.MovePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MovePicture.Location = new System.Drawing.Point(12, 699);
            this.MovePicture.Name = "MovePicture";
            this.MovePicture.Size = new System.Drawing.Size(231, 35);
            this.MovePicture.TabIndex = 4;
            this.MovePicture.Text = "Verplaats naar: ";
            this.MovePicture.UseVisualStyleBackColor = true;
            this.MovePicture.Click += new System.EventHandler(this.MovePicture_Click);
            // 
            // Picture
            // 
            this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture.ErrorImage = null;
            this.Picture.InitialImage = null;
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(764, 734);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // RotateRight
            // 
            this.RotateRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RotateRight.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RotateRight.Location = new System.Drawing.Point(192, 625);
            this.RotateRight.Name = "RotateRight";
            this.RotateRight.Size = new System.Drawing.Size(51, 68);
            this.RotateRight.TabIndex = 5;
            this.RotateRight.Text = "⟳ ";
            this.RotateRight.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RotateRight.UseVisualStyleBackColor = true;
            this.RotateRight.Click += new System.EventHandler(this.RotateRight_Click);
            // 
            // RotateLeft
            // 
            this.RotateLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RotateLeft.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RotateLeft.Location = new System.Drawing.Point(135, 625);
            this.RotateLeft.Name = "RotateLeft";
            this.RotateLeft.Size = new System.Drawing.Size(51, 68);
            this.RotateLeft.TabIndex = 6;
            this.RotateLeft.Text = "⟲";
            this.RotateLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RotateLeft.UseVisualStyleBackColor = true;
            this.RotateLeft.Click += new System.EventHandler(this.RotateLeft_Click);
            // 
            // PhotoSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 735);
            this.Controls.Add(this.RotateLeft);
            this.Controls.Add(this.RotateRight);
            this.Controls.Add(this.MovePicture);
            this.Controls.Add(this.SortedFolders);
            this.Controls.Add(this.NewFolder);
            this.Controls.Add(this.Panel);
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "PhotoSortForm";
            this.ShowIcon = false;
            this.Text = "Foto\'s Sorteren";
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button NewFolder;
        private System.Windows.Forms.ListBox SortedFolders;
        private System.Windows.Forms.Button MovePicture;
        private System.Windows.Forms.Button RotateRight;
        private System.Windows.Forms.Button RotateLeft;
    }
}

