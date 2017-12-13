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
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
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
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "World of Warcraft - Character Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 77);
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
            this.exclude_classes.Location = new System.Drawing.Point(18, 108);
            this.exclude_classes.Name = "exclude_classes";
            this.exclude_classes.Size = new System.Drawing.Size(150, 140);
            this.exclude_classes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exclude races:";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
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
            this.checkedListBox2.Location = new System.Drawing.Point(217, 108);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(150, 140);
            this.checkedListBox2.TabIndex = 6;
            // 
            // option_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 459);
            this.Controls.Add(this.checkedListBox2);
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
        private System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}

