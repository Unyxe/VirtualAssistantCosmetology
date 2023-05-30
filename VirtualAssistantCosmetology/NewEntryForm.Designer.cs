namespace VirtualAssistantCosmetology
{
    partial class NewEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEntryForm));
            this.title_lbl = new System.Windows.Forms.Label();
            this.nm_lbl = new System.Windows.Forms.Label();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.date_txt = new System.Windows.Forms.TextBox();
            this.date_lbl = new System.Windows.Forms.Label();
            this.proc_txt = new System.Windows.Forms.TextBox();
            this.proc_lbl = new System.Windows.Forms.Label();
            this.rec_txt = new System.Windows.Forms.TextBox();
            this.rec_lbl = new System.Windows.Forms.Label();
            this.pic_txt = new System.Windows.Forms.TextBox();
            this.pic_lbl = new System.Windows.Forms.Label();
            this.check_client_btn = new System.Windows.Forms.Button();
            this.pic_brows_btn = new System.Windows.Forms.Button();
            this.add_entry_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.today_btn = new System.Windows.Forms.Button();
            this.procedure_check_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title_lbl.Location = new System.Drawing.Point(12, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(140, 31);
            this.title_lbl.TabIndex = 9;
            this.title_lbl.Text = "New Entry";
            // 
            // nm_lbl
            // 
            this.nm_lbl.AutoSize = true;
            this.nm_lbl.Location = new System.Drawing.Point(38, 66);
            this.nm_lbl.Name = "nm_lbl";
            this.nm_lbl.Size = new System.Drawing.Size(62, 13);
            this.nm_lbl.TabIndex = 10;
            this.nm_lbl.Text = "Client name";
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(106, 63);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(258, 20);
            this.name_txtbox.TabIndex = 11;
            this.name_txtbox.TextChanged += new System.EventHandler(this.name_txtbox_TextChanged);
            // 
            // date_txt
            // 
            this.date_txt.Location = new System.Drawing.Point(106, 89);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(258, 20);
            this.date_txt.TabIndex = 13;
            this.date_txt.Leave += new System.EventHandler(this.date_txt_Leave);
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(70, 92);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(30, 13);
            this.date_lbl.TabIndex = 12;
            this.date_lbl.Text = "Date";
            // 
            // proc_txt
            // 
            this.proc_txt.Location = new System.Drawing.Point(106, 115);
            this.proc_txt.Name = "proc_txt";
            this.proc_txt.Size = new System.Drawing.Size(258, 20);
            this.proc_txt.TabIndex = 15;
            this.proc_txt.TextChanged += new System.EventHandler(this.proc_txt_TextChanged);
            // 
            // proc_lbl
            // 
            this.proc_lbl.AutoSize = true;
            this.proc_lbl.Location = new System.Drawing.Point(44, 118);
            this.proc_lbl.Name = "proc_lbl";
            this.proc_lbl.Size = new System.Drawing.Size(56, 13);
            this.proc_lbl.TabIndex = 14;
            this.proc_lbl.Text = "Procedure";
            // 
            // rec_txt
            // 
            this.rec_txt.Location = new System.Drawing.Point(106, 141);
            this.rec_txt.Name = "rec_txt";
            this.rec_txt.Size = new System.Drawing.Size(258, 20);
            this.rec_txt.TabIndex = 17;
            // 
            // rec_lbl
            // 
            this.rec_lbl.AutoSize = true;
            this.rec_lbl.Location = new System.Drawing.Point(10, 144);
            this.rec_lbl.Name = "rec_lbl";
            this.rec_lbl.Size = new System.Drawing.Size(90, 13);
            this.rec_lbl.TabIndex = 16;
            this.rec_lbl.Text = "Recommendation";
            // 
            // pic_txt
            // 
            this.pic_txt.Location = new System.Drawing.Point(106, 167);
            this.pic_txt.Name = "pic_txt";
            this.pic_txt.Size = new System.Drawing.Size(258, 20);
            this.pic_txt.TabIndex = 19;
            // 
            // pic_lbl
            // 
            this.pic_lbl.AutoSize = true;
            this.pic_lbl.Location = new System.Drawing.Point(60, 170);
            this.pic_lbl.Name = "pic_lbl";
            this.pic_lbl.Size = new System.Drawing.Size(40, 13);
            this.pic_lbl.TabIndex = 18;
            this.pic_lbl.Text = "Picture";
            // 
            // check_client_btn
            // 
            this.check_client_btn.Location = new System.Drawing.Point(370, 61);
            this.check_client_btn.Name = "check_client_btn";
            this.check_client_btn.Size = new System.Drawing.Size(52, 23);
            this.check_client_btn.TabIndex = 20;
            this.check_client_btn.Text = "Check";
            this.check_client_btn.UseVisualStyleBackColor = true;
            this.check_client_btn.Click += new System.EventHandler(this.check_client_btn_Click);
            // 
            // pic_brows_btn
            // 
            this.pic_brows_btn.Location = new System.Drawing.Point(370, 165);
            this.pic_brows_btn.Name = "pic_brows_btn";
            this.pic_brows_btn.Size = new System.Drawing.Size(52, 23);
            this.pic_brows_btn.TabIndex = 21;
            this.pic_brows_btn.Text = "Browse";
            this.pic_brows_btn.UseVisualStyleBackColor = true;
            this.pic_brows_btn.Click += new System.EventHandler(this.pic_brows_btn_Click);
            // 
            // add_entry_btn
            // 
            this.add_entry_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.add_entry_btn.Location = new System.Drawing.Point(12, 194);
            this.add_entry_btn.Name = "add_entry_btn";
            this.add_entry_btn.Size = new System.Drawing.Size(410, 53);
            this.add_entry_btn.TabIndex = 22;
            this.add_entry_btn.Text = "Add Entry";
            this.add_entry_btn.UseVisualStyleBackColor = true;
            this.add_entry_btn.Click += new System.EventHandler(this.add_entry_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // today_btn
            // 
            this.today_btn.Location = new System.Drawing.Point(370, 87);
            this.today_btn.Name = "today_btn";
            this.today_btn.Size = new System.Drawing.Size(52, 23);
            this.today_btn.TabIndex = 23;
            this.today_btn.Text = "Today";
            this.today_btn.UseVisualStyleBackColor = true;
            this.today_btn.Click += new System.EventHandler(this.today_btn_Click);
            // 
            // procedure_check_btn
            // 
            this.procedure_check_btn.Location = new System.Drawing.Point(370, 113);
            this.procedure_check_btn.Name = "procedure_check_btn";
            this.procedure_check_btn.Size = new System.Drawing.Size(52, 23);
            this.procedure_check_btn.TabIndex = 24;
            this.procedure_check_btn.Text = "Check";
            this.procedure_check_btn.UseVisualStyleBackColor = true;
            this.procedure_check_btn.Click += new System.EventHandler(this.procedure_check_btn_Click);
            // 
            // NewEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 254);
            this.Controls.Add(this.procedure_check_btn);
            this.Controls.Add(this.today_btn);
            this.Controls.Add(this.add_entry_btn);
            this.Controls.Add(this.pic_brows_btn);
            this.Controls.Add(this.check_client_btn);
            this.Controls.Add(this.pic_txt);
            this.Controls.Add(this.pic_lbl);
            this.Controls.Add(this.rec_txt);
            this.Controls.Add(this.rec_lbl);
            this.Controls.Add(this.proc_txt);
            this.Controls.Add(this.proc_lbl);
            this.Controls.Add(this.date_txt);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.nm_lbl);
            this.Controls.Add(this.title_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewEntryForm";
            this.Text = "New Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label nm_lbl;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.TextBox date_txt;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.TextBox proc_txt;
        private System.Windows.Forms.Label proc_lbl;
        private System.Windows.Forms.TextBox rec_txt;
        private System.Windows.Forms.Label rec_lbl;
        private System.Windows.Forms.TextBox pic_txt;
        private System.Windows.Forms.Label pic_lbl;
        private System.Windows.Forms.Button check_client_btn;
        private System.Windows.Forms.Button pic_brows_btn;
        private System.Windows.Forms.Button add_entry_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button today_btn;
        private System.Windows.Forms.Button procedure_check_btn;
    }
}