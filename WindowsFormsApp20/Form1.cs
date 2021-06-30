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
            button1.Click += Button1_Click;
        }

        public void ChangeFontColor() {
            using (ColorDialog dialog = new ColorDialog()) {

                if (dialog.ShowDialog() == DialogResult.OK) {
                    labelTime.ForeColor = dialog.Color;
    
                }

            }
        }

        public void ChangePanelColor() {
            using (ColorDialog dialog = new ColorDialog()) {

                if (dialog.ShowDialog() == DialogResult.OK) {
                    panel1.BackColor = dialog.Color;

                }

            }
        }

        private void Button1_Click(object sender, EventArgs e) {
            Settings settings = new Settings(this);
            settings.ShowDialog();
            
           
        }

        private void Timer_Tick(object sender, EventArgs e) {
            labelTime.Text =$"{DateTime.Now.Hour.ToString()}:{DateTime.Now.Minute.ToString()}";
        }
    }
}
