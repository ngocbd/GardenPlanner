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
        // Bo 3 cay co san di
        GrardenPicture thegrardenPicture = new GrardenPicture();
        GrardenPicture thegrardenPicture2 = new GrardenPicture();
        GrardenPicture thegrardenPicture3 = new GrardenPicture();
        // tao array o day
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
               

                thegrardenPicture.Dai = 2;
                thegrardenPicture.Rong = 3;
            thegrardenPicture.Toado = new Point(0, 0);
            thegrardenPicture2.Toado = new Point(300, 300);
            thegrardenPicture3.Toado = new Point(600, 0);
            thegrardenPicture.Hinh = Image.FromFile("CAY1.png");
            thegrardenPicture2.Hinh = Image.FromFile("CAY2.png");
            thegrardenPicture3.Hinh = Image.FromFile("CAY3.png");




            this.DoubleBuffered = true;



        }

        private void Form1_clicked(object sender, EventArgs e)
        {
            //MessageBox.Show("Form 1 vua dc click ");
        }

        private void Form1_paint(object sender, PaintEventArgs e)
        {
            // Ve hinh chu nhat bao ngoai cua vuon cay
            Pen myPen = new Pen(Color.Red);
            Rectangle hinhchunhat = new Rectangle();
            hinhchunhat.Height = 200;
            hinhchunhat.Width = 500;
            hinhchunhat.X = 100;
            hinhchunhat.Y = 10;
            e.Graphics.DrawRectangle(myPen, hinhchunhat);
            thegrardenPicture.Draw(e.Graphics);
            thegrardenPicture2.Draw(e.Graphics);
            thegrardenPicture3.Draw(e.Graphics);

        }

        private void Button1Click(object sender, EventArgs e)
        {
            // ve them 1 cai cay
            MessageBox.Show("Test");
        }
    }
}
