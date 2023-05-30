namespace VirtualAssistantCosmetology
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RenderGroupBox = new System.Windows.Forms.GroupBox();
            this.up_btn = new System.Windows.Forms.Button();
            this.down_btw = new System.Windows.Forms.Button();
            this.column_names_panel = new System.Windows.Forms.Panel();
            this.pic_column_txt = new System.Windows.Forms.TextBox();
            this.recomm_column_txt = new System.Windows.Forms.TextBox();
            this.proc_type_column_txt = new System.Windows.Forms.TextBox();
            this.date_column_txt = new System.Windows.Forms.TextBox();
            this.desc_column_txt = new System.Windows.Forms.TextBox();
            this.name_column_txt = new System.Windows.Forms.TextBox();
            this.filter_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.show_all_btn = new System.Windows.Forms.Button();
            this.new_entry_image = new System.Windows.Forms.Button();
            this.title_lbl = new System.Windows.Forms.Label();
            this.new_client_btn = new System.Windows.Forms.Button();
            this.clients_view_btn = new System.Windows.Forms.Button();
            this.procedures_view_btn = new System.Windows.Forms.Button();
            this.prep_view_btn = new System.Windows.Forms.Button();
            this.column_names_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RenderGroupBox
            // 
            this.RenderGroupBox.Location = new System.Drawing.Point(12, 140);
            this.RenderGroupBox.Name = "RenderGroupBox";
            this.RenderGroupBox.Size = new System.Drawing.Size(673, 577);
            this.RenderGroupBox.TabIndex = 0;
            this.RenderGroupBox.TabStop = false;
            // 
            // up_btn
            // 
            this.up_btn.Location = new System.Drawing.Point(517, 81);
            this.up_btn.Name = "up_btn";
            this.up_btn.Size = new System.Drawing.Size(75, 23);
            this.up_btn.TabIndex = 1;
            this.up_btn.Text = "<";
            this.up_btn.UseVisualStyleBackColor = true;
            this.up_btn.Click += new System.EventHandler(this.up_btn_Click);
            // 
            // down_btw
            // 
            this.down_btw.Location = new System.Drawing.Point(610, 81);
            this.down_btw.Name = "down_btw";
            this.down_btw.Size = new System.Drawing.Size(75, 23);
            this.down_btw.TabIndex = 2;
            this.down_btw.Text = ">";
            this.down_btw.UseVisualStyleBackColor = true;
            this.down_btw.Click += new System.EventHandler(this.down_btw_Click);
            // 
            // column_names_panel
            // 
            this.column_names_panel.Controls.Add(this.pic_column_txt);
            this.column_names_panel.Controls.Add(this.recomm_column_txt);
            this.column_names_panel.Controls.Add(this.proc_type_column_txt);
            this.column_names_panel.Controls.Add(this.date_column_txt);
            this.column_names_panel.Controls.Add(this.desc_column_txt);
            this.column_names_panel.Controls.Add(this.name_column_txt);
            this.column_names_panel.Location = new System.Drawing.Point(12, 116);
            this.column_names_panel.Name = "column_names_panel";
            this.column_names_panel.Size = new System.Drawing.Size(673, 37);
            this.column_names_panel.TabIndex = 3;
            // 
            // pic_column_txt
            // 
            this.pic_column_txt.Enabled = false;
            this.pic_column_txt.Location = new System.Drawing.Point(505, 3);
            this.pic_column_txt.Multiline = true;
            this.pic_column_txt.Name = "pic_column_txt";
            this.pic_column_txt.ReadOnly = true;
            this.pic_column_txt.Size = new System.Drawing.Size(59, 31);
            this.pic_column_txt.TabIndex = 5;
            this.pic_column_txt.Text = "Picture";
            this.pic_column_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // recomm_column_txt
            // 
            this.recomm_column_txt.Enabled = false;
            this.recomm_column_txt.Location = new System.Drawing.Point(363, 3);
            this.recomm_column_txt.Multiline = true;
            this.recomm_column_txt.Name = "recomm_column_txt";
            this.recomm_column_txt.ReadOnly = true;
            this.recomm_column_txt.Size = new System.Drawing.Size(97, 31);
            this.recomm_column_txt.TabIndex = 4;
            this.recomm_column_txt.Text = "Recommendations\r\n";
            this.recomm_column_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // proc_type_column_txt
            // 
            this.proc_type_column_txt.Enabled = false;
            this.proc_type_column_txt.Location = new System.Drawing.Point(279, 3);
            this.proc_type_column_txt.Multiline = true;
            this.proc_type_column_txt.Name = "proc_type_column_txt";
            this.proc_type_column_txt.ReadOnly = true;
            this.proc_type_column_txt.Size = new System.Drawing.Size(59, 31);
            this.proc_type_column_txt.TabIndex = 3;
            this.proc_type_column_txt.Text = "Procedure\r\nType\r\n";
            this.proc_type_column_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date_column_txt
            // 
            this.date_column_txt.Enabled = false;
            this.date_column_txt.Location = new System.Drawing.Point(189, 3);
            this.date_column_txt.Multiline = true;
            this.date_column_txt.Name = "date_column_txt";
            this.date_column_txt.ReadOnly = true;
            this.date_column_txt.Size = new System.Drawing.Size(59, 31);
            this.date_column_txt.TabIndex = 2;
            this.date_column_txt.Text = "Date";
            this.date_column_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // desc_column_txt
            // 
            this.desc_column_txt.Enabled = false;
            this.desc_column_txt.Location = new System.Drawing.Point(100, 3);
            this.desc_column_txt.Multiline = true;
            this.desc_column_txt.Name = "desc_column_txt";
            this.desc_column_txt.ReadOnly = true;
            this.desc_column_txt.Size = new System.Drawing.Size(59, 31);
            this.desc_column_txt.TabIndex = 1;
            this.desc_column_txt.Text = "Description";
            this.desc_column_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name_column_txt
            // 
            this.name_column_txt.Enabled = false;
            this.name_column_txt.Location = new System.Drawing.Point(6, 3);
            this.name_column_txt.Multiline = true;
            this.name_column_txt.Name = "name_column_txt";
            this.name_column_txt.ReadOnly = true;
            this.name_column_txt.Size = new System.Drawing.Size(59, 31);
            this.name_column_txt.TabIndex = 0;
            this.name_column_txt.Text = "Name\r\nSurname\r\n";
            this.name_column_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // filter_txt
            // 
            this.filter_txt.Location = new System.Drawing.Point(12, 81);
            this.filter_txt.Name = "filter_txt";
            this.filter_txt.Size = new System.Drawing.Size(159, 20);
            this.filter_txt.TabIndex = 4;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(177, 81);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 5;
            this.search_btn.Text = "Search!";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // show_all_btn
            // 
            this.show_all_btn.Location = new System.Drawing.Point(258, 81);
            this.show_all_btn.Name = "show_all_btn";
            this.show_all_btn.Size = new System.Drawing.Size(75, 23);
            this.show_all_btn.TabIndex = 6;
            this.show_all_btn.Text = "Show all";
            this.show_all_btn.UseVisualStyleBackColor = true;
            this.show_all_btn.Click += new System.EventHandler(this.show_all_btn_Click);
            // 
            // new_entry_image
            // 
            this.new_entry_image.Location = new System.Drawing.Point(12, 46);
            this.new_entry_image.Name = "new_entry_image";
            this.new_entry_image.Size = new System.Drawing.Size(75, 23);
            this.new_entry_image.TabIndex = 7;
            this.new_entry_image.Text = "New entry";
            this.new_entry_image.UseVisualStyleBackColor = true;
            this.new_entry_image.Click += new System.EventHandler(this.new_entry_image_Click);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title_lbl.Location = new System.Drawing.Point(12, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(210, 31);
            this.title_lbl.TabIndex = 8;
            this.title_lbl.Text = "Virtual Assistant";
            // 
            // new_client_btn
            // 
            this.new_client_btn.Location = new System.Drawing.Point(96, 46);
            this.new_client_btn.Name = "new_client_btn";
            this.new_client_btn.Size = new System.Drawing.Size(75, 23);
            this.new_client_btn.TabIndex = 9;
            this.new_client_btn.Text = "New client";
            this.new_client_btn.UseVisualStyleBackColor = true;
            this.new_client_btn.Click += new System.EventHandler(this.new_client_btn_Click);
            // 
            // clients_view_btn
            // 
            this.clients_view_btn.Location = new System.Drawing.Point(228, 9);
            this.clients_view_btn.Name = "clients_view_btn";
            this.clients_view_btn.Size = new System.Drawing.Size(75, 23);
            this.clients_view_btn.TabIndex = 10;
            this.clients_view_btn.Text = "Clients";
            this.clients_view_btn.UseVisualStyleBackColor = true;
            this.clients_view_btn.Click += new System.EventHandler(this.clients_view_btn_Click);
            // 
            // procedures_view_btn
            // 
            this.procedures_view_btn.Location = new System.Drawing.Point(309, 9);
            this.procedures_view_btn.Name = "procedures_view_btn";
            this.procedures_view_btn.Size = new System.Drawing.Size(75, 23);
            this.procedures_view_btn.TabIndex = 11;
            this.procedures_view_btn.Text = "Procedures";
            this.procedures_view_btn.UseVisualStyleBackColor = true;
            this.procedures_view_btn.Click += new System.EventHandler(this.procedures_view_btn_Click);
            // 
            // prep_view_btn
            // 
            this.prep_view_btn.Location = new System.Drawing.Point(390, 9);
            this.prep_view_btn.Name = "prep_view_btn";
            this.prep_view_btn.Size = new System.Drawing.Size(75, 23);
            this.prep_view_btn.TabIndex = 12;
            this.prep_view_btn.Text = "Preparats";
            this.prep_view_btn.UseVisualStyleBackColor = true;
            this.prep_view_btn.Click += new System.EventHandler(this.prep_view_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 729);
            this.Controls.Add(this.prep_view_btn);
            this.Controls.Add(this.procedures_view_btn);
            this.Controls.Add(this.clients_view_btn);
            this.Controls.Add(this.new_client_btn);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.new_entry_image);
            this.Controls.Add(this.show_all_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.filter_txt);
            this.Controls.Add(this.column_names_panel);
            this.Controls.Add(this.down_btw);
            this.Controls.Add(this.up_btn);
            this.Controls.Add(this.RenderGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Assistant";
            this.column_names_panel.ResumeLayout(false);
            this.column_names_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RenderGroupBox;
        private System.Windows.Forms.Button up_btn;
        private System.Windows.Forms.Button down_btw;
        private System.Windows.Forms.Panel column_names_panel;
        private System.Windows.Forms.TextBox pic_column_txt;
        private System.Windows.Forms.TextBox recomm_column_txt;
        private System.Windows.Forms.TextBox proc_type_column_txt;
        private System.Windows.Forms.TextBox date_column_txt;
        private System.Windows.Forms.TextBox desc_column_txt;
        private System.Windows.Forms.TextBox name_column_txt;
        private System.Windows.Forms.TextBox filter_txt;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button show_all_btn;
        private System.Windows.Forms.Button new_entry_image;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button new_client_btn;
        private System.Windows.Forms.Button clients_view_btn;
        private System.Windows.Forms.Button procedures_view_btn;
        private System.Windows.Forms.Button prep_view_btn;
    }
}

