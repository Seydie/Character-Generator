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
        string test = "lol";
        generate_form Fgenerate = new generate_form();
        public option_form()
        {
            InitializeComponent();
        }
        public string Test
        {

            get; set;
        }

        public void bnext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fgenerate.ShowDialog();
            this.Close();
        }

        public void variable(object sender, EventArgs e)
        {
            string test = "Test werkt";
        }
    }
}
