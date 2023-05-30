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
    public partial class ClientEditor : Form
    {
        static int client_ind;
        static ClientView cw;
        public ClientEditor(int client_ind_, ClientView cw_)
        {
            client_ind = client_ind_;
            cw = cw_;
            InitializeComponent();

            name_txtbox.Text = MainForm.client_db[client_ind][0];
            desc_txtbox.Text = MainForm.client_db[client_ind][1];


        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < MainForm.entry_db.Count; i++)
            {
                if (MainForm.entry_db[i][0] == MainForm.client_db[client_ind][0])
                {
                    MainForm.entry_db[i][0] = name_txtbox.Text;
                    MainForm.entry_db[i][1] = desc_txtbox.Text;
                }
            }
            MainForm.client_db[client_ind][0] = name_txtbox.Text;
            MainForm.client_db[client_ind][1] = desc_txtbox.Text;
            this.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            List<string[]> list = new List<string[]>();
            List<string[]> list2 = new List<string[]>();
            for (int i = 0; i < MainForm.entry_db.Count; i++)
            {
                if (MainForm.client_db[client_ind][0] != MainForm.entry_db[i][0])
                {
                    list.Add(MainForm.entry_db[i]);
                    list2.Add(MainForm.picture_db[i]);
                }
            }
            MainForm.entry_db = list;
            MainForm.picture_db = list2;
            MainForm.client_db.RemoveAt(client_ind);
            
            
            this.Close();
        }
    }
}
