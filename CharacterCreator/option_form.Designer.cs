namespace CharacterCreator
{
    partial class option_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bnext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bexit = new System.Windows.Forms.Button();
            this.exclude_classes = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exclude_races = new System.Windows.Forms.CheckedListBox();
            this.exclude_professions = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkbox_realm = new System.Windows.Forms.CheckBox();
            this.radio_pvprealm = new System.Windows.Forms.RadioButton();
            this.radio_bothrealm = new System.Windows.Forms.RadioButton();
            this.radio_pverealm = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // bnext
            // 
            this.bnext.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bnext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnext.ForeColor = System.Drawing.SystemColors.Window;
            this.bnext.Location = new System.Drawing.Point(455, 398);
            this.bnext.Margin = new System.Windows.Forms.Padding(4);
            this.bnext.Name = "bnext";
            this.bnext.Size = new System.Drawing.Size(216, 47);
            this.bnext.TabIndex = 0;
            this.bnext.Text = "Next";
            this.bnext.UseVisualStyleBackColor = false;
            this.bnext.Click += new System.EventHandler(this.bnext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "World of Warcraft - Character Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exclude classes:";
            // 
            // Bexit
            // 
            this.Bexit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Bexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bexit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bexit.ForeColor = System.Drawing.SystemColors.Window;
            this.Bexit.Location = new System.Drawing.Point(13, 398);
            this.Bexit.Margin = new System.Windows.Forms.Padding(4);
            this.Bexit.Name = "Bexit";
            this.Bexit.Size = new System.Drawing.Size(216, 47);
            this.Bexit.TabIndex = 3;
            this.Bexit.Text = "Exit";
            this.Bexit.UseVisualStyleBackColor = false;
            this.Bexit.Click += new System.EventHandler(this.Bexit_Click);
            // 
            // exclude_classes
            // 
            this.exclude_classes.BackColor = System.Drawing.SystemColors.Control;
            this.exclude_classes.CheckOnClick = true;
            this.exclude_classes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.exclude_classes.FormattingEnabled = true;
            this.exclude_classes.Items.AddRange(new object[] {
            "Warrior",
            "Paladin",
            "Hunter",
            "Rogue",
            "Priest",
            "Shaman",
            "Mage",
            "Warlock",
            "Monk",
            "Druid",
            "Demon Hunter",
            "Death Knight"});
            this.exclude_classes.Location = new System.Drawing.Point(22, 150);
            this.exclude_classes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exclude_classes.Name = "exclude_classes";
            this.exclude_classes.Size = new System.Drawing.Size(151, 123);
            this.exclude_classes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exclude races:";
            // 
            // exclude_races
            // 
            this.exclude_races.BackColor = System.Drawing.SystemColors.Control;
            this.exclude_races.CheckOnClick = true;
            this.exclude_races.ForeColor = System.Drawing.SystemColors.WindowText;
            this.exclude_races.FormattingEnabled = true;
            this.exclude_races.Items.AddRange(new object[] {
            "Human",
            "Dwarf",
            "Night Elf",
            "Gnome",
            "Draenei",
            "Worgen",
            "Orc",
            "Undead",
            "Tauren",
            "Troll",
            "Blood Elf",
            "Goblin",
            "Panda"});
            this.exclude_races.Location = new System.Drawing.Point(220, 150);
            this.exclude_races.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exclude_races.Name = "exclude_races";
            this.exclude_races.Size = new System.Drawing.Size(151, 123);
            this.exclude_races.TabIndex = 6;
            // 
            // exclude_professions
            // 
            this.exclude_professions.BackColor = System.Drawing.SystemColors.Control;
            this.exclude_professions.CheckOnClick = true;
            this.exclude_professions.ForeColor = System.Drawing.SystemColors.WindowText;
            this.exclude_professions.FormattingEnabled = true;
            this.exclude_professions.Items.AddRange(new object[] {
            "Alchemy",
            "Blacksmithing",
            "Enchanting",
            "Engineering",
            "Inscription",
            "Jewelcrafting",
            "Leatherworking",
            "Tailoring",
            "Herbalism",
            "Mining",
            "Skinning"});
            this.exclude_professions.Location = new System.Drawing.Point(420, 150);
            this.exclude_professions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exclude_professions.Name = "exclude_professions";
            this.exclude_professions.Size = new System.Drawing.Size(151, 123);
            this.exclude_professions.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Exclude professions:";
            // 
            // Tname
            // 
            this.Tname.Location = new System.Drawing.Point(18, 82);
            this.Tname.Name = "Tname";
            this.Tname.Size = new System.Drawing.Size(157, 22);
            this.Tname.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Character name:";
            // 
            // checkbox_realm
            // 
            this.checkbox_realm.AutoSize = true;
            this.checkbox_realm.Location = new System.Drawing.Point(21, 278);
            this.checkbox_realm.Name = "checkbox_realm";
            this.checkbox_realm.Size = new System.Drawing.Size(145, 21);
            this.checkbox_realm.TabIndex = 12;
            this.checkbox_realm.Text = "Randomize Realm";
            this.checkbox_realm.UseVisualStyleBackColor = true;
            this.checkbox_realm.CheckedChanged += new System.EventHandler(this.checkbox_realm_CheckedChanged);
            // 
            // radio_pvprealm
            // 
            this.radio_pvprealm.AutoSize = true;
            this.radio_pvprealm.Enabled = false;
            this.radio_pvprealm.Location = new System.Drawing.Point(21, 305);
            this.radio_pvprealm.Name = "radio_pvprealm";
            this.radio_pvprealm.Size = new System.Drawing.Size(100, 21);
            this.radio_pvprealm.TabIndex = 13;
            this.radio_pvprealm.Text = "PVP Realm";
            this.radio_pvprealm.UseVisualStyleBackColor = true;
            // 
            // radio_bothrealm
            // 
            this.radio_bothrealm.AutoSize = true;
            this.radio_bothrealm.Checked = true;
            this.radio_bothrealm.Enabled = false;
            this.radio_bothrealm.Location = new System.Drawing.Point(21, 359);
            this.radio_bothrealm.Name = "radio_bothrealm";
            this.radio_bothrealm.Size = new System.Drawing.Size(58, 21);
            this.radio_bothrealm.TabIndex = 14;
            this.radio_bothrealm.TabStop = true;
            this.radio_bothrealm.Text = "Both";
            this.radio_bothrealm.UseVisualStyleBackColor = true;
            // 
            // radio_pverealm
            // 
            this.radio_pverealm.AutoSize = true;
            this.radio_pverealm.Enabled = false;
            this.radio_pverealm.Location = new System.Drawing.Point(21, 332);
            this.radio_pverealm.Name = "radio_pverealm";
            this.radio_pverealm.Size = new System.Drawing.Size(100, 21);
            this.radio_pverealm.TabIndex = 15;
            this.radio_pverealm.Text = "PVE Realm";
            this.radio_pverealm.UseVisualStyleBackColor = true;
            // 
            // option_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 459);
            this.Controls.Add(this.radio_pverealm);
            this.Controls.Add(this.radio_bothrealm);
            this.Controls.Add(this.radio_pvprealm);
            this.Controls.Add(this.checkbox_realm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tname);
            this.Controls.Add(this.exclude_professions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exclude_races);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exclude_classes);
            this.Controls.Add(this.Bexit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnext);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "option_form";
            this.Text = "Character generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bexit;
        private System.Windows.Forms.CheckedListBox exclude_classes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox exclude_races;
        private System.Windows.Forms.CheckedListBox exclude_professions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkbox_realm;
        private System.Windows.Forms.RadioButton radio_pvprealm;
        private System.Windows.Forms.RadioButton radio_bothrealm;
        private System.Windows.Forms.RadioButton radio_pverealm;
    }
}

