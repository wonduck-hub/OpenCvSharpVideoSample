namespace OpenCvSharpVideoSample
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
            components = new System.ComponentModel.Container();
            videoPictureBox = new PictureBox();
            loadVideoButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)videoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // videoPictureBox
            // 
            videoPictureBox.Location = new Point(0, 0);
            videoPictureBox.Name = "videoPictureBox";
            videoPictureBox.Size = new Size(555, 451);
            videoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            videoPictureBox.TabIndex = 0;
            videoPictureBox.TabStop = false;
            // 
            // loadVideoButton
            // 
            loadVideoButton.Location = new Point(713, 12);
            loadVideoButton.Name = "loadVideoButton";
            loadVideoButton.Size = new Size(75, 23);
            loadVideoButton.TabIndex = 1;
            loadVideoButton.Text = "load";
            loadVideoButton.UseVisualStyleBackColor = true;
            loadVideoButton.Click += loadVideoButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loadVideoButton);
            Controls.Add(videoPictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)videoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox videoPictureBox;
        private Button loadVideoButton;
        private System.Windows.Forms.Timer timer1;
    }
}
