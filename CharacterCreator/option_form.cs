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

        public option_form()
        {
            InitializeComponent();
        }

        public void bnext_Click(object sender, EventArgs e)
        {
            this.Hide();
            generate_form Fgenerate = new generate_form();
            Fgenerate.ShowDialog();
            this.Close();
        }

        public void variable(object sender, EventArgs e)
        {
            string test = "Test werkt";
        }
    }
}
