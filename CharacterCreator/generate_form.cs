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
        public CheckedListBox.CheckedItemCollection exclude_c;
        public CheckedListBox.CheckedItemCollection exclude_r;
        public CheckedListBox.CheckedItemCollection exclude_p;
        public string Tnamebox;
        public CheckBox checkbox_realm;
        public RadioButton Rpvprealm;
        public RadioButton Rpverealm;
        public RadioButton Rbothrealm;
        static Random random = new Random();
        string[] Arraygender = { "Male", "Female" };
        string[] Arrayfaction = { "Alliance", "Horde" };
        string[] Arraypverealm = { "Aerie Peak", "Aggramar", "Alonsus", "Anachronos", "Arathor", "Argent Dawn", "Aszune", "Azjol-Nerub", "Azuremyst", "Blade's Edge", "Bloodhoof", "Bronze Dragonflight", "Bronzebeard", "Chamber of Aspects", "Darkmoon Faire", "Darkspear", "Doomhammer", "Draenor", "Dragonblight", "Earthen Ring", "Emerald Dream", "Eonar", "Ghostlands", "Hellfire", "Hellscream", "Khadgar", "Kilrogg", "Kul Tiras", "Lightbringer", "Magtheridon", "Mazrigos", "Moonglade", "Nagrand", "Nordrassil", "Quel'Thalas", "Runetotem", "Saurfang", "Shadowsong", "Silvermoon", "Steamwheedle Cartel", "Stormrage", "Terenas", "Terokkar", "The Sha'tar", "Thunderhorn", "Turalyon", "Vek'nilash", "Wildhammer" };
        string[] Arraypvprealm = { "Agamaggan", "Ahn'Qiraj", "Al'Akir", "Auchindoun", "Balnazzar", "Bladefist", "Bloodfeather", "Bloodscalp", "Boulderfist", "Burning Blade", "Burning Legion", "Burning Steppes", "Chromaggus", "Crushridge", "Daggerspine", "Darksorrow", "Deathwing", "Defias Brotherhood", "Dentarg", "Dragonmaw", "Drak'thul", "Dunemaul", "Emeriss", "Executus", "Frostmane", "Frostwhisper", "Genjuros", "Grim Batol", "Hakkar", "Haomarush", "Jaedenar", "Karazhan", "Kazzak", "Kor'gall", "Laughing Skull", "Lightning's Blade", "Neptulon", "Outland", "Ragnaros", "Ravencrest", "Ravenholdt", "Scarshield Legion", "Shattered Halls", "Shattered Hand", "Skullcrusher", "Spinebreaker", "Sporeggar", "Stormreaver", "Stormscale", "Sunstrider", "Sylvanas", "Talnivarr", "Tarren Mill", "The Maelstrom", "The Venture Co", "Trollbane", "Twilight's Hammer", "Twisting Nether", "Vashj", "Xavius", "Zenedar" };
        string[] professions = { "Alchemy", "Blacksmithing", "Enchanting", "Engineering", "Inscription", "Jewelcrafting", "Leatherworking", "Tailoring", "Herbalism", "Mining", "Skinning"};

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
            string race_key = dict_races.Keys.ToList()[random.Next(dict_races.Count)];
            string race_value = dict_races[race_key][random.Next(dict_races[race_key].Length)];
            string specalisation = dict_specalisation[race_value][random.Next(dict_specalisation[race_value].Length)];
            string profession1 = professions[random.Next(professions.Length)];
            string profession2 = professions[random.Next(professions.Length)];

            Gname.Text = Tnamebox;
            Ggender.Text = Arraygender[random.Next(Arraygender.Length)];

            //Checking Class and filling
            if (exclude_c.Count != 0)
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
            //End class

            //Checking specalisation and filling
            Gspecialisation.Text = specalisation;

            switch(specalisation)
            {
                case "Fury":
                case "Arms":
                case "Retribution":
                case "Beast Mastery":
                case "Marksmanship":
                case "Survival":
                case "Assassination":
                case "Outlaw":
                case "Subtlety":
                case "Elemental":
                case "Enhancement":
                case "Arcane":
                case "Fire":
                case "Frost":
                case "Shadow":
                case "Affliction":
                case "Demonology":
                case "Destruction":
                case "Windwalker":
                case "Feral":
                case "Balance":
                case "Unholy":
                case "Havoc":
                    Grole.Text = "Damage";
                    break;
                case "Protection":
                case "Brewmaster":
                case "Guardian":
                case "Blood":
                case "Vengeance":
                    Grole.Text = "Tank";
                    break;
                case "Holy":
                case "Restoration":
                case "Discipline":
                case "Mistweaver":
                    Grole.Text = "Heal";
                    break;
            }
            //End specalisation

            //Checking race and filling
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
                }
            }
            else
            {
                Grace.Text = race_key;
            }
            //End race

            //Checking profession and filling
            if (exclude_p.Count != 0 && exclude_p.Count != 10)
            {
                if (profession1 != profession2)
                {
                    for(int i = 0; i < exclude_p.Count; i++)
                    {
                        if(exclude_p[i].ToString() == profession1 || exclude_p[i].ToString() == profession2)
                        {
                            Generate();
                            return;
                        }
                        else if (i == exclude_p.Count -1 && profession1 != exclude_p[i].ToString() && profession2 != exclude_p[i].ToString())
                        {
                            Gprof1.Text = profession1;
                            Gprof2.Text = profession2;
                        }
                    }
                }
                else
                {
                    Generate();
                }
            }
            else if(exclude_p.Count == 10)
            {
                Gprof1.Text = "";
                Gprof2.Text = "";
            }
            else
            {
                if (profession1 != profession2)
                {
                    Gprof1.Text = profession1;
                    Gprof2.Text = profession2;
                }
                else
                {
                    Generate();
                }
            }
            //End profession

            //Checking faction and filling
            switch(Grace.Text)
            {
                case "Human":
                case "Dwarf":
                case "Night Elf":
                case "Gnome":
                case "Draenei":
                case "Worgen":
                    Gfaction.Text = "Alliance";
                    break;
                case "Orc":
                case "Undead":
                case "Tauren":
                case "Troll":
                case "Blood Elf":
                case "Goblin":
                    Gfaction.Text = "Horde";
                    break;
                case "Panda":
                    Gfaction.Text = Arrayfaction[random.Next(Arrayfaction.Length)];
                    break;
            }
            //End faction

            //Checking realm and filling
            if(checkbox_realm.Checked) {
                if (Rpvprealm.Checked)
                {
                    Grealm.Text = Arraypvprealm[random.Next(Arraypvprealm.Length)];
                }
                else if(Rpverealm.Checked)
                {
                    Grealm.Text = Arraypverealm[random.Next(Arraypverealm.Length)];
                }
                else if(Rbothrealm.Checked)
                {
                    string pve = Arraypverealm[random.Next(Arraypverealm.Length)];
                    string pvp = Arraypvprealm[random.Next(Arraypvprealm.Length)];
                    string[] randomrealm = { pve, pvp };
                    Grealm.Text = randomrealm[random.Next(randomrealm.Length)];
                }
            }
            else
            {
                Grealm.Text = "";
            }
            //End realm
        }

        private void Bretry_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void Bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}