using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20 {
    public partial class Settings : Form {

        Form1 form1;
        public Settings(Form1 f) {
            InitializeComponent();
            form1 = f;
            changeFormColorButton.Click += ChangeFormColorButton_Click;
            changePanelColorButton.Click += ChangePanelColorButton_Click;
            changeFontColorButton.Click += ChangeFontColorButton_Click; ;
        }

        private void ChangeFontColorButton_Click(object sender, EventArgs e) {
            form1.ChangeFontColor(); 
        }

        private void ChangePanelColorButton_Click(object sender, EventArgs e) {
            form1.ChangePanelColor();
        }

        private void ChangeFormColorButton_Click(object sender, EventArgs e) {
           using(ColorDialog dialog = new ColorDialog()) {

                if(dialog.ShowDialog() == DialogResult.OK) {
                    form1.BackColor = dialog.Color;
                }

           }
        }
    }
}
