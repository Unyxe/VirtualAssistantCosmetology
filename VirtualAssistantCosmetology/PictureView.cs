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
    }
}
