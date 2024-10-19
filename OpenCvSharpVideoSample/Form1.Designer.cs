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
            videoPictureBox.Margin = new Padding(4, 5, 4, 5);
            videoPictureBox.Name = "videoPictureBox";
            videoPictureBox.Size = new Size(957, 752);
            videoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            videoPictureBox.TabIndex = 0;
            videoPictureBox.TabStop = false;
            // 
            // loadVideoButton
            // 
            loadVideoButton.Location = new Point(1019, 20);
            loadVideoButton.Margin = new Padding(4, 5, 4, 5);
            loadVideoButton.Name = "loadVideoButton";
            loadVideoButton.Size = new Size(107, 38);
            loadVideoButton.TabIndex = 1;
            loadVideoButton.Text = "start";
            loadVideoButton.UseVisualStyleBackColor = true;
            loadVideoButton.Click += loadVideoButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(loadVideoButton);
            Controls.Add(videoPictureBox);
            Margin = new Padding(4, 5, 4, 5);
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
