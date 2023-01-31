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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browsePicture = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.directoryPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Undo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // browsePicture
            // 
            this.browsePicture.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browsePicture.Location = new System.Drawing.Point(105, 242);
            this.browsePicture.Name = "browsePicture";
            this.browsePicture.Size = new System.Drawing.Size(175, 38);
            this.browsePicture.TabIndex = 0;
            this.browsePicture.Text = "Browse Picture";
            this.browsePicture.UseVisualStyleBackColor = true;
            this.browsePicture.Click += new System.EventHandler(this.button1_Click);
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.applyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.applyButton.Location = new System.Drawing.Point(636, 363);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(250, 87);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(440, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 327);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // directoryPath
            // 
            this.directoryPath.AutoSize = true;
            this.directoryPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.directoryPath.Location = new System.Drawing.Point(38, 211);
            this.directoryPath.Name = "directoryPath";
            this.directoryPath.Size = new System.Drawing.Size(90, 17);
            this.directoryPath.TabIndex = 3;
            this.directoryPath.Text = "Directory Path";
            this.directoryPath.Click += new System.EventHandler(this.directoryPath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Undo
            // 
            this.Undo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Undo.BackgroundImage")));
            this.Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Undo.Location = new System.Drawing.Point(176, 286);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(52, 52);
            this.Undo.TabIndex = 4;
            this.Undo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1208, 536);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.directoryPath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.applyButton);
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
        private Button applyButton;
        private PictureBox pictureBox1;
        private Label directoryPath;
        private OpenFileDialog openFileDialog1;
        private Button Undo;
    }
}