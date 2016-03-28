using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace train
{
   
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        public Human h1=new Human();

        public double ROMA1 = 3; // для 1 шкалы
        public double ROMA2 = 1; //для 2 шкалы
        //public double ROMA3 = 1; //  а это лучше не трогать

        double[] ii = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double[] jj = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double[] kk = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double[] tt = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double[] pp = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double[] ee = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double[] ee2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        public double noise(double krit)
        {
            Random r=new Random();
            double d = (r.NextDouble() - 0.5)*trackBar2.Value/100*2*krit/ROMA1;
            //label15.Text = d.ToString();
            return d;
        }
        void push()
        {
            for (int j = 0; j < ii.Length - 1; j++)
            {
                ii[j] = ii[j + 1];
                jj[j] = jj[j + 1];
                tt[j] = tt[j + 1];
                pp[j] = pp[j + 1];
                kk[j] = kk[j + 1];
                ee[j] = ee[j + 1];
                ee2[j] = ee2[j + 1];
            }
            ii[ii.Length - 1] = h1.geter();
            jj[jj.Length - 1] = h1.geter2();
            tt[tt.Length - 1] = h1.t1 ;
            pp[pp.Length - 1] = h1.pr1;
            ee[ee.Length - 1] = h1.e;
            ee2[ee2.Length - 1] = h1.e2;
            kk[kk.Length - 1] = h1.p3 ;
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = Convert.ToString(hScrollBar1.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = Convert.ToString(hScrollBar2.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label3.Text = Convert.ToString(hScrollBar3.Value);
        }
        public int Noise3(int disp)
        {
            Random r=new Random();
            int i=r.Next(-disp/2, disp/2);
            return i;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //label7.Text = Convert.ToString(h1.pr1);
            h1.seter(Noise3(trackBar4.Value), Noise3(trackBar4.Value),
                Noise3(trackBar4.Value), Noise3(trackBar4.Value));
            h1.update();
            push();
            pictureBox1.Refresh();
            pictureBox2.Refresh();
            pictureBox3.Refresh();
            pictureBox4.Refresh();
            label10.Text = ii[ii.Length - 1].ToString() + " " + jj[ii.Length - 1].ToString() + " " +
                           kk[ii.Length - 1].ToString() + " ";
            //label15.Text=h1.p1.ToString();
            //if (ii[ii.Length - 1] > h1.kp1
            //     || jj[jj.Length - 1] > h1.kp2
            //    || tt[tt.Length - 1] > h1.kt1)
            //{
            //   timer1.Enabled = false;
            //   MessageBox.Show("you dead");
            //   Close();

            // }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawLine(Pens.Crimson, 0, 15, pictureBox4.Width, 15);
            Font hFont = new Font("Arial", 10, FontStyle.Regular);
            //e.Graphics.DrawString("critical level", hFont, Brushes.Crimson, 7, 20);
            //e.Graphics.DrawLine(Pens.Green, 0, pictureBox4.Height - 60, pictureBox4.Width, pictureBox4.Height - 60);
            //e.Graphics.DrawString("good level", hFont, Brushes.Green, 500, 75);
            Pen q = new Pen(Color.Brown, 3);
            int phase = 0;
            int dph=(int)pictureBox1.Width/(ii.Length-1);
            if (ii[ii.Length - 1] > h1.kp1 - 15)
                pictureBox1.BackColor = Color.Gray;
            else
            {
                pictureBox1.BackColor = Color.LightPink;
            }
            int h = pictureBox1.Height-2;
            double k1;
            double k2;
            for (int j = 0; j < ii.Length-1; j++)
            {
                k1 = 1-ii[j]/h1.kp1;//отнистельная шкала
                k2 = 1-ii[j+1] / h1.kp1;
                e.Graphics.DrawLine(q, phase,Convert.ToInt32(h*k1), phase + dph,Convert.ToInt32(h*k2));
                phase += dph;
            }

        }

        public int Noise2(double krit=1000)
        {
            Random r = new Random();
            double d = (r.NextDouble() - 0.5) * trackBar3.Value / 100 * 2 * krit/ROMA2;
            //.Text = d.ToString();
            return (int)d;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            h1.seter(Convert.ToInt32(label1.Text)+Noise2(),
                    Convert.ToInt32(label2.Text)+Noise2(),
                    Convert.ToInt32(label3.Text) + Noise2(),
                     Convert.ToInt32(label13.Text) + Noise2());
        }
   

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawLine(Pens.Crimson, 0, 15, pictureBox4.Width, 15);
            Font hFont = new Font("Arial", 10, FontStyle.Regular);
            //e.Graphics.DrawString("critical level", hFont, Brushes.Crimson, 7, 20);
            //e.Graphics.DrawLine(Pens.Green, 0, pictureBox4.Height - 60, pictureBox4.Width, pictureBox4.Height - 60);
            //e.Graphics.DrawString("good level", hFont, Brushes.Green, 500, 75);
            int h = pictureBox2.Height - 2;
            int phase = 0;
            int dph = (int)pictureBox1.Width / (jj.Length - 1);
            if (jj[jj.Length - 1] > h1.kp2-15)
                pictureBox2.BackColor = Color.Gray;
            else
            {
                pictureBox2.BackColor = Color.LightPink;
            }
            double k1;
            double k2;
            Pen q = new Pen(Color.Brown, 3);
            for (int j = 0; j < ii.Length - 1; j++)
            {
                k1 = 1 - jj[j] / h1.kp2;//отнистельная шкала
                k2 = 1 - jj[j + 1] / h1.kp2;
                e.Graphics.DrawLine(q, phase, Convert.ToInt32(h * k1), phase + dph, Convert.ToInt32(h * k2));
                phase += dph;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawLine(Pens.Crimson, 0, 55, pictureBox3.Width, 55);
            Font hFont = new Font("Arial", 10, FontStyle.Regular);
            //e.Graphics.DrawString("critical level", hFont, Brushes.Crimson, 7, 60);
            //e.Graphics.DrawLine(Pens.Green, 0, pictureBox3.Height - 30, pictureBox3.Width, pictureBox3.Height - 30);
            //e.Graphics.DrawString("good level", hFont, Brushes.Green, pictureBox3.Width - 80, pictureBox3.Height-25);

            int h = pictureBox3.Height - 2;
            int phase = 0;
            int dph = (int)pictureBox3.Width / (tt.Length - 1);
            if (tt[tt.Length - 1] > h1.kt1-80)
                pictureBox3.BackColor = Color.White;
            else
            {
                pictureBox3.BackColor = Color.White;
            }
            double k1;
            double k2;
            Pen p=new Pen(Color.SpringGreen,3);
            
            Pen q = new Pen(Color.Brown, 3);
            Pen f = new Pen(Color.SlateBlue, 3);
            Pen ff = new Pen(Color.DeepPink, 3);
            e.Graphics.DrawLine(p, 30, 20, 60, 20);
            e.Graphics.DrawString("Ймовірність Гепатиту С", hFont, Brushes.Black, 35, 20);
            e.Graphics.DrawLine(q, 30, 40, 60, 40);
            e.Graphics.DrawString("рівень норми", hFont, Brushes.Black, 35, 40);
            e.Graphics.DrawLine(f, 30, 60, 60, 60);
            e.Graphics.DrawString("Ймовірність метаболічного гепатиту", hFont, Brushes.Black, 35, 60);
            e.Graphics.DrawLine(ff, 30, 80, 60, 80);
            e.Graphics.DrawString("Ймовірність гіпертензії", hFont, Brushes.Black, 35, 80);

            for (int j = 0; j < tt.Length - 1; j++)
            {
                k1 = 1 - pp[j];//отнистельная шкала
                k2 = 1 - pp[j + 1];
                e.Graphics.DrawLine(p, phase, Convert.ToInt32(h * k1), phase + dph, Convert.ToInt32(h * k2));
                k1 = 1 - tt[j] / h1.kt1;//отнистельная шкала
                k2 = 1 - tt[j + 1] / h1.kt1;
                e.Graphics.DrawLine(q, phase, Convert.ToInt32(h * k1), phase + dph, Convert.ToInt32(h * k2));
                k1 = 1 - ee[j] / h1.ke;//отнистельная шкала
                k2 = 1 - ee[j + 1] / h1.ke;
               // label10.Text = k2.ToString() + " " + h1.e.ToString();
                e.Graphics.DrawLine(f, phase, Convert.ToInt32(h * k1), phase + dph, Convert.ToInt32(h * k2));
                
                k1 = 1 - ee[j] / h1.ke;//отнистельная шкала
                k2 = 1 - ee[j + 1] / h1.ke;
                //label10.Text = k2.ToString() + " " + h1.e.ToString();
                e.Graphics.DrawLine(f, phase, Convert.ToInt32(h * k1), phase + dph, Convert.ToInt32(h * k2));
                k1 = 1 - ee2[j] / h1.ke2;//отнистельная шкала
                k2 = 1 - ee2[j + 1] / h1.ke2;
                //label10.Text = k2.ToString() + " " + h1.e.ToString();
                e.Graphics.DrawLine(ff, phase, Convert.ToInt32(h * k1), phase + dph, Convert.ToInt32(h * k2));
                phase += dph;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create the MATLAB instance 
            MLApp.MLApp matlab = new MLApp.MLApp();

            // Change to the directory where the function is located 
            //matlab.Execute(@"cd c:\temp\example");
            matlab.Execute(@"cd c:\temp\example");
            // Define the output 
            object result = null;
            double []f=new double[4]{1,1,1,1};

            double[,] A = new double[6, 4] { { 0, 0.022, -0.088,0.022 }, 
                                             { -0.0376, 0.0094, 0, 0 },
                                             {0.1692,-0.1692, 0, -0.5076},
                                             { 0, -0.022, 0.088, 0 },
                                             { 0.0376, -0.0094, 0, 0 },
                                             {-0.1692, 0.1692, 0, 0.5076}};
            //double[] B = new double[6] { 60-h1.p1, 15-h1.p2,500-h1.p3,20-h1.p1,0-h1.p2,200-h1.p3 };
            double[] B = new double[6] { 50 - h1.p1, 10 - h1.p2, 400 - h1.p3, 
                                        -1*(30 - h1.p1), -1*(0 - h1.p2), -1*(300 - h1.p3) };
            double[] lb = new double[4] { 0, 0, 0,0 };
            double[] ub = new double[4] { 3000, 3000, 3000, 3000};

            
            f[0] = Convert.ToDouble(f2.textBox1.Text);
            f[1] = Convert.ToDouble(f2.textBox2.Text);
            f[2] = Convert.ToDouble(f2.textBox3.Text);
            f[3] = Convert.ToDouble(f2.textBox15.Text);

            A[0, 0] = Convert.ToDouble(f2.textBox4.Text);
            A[0, 1] = Convert.ToDouble(f2.textBox5.Text);
            A[0, 2] = Convert.ToDouble(f2.textBox6.Text);
            A[0, 3] = Convert.ToDouble(f2.textBox16.Text);
            
            A[1, 0] = Convert.ToDouble(f2.textBox7.Text);
            A[1, 1] = Convert.ToDouble(f2.textBox8.Text);
            A[1, 2] = Convert.ToDouble(f2.textBox9.Text);
            A[1, 3] = Convert.ToDouble(f2.textBox17.Text);

            A[2, 0] = Convert.ToDouble(f2.textBox18.Text);
            A[2, 1] = Convert.ToDouble(f2.textBox19.Text);
            A[2, 2] = Convert.ToDouble(f2.textBox20.Text);
            A[2, 3] = Convert.ToDouble(f2.textBox21.Text);

            A[3, 0] = Convert.ToDouble(f2.textBox22.Text);
            A[3, 1] = Convert.ToDouble(f2.textBox23.Text);
            A[3, 2] = Convert.ToDouble(f2.textBox24.Text);
            A[3, 3] = Convert.ToDouble(f2.textBox25.Text);

            A[4, 0] = Convert.ToDouble(f2.textBox26.Text);
            A[4, 1] = Convert.ToDouble(f2.textBox27.Text);
            A[4, 2] = Convert.ToDouble(f2.textBox28.Text);
            A[4, 3] = Convert.ToDouble(f2.textBox29.Text);

            A[5, 0] = Convert.ToDouble(f2.textBox30.Text);
            A[5, 1] = Convert.ToDouble(f2.textBox31.Text);
            A[5, 2] = Convert.ToDouble(f2.textBox32.Text);
            A[5, 3] = Convert.ToDouble(f2.textBox33.Text);
            
            B[0] = Convert.ToDouble(f2.textBox10.Text)-h1.p1;
            B[1] = Convert.ToDouble(f2.textBox11.Text)-h1.p2;
            B[2] = Convert.ToDouble(f2.textBox34.Text) - h1.p3;
            B[3] = -1*(Convert.ToDouble(f2.textBox35.Text) - h1.p1);
            B[4] = -1*(Convert.ToDouble(f2.textBox36.Text) - h1.p2);
            B[5] = -1*(Convert.ToDouble(f2.textBox37.Text) - h1.p3);

            ub[0] = Convert.ToDouble(f2.textBox12.Text);
            ub[1] = Convert.ToDouble(f2.textBox13.Text);
            ub[2] = Convert.ToDouble(f2.textBox14.Text);
            ub[3] = Convert.ToDouble(f2.textBox38.Text);
             
            // Call the MATLAB function myfunc
            matlab.Feval("AidProg", 2, out result,
                f,A,B,lb,ub);
            
            
            //label7.Text=
            // Display result 
            object[] res = result as object[];
            //double outt =new double[3,2];
            //outt = Convert.ToDouble(res[0]);
            double[,] res2 = res[0] as double[,];
            if (res2 != null)
            {
                label4.Text = res2[0, 0].ToString("N");
                label5.Text = res2[1, 0].ToString("N");
                label6.Text = res2[2, 0].ToString("N");
                label14.Text = res2[3, 0].ToString("N");
            }
            //label4.Text = Convert.ToString(Convert.ToDouble(res[0])[0, 0]);
            //label4.Text = Convert.ToString((double)(res[0])[0, 0]);

            //label10.Text = res[0].ToString() + " \n" + res[1].ToString() + "  \n";
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
            
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawLine(Pens.Crimson, 0,15,pictureBox4.Width,15 );
            Font hFont=new Font("Arial",10,FontStyle.Regular);
           // e.Graphics.DrawString("critical level", hFont, Brushes.Crimson, 7, 20);
            //e.Graphics.DrawLine(Pens.Green, 0, pictureBox4.Height - 60, pictureBox4.Width, pictureBox4.Height -60);
            //e.Graphics.DrawString("good level",hFont,Brushes.Green,500,75);
            int h = pictureBox4.Height - 2;
            int phase = 0;
            int dph = (int) pictureBox4.Width/(kk.Length - 1);
            if (kk[kk.Length - 1] > 0.85*h1.kp2)
                pictureBox4.BackColor = Color.Gray;
            else
            {
                pictureBox4.BackColor = Color.LightPink;
            }
            double k1;
            double k2;
            Pen p = new Pen(Color.SpringGreen, 3);
            Pen q = new Pen(Color.Brown, 3);
            for (int j = 0; j < tt.Length - 1; j++)
            {
                k1 = 1 - kk[j] / h1.kp3;//отнистельная шкала
                k2 = 1 - kk[j + 1] / h1.kp3;
                e.Graphics.DrawLine(q, phase, Convert.ToInt32(h * k1), phase + dph, Convert.ToInt32(h * k2));
                phase += dph;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double [,]diagnisis=new double[3,3]
            {
                {4,23,630},
                {105,47,0},
                {76,33,840}
            };
            Random ch = new Random();
            
            int temp;

            temp = ch.Next(0,3);
            //h1.t1 = 150;
            int[] ii = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] jj = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] kk = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] tt = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] pp = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //h1.pr1 = 80;
            h1.p1 = diagnisis[temp,0];
            h1.p2 = diagnisis[temp, 1];
            h1.p3 = diagnisis[temp, 2];
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
            //h1.sp1 = Convert.ToDouble(f2.textBox12.Text);
            //h1.sp2 = Convert.ToDouble(f2.textBox13.Text);
            //h1.sp3 = Convert.ToDouble(f2.textBox14.Text);
            
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            label13.Text = hScrollBar4.Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MLApp.MLApp matlab = new MLApp.MLApp();

            // Change to the directory where the function is located 
            //matlab.Execute(@"cd c:\temp\example");
            matlab.Execute(@"cd c:\temp\example");
            // Define the output 
            object result = null;
            // Call the MATLAB function myfunc
            matlab.Feval("FforDiag", 1, out result, 1);


            //label7.Text=
            // Display result 
            object[] res = result as object[];
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label15.Text = trackBar2.Value.ToString() + "%";
            h1.rand = trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label16.Text = trackBar3.Value.ToString()+"%";
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label17.Text = trackBar4.Value.ToString()+" од.";
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
    public class Human
    {
        public double rand = 0;

        double[] ur1 = new double[4];
        double[] ur2 = new double[4];
        double[] ur3 = new double[4];

        public double k = 1;

        public double kp1 = 110;
        public double p1 = 76;// блокада микроциркуляції'
        public double sp1 = 1.1;

        public double kp2 = 47;
        public double p2 = 33;//тромбопластичні речовини
        public double sp2 = 0.47;

        public double kp3 = 846;
        public double p3 = 840;//некроз тканини
        public double sp3 = 8.46;

        public double kt1 = 1;
        public double t1 = 150;//норма    
        public double st1 = 5;

        public double kpr1 = 1;
        public double pr1 = 0;//гангрена
        public double spr1 = 5;

        public double ke = 1;
        public double e = 0;//лімфаденіт
        public double se = 5;

        public double ke2 = 1;
        public double e2 = 0;//ДВС
        public double se2 = 5;

        public double pre1=0;
        public double pre2=0;
        public double pre3=0;
        public double pre4=0;



        public void seter(double incr1, double incr2, double incr3,double incr4)
        {
            pre1 = pre1 + incr1;
            pre2 = pre2 + incr2;
            pre3 = pre3 + incr3;
            pre4 = pre4 + incr4;
            //p2 += incr2;
            //p3 += incr3;
        }

        public void update()
        {

            Random realRnd = new Random();  
            double K = 100;
            /*
            p1 = p1 + sp1/10+noise(kp1);
            p2 = p2 + sp2 / 10 + noise(kp2);
            p3 = p3 + sp3/10+noise(kp3);
             * */
            p1 = p1  + noise(kp1);
            p2 = p2  + noise(kp2);
            p3 = p3  + noise(kp3);
            // Create the MATLAB instance 
            MLApp.MLApp matlab = new MLApp.MLApp();

            // Change to the directory where the function is located 
            //matlab.Execute(@"cd c:\temp\example");
            matlab.Execute(@"cd c:\temp\example");
            // Define the output 
            object result = null;
            // Call the MATLAB function myfunc
            matlab.Feval("MyEval", 1, out result,
                p1,p2,p3);


            //label7.Text=
            // Display result 
            object[] res = result as object[];
            //label10.Text = res[0].ToString() + " \n" + res[1].ToString() + "  \n";
            double[,] res2 = res[0] as double[,];
            t1 = res2[0, 0];
            pr1 = res2[0,1];
            e = res2[0, 2];
            e2 = res2[0, 3];
            double dpre1=0;
            double dpre2 = 0;
            double dpre3 = 0;
            double dpre4 = 0;
            if (pre1 > 100)
            {
                dpre1 = 100;
                pre1 = pre1 - 100;
            }
            else
            {
                dpre1 = pre1;
                pre1 = 0;
            }
            if (pre2 > 100)
            {
                dpre2 = 100;
                pre2 = pre2 - 100;
            }
            else
            {
                dpre2 = pre2;
                pre2 = 0;
            }
            if (pre3 > 100)
            {
                dpre3 = 100;
                pre3 = pre3 - 100;
            }
            else
            {
                dpre3 = pre3;
                pre3 = 0;
            }
            if (pre4 > 100)
            {
                dpre4 = 100;
                pre4 = pre4 - 100;
            }
            else
            {
                dpre4 = pre4;
                pre4 = 0;
            }
            // p1 = p1 - 5/K*pre1 + 1/K*pre2 - 2/k*pre3 + 2/K*pre4;
           // p2 = p2 - 3 / K * pre1 + 6 / K * pre2 - 3 / k * pre3 + 2 / K * pre4;
           // p3 = p3 - 3.5/ K * pre1 + 2 / K * pre2 + 3 / k * pre3 - 3 / K * pre4;
            double op1 = kp1/100;
            double op2 = kp2 / 100;
            double op3 = kp3 / 100;
            
            p1 = p1 + op1 * 2 / K * dpre2 - op1 * 8 / K * dpre3 + op1*2 / K * dpre4;
            p2 = p2 - op2*8 / K * dpre1 + op2*2 / K * dpre2  ;
            p3 = p3 + op3 * 2 / K * dpre1 - op3 * 2 / K * dpre2 - op3*6 / K * dpre4;
            
            /*
            p1 = p1 + op1*2/K*dpre2 - op1*8/K*dpre3;
            p2 = p2 - op2 * 8 / K * dpre1 ;
            p3 = p3   - op3 * 6 / K * dpre4;
             */
            if (p1 < 0)
                p1 = 0;
            if (p2 < 0)
                p2 = 0;
            if (p3 < 0)
                p3 = 0;
            if (p1 > kp1)
                p1 = kp1*0.95;
            if (p2 > kp2)
                p2 = kp2*0.95;
            if (p3 > kp3)
                p3 = kp3*0.95;
        }

        public double geter()
        {
            return p1;
        }
        public double geter2()
        {
            return p2;
        }
        public double noise(double krit)
        {
            Random r = new Random();
            double d = (r.NextDouble() - 0.5) * rand / 100 * 2 * krit;
            //.Text = d.ToString();
            return d;
        }
    }


}
