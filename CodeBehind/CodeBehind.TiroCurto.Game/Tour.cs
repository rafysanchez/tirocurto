﻿using System;
using System.Windows.Forms;

namespace CodeBehind.TiroCurto.Game
{
    public partial class frmTour : Form
    {
        public frmTour()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            new frmGameStart().ShowDialog();
            this.Close();
        }
    }
}
