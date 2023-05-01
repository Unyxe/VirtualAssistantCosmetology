namespace ClientDatabaseCosmetology
{
    partial class PictureView
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
            this.pic_box_1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_box_1
            // 
            this.pic_box_1.Cursor = System.Windows.Forms.Cursors.No;
            this.pic_box_1.Location = new System.Drawing.Point(12, 12);
            this.pic_box_1.Name = "pic_box_1";
            this.pic_box_1.Size = new System.Drawing.Size(476, 475);
            this.pic_box_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_box_1.TabIndex = 0;
            this.pic_box_1.TabStop = false;
            // 
            // PictureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 499);
            this.Controls.Add(this.pic_box_1);
            this.Name = "PictureView";
            this.Text = "PictureView";
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_box_1;
    }
}