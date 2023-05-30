using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualAssistantCosmetology
{
    public partial class NewPreparatForm : Form
    {
        MainForm mainForm;
        public NewPreparatForm(MainForm mainForm_)
        {
            mainForm = mainForm_;
            InitializeComponent();
        }

        private void add_preparat_btn_Click(object sender, EventArgs e)
        {
            double price;
            if(Double.TryParse(price_txtbox.Text, out price))
            {
                MainForm.preparats_db.Add(new string[] {name_txtbox.Text, minimal_unit_txtbox.Text, price+""});
                mainForm.RenderEntries();
                MainForm.RenderAllForms();
                this.Close();
            }
            
        }
    }
}
