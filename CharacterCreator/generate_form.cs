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
          {"Human", new string[] {"Warrior", "Paladin", "Hunter", "Rogue", "Priest", "Mage", "Warlock", "Monk", "Death Knight"}},
          {"Dwarf", new string[] {"Warrior", "Paladin", "Hunter", "Rogue", "Priest", "Shaman", "Mage", "Warlock", "Monk", "Death Knight"}},
          {"Night Elf", new string[] {"Warrior", "Hunter", "Rogue", "Priest", "Mage", "Monk", "Druid", "Demon Hunter", "Death Knight"}},
          {"Gnome", new string[] {"Warrior", "Hunter", "Rogue", "Priest", "Mage", "Warlock", "Monk", "Death Knight"}},
          {"Draenei", new string[] {"Warrior", "Paladin", "Hunter", "Priest", "Shaman", "Mage", "Monk", "Death Knight"}},
          {"Worgen", new string[] {"Warrior", "Hunter", "Rogue", "Priest", "Mage", "Warlock", "Druid", "Death Knight"}},
          {"Orc", new string[] {"Warrior", "Hunter", "Rogue", "Shaman", "Mage", "Warlock", "Monk", "Death Knight"}},
          {"Undead", new string[] {"Warrior", "Humter","Rogue", "Priest", "Mage", "Warlock", "Monk", "Death Knight"}},
          {"Tauren", new string[] {"Warrior", "Paladin", "Hunter", "Priest", "Shaman", "Monk", "Druid", "Death Knight"}},
          {"Troll", new string[] {"Warrior", "Hunter", "Rogue", "Priest", "Shaman", "Mage", "Warlock", "Monk", "Druid", "Death Knight"}},
          {"Blood Elf", new string[] {"Warrior", "Paladin", "Hunter", "Rogue", "Priest", "Mage", "Warlock", "Monk", "Demon Hunter", "Death Knight"}},
          {"Goblin", new string[] {"Warrior", "Hunter", "Rogue", "Priest", "Shaman", "Mage", "Warlock", "Death Knight"}},
          {"Panda", new string[] {"Warrior", "Hunter", "Rogue", "Priest", "Shaman", "Mage", "Monk"}}
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
            string race = dict_races.Keys.ToList()[random.Next(dict_races.Count)];
            string[] race_value = dict_races.Values.ToList()[random.Next(dict_races.Count)];
            string race_int = race_value[random.Next(race_value.Length)];
            Grace.Text = race;
            Grace.Text += " + " + race_int;
        }
    }
}
