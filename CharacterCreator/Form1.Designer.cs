namespace CharacterCreator
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // bnext
            // 
            this.bnext.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bnext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnext.ForeColor = System.Drawing.SystemColors.Window;
            this.bnext.Location = new System.Drawing.Point(680, 323);
            this.bnext.Name = "bnext";
            this.bnext.Size = new System.Drawing.Size(162, 38);
            this.bnext.TabIndex = 0;
            this.bnext.Text = "Next";
            this.bnext.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 373);
            this.Controls.Add(this.bnext);
            this.Name = "Form1";
            this.Text = "Character generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnext;
    }
}

