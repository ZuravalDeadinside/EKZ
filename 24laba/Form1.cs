using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24laba
{
   
    public partial class Form1 : Form
    {
        Thermometr t1 = new Thermometr();
        public Form1()

        {
            InitializeComponent();

            textBox1.Text = t1.t_.ToString();
            progressBar1.Value = Convert.ToInt16(t1.t_) + 50;
            textBox2.Text = Convert.ToString(Convert.ToInt16(t1.t_) * 9 / 5 + 32);
            t1.tChanged += new Thermometr.d(tChanged);
        }
        public void tChanged()
        {
            if (t1.t_ < 0)
                label3.Text = "Похоладало " + "Температура " + t1.t_.ToString();
            else
                label3.Text = "Потеплело " + "Температура +" + t1.t_.ToString(); 
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = " ";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random r = new Random();
            t1.t_ = r.Next(-50, 50);

            textBox1.Text = Convert.ToString(t1.t_);
            textBox2.Text = Convert.ToString(Convert.ToInt16(t1.t_) * 9 / 5 + 32);

            progressBar1.Value = Convert.ToInt16(t1.t_) + 50;
        }
    }
}
