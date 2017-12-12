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
        string[] ArrayHrace = { "Orc", "Troll", "Goblin", "Undead", "Blood Elf", "Tauren", "Panda" };
        Dictionary<string, string[]> dict_races = new Dictionary<string, string[]>()
        {
          {"Human", new string[] {"Warrior", "Monk"}},
          {"Dwarf", new string[] {"Warrior", "Hunter"}},
          {"Gnome", new string[] {"Priest", "Mage", "Warlock" , "Death Knight", "Hunter"}},
          {"Draenei", new string[] {"Mage"}},
          {"Worgen", new string[] {"Rogue", "Death Knight", "Mage"}},
          {"Night Elf", new string[] {"Warrior", "Druid", "Demon Hunter"}},
          {"Orc", new string[] {"Warrior", "Hunter", "Death Knight"}},
          {"Troll", new string[] {"Priest", "Hunter"}},
          {"Goblin", new string[] {"Shaman" }},
          {"Undead", new string[] {"Rogue"}},
          {"Blood Elf", new string[] {"Warrior", "Rogue", "Demon Hunter", "Mage", "Warlock"}},
          {"Tauren", new string[] {"Paladin", "Druid", "Death Knight"}},
          {"Panda", new string[] {"Warrior", "Monk", "Priest", "Hunter"}}
        };

        Dictionary<string, string[]> dict_specalisation = new Dictionary<string, string[]>()
        {
            {"Warrior", new string[] {"Fury"}},
            {"Paladin", new string[] {"Retribution", "Holy"}},
            {"Hunter", new string[] {"Beast Mastery"}},
            {"Rogue", new string[] {"Assassin"}},
            {"Shaman", new string[] {"Fury"}},
            {"Mage", new string[] {"Frost", "Fire", "Arcane"}},
            {"Priest", new string[] {"Fury"}},
            {"Warlock", new string[] {"Fury"}},
            {"Monk", new string[] {"Fury"}},
            {"Druid", new string[] {"Feral"}},
            {"Death Knight", new string[] {"Fury"}},
            {"Demon Hunter", new string[] {"Havoc"}}
        };


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

            string Random_Alliance_Race = ArrayArace[random.Next(ArrayArace.Length)];
            string Random_Horde_Race = ArrayHrace[random.Next(ArrayHrace.Length)];
            string[] Race_Array = { Random_Alliance_Race, Random_Horde_Race };
            string Random_Race = Race_Array[random.Next(Race_Array.Length)];
            Grace.Text = Random_Race;

            if (ArrayArace.Contains(Random_Race))
            {
                Gfaction.Text = "Alliance";
            }
            if (ArrayHrace.Contains(Random_Race))
            {
                Gfaction.Text = "Horde";
            }



        }
    }
}
