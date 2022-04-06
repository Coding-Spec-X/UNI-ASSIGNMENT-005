namespace Brick_Project
{
    partial class Form1
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
            this.brickDrawingPictureBox = new System.Windows.Forms.PictureBox();
            this.drawButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brickDrawingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // brickDrawingPictureBox
            // 
            this.brickDrawingPictureBox.BackColor = System.Drawing.Color.White;
            this.brickDrawingPictureBox.Location = new System.Drawing.Point(20, 12);
            this.brickDrawingPictureBox.MaximumSize = new System.Drawing.Size(800, 500);
            this.brickDrawingPictureBox.Name = "brickDrawingPictureBox";
            this.brickDrawingPictureBox.Size = new System.Drawing.Size(800, 500);
            this.brickDrawingPictureBox.TabIndex = 0;
            this.brickDrawingPictureBox.TabStop = false;
            this.brickDrawingPictureBox.Click += new System.EventHandler(this.brickDrawingPictureBox_Click);
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(355, 518);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(175, 32);
            this.drawButton.TabIndex = 4;
            this.drawButton.Text = "Draw French Flag";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.brickDrawingPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.brickDrawingPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox brickDrawingPictureBox;
        private System.Windows.Forms.Button drawButton;
    }
}

