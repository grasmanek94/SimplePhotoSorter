namespace PhotoSorting
{
    partial class NewFolder
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
            this.LabelName = new System.Windows.Forms.Label();
            this.NewFolderName = new System.Windows.Forms.TextBox();
            this.CreateNewFolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelName.Location = new System.Drawing.Point(12, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(48, 16);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Naam:";
            // 
            // NewFolderName
            // 
            this.NewFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewFolderName.Location = new System.Drawing.Point(66, 8);
            this.NewFolderName.Name = "NewFolderName";
            this.NewFolderName.Size = new System.Drawing.Size(350, 22);
            this.NewFolderName.TabIndex = 1;
            this.NewFolderName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewFolderName_KeyDown);
            // 
            // CreateNewFolderButton
            // 
            this.CreateNewFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateNewFolderButton.Location = new System.Drawing.Point(15, 34);
            this.CreateNewFolderButton.Name = "CreateNewFolderButton";
            this.CreateNewFolderButton.Size = new System.Drawing.Size(401, 23);
            this.CreateNewFolderButton.TabIndex = 2;
            this.CreateNewFolderButton.Text = "Aanmaken";
            this.CreateNewFolderButton.UseVisualStyleBackColor = true;
            this.CreateNewFolderButton.Click += new System.EventHandler(this.CreateNewFolderButton_Click);
            // 
            // NewFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 67);
            this.Controls.Add(this.CreateNewFolderButton);
            this.Controls.Add(this.NewFolderName);
            this.Controls.Add(this.LabelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewFolder";
            this.Text = "Nieuwe Map...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox NewFolderName;
        private System.Windows.Forms.Button CreateNewFolderButton;
    }
}