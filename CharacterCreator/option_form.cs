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

        private void bnext_Click(object sender, EventArgs e)
        {
            generate_form Fgenerate = new generate_form();
            Fgenerate.Show();
        }
    }
}
