using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Form1 : Form
    {
        int n=100; // number of iterations
        int zPow = 2; // Power of z function;
        double c_re = -0.511;
        double c_im = 0.541;
        bool setToDefault = false;
        bool generateRandom = false;
        bool renderMandelbrot = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zBox.Text = 2.ToString();
        }
        private double ParseToDouble(string s)
        {
            var sourceValue = s;
            double doubleValue;
            if (double.TryParse(sourceValue, out doubleValue))
            {
                return doubleValue;
            }
            else
            {

                return -100;
            }
        }
        private void render_Click(object sender, EventArgs e)
        {
            if (nBox.Text == string.Empty || zBox.Text==string.Empty) return;
            n = Int32.Parse(nBox.Text);
            zPow = Int32.Parse(zBox.Text);
            if (renderMandelbrot)
                DrawMandelbrot(n,zPow);
            else DrawJulia(n,zPow);
        }
        private void DrawMandelbrot(int n, int zPow = 2)
        {
            
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int x = 0; x < pictureBox1.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Height; y++)
                {
                    Complex z = new Complex(0, 0);
                    double re = (double)(x - (pictureBox1.Width / 2)) / (double)(pictureBox1.Width / 4);
                    double im = (double)(y - (pictureBox1.Height / 2)) / (double)(pictureBox1.Height / 4);
                    Complex c = new Complex(re, im);
                    int iteration = 0;

                    while (iteration <= n && z.GetModulus() < 2)
                    {
                        iteration++;
                        Complex zValue = z;
                        for (int i = 0; i < zPow - 1; i++)
                        {
                            z *= zValue;
                        }
                        z += c;

                    }
                    //Color edgeColor = (iteration <= n / (4) ? Color.Black : Color.Red);
            
                    bm.SetPixel(x, y, iteration < n ? Color.FromArgb(iteration%128*2,iteration%32*7,iteration%16*14) : Color.Black);
                }
            }
            pictureBox1.Image = bm;
        }


        private void DrawJulia(int n, int zPow)
        {
           
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Complex c = new Complex();
            for (int x = 0; x < pictureBox1.Width; x++)
            {
                
                for (int y = 0; y < pictureBox1.Height; y++)
                {
                    double re = (double)(x - (pictureBox1.Width / 2)) / (double)(pictureBox1.Width / 4);
                    double im = (double)(y - (pictureBox1.Height / 2)) / (double)(pictureBox1.Height / 4);

                    if (setToDefault)
                        c = new Complex(c_re, c_im);
                    else if (generateRandom)
                    {
                        Random rnd = new Random();
                        double a = rnd.NextDouble() * rnd.Next(-1, 1);
                        if (a == 0)
                            a=  rnd.NextDouble() * rnd.Next(-1, 1);
                        double b = rnd.NextDouble() * rnd.Next(-1, 1);
                        if (b == 0)
                            a = rnd.NextDouble() * rnd.Next(-1, 1);
                        c = new Complex(a,b);
                        UpdateView(c);
                        generateRandom = false;
                        return;
                     }
                    else
                    {
                        double a = ParseToDouble(ReBox.Text);
                        double b = ParseToDouble(ImBox.Text);

                        if (a == -100 || b == -100)
                        {
                            MessageBox.Show("Invalid double input. Try ',' instead of '.'\n");
                            return;
                        }
                        else
                            c = new Complex(a, b);
                    }
                  
                    Complex z = new Complex(re, im);
                    int iteration = 0;

                    while (iteration <= n && z.GetModulus() < 2)
                    {
                        iteration++;
                        Complex zValue = z;
                        for (int i = 0; i < zPow - 1; i++)
                        {
                            z *= zValue;
                        }
                        z += c;

                    }
                    bm.SetPixel(x, y, iteration < n ? Color.FromArgb(iteration % 128 * 2, iteration % 32 * 7, iteration % 16 * 14) : Color.Black);

                }
            }
            UpdateView(c);
            setToDefault = false;
            pictureBox1.Image = bm;
        }

        private void juliaSwitch_MouseDown(object sender, MouseEventArgs e)
        {
            renderMandelbrot = false;
            ReBox.ReadOnly = false;
            ImBox.ReadOnly = false;
            defaultBtn.Visible = true;
            randomBtn.Visible = true;
        }

        private void mandelSwitch_MouseDown(object sender, MouseEventArgs e)
        {
            renderMandelbrot = true;
            ReBox.ReadOnly = true;
            ImBox.ReadOnly = true;
            ReBox.Text = string.Empty;
            ImBox.Text = string.Empty;
            defaultBtn.Visible = false;
            randomBtn.Visible = false;
        }

        private void defaultBtn_Click(object sender, EventArgs e)
        {
            setToDefault = true;
            zPow = 2;
            DrawJulia(n, zPow);
        }
        private void UpdateView(Complex c)
        {
            zBox.Text = zPow.ToString();
            ReBox.Text = c.Re.ToString();
            ImBox.Text = c.Im.ToString();
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            generateRandom = true;
            DrawJulia(n, zPow);
        }
    }
}
