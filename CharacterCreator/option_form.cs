using System;
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

        public void bnext_Click(object sender, EventArgs e)
        {
            var exclude_c = exclude_classes.SelectedItems;
            this.Hide();
            Fgenerate.test = test;
            Fgenerate.exclude_c = exclude_c;
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
