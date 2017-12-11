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
        static Random random = new Random();
        string[] Arraygender = { "Male", "Female" };
        string[] Arrayclass = { "Warrior", "Paladin", "Hunter", "Rogue", "Shaman", "Monk", "Mage", "Warlock", "Priest", "Druid", "Death Knight", "Demon Hunter" };
        string[] ArrayArace = { "Human", "Dwarf", "Gnome", "Draenei", "Worgen", "Night Elf" };
        string[] ArrayHrace = { "Orc", "Troll", "Goblin", "Undead", "Blood Elf", "Tauren" };
        

        public option_form frm1;
        public string test;
        public generate_form()
        {
            InitializeComponent();
        }
        public void Generate()
        {
            Ggender.Text = Arraygender[random.Next(Arraygender.Length)];
            Gclass.Text = Arrayclass[random.Next(Arrayclass.Length)];
            string testt = ArrayArace[random.Next(ArrayArace.Length)];
            string testt2 = ArrayHrace[random.Next(ArrayHrace.Length)];
            string[] testt3 = { testt, testt2 };
            Grace.Text = testt3[random.Next(testt3.Length)];



        }
    }
}
