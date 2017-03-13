using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BertScoutView
{
    public partial class FormTeamPix : Form
    {
        public FormTeamPix()
        {
            InitializeComponent();
        }

        public FormTeamPix(string picPath)
        {
            InitializeComponent();
            if (File.Exists(picPath))
            {
                Image pix = Image.FromFile(picPath);
                pictureBoxTeam.Image = pix;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
