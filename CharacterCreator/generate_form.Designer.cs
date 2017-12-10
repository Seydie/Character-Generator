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
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(13, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 17);
            this.name.TabIndex = 0;
            this.name.Text = "Name:";
            // 
            // Gname
            // 
            this.Gname.AutoSize = true;
            this.Gname.Location = new System.Drawing.Point(69, 13);
            this.Gname.Name = "Gname";
            this.Gname.Size = new System.Drawing.Size(46, 17);
            this.Gname.TabIndex = 1;
            this.Gname.Text = "label1";
            // 
            // generate_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 416);
            this.Controls.Add(this.Gname);
            this.Controls.Add(this.name);
            this.Name = "generate_form";
            this.Text = "Character Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Gname;
    }
}