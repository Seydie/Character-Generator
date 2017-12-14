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
    public partial class generate_form : Form
    {
        public CheckedListBox.CheckedItemCollection exclude_c;
        public CheckedListBox.CheckedItemCollection exclude_r;
        public CheckedListBox.CheckedItemCollection exclude_p;
        static Random random = new Random();
        string[] Arraygender = { "Male", "Female" };
        string[] professions = {"Alchemy", "Blacksmithing", "Enchanting", "Engineering", "Inscription", "Jewelcrafting",
        "Leatherworking", "Tailoring", "Herbalism", "Mining", "Skinning"};

        Dictionary<string, string[]> dict_races = new Dictionary<string, string[]>()
        {
          {"Human", new string[] {"Warrior", "Paladin", "Hunter", "Rogue", "Priest", "Mage", "Warlock", "Monk", "Death Knight"}},
          {"Dwarf", new string[] {"Warrior", "Paladin", "Hunter", "Rogue", "Priest", "Shaman", "Mage", "Warlock", "Monk", "Death Knight"}},
          {"Night Elf", new string[] {"Warrior", "Hunter", "Rogue", "Priest", "Mage", "Monk", "Druid", "Demon Hunter", "Death Knight"}},
          {"Gnome", new string[] {"Warrior", "Hunter", "Rogue", "Priest", "Mage", "Warlock", "Monk", "Death Knight"}},
          {"Draenei", new string[] {"Warrior", "Paladin", "Hunter", "Priest", "Shaman", "Mage", "Monk", "Death Knight"}},
          {"Worgen", new string[] {"Warrior", "Hunter", "Rogue", "Priest", "Mage", "Warlock", "Druid", "Death Knight"}},
          {"Orc", new string[] {"Warrior", "Hunter", "Rogue", "Shaman", "Mage", "Warlock", "Monk", "Death Knight"}},
          {"Undead", new string[] {"Warrior", "Hunter","Rogue", "Priest", "Mage", "Warlock", "Monk", "Death Knight"}},
          {"Tauren", new string[] {"Warrior", "Paladin", "Hunter", "Priest", "Shaman", "Monk", "Druid", "Death Knight"}},
          {"Troll", new string[] {"Warrior", "Hunter", "Rogue", "Priest", "Shaman", "Mage", "Warlock", "Monk", "Druid", "Death Knight"}},
          {"Blood Elf", new string[] {"Warrior", "Paladin", "Hunter", "Rogue", "Priest", "Mage", "Warlock", "Monk", "Demon Hunter", "Death Knight"}},
          {"Goblin", new string[] {"Warrior", "Hunter", "Rogue", "Priest", "Shaman", "Mage", "Warlock", "Death Knight"}},
          {"Panda", new string[] {"Warrior", "Hunter", "Rogue", "Priest", "Shaman", "Mage", "Monk"}}
        };

        Dictionary<string, string[]> dict_specalisation = new Dictionary<string, string[]>()
        {
            {"Warrior", new string[] {"Arms", "Fury", "Protection"}},
            {"Paladin", new string[] {"Holy", "Protection", "Retribution"}},
            {"Hunter", new string[] {"Beast Mastery", "Marksmanship", "Survival"}},
            {"Rogue", new string[] {"Assassination", "Outlaw", "Sublety"}},
            {"Shaman", new string[] {"Elemental", "Enhancement", "Restoration"}},
            {"Mage", new string[] {"Arcane", "Fire", "Frost"}},
            {"Priest", new string[] {"Discipline", "Holy", "Shadow"}},
            {"Warlock", new string[] {"Affliction", "Demonology", "Destruction"}},
            {"Monk", new string[] {"Brewmaster", "Mistweaver", "Windwalker"}},
            {"Druid", new string[] {"Balance", "Feral", "Guardian", "Restoration"}},
            {"Death Knight", new string[] {"Blood", "Frost", "Unholy"}},
            {"Demon Hunter", new string[] {"Havoc", "Vengeance"}}
        };

        public option_form frm1;

        public generate_form()

        {
            InitializeComponent();
        }
        public void Generate()
        {
            Ggender.Text = Arraygender[random.Next(Arraygender.Length)];

            string race_key = dict_races.Keys.ToList()[random.Next(dict_races.Count)];
            string race_value = dict_races[race_key][random.Next(dict_races[race_key].Length)];

            if(exclude_c.Count != 0)
            {
                for (int i = 0; i < exclude_c.Count; i++)
                {
                    if (exclude_c[i].ToString() == race_value)
                    {
                        Generate();
                        return;
                    }
                    else if (i == exclude_c.Count - 1 && race_value != exclude_c[i].ToString())
                    {
                        Gclass.Text = race_value;
                    }
                }
            }
            else
            {
                Gclass.Text = race_value;
            }
            if (exclude_r.Count != 0)
            {
                for (int i = 0; i < exclude_r.Count; i++)
                {
                    if (exclude_r[i].ToString() == race_key)
                    {
                        Generate();
                        return;
                    }
                    else if (i == exclude_r.Count - 1 && race_key != exclude_r[i].ToString())
                    {
                        Grace.Text = race_key;
                    }
                    else if (exclude_r[0].ToString() == "")
                    {
                        Grace.Text = race_key;
                        return;
                    }
                }
            }
            else
            {
                Grace.Text = race_key;
            }
        }

        private void Bretry_Click(object sender, EventArgs e)
        {
            Generate();
        }
    }
}