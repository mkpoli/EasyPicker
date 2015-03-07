using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EasyPicker {
    public partial class frmMain : Form {
        Configuration config = new Configuration(Application.StartupPath + "/EasyPicker.xml");
        public frmMain() {
            InitializeComponent();
        }

        private void btnSpawn_Click(object sender, EventArgs e) {
            config.s = int.Parse(txtS.Text);
            config.e = int.Parse(txtE.Text);
            int rand = new Random().Next(config.s, config.e + 1);
            lblOut.Text = rand.ToString();
            lblName.Text = config.name[rand];
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e) {
            config.saveConfig();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            txtS.Text = config.s.ToString();
            txtE.Text = config.e.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            Process.Start(config.filename);
        }


    }
}
