using System;

namespace VirtualAssistantCosmetology
{
    partial class ProcedureView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcedureView));
            this.title_lbl = new System.Windows.Forms.Label();
            this.show_all_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.filter_txt = new System.Windows.Forms.TextBox();
            this.RenderGroupBox = new System.Windows.Forms.GroupBox();
            this.column_names_panel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.desc_column_txt = new System.Windows.Forms.TextBox();
            this.name_column_txt = new System.Windows.Forms.TextBox();
            this.down_btw = new System.Windows.Forms.Button();
            this.up_btn = new System.Windows.Forms.Button();
            this.new_proc_btn = new System.Windows.Forms.Button();
            this.new_prep_btn = new System.Windows.Forms.Button();
            this.prep_view_btn = new System.Windows.Forms.Button();
            this.column_names_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title_lbl.Location = new System.Drawing.Point(12, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(153, 31);
            this.title_lbl.TabIndex = 9;
            this.title_lbl.Text = "Procedures";
            // 
            // show_all_btn
            // 
            this.show_all_btn.Location = new System.Drawing.Point(258, 56);
            this.show_all_btn.Name = "show_all_btn";
            this.show_all_btn.Size = new System.Drawing.Size(75, 23);
            this.show_all_btn.TabIndex = 12;
            this.show_all_btn.Text = "Show all";
            this.show_all_btn.UseVisualStyleBackColor = true;
            this.show_all_btn.Click += new System.EventHandler(this.show_all_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(177, 56);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 11;
            this.search_btn.Text = "Search!";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // filter_txt
            // 
            this.filter_txt.Location = new System.Drawing.Point(12, 56);
            this.filter_txt.Name = "filter_txt";
            this.filter_txt.Size = new System.Drawing.Size(159, 20);
            this.filter_txt.TabIndex = 10;
            // 
            // RenderGroupBox
            // 
            this.RenderGroupBox.Location = new System.Drawing.Point(18, 128);
            this.RenderGroupBox.Name = "RenderGroupBox";
            this.RenderGroupBox.Size = new System.Drawing.Size(700, 577);
            this.RenderGroupBox.TabIndex = 13;
            this.RenderGroupBox.TabStop = false;
            // 
            // column_names_panel
            // 
            this.column_names_panel.Controls.Add(this.textBox1);
            this.column_names_panel.Controls.Add(this.textBox2);
            this.column_names_panel.Controls.Add(this.desc_column_txt);
            this.column_names_panel.Controls.Add(this.name_column_txt);
            this.column_names_panel.Location = new System.Drawing.Point(18, 85);
            this.column_names_panel.Name = "column_names_panel";
            this.column_names_panel.Size = new System.Drawing.Size(700, 37);
            this.column_names_panel.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(488, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(59, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Cost";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(343, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(59, 31);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Preparats";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // desc_column_txt
            // 
            this.desc_column_txt.Enabled = false;
            this.desc_column_txt.Location = new System.Drawing.Point(159, 3);
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
            this.name_column_txt.Text = "Name\r\n";
            this.name_column_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // down_btw
            // 
            this.down_btw.Location = new System.Drawing.Point(259, 27);
            this.down_btw.Name = "down_btw";
            this.down_btw.Size = new System.Drawing.Size(74, 23);
            this.down_btw.TabIndex = 15;
            this.down_btw.Text = ">";
            this.down_btw.UseVisualStyleBackColor = true;
            this.down_btw.Click += new System.EventHandler(this.down_btn_Click);
            // 
            // up_btn
            // 
            this.up_btn.Location = new System.Drawing.Point(178, 27);
            this.up_btn.Name = "up_btn";
            this.up_btn.Size = new System.Drawing.Size(74, 23);
            this.up_btn.TabIndex = 14;
            this.up_btn.Text = "<";
            this.up_btn.UseVisualStyleBackColor = true;
            this.up_btn.Click += new System.EventHandler(this.up_btn_Click);
            // 
            // new_proc_btn
            // 
            this.new_proc_btn.Location = new System.Drawing.Point(610, 53);
            this.new_proc_btn.Name = "new_proc_btn";
            this.new_proc_btn.Size = new System.Drawing.Size(108, 23);
            this.new_proc_btn.TabIndex = 17;
            this.new_proc_btn.Text = "New procedure";
            this.new_proc_btn.UseVisualStyleBackColor = true;
            // 
            // new_prep_btn
            // 
            this.new_prep_btn.Location = new System.Drawing.Point(610, 27);
            this.new_prep_btn.Name = "new_prep_btn";
            this.new_prep_btn.Size = new System.Drawing.Size(108, 23);
            this.new_prep_btn.TabIndex = 18;
            this.new_prep_btn.Text = "New preparat";
            this.new_prep_btn.UseVisualStyleBackColor = true;
            this.new_prep_btn.Click += new System.EventHandler(this.new_prep_btn_Click);
            // 
            // prep_view_btn
            // 
            this.prep_view_btn.Location = new System.Drawing.Point(529, 27);
            this.prep_view_btn.Name = "prep_view_btn";
            this.prep_view_btn.Size = new System.Drawing.Size(75, 23);
            this.prep_view_btn.TabIndex = 19;
            this.prep_view_btn.Text = "Preparats";
            this.prep_view_btn.UseVisualStyleBackColor = true;
            this.prep_view_btn.Click += new System.EventHandler(this.prep_view_btn_Click);
            // 
            // ProcedureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 714);
            this.Controls.Add(this.prep_view_btn);
            this.Controls.Add(this.new_prep_btn);
            this.Controls.Add(this.new_proc_btn);
            this.Controls.Add(this.down_btw);
            this.Controls.Add(this.up_btn);
            this.Controls.Add(this.column_names_panel);
            this.Controls.Add(this.RenderGroupBox);
            this.Controls.Add(this.show_all_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.filter_txt);
            this.Controls.Add(this.title_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcedureView";
            this.Text = "Procedure View";
            this.column_names_panel.ResumeLayout(false);
            this.column_names_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button show_all_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox filter_txt;
        private System.Windows.Forms.GroupBox RenderGroupBox;
        private System.Windows.Forms.Panel column_names_panel;
        private System.Windows.Forms.TextBox desc_column_txt;
        private System.Windows.Forms.TextBox name_column_txt;
        private System.Windows.Forms.Button down_btw;
        private System.Windows.Forms.Button up_btn;
        private System.Windows.Forms.Button new_proc_btn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button new_prep_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button prep_view_btn;
    }
}