﻿using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agron
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void movimientosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormMovimientoBancario fm = new FormMovimientoBancario();
            fm.Show();

        }
    }
}
