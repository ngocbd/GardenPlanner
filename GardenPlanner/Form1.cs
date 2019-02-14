using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GardenPlanner
{
    public partial class Form1 : Form
    {
        GrardenPicture thegrardenPicture = new GrardenPicture();
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
               

                thegrardenPicture.Dai = 2;
                thegrardenPicture.Rong = 3;
                thegrardenPicture.Hinh = Image.FromFile("tree.jpg");

                
            }
            catch (Exception ex)
            {
                
            }





        }

        private void Form1_clicked(object sender, EventArgs e)
        {
            //MessageBox.Show("Form 1 vua dc click ");
        }

        private void Form1_paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Red);
            Rectangle hinhchunhat = new Rectangle();
            hinhchunhat.Height = 200;
            hinhchunhat.Width = 500;
            hinhchunhat.X = 100;
            hinhchunhat.Y = 10;
            e.Graphics.DrawRectangle(myPen, hinhchunhat);
        }
    }
}
