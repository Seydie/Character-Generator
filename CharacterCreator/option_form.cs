﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class option_form : Form
    {
        generate_form Fgenerate = new generate_form();
        public option_form()
        {
            InitializeComponent();
        }

        public void bnext_Click(object sender, EventArgs e)
        {
            var exclude_c = exclude_classes.CheckedItems;
            var exclude_r = exclude_races.CheckedItems;
            var exclude_p = exclude_professions.CheckedItems;
            this.Hide();
            Fgenerate.exclude_c = exclude_c;
            Fgenerate.exclude_r = exclude_r;
            Fgenerate.exclude_p = exclude_p;
            Fgenerate.Generate();
            Fgenerate.ShowDialog();
            this.Close();
        }

        private void Bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
