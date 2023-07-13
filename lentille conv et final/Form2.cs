using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lentille_conv_et_final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int width = 721; int height = 379;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int width = 721; int height = 379;
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 3);
            p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, width  / 2, 0,width  /2,height  /2);
            g.DrawLine(p, width /2 , height , width  / 2, height   / 2);
            g.DrawLine(p, width  , height   / 2, 0, height  / 2);
            Pen p1 = new Pen(Color.Black, 2);
            p1.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p1, 20, 10, 0, 10);
            Pen p2 = new Pen(Color.Black, 3);
            g.DrawEllipse(p2, label10.Location.X,  height / 2, 2, 2);
            g.DrawEllipse(p2, label11.Location.X,height   / 2, 2, 2);
            g.DrawLine(p, label12.Location.X, label13.Location.Y, label12.Location.X, height  / 2);
            ;
            p2.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int width = 721; int height = 379;
            label11.Location = new Point(width  / 2 - trackBar1.Value, label11.Location.Y);
            label10.Location = new Point(width  / 2 + trackBar1.Value, label10.Location.Y);
            label5.Text = trackBar1.Value.ToString();

            pictureBox1.Invalidate();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

            label12.Location = new Point(width / 2 - trackBar2.Value, label12.Location.Y);
            label13.Location = new Point(width / 2 - trackBar2.Value, label13.Location.Y);
            label6.Text = trackBar2.Value.ToString();
            label6.Visible = true;
            pictureBox1.Invalidate();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label13.Location = new Point(label13.Location.X, height  / 2 - trackBar3.Value);

            label7.Text = trackBar3.Value.ToString();

            pictureBox1.Invalidate();
            pictureBox1.Invalidate();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pen p9 = new Pen(Color.Coral, 3);
                p9.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

                System.Drawing.Pen myPen;
                myPen = new System.Drawing.Pen(System.Drawing.Color.RosyBrown, 3);
                System.Drawing.Graphics frmGraphics = pictureBox1.CreateGraphics();
                myPen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                frmGraphics.DrawLine(myPen, width  / 2, label13.Location.Y, label13.Location.X, label13.Location.Y);
                int oa;
                int y = (label13.Location.Y - height  / 2) / (width  / 2 - label10.Location.X) * width + (label13.Location.Y - (label13.Location.Y - height  / 2) / (width /label10.Location.X) * label10.Location.X);
                oa = (-trackBar1.Value * trackBar2.Value) / (-trackBar2.Value + trackBar1.Value);
                int ab = (oa * trackBar3.Value) / (trackBar2.Value);

                frmGraphics.DrawLine(myPen, label10.Location.X, height  / 2, width  / 2, label13.Location.Y);
                frmGraphics.DrawLine(myPen, width / 2 + oa, height / 2 + ab, width / 2, label13.Location.Y);
            }
            catch (Exception)
            {
                label16.Text = "Image a L'infinie";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Pen p11 = new Pen(Color.BurlyWood, 3);
                System.Drawing.Graphics rayon2 = pictureBox1.CreateGraphics();
                p11.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

                int ab;
                int oa;
                oa = (-trackBar1.Value * trackBar2.Value) / (-trackBar2.Value + trackBar1.Value);
                oa = (-trackBar1.Value * trackBar2.Value) / (-trackBar2.Value + trackBar1.Value);
                ab = (oa * trackBar3.Value) / (trackBar2.Value);


                rayon2.DrawLine(p11, label13.Location.X, label13.Location.Y, width  / 2 + oa, height / 2 + ab);
                oa = (label11.Location.X * label12.Location.X) / (label11.Location.X + label12.Location.X);
                ab = (oa * (height  / 2 - label13.Location.Y) / (label12.Location.X));
                rayon2.DrawLine(p11, label13.Location.X, label13.Location.Y, width  / 2, height  / 2);

            }
            catch (Exception)
            {
                label16.Text = "Image a L'infinie";
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {try { 

            Pen p11 = new Pen(Color.Brown, 3);
            System.Drawing.Graphics rayon2 = pictureBox1.CreateGraphics();
            p11.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            int ab;
            int oa;
            oa = (-trackBar1.Value * trackBar2.Value) / (-trackBar2.Value + trackBar1.Value);
            oa = (-trackBar1.Value * trackBar2.Value) / (-trackBar2.Value + trackBar1.Value);
            ab = (oa * trackBar3.Value) / (trackBar2.Value);



            rayon2.DrawLine(p11,label13.Location.X,label13.Location.Y, width / 2, height / 2 + ab);
            rayon2.DrawLine(p11, width  / 2,height / 2 + ab, width, height / 2 + ab);

            rayon2.DrawLine(p11,label13.Location.X,label13.Location.Y,label11.Location.X, height / 2);

            }
            catch (Exception)
            {
                label16.Text = "Image a L'infinie";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label12.Location.X == label11.Location.X)
            {
                label16.Text = "Pas d'image , image a l'infinie";

            }
            else
               if (label12.Location.X < label11.Location.X / 2)
            {
                label16.Text = "Image reelle , inversee , plus petite ";

            }
            else if (label12.Location.X == label11.Location.X / 2)
            {
                label16.Text = "Reelle , inversee et de meme grandeur";

            }
            else
            if ((label12.Location.X > label11.Location.X / 2) && (label12.Location.X <label11.Location.X))
            {
                label16.Text = " Image reelle, inversee , plus grande  ";
                
            }
            else

      if ( (label12.Location.X >label11.Location.X) &&(label12.Location.X <label9.Location.X))
            {
                label16.Text = " Image virtuelle , Droitr , et plus grande ";
                

            }
            System.Drawing.Graphics Image = pictureBox1.CreateGraphics();
            int ab;
            int oa;
            Pen p12 = new Pen(Color.Black, 3);
            oa = (-trackBar1.Value * trackBar2.Value) / (-trackBar2.Value + trackBar1.Value);
            ab = (oa * trackBar3.Value) / (trackBar2.Value);
            p12.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            Image.DrawLine(p12, width  / 2 + oa, height / 2 + ab, width / 2 + +oa, height / 2
                );

            label17.Text = "Taille de A'B'=" + Math.Abs(ab).ToString();

            label15.Location = new Point(width / 2 + oa, height / 2);
            label15.Visible = true;
            label14.Location = new Point(width  / 2 + oa, height 
                / 2 + ab);
            label14.Visible = true;
            
      label18 .Text = "Distance de L'image  ="+ Math.Abs(oa).ToString();



        }
    }
}
