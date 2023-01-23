using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZıplayanTop_2_
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {   // form tarih ekledik
            InitializeComponent();
            

        }
        // Formun içne timer atadık içinde saymayda devam ediyor ve 2 saniye sonra form kapanıyor
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            
            Corner.Text = now.ToString("HH:mm:ss.fff");

            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
