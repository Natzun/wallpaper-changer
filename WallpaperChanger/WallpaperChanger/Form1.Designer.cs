namespace WallpaperChanger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.browsePicture = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.directoryPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // browsePicture
            // 
            this.browsePicture.Location = new System.Drawing.Point(70, 212);
            this.browsePicture.Name = "browsePicture";
            this.browsePicture.Size = new System.Drawing.Size(145, 38);
            this.browsePicture.TabIndex = 0;
            this.browsePicture.Text = "Browse Picture";
            this.browsePicture.UseVisualStyleBackColor = true;
            this.browsePicture.Click += new System.EventHandler(this.button1_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(530, 363);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(250, 87);
            this.uploadButton.TabIndex = 1;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(436, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 244);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // directoryPath
            // 
            this.directoryPath.AutoSize = true;
            this.directoryPath.Location = new System.Drawing.Point(44, 185);
            this.directoryPath.Name = "directoryPath";
            this.directoryPath.Size = new System.Drawing.Size(82, 15);
            this.directoryPath.TabIndex = 3;
            this.directoryPath.Text = "Directory Path";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 519);
            this.Controls.Add(this.directoryPath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.browsePicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button browsePicture;
        private Button uploadButton;
        private PictureBox pictureBox1;
        private Label directoryPath;
        private OpenFileDialog openFileDialog1;
    }
}