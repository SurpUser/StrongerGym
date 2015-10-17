﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StrongerGym.R;
namespace StrongerGym
{
    public partial class StrongerGymForm : Form
    {
        public StrongerGymForm()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroForm rf = new RegistroForm();
            rf.MdiParent = this;
            rf.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarForm c = new ConsultarForm();
            c.MdiParent = this;
            c.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracoinForm configuracion = new ConfiguracoinForm();
            configuracion.ShowDialog();
        }
    }
}
