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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int width = 721; int height = 379;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int width = 721; int height = 379;
            Graphics g = e.Graphics;
            Pen p1 = new Pen(Color.Black, 10);
            Pen p3 = new Pen(Color.Black, 3);
            p3.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            p1.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p1, width  / 2, 20, width  / 2, 0);
            Pen p2 = new Pen(Color.Black, 3);
            g.DrawLine(p2,width  / 2, 10, width  / 2, height  - 10);
            g.DrawLine(p1, width  / 2, height - 20, width  / 2,height  );
            g.DrawLine(p3, width, height / 2, 0, height / 2);
            Pen p = new Pen(Color.Black ,3);
            p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            g.DrawLine(p, 20, 10, 0, 10);
            Pen p4 = new Pen(Color.Black , 3);
            g.DrawEllipse(p4,width / 2, height / 2, 2, 2);
            g.DrawEllipse(p4, label11.Location.X, height / 2, 2, 2);
            g.DrawEllipse(p4, label10.Location.X, height / 2, 2, 2);
            g.DrawEllipse(p4, label12.Location.X, pictureBox1.Height, 2, 2);
            g.DrawEllipse(p4, label13.Location.X, label13.Location.Y, 2, 2);
            g.DrawLine(p3, label13.Location.X, label13.Location.Y, label12.Location.X, height / 2);
            p4.Dispose();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            label10.Location = new Point(width / 2 - trackBar1.Value, label10.Location.Y);
            label11.Location = new Point(width / 2 + trackBar1.Value, label11.Location.Y);
            label6.Text = trackBar1.Value.ToString();
            pictureBox1.Invalidate();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label12.Location = new Point(width / 2 - trackBar2.Value,height / 2);
            label13.Location = new Point(width / 2 - trackBar2.Value, label13.Location.Y);
            label7 .Text = trackBar2.Value.ToString();
            
            pictureBox1.Invalidate();

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

            label13.Location = new Point(label13.Location.X, height / 2 - trackBar3.Value);
            label14.Text = trackBar3.Value.ToString();
           
            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {try
            {
                int oa, ab;
                System.Drawing.Graphics rayon1 = pictureBox1.CreateGraphics();
                oa = (trackBar1.Value * trackBar2.Value) / (trackBar1.Value - trackBar2.Value);
                ab = (-trackBar3.Value * oa) / trackBar2.Value;
                Pen p5 = new Pen(Color.Red, 3);
                p5.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                rayon1.DrawLine(p5, width / 2, label13.Location.Y, label13.Location.X, label13.Location.Y);
                //rayon1.DrawLine(p5, width / 2 + oa, height / 2 + ab,width / 2, label10.Location.Y);
                //rayon1.DrawLine(p5, width / 2 - 10, label10.Location.Y - 10, width / 2, label10.Location.Y);
                rayon1.DrawLine(p5, label10.Location.X, height / 2, width / 2, label13.Location.Y);
                rayon1.DrawLine(p5, width / 2 + oa, height / 2 + ab, width / 2, label13.Location.Y);
            }catch (Exception )
            {
                label16.Text = "Image a l'infinie";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int oa, ab;
            System.Drawing.Graphics rayon2 = pictureBox1.CreateGraphics();
            oa = (trackBar2.Value * trackBar1.Value) / (-trackBar1.Value - trackBar2.Value);
            ab = (trackBar3.Value * oa) / trackBar2.Value;
            Pen p6 = new Pen(Color.Bisque , 3);
            p6.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            rayon2.DrawLine(p6, width / 2, height / 2, label13.Location.X, label13.Location.Y);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int oa, ab;
            System.Drawing.Graphics rayon2 = pictureBox1.CreateGraphics();
            oa = (trackBar2.Value * trackBar1.Value) / (-trackBar1.Value - trackBar2.Value);
            ab = (trackBar3.Value * oa) / trackBar2.Value;
            Pen p6 = new Pen(Color.Aquamarine, 3);
            p6.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            rayon2.DrawLine(p6, width / 2 + oa, height / 2 + ab, width / 2 + oa,height / 2);
            label15.Location = new Point(width / 2 + oa, height / 2);
            label15.Visible = true; 
            label2.Location = new Point(width / 2 + oa, height / 2 + ab);
            label2.Visible = true;

            label16.Text = "Image Virtuelle , droite , et plus petie";




            label17.Text = " taille de A'B' =" + Math.Abs(oa).ToString(); 
           
         
            label18.Text =" distance de l'image " +Math.Abs(ab).ToString();
           
        }
    }
}
