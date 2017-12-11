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
    public partial class generate_form : Form
    {
        option_form Foption = new option_form();
        public option_form frm1;
        public generate_form()
        {
            InitializeComponent();
            Generate();
        }
        public void Generate()
        {
            Foption.Test = test;
            // lol.variable();
            // Gname.Text = ((option_form)frm1).variable.test;
        }
    }
}
