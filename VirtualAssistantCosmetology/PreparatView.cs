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
    public partial class PreparatView : Form
    {
        public static List<string[]> preparat_db;
        static int max_entries_per_page = 11;
        static int active_page = 0;
        static int search_res = 0;

        static bool filteres = false;
        static PreparatView this_;
        static MainForm main_form;

        public PreparatView(MainForm mainForm)
        {
            //Console.WriteLine(String.Compare("Vicky Daubaraite", "Karolina Kutkaite"));
            this_ = this;
            main_form = mainForm;

            InitializeComponent();


            SyncWithMainForm();

        }
        static void SyncWithMainForm()
        {
            active_page = 0;
            string[][] buff = new string[MainForm.preparats_db.Count][];
            MainForm.preparats_db.CopyTo(buff);
            preparat_db = buff.ToList();
            preparat_db = SortList(preparat_db);
            search_res = preparat_db.Count();
            CheckBtnsBounds();
            RenderEntries();
        }
        static List<string[]> SortList(List<string[]> input)
        {
            string[][] buff = new string[input.Count][];
            input.CopyTo(buff);
            input = buff.ToList();
            List<string[]> rs = new List<string[]>();
            preparat_db.Clear();
            for (int i = 0; i < input.Count; i++)
            {
                int ind = 0;
                for (int j = 0; j < rs.Count; j++)
                {
                    if (String.Compare(rs[j][0], input[i][0]) == 1 && (j == rs.Count - 1 ? true : String.Compare(rs[j + 1][0], input[i][0]) == -1)) { ind = j + 1; break; }
                }
                rs.Insert(ind, input[i]);
            }
            rs.Reverse();
            return rs;
        }

        public static void RenderEntries()
        {
            if (this_ == null) return;
            int page = active_page;
            this_.RenderGroupBox.Controls.Clear();

            int m = max_entries_per_page;
            if (preparat_db.Count < m)
            {
                m = preparat_db.Count();
            }
            int act_j = 0;
            for (int j = 0; act_j < m && j < preparat_db.Count; j++)
            {
                int i = j + page;
                if (filteres)
                {
                    if (!MainForm.CompareStrings(preparat_db[i][0], this_.filter_txt.Text))
                    {
                        continue;
                    }
                }

                Panel entry_panel = new Panel();
                Label val_1 = new Label();
                Label val_2 = new Label();
                Label val_3 = new Label();
                Button edit_btn = new Button();

                entry_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                entry_panel.Location = new System.Drawing.Point(6, 19 + 49 * act_j);
                entry_panel.Name = "default_entry_panel_" + j;
                entry_panel.Size = new System.Drawing.Size(470, 48);
                entry_panel.TabIndex = 0;

                val_1.AutoSize = true;
                val_1.Location = new System.Drawing.Point(12, 12);
                val_1.Name = "value_1_" + j;
                val_1.Size = new System.Drawing.Size(35, 13);
                val_1.TabIndex = 0;
                val_1.Text = MainForm.WordWrap(preparat_db[i][0], 25);

                val_2.AutoSize = true;
                val_2.Location = new System.Drawing.Point(130, 10);
                val_2.Name = "value_2_" + j;
                val_2.Size = new System.Drawing.Size(35, 13);
                val_2.TabIndex = 1;
                val_2.Text = MainForm.WordWrap(preparat_db[i][1], 30);

                val_3.AutoSize = true;
                val_3.Location = new System.Drawing.Point(310, 10);
                val_3.Name = "value_3_" + j;
                val_3.Size = new System.Drawing.Size(35, 13);
                val_3.TabIndex = 1;
                val_3.Text = "£"+preparat_db[i][2];

                edit_btn.AutoSize = true;
                edit_btn.Location = new System.Drawing.Point(380, 10);
                edit_btn.Name = "edit_btn_" + j + ":" + i;
                edit_btn.TabIndex = 1;
                edit_btn.Text = "Edit";
                edit_btn.Click += this_.Edit_btn_Click;

                entry_panel.Controls.Add(val_1);
                entry_panel.Controls.Add(val_2);
                entry_panel.Controls.Add(val_3);
                entry_panel.Controls.Add(edit_btn);

                this_.RenderGroupBox.Controls.Add(entry_panel);
                act_j++;
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int id = Int32.Parse(button.Name.Split(':')[1]);
            for (int i = 0; i < MainForm.preparats_db.Count; i++)
            {
                if (preparat_db[id][0] == MainForm.preparats_db[i][0])
                {
                    id = i; break;
                }
            }

            //ClientEditor clientEditor = new ClientEditor(id, this_);
            //clientEditor.ShowDialog();

            SyncWithMainForm();
            main_form.RenderEntries();

            MainForm.WriteLocalDatabases();
        }

        static void CheckBtnsBounds()
        {
            if (active_page > 0)
            {
                this_.up_btn.Enabled = true;
            }
            if (active_page >= search_res - max_entries_per_page)
            {
                this_.down_btw.Enabled = false;
            }
            if (active_page <= 0)
            {
                this_.up_btn.Enabled = false;
            }
            if (active_page < search_res - max_entries_per_page)
            {
                this_.down_btw.Enabled = true;
            }
        }
        private void up_btn_Click(object sender, EventArgs e)
        {
            active_page--;
            RenderEntries();
            CheckBtnsBounds();
        }

        private void down_btn_Click(object sender, EventArgs e)
        {

            active_page++;
            RenderEntries();
            CheckBtnsBounds();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            active_page = 0;
            search_res = 0;
            for (int i = 0; i < preparat_db.Count; i++)
            {
                if (MainForm.CompareStrings(preparat_db[i][0], filter_txt.Text))
                {
                    search_res++;
                }
            }

            filteres = true;
            RenderEntries();
            CheckBtnsBounds();
        }

        private void show_all_btn_Click(object sender, EventArgs e)
        {
            active_page = 0;
            filteres = false;
            search_res = preparat_db.Count();
            RenderEntries();
            CheckBtnsBounds();
        }

        private void new_prep_btn_Click(object sender, EventArgs e)
        {
            NewPreparatForm n = new NewPreparatForm(main_form);
            n.ShowDialog();
            SyncWithMainForm();
        }
    }
}
