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

namespace VirtualAssistantCosmetology
{
    public partial class NewEntryForm : Form
    {
        List<string> pictures_path = new List<string>();
        static int check_ind = 0;
        string v = "";
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
            if (v == "") return;
            int client_ind = MainForm.GetClientIndex(v, check_ind);
            if (client_ind == -1)
            {
                name_txtbox.Text = "";
                return;
            }
            check_ind++;
            name_txtbox.Text = MainForm.client_db[client_ind][0];
        }

        private void pic_brows_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pic_txt.Text = openFileDialog1.FileName;
            pictures_path.Add(pic_txt.Text);

            RenderPictures();
            
        }
        void ClearPictures()
        {
            List<PictureBox> pictures = new List<PictureBox>();
            foreach (object c in this.Controls)
            {
                //Console.WriteLine(c.GetType());
                if (c.GetType() == typeof(PictureBox))
                {

                    PictureBox pictureBo = (PictureBox)c;

                    if (pictureBo.Name.StartsWith("pb"))
                    {
                        //Console.WriteLine(pictureBo.Name);
                        pictures.Add(pictureBo);
                    }
                }
            }
            foreach(PictureBox p in pictures)
            {
                this.Controls.Remove(p);
            }
        }
        void RenderPictures()
        {

            ClearPictures();

            this.Size = new Size(450, 293);
            this.add_entry_btn.Location = new Point(12, 194);
            int py = 204-110;
            for (int i = 0; i < pictures_path.Count; i++)
            {
                //Console.WriteLine(pictures_path[i]);
                if (i % 4 == 0)
                {
                    this.Size = new Size(this.Size.Width, this.Size.Height+110);
                    this.add_entry_btn.Location = new Point(this.add_entry_btn.Location.X, this.add_entry_btn.Location.Y + 110);
                    py += 110;
                }
                PictureBox pbox = new PictureBox();
                pbox.Location = new System.Drawing.Point(16 + 100*(i%4), py);
                pbox.Name = "pb" + i;
                pbox.Size = new System.Drawing.Size(95, 95);
                pbox.TabIndex = 25;
                pbox.TabStop = false;
                pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pbox.Image = Image.FromFile(pictures_path[i]);
                pbox.Click += Pbox_Click;
                this.Controls.Add(pbox);
            }
        }

        private void Pbox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int ind = Int32.Parse(pictureBox.Name.Substring(2));
            pictures_path.RemoveAt(ind);
            
            RenderPictures();
        }

        private void add_entry_btn_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            string p = rn.Next() + ".png";
            File.Copy(pic_txt.Text, MainForm.images_path + p);
            List<string> cop_pic_paths = new List<string>();
            foreach (string pic in pictures_path)
            {
                string pic_n = rn.Next() + ".png";
                File.Copy(pic, MainForm.images_path + pic_n);
                cop_pic_paths.Add(pic_n);
            }
            MainForm.AddEntry(MainForm.GetClientIndex(name_txtbox.Text, 0), date_txt.Text, proc_txt.Text, rec_txt.Text, p, cop_pic_paths.ToArray());
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

        private void name_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (name_txtbox.Focused)
            {
                v = name_txtbox.Text;
                check_ind = 0;
            }
        }

        private void procedure_check_btn_Click(object sender, EventArgs e)
        {
            if (v == "") return;
            int proc_ind = MainForm.GetProcIndex(v, check_ind);
            if (proc_ind == -1)
            {
                proc_txt.Text = "";
                return;
            }
            check_ind++;
            proc_txt.Text = MainForm.procedures_db[proc_ind][0];
        }

        private void proc_txt_TextChanged(object sender, EventArgs e)
        {
            if (proc_txt.Focused)
            {
                v = proc_txt.Text;
                check_ind = 0;
            }
        }
    }
}
