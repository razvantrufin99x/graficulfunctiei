using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace graficulfunctiei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void drawlines()
        {

            for (int i = 1; i < 360; i++)
            {

                this.userControl11.g.DrawLine(this.userControl11.p, 1, i, i, 1);
                Refresh();

            }
        
        }
        private void button1_Click(object sender, EventArgs e)
        {

            
            this.userControl11.SetMode("LINE");
            
            this.userControl11.g.DrawEllipse(this.userControl11.p, 200, 200,100,100);
            Refresh();


        }
    }
}
