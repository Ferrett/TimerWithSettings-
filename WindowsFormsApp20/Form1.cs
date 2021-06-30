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
        private bool showHours = false;
        private bool showMinutes = true;
        private bool showSeconds = true;
        private bool showMiliseconds = false;
        public Form1() {
            InitializeComponent();

            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start();
            panel1.BackColor = Color.Cyan;
            button1.Click += Button1_Click;
            
        }

        public void ShowHours() {
            showHours = !showHours;
        }
        public void ShowMinutes() {
            showMinutes = !showMinutes;
        }
        public void ShowSeconds() {
            showSeconds = !showSeconds;
        }
        public void ShowMiliseconds() {
            showMiliseconds = !showMiliseconds;
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

            labelTime.Text = $"{(showHours ? DateTime.Now.Hour.ToString() : "")}{(showMinutes ? " " + DateTime.Now.Hour.ToString() : "")}" +
                $"{(showSeconds ? " " + DateTime.Now.Second.ToString() : "")} {(showMiliseconds ? " " + DateTime.Now.Millisecond.ToString() : "")}";
        }

    }
}
