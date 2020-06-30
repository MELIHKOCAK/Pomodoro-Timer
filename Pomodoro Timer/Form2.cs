using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro_Timer
{
    public partial class Form2 : Form
    {
        Form1 ab = new Form1();
        public Form2()
        {
            InitializeComponent();

        }
        
        public void Form2_Load(object sender, EventArgs e)
        {
            
        }
        
        private void seçeneklerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ab.Show();
            this.Hide();
            
        }
    }
}
