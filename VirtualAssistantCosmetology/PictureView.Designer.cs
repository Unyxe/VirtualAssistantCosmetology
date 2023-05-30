namespace VirtualAssistantCosmetology
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureView));
            this.pic_box_1 = new System.Windows.Forms.PictureBox();
            this.left_btn = new System.Windows.Forms.Button();
            this.right_btn = new System.Windows.Forms.Button();
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
            // left_btn
            // 
            this.left_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_btn.Location = new System.Drawing.Point(12, 493);
            this.left_btn.Name = "left_btn";
            this.left_btn.Size = new System.Drawing.Size(238, 34);
            this.left_btn.TabIndex = 1;
            this.left_btn.Text = "<";
            this.left_btn.UseVisualStyleBackColor = true;
            this.left_btn.Click += new System.EventHandler(this.left_btn_Click);
            // 
            // right_btn
            // 
            this.right_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right_btn.Location = new System.Drawing.Point(250, 493);
            this.right_btn.Name = "right_btn";
            this.right_btn.Size = new System.Drawing.Size(238, 34);
            this.right_btn.TabIndex = 2;
            this.right_btn.Text = ">";
            this.right_btn.UseVisualStyleBackColor = true;
            this.right_btn.Click += new System.EventHandler(this.right_btn_Click);
            // 
            // PictureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 532);
            this.Controls.Add(this.right_btn);
            this.Controls.Add(this.left_btn);
            this.Controls.Add(this.pic_box_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PictureView";
            this.Text = "Picture View";
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_box_1;
        private System.Windows.Forms.Button left_btn;
        private System.Windows.Forms.Button right_btn;
    }
}