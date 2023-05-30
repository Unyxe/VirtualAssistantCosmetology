namespace VirtualAssistantCosmetology
{
    partial class NewPreparatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPreparatForm));
            this.add_preparat_btn = new System.Windows.Forms.Button();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.nm_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.price_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minimal_unit_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_preparat_btn
            // 
            this.add_preparat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.add_preparat_btn.Location = new System.Drawing.Point(12, 162);
            this.add_preparat_btn.Name = "add_preparat_btn";
            this.add_preparat_btn.Size = new System.Drawing.Size(360, 53);
            this.add_preparat_btn.TabIndex = 42;
            this.add_preparat_btn.Text = "Add Preparat";
            this.add_preparat_btn.UseVisualStyleBackColor = true;
            this.add_preparat_btn.Click += new System.EventHandler(this.add_preparat_btn_Click);
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(126, 63);
            this.name_txtbox.MaxLength = 30;
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(246, 20);
            this.name_txtbox.TabIndex = 39;
            // 
            // nm_lbl
            // 
            this.nm_lbl.AutoSize = true;
            this.nm_lbl.Location = new System.Drawing.Point(38, 66);
            this.nm_lbl.Name = "nm_lbl";
            this.nm_lbl.Size = new System.Drawing.Size(76, 13);
            this.nm_lbl.TabIndex = 38;
            this.nm_lbl.Text = "Preparat name";
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title_lbl.Location = new System.Drawing.Point(12, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(180, 31);
            this.title_lbl.TabIndex = 37;
            this.title_lbl.Text = "New Preparat";
            // 
            // price_txtbox
            // 
            this.price_txtbox.Location = new System.Drawing.Point(126, 115);
            this.price_txtbox.MaxLength = 30;
            this.price_txtbox.Name = "price_txtbox";
            this.price_txtbox.Size = new System.Drawing.Size(246, 20);
            this.price_txtbox.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Preparat price (£)";
            // 
            // minimal_unit_txtbox
            // 
            this.minimal_unit_txtbox.Location = new System.Drawing.Point(126, 89);
            this.minimal_unit_txtbox.MaxLength = 30;
            this.minimal_unit_txtbox.Name = "minimal_unit_txtbox";
            this.minimal_unit_txtbox.Size = new System.Drawing.Size(246, 20);
            this.minimal_unit_txtbox.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Minimal unit (ml, etc.)";
            // 
            // NewPreparatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 227);
            this.Controls.Add(this.minimal_unit_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_preparat_btn);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.nm_lbl);
            this.Controls.Add(this.title_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPreparatForm";
            this.Text = "New Preparat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_preparat_btn;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label nm_lbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox price_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minimal_unit_txtbox;
        private System.Windows.Forms.Label label2;
    }
}