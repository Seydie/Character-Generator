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
        public option_form frm1;
        public generate_form()
        {
            InitializeComponent();
        }
        public void Generate()
        {
            Gname.Text = ((option_form)frm1).variable;
        }
    }
}
