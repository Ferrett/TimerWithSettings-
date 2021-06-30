using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp20 {
    public partial class Form1 : Form {
        private Timer timer = new Timer();
        public Form1() {
            InitializeComponent();

            timer.Interval = 5;
            timer.Tick += Timer_Tick;
            timer.Start();
            panel1.BackColor = Color.Cyan;
        }

        private void Timer_Tick(object sender, EventArgs e) {
            labelTime.Text =$"{DateTime.Now.Hour.ToString()}:{DateTime.Now.Minute.ToString()}";
        }
    }
}
