namespace CharacterCreator
{
    partial class generate_form
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
            this.name = new System.Windows.Forms.Label();
            this.Gname = new System.Windows.Forms.Label();
            this.Gclass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Grace = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ggender = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Gfaction = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bretry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(13, 58);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 17);
            this.name.TabIndex = 0;
            this.name.Text = "Name:";
            // 
            // Gname
            // 
            this.Gname.AutoSize = true;
            this.Gname.Location = new System.Drawing.Point(89, 58);
            this.Gname.Name = "Gname";
            this.Gname.Size = new System.Drawing.Size(32, 17);
            this.Gname.TabIndex = 1;
            this.Gname.Text = "hier";
            // 
            // Gclass
            // 
            this.Gclass.AutoSize = true;
            this.Gclass.Location = new System.Drawing.Point(91, 85);
            this.Gclass.Name = "Gclass";
            this.Gclass.Size = new System.Drawing.Size(32, 17);
            this.Gclass.TabIndex = 3;
            this.Gclass.Text = "hier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class:";
            // 
            // Grace
            // 
            this.Grace.AutoSize = true;
            this.Grace.Location = new System.Drawing.Point(89, 142);
            this.Grace.Name = "Grace";
            this.Grace.Size = new System.Drawing.Size(32, 17);
            this.Grace.TabIndex = 7;
            this.Grace.Text = "hier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Race:";
            // 
            // Ggender
            // 
            this.Ggender.AutoSize = true;
            this.Ggender.Location = new System.Drawing.Point(91, 113);
            this.Ggender.Name = "Ggender";
            this.Ggender.Size = new System.Drawing.Size(32, 17);
            this.Ggender.TabIndex = 5;
            this.Ggender.Text = "hier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gender:";
            // 
            // Gfaction
            // 
            this.Gfaction.AutoSize = true;
            this.Gfaction.Location = new System.Drawing.Point(89, 169);
            this.Gfaction.Name = "Gfaction";
            this.Gfaction.Size = new System.Drawing.Size(32, 17);
            this.Gfaction.TabIndex = 9;
            this.Gfaction.Text = "hier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Faction:";
            // 
            // Bretry
            // 
            this.Bretry.Location = new System.Drawing.Point(756, 364);
            this.Bretry.Name = "Bretry";
            this.Bretry.Size = new System.Drawing.Size(151, 40);
            this.Bretry.TabIndex = 10;
            this.Bretry.Text = "Retry";
            this.Bretry.UseVisualStyleBackColor = true;
            this.Bretry.Click += new System.EventHandler(this.Bretry_Click);
            // 
            // generate_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 416);
            this.Controls.Add(this.Bretry);
            this.Controls.Add(this.Gfaction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Grace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ggender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Gclass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gname);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "generate_form";
            this.Text = "Character Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Gname;
        private System.Windows.Forms.Label Gclass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Grace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Ggender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Gfaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bretry;
    }
}