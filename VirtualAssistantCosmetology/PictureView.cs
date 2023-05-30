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
    public partial class PictureView : Form
    {
        static string[] images;
        int image_num = 0;
        public PictureView(int entry_id)
        {
            InitializeComponent();
            images = MainForm.picture_db[entry_id];
            pic_box_1.Image = Image.FromFile(MainForm.images_path + images[image_num]);
        }

        private void left_btn_Click(object sender, EventArgs e)
        {
            image_num--;
            if(image_num < 0)
            {
                image_num = images.Length - 1;
            }
            pic_box_1.Image = Image.FromFile(MainForm.images_path + images[image_num]);
        }

        private void right_btn_Click(object sender, EventArgs e)
        {
            image_num++;
            if(image_num > images.Length - 1)
            {
                image_num = 0;
            }
            pic_box_1.Image = Image.FromFile(MainForm.images_path + images[image_num]);
        }
    }
}
