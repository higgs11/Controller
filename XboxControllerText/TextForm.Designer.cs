namespace XboxControllerText
{
    partial class TextForm
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
            this.rtfTextBox = new System.Windows.Forms.RichTextBox();
            this.txtLettersAfter = new System.Windows.Forms.TextBox();
            this.txtLettersBefore = new System.Windows.Forms.TextBox();
            this.txtCurrentLetter = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.letterOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphabeticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtfTextBox
            // 
            this.rtfTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.rtfTextBox.Location = new System.Drawing.Point(12, 69);
            this.rtfTextBox.Name = "rtfTextBox";
            this.rtfTextBox.Size = new System.Drawing.Size(445, 427);
            this.rtfTextBox.TabIndex = 5;
            this.rtfTextBox.Text = "";
            // 
            // txtLettersAfter
            // 
            this.txtLettersAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLettersAfter.Location = new System.Drawing.Point(256, 37);
            this.txtLettersAfter.Name = "txtLettersAfter";
            this.txtLettersAfter.ReadOnly = true;
            this.txtLettersAfter.Size = new System.Drawing.Size(199, 26);
            this.txtLettersAfter.TabIndex = 4;
            this.txtLettersAfter.TabStop = false;
            // 
            // txtLettersBefore
            // 
            this.txtLettersBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLettersBefore.Location = new System.Drawing.Point(12, 37);
            this.txtLettersBefore.Name = "txtLettersBefore";
            this.txtLettersBefore.ReadOnly = true;
            this.txtLettersBefore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLettersBefore.Size = new System.Drawing.Size(202, 26);
            this.txtLettersBefore.TabIndex = 2;
            this.txtLettersBefore.TabStop = false;
            this.txtLettersBefore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCurrentLetter
            // 
            this.txtCurrentLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentLetter.Location = new System.Drawing.Point(220, 37);
            this.txtCurrentLetter.Name = "txtCurrentLetter";
            this.txtCurrentLetter.ReadOnly = true;
            this.txtCurrentLetter.Size = new System.Drawing.Size(30, 26);
            this.txtCurrentLetter.TabIndex = 3;
            this.txtCurrentLetter.TabStop = false;
            this.txtCurrentLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.letterOrderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // letterOrderToolStripMenuItem
            // 
            this.letterOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.morseToolStripMenuItem,
            this.alphabeticalToolStripMenuItem});
            this.letterOrderToolStripMenuItem.Name = "letterOrderToolStripMenuItem";
            this.letterOrderToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.letterOrderToolStripMenuItem.Text = "Letter Order";
            // 
            // morseToolStripMenuItem
            // 
            this.morseToolStripMenuItem.CheckOnClick = true;
            this.morseToolStripMenuItem.Name = "morseToolStripMenuItem";
            this.morseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.morseToolStripMenuItem.Text = "Morse Code";
            this.morseToolStripMenuItem.Click += new System.EventHandler(this.morseToolStripMenuItem_Click);
            // 
            // alphabeticalToolStripMenuItem
            // 
            this.alphabeticalToolStripMenuItem.CheckOnClick = true;
            this.alphabeticalToolStripMenuItem.Name = "alphabeticalToolStripMenuItem";
            this.alphabeticalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alphabeticalToolStripMenuItem.Text = "Alphabetical";
            this.alphabeticalToolStripMenuItem.Click += new System.EventHandler(this.alphabeticalToolStripMenuItem_Click);
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 508);
            this.Controls.Add(this.rtfTextBox);
            this.Controls.Add(this.txtLettersAfter);
            this.Controls.Add(this.txtLettersBefore);
            this.Controls.Add(this.txtCurrentLetter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextForm";
            this.Text = "TextForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextForm_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfTextBox;
        private System.Windows.Forms.TextBox txtLettersAfter;
        private System.Windows.Forms.TextBox txtLettersBefore;
        private System.Windows.Forms.TextBox txtCurrentLetter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem letterOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphabeticalToolStripMenuItem;
    }
}