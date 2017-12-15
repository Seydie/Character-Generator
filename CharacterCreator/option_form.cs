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
            //Values passing to Generate_Form
            var exclude_c = exclude_classes.CheckedItems;
            var exclude_r = exclude_races.CheckedItems;
            var exclude_p = exclude_professions.CheckedItems;
            string Tnamebox = Tname.Text;
            bool check_realm = checkbox_realm.Checked;
            var Rpvprealm = radio_pvprealm;
            var Rpverealm = radio_pverealm;
            var Rbothrealm = radio_bothrealm;
            //End passing

            this.Hide();
            Fgenerate.exclude_c = exclude_c;
            Fgenerate.exclude_r = exclude_r;
            Fgenerate.exclude_p = exclude_p;
            Fgenerate.Tnamebox = Tnamebox;
            Fgenerate.checkbox_realm = checkbox_realm;
            Fgenerate.Rpvprealm = Rpvprealm;
            Fgenerate.Rpverealm = Rpverealm;
            Fgenerate.Rbothrealm = Rbothrealm;
            Fgenerate.Generate();
            Fgenerate.ShowDialog();
            this.Close();
        }

        private void Bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkbox_realm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_realm.Checked)
            {
                radio_pvprealm.Enabled = true;
                radio_pverealm.Enabled = true;
                radio_bothrealm.Enabled = true;
            }
            else
            {
                radio_pvprealm.Enabled = false;
                radio_pverealm.Enabled = false;
                radio_bothrealm.Enabled = false;
            }
        }
    }
}
