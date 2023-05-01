using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDatabaseCosmetology
{
    public partial class NewClientForm : Form
    {
        MainForm mainForm;
        public NewClientForm(MainForm mainForm_)
        {
            InitializeComponent();
            mainForm = mainForm_;
        }

        private void add_client_btn_Click(object sender, EventArgs e)
        {
            string name = name_txtbox.Text;
            string desc = desc_txt.Text.Replace("\n", " ").Replace(Environment.NewLine, " ");
            MainForm.NewClient(name, desc);
            this.Close();
        }
    }
}
