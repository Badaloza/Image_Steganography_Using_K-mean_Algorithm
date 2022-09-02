namespace Steganography
{
    partial class Steganography
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
            this.hideButton = new System.Windows.Forms.Button();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.extractButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // hideButton
            // 
            this.hideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideButton.Location = new System.Drawing.Point(19, 482);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(181, 46);
            this.hideButton.TabIndex = 0;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dataTextBox.Location = new System.Drawing.Point(55, 342);
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTextBox.Size = new System.Drawing.Size(551, 114);
            this.dataTextBox.TabIndex = 2;
            this.dataTextBox.TextChanged += new System.EventHandler(this.dataTextBox_TextChanged);
            // 
            // extractButton
            // 
            this.extractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractButton.Location = new System.Drawing.Point(247, 482);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(181, 46);
            this.extractButton.TabIndex = 3;
            this.extractButton.Text = "Extract";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem1,
            this.textToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // imageToolStripMenuItem1
            // 
            this.imageToolStripMenuItem1.Name = "imageToolStripMenuItem1";
            this.imageToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.imageToolStripMenuItem1.Text = "Image";
            this.imageToolStripMenuItem1.Click += new System.EventHandler(this.imageToolStripMenuItem1_Click);
            // 
            // textToolStripMenuItem1
            // 
            this.textToolStripMenuItem1.Name = "textToolStripMenuItem1";
            this.textToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.textToolStripMenuItem1.Text = "Text";
            this.textToolStripMenuItem1.Click += new System.EventHandler(this.textToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.textToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(15, 593);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(55, 20);
            this.notesLabel.TabIndex = 9;
            this.notesLabel.Text = "Notes:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(461, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Image = global::Steganography.Properties.Resources.IMG_20200409_WA0084;
            this.imagePictureBox.Location = new System.Drawing.Point(55, 41);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(551, 281);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 4;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.Click += new System.EventHandler(this.imagePictureBox_Click);
            // 
            // Steganography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 622);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Steganography";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Button button2;
    }
}

