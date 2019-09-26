using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1._2_AP1.UI;

using Parcial1._2_AP1.Entidades;


namespace Parcial1._2_AP1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
          rEvaluacion ev = new rEvaluacion();
           ev.MdiParent = this;
           ev.Show();
        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}

