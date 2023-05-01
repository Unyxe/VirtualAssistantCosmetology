using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDatabaseCosmetology
{
    public partial class NewEntryForm : Form
    {
        MainForm mainForm;
        public NewEntryForm(MainForm mainform)
        {
            mainForm = mainform;
            InitializeComponent();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.Title = "Browse Pictures";
        }

        private void check_client_btn_Click(object sender, EventArgs e)
        {
            int client_ind = MainForm.GetClientIndex(name_txtbox.Text);
            if (client_ind == -1)
            {
                name_txtbox.Text = "";
                return;
            }
            name_txtbox.Text = MainForm.client_db[client_ind][0];
        }

        private void pic_brows_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pic_txt.Text = openFileDialog1.FileName;
        }

        private void add_entry_btn_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            string p = rn.Next() + ".png";
            File.Copy(pic_txt.Text, MainForm.images_path + p);
            MainForm.AddEntry(MainForm.GetClientIndex(name_txtbox.Text), date_txt.Text, proc_txt.Text, rec_txt.Text, p);
            mainForm.RenderEntries();
            this.Close();
        }

        private void today_btn_Click(object sender, EventArgs e)
        {
            date_txt.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void date_txt_Leave(object sender, EventArgs e)
        {
            if (date_txt.Text == "") return;
            try
            {
                DateTime.Parse(date_txt.Text);
            }
            catch
            {
                date_txt.Text = "";
            }
        }
    }
}
