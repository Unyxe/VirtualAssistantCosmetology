namespace VirtualAssistantCosmetology
{
    partial class NewClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewClientForm));
            this.add_client_btn = new System.Windows.Forms.Button();
            this.desc_txt = new System.Windows.Forms.TextBox();
            this.desc_lbl = new System.Windows.Forms.Label();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.nm_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_client_btn
            // 
            this.add_client_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.add_client_btn.Location = new System.Drawing.Point(12, 154);
            this.add_client_btn.Name = "add_client_btn";
            this.add_client_btn.Size = new System.Drawing.Size(329, 53);
            this.add_client_btn.TabIndex = 36;
            this.add_client_btn.Text = "Add Client";
            this.add_client_btn.UseVisualStyleBackColor = true;
            this.add_client_btn.Click += new System.EventHandler(this.add_client_btn_Click);
            // 
            // desc_txt
            // 
            this.desc_txt.Location = new System.Drawing.Point(83, 86);
            this.desc_txt.MaxLength = 200;
            this.desc_txt.Multiline = true;
            this.desc_txt.Name = "desc_txt";
            this.desc_txt.Size = new System.Drawing.Size(258, 62);
            this.desc_txt.TabIndex = 27;
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.Location = new System.Drawing.Point(17, 89);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(60, 13);
            this.desc_lbl.TabIndex = 26;
            this.desc_lbl.Text = "Description";
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(83, 63);
            this.name_txtbox.MaxLength = 30;
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(258, 20);
            this.name_txtbox.TabIndex = 25;
            // 
            // nm_lbl
            // 
            this.nm_lbl.AutoSize = true;
            this.nm_lbl.Location = new System.Drawing.Point(15, 66);
            this.nm_lbl.Name = "nm_lbl";
            this.nm_lbl.Size = new System.Drawing.Size(62, 13);
            this.nm_lbl.TabIndex = 24;
            this.nm_lbl.Text = "Client name";
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title_lbl.Location = new System.Drawing.Point(12, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(146, 31);
            this.title_lbl.TabIndex = 23;
            this.title_lbl.Text = "New Client";
            // 
            // NewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 219);
            this.Controls.Add(this.add_client_btn);
            this.Controls.Add(this.desc_txt);
            this.Controls.Add(this.desc_lbl);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.nm_lbl);
            this.Controls.Add(this.title_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewClientForm";
            this.Text = "New Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_client_btn;
        private System.Windows.Forms.TextBox desc_txt;
        private System.Windows.Forms.Label desc_lbl;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label nm_lbl;
        private System.Windows.Forms.Label title_lbl;
    }
}