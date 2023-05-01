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
using System.Xml.Linq;

namespace ClientDatabaseCosmetology
{
    public partial class MainForm : Form
    {
        static List<string[]> entry_db = new List<string[]>();
        public static List<string[]> client_db = new List<string[]>();
        public static List<string[]> picture_db = new List<string[]>();

        public static string drive_letter = Directory.Exists(@"D:\") ? @"D:\" : @"C:\";
        public static string home_path = drive_letter + @"CosmetologyDB\";
        public static string images_path = home_path+@"Images\";
        public static string databases_path = home_path+@"Databases\";

        public static string entry_db_path = databases_path + @"entries.db";
        public static string clients_db_path = databases_path + @"clients.db";
        public static string pictures_db_path = databases_path + @"pictures.db";

        int max_entries_per_page = 11;
        int active_page = 0;

        int search_res = 0;

        bool filteres = false;
        public MainForm()
        {
            InitializeComponent();
            ReadLocalDatabases();
            up_btn.Enabled = false;
            search_res = entry_db.Count();
            if (active_page >= search_res - max_entries_per_page)
            {
                down_btw.Enabled = false;
            }
            RenderEntries();
        }



        public static void AddEntry(int client_id, string date, string ProcType, string Recomm, string photopath)
        {
            string name = client_db[client_id][0];
            string desc = client_db[client_id][1];
            
            picture_db.Insert(0, new string[] {photopath});
            entry_db.Insert(0, new string[] {name, desc, date, ProcType, Recomm, photopath });
            WriteLocalDatabases();
        }
        public static void NewClient(string name, string desc)
        {
            client_db.Add(new string[] { name, desc });
            WriteLocalDatabases();
        }
        public static int GetClientIndex(string name)
        {
            int ind = 0;
            foreach (string[] client in client_db)
            {
                if (CompareStrings(client[0], name))
                {
                    return ind;
                }
                ind++;
            }
            return -1;
        }
        public static int GetEntryIndex(string photopath)
        {
            int ind = 0;
            foreach (string[] entry in entry_db)
            {
                if (photopath == entry[5])
                {
                    return ind;
                }
                ind++;
            }
            return -1;
        }
        public static string WordWrap(string str, int max_line_size)
        {
            string[] words_arr = str.Split(' ');
            List<string> word_list = new List<string>();
            for(int i = 0;i < words_arr.Length;i++)
            {
                string word = words_arr[i];
                if (word == " " || word == "") { continue; }

                while (true) {
                    if (word.Length > max_line_size)
                    {
                        word_list.Add(word.Substring(0, max_line_size));
                        word = word.Substring(max_line_size);
                    } else
                    {
                        break;
                    }
                }
                word_list.Add(word);
            }
            string wrapped_string = "";
            string line = "";
            foreach(string word in word_list)
            {
                
                string new_line = line;
                new_line += word + " ";
                if(new_line.Length > max_line_size)
                {
                    wrapped_string += line + "\n";
                    line = word;
                }
                else
                {
                    line = new_line;
                }
                //Console.WriteLine(line + "   " + word);
            }
            if(line != "")
            {
                wrapped_string += line + "\n";
            }
            if (wrapped_string[0] == '\n')
            {
                wrapped_string = wrapped_string.Substring(1);
            }
            return wrapped_string;
        }
        public static bool CompareStrings(string str1, string str2)
        {
            return str1.ToLower().Contains(str2.ToLower()) || str2.ToLower().Contains(str1.ToLower());
        }
        public void RenderEntries()
        {
            int page = active_page;
            RenderGroupBox.Controls.Clear();

            int m = max_entries_per_page;
            if(entry_db.Count < m)
            {
                m = entry_db.Count();
            }
            int act_j = 0;
            for(int j = 0; act_j < m && j < entry_db.Count; j++)
            {
                int i = j + page;
                if (filteres)
                {
                    if (!CompareStrings(entry_db[i][0], filter_txt.Text))
                    {
                        continue;
                    }
                }

                Panel entry_panel = new Panel();
                Label val_1 = new Label();
                Label val_2 = new Label();
                Label val_3 = new Label();
                Label val_4 = new Label();
                Label val_5 = new Label();
                Label id = new Label();
                PictureBox pic1 = new PictureBox();

                id.Text = entry_db[i][5];
                id.Visible = false;

                entry_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                entry_panel.Location = new System.Drawing.Point(6, 19 + 49*act_j);
                entry_panel.Name = "default_entry_panel_" + j;
                entry_panel.Size = new System.Drawing.Size(601, 48);
                entry_panel.TabIndex = 0;

                val_1.AutoSize = true;
                val_1.Location = new System.Drawing.Point(12, 12);
                val_1.Name = "value_1_" + j;
                val_1.Size = new System.Drawing.Size(35, 13);
                val_1.TabIndex = 0;
                val_1.Text = WordWrap(entry_db[i][0], 18);

                val_2.AutoSize = true;
                val_2.Location = new System.Drawing.Point(100, 10);
                val_2.Name = "value_2_" + j;
                val_2.Size = new System.Drawing.Size(35, 13);
                val_2.TabIndex = 1;
                val_2.Text = WordWrap(entry_db[i][1], 18);

                val_3.AutoSize = true;
                val_3.Location = new System.Drawing.Point(200, 18);
                val_3.Name = "value_3_" + j;
                val_3.Size = new System.Drawing.Size(35, 13);
                val_3.TabIndex = 2;
                val_3.TextAlign = ContentAlignment.MiddleCenter;
                val_3.Text = entry_db[i][2];

                val_4.AutoSize = true;
                val_4.Location = new System.Drawing.Point(280, 18);
                val_4.Name = "value_4_" + j;
                val_4.Size = new System.Drawing.Size(35, 13);
                val_4.TabIndex = 2;
                val_4.TextAlign = ContentAlignment.MiddleCenter;
                val_4.Text = entry_db[i][3];

                val_5.AutoSize = true;
                val_5.Location = new System.Drawing.Point(380, 18);
                val_5.Name = "value_5_" + j;
                val_5.Size = new System.Drawing.Size(35, 13);
                val_5.TabIndex = 2;
                val_5.TextAlign = ContentAlignment.MiddleCenter;
                val_5.Text = entry_db[i][4];


                pic1.Location = new System.Drawing.Point(500, 3);
                pic1.Name = "pic1_"+j;
                pic1.Size = new System.Drawing.Size(45, 40);
                pic1.TabIndex = 3;
                pic1.TabStop = false;
                pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pic1.Click += new System.EventHandler(ViewEntryPics);
                pic1.Image = Image.FromFile(images_path + entry_db[i][5]);

                entry_panel.Controls.Add(id);
                entry_panel.Controls.Add(val_1);
                entry_panel.Controls.Add(val_2);
                entry_panel.Controls.Add(val_3);
                entry_panel.Controls.Add(val_4);
                entry_panel.Controls.Add(val_5);
                entry_panel.Controls.Add(pic1);

                RenderGroupBox.Controls.Add(entry_panel);
                act_j++;
            }
        }
        static void WriteLocalDatabases()
        {
            ClearLocalDatabases();
            {
                FileStream fs = new FileStream(entry_db_path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter writer = new StreamWriter(fs);
                foreach (string[] entry in entry_db)
                {
                    string line = "";
                    for (int i = 0; i < entry.Length; i++)
                    {
                        line += entry[i];
                        if (i == entry.Length - 1)
                        {
                            break;
                        }
                        line += "~";
                    }
                    writer.WriteLine(line);
                }
                writer.Close();
            }
            {
                FileStream fs = new FileStream(clients_db_path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter writer = new StreamWriter(fs);
                foreach (string[] client in client_db)
                {
                    string line = "";
                    for (int i = 0; i < client.Length; i++)
                    {
                        line += client[i];
                        if (i == client.Length - 1)
                        {
                            break;
                        }
                        line += "~";
                    }
                    writer.WriteLine(line);
                }
                writer.Close();
            }
            {
                FileStream fs = new FileStream(pictures_db_path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter writer = new StreamWriter(fs);
                foreach (string[] pic in picture_db)
                {
                    string line = "";
                    for (int i = 0; i < pic.Length; i++)
                    {
                        line += pic[i];
                        if (i == pic.Length - 1)
                        {
                            break;
                        }
                        line += "~";
                    }
                    writer.WriteLine(line);
                }
                writer.Close();
            }
        }
        static void ReadLocalDatabases()
        {
            ClearRamDatabases();
            {
                FileStream fs = new FileStream(entry_db_path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader reader = new StreamReader(fs);
                string line = "";
                while (true)
                {
                    line = reader.ReadLine();
                    if(line == "" || line == null)
                    {
                        break;
                    }
                    entry_db.Add(line.Split('~'));
                }
                reader.Close();
            }
            {
                FileStream fs = new FileStream(clients_db_path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader reader = new StreamReader(fs);
                string line = "";
                while (true)
                {
                    line = reader.ReadLine();
                    if (line == "" || line == null)
                    {
                        break;
                    }
                    client_db.Add(line.Split('~'));
                }
                reader.Close();
            }
            {
                FileStream fs = new FileStream(pictures_db_path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamReader reader = new StreamReader(fs);
                string line = "";
                while (true)
                {
                    line = reader.ReadLine();
                    if (line == "" || line == null)
                    {
                        break;
                    }
                    picture_db.Add(line.Split('~'));
                }
                reader.Close();
            }
        }
        static void ClearLocalDatabases()
        {
            {
                FileStream fs = new FileStream(entry_db_path, FileMode.Truncate, FileAccess.ReadWrite, FileShare.ReadWrite);
                fs.Close();
            }
            {
                FileStream fs = new FileStream(clients_db_path, FileMode.Truncate, FileAccess.ReadWrite, FileShare.ReadWrite);
                fs.Close();
            }
            {
                FileStream fs = new FileStream(pictures_db_path, FileMode.Truncate, FileAccess.ReadWrite, FileShare.ReadWrite);
                fs.Close();
            }
        }
        static void ClearRamDatabases()
        {
            entry_db.Clear();
            client_db.Clear();
            picture_db.Clear();
        }

        private void down_btw_Click(object sender, EventArgs e)
        {
            active_page++;
            RenderEntries();
            if (active_page > 0)
            {
                up_btn.Enabled = true;
            }
            if(active_page >= search_res - max_entries_per_page)
            {
                down_btw.Enabled = false;
            }
        }

        private void up_btn_Click(object sender, EventArgs e)
        {
            active_page--;
            RenderEntries();
            if(active_page <= 0)
            {
                up_btn.Enabled = false;
            }
            if (active_page < search_res - max_entries_per_page)
            {
                down_btw.Enabled = true;
            }
        }

        void up_down_btn_check()
        {
            if (active_page > 0)
            {
                up_btn.Enabled = true;
            }
            if (active_page >= search_res - max_entries_per_page)
            {
                down_btw.Enabled = false;
            }
            if (active_page <= 0)
            {
                up_btn.Enabled = false;
            }
            if (active_page < search_res - max_entries_per_page)
            {
                down_btw.Enabled = true;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            active_page = 0;
            search_res = 0;
            for(int i = 0; i < entry_db.Count; i++)
            {
                if (CompareStrings(entry_db[i][0], filter_txt.Text))
                {
                    search_res++;
                }
            }
            
            filteres = true;
            RenderEntries();
            up_down_btn_check();
        }

        private void ViewEntryPics(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Panel gr = (Panel)pictureBox.Parent;
            string entry_id = gr.Controls[0].Text;
            int entry_ind = GetEntryIndex(entry_id);
            PictureView pw = new PictureView(entry_ind);
            pw.ShowDialog();
        }

        private void show_all_btn_Click(object sender, EventArgs e)
        {
            active_page = 0;
            filteres = false;
            search_res = entry_db.Count();
            RenderEntries();
            up_down_btn_check();
        }

        private void new_entry_image_Click(object sender, EventArgs e)
        {
            NewEntryForm n = new NewEntryForm(this);
            n.ShowDialog();
        }

        private void new_client_btn_Click(object sender, EventArgs e)
        {
            NewClientForm n = new NewClientForm(this);
            n.ShowDialog();
        }
    }
}





/*
   static void WriteDataToDatabase()
        {
            ClearDatabases();
            int inc_app = 0;

            foreach (string[] app_dbs in database_paths)
            {
                if(inc_app == GetAppIndex("root"))
                {
                    inc_app++;
                    continue;
                }
                int inc_db = 0;
                foreach (string db_path in app_dbs)
                {
                    FileStream fs = new FileStream(databases_dir + db_path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                    StreamWriter writer = new StreamWriter(fs);
                    foreach (string[] item in databases[inc_app][inc_db])
                    {
                        string line_u = "";
                        for (int i = 0; i < item.Length; i++)
                        {
                            line_u += item[i];
                            if (i == item.Length - 1)
                            {
                                break;
                            }
                            line_u += "~";
                        }
                        writer.WriteLine(line_u);
                    }
                    writer.Close();
                    inc_db++;
                }
                inc_app++;
            }
        }
        static void ReadDataFromDatabase()
        {
            InitRAMDatabases();
            ClearRAMDatabases();
            

            int inc_app = 0;
            
            foreach (string[] app_dbs in database_paths)
            {
                int inc_db = 0;
                foreach (string db_path in app_dbs)
                {
                    FileStream fs = new FileStream(databases_dir + db_path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                    StreamReader reader = new StreamReader(fs);
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null || line == "")
                        {
                            break;
                        }
                        string[] param = line.Split('~');
                        databases[inc_app][inc_db].Add(param);
                    }
                    reader.Close();
                    inc_db++;
                }
                inc_app++;
            }
        }
*/
