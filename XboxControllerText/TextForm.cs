using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace XboxControllerText
{
    public partial class TextForm : Form
    {
       
        Alphabet _alphabet = new Alphabet();



        public TextForm()
        {
            InitializeComponent();           
            this.selectLetterOrdering((Alphabet.eLetterOrder)Settings1.Default.LetterOrderingSetting);                                    
        }

        /// <summary>
        /// Helper method to update text on changes.
        /// </summary>
        private void UpdateText()
        {
            txtCurrentLetter.Text = _alphabet.GetCurrentLetter().ToString();
            txtLettersAfter.Text = _alphabet.GetLettersToRight();
            txtLettersBefore.Text = _alphabet.GetLettersToLeft();
        }

        /// <summary>
        /// Button handler, overrides base class handler
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            try
            {
                switch (msg.WParam.ToInt32())
                {
                    case (int)System.Windows.Forms.Keys.Escape:
                        _alphabet.ResetSearchIndexes();
                        break;

                    case (int)System.Windows.Forms.Keys.Space:
                        rtfTextBox.AppendText(_alphabet.GetCurrentLetter().ToString());
                        _alphabet.ResetSearchIndexes();
                        break;

                    default:
                        break;
                }
               
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Key Overrided Events Error:" + Ex.Message);
            }

            this.UpdateText();
            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TextForm_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    _alphabet.ShiftLeftHalf();
                    break;

                case MouseButtons.Right:
                    _alphabet.ShiftRightHalf();
                    break;


                default:
                    break;
            }

            this.UpdateText();
        }

        public void ControllerInputLeft()
        {
            _alphabet.ShiftLeftHalf();
            this.UpdateText();
        }

        public void ControllerInputRight()
        {
            _alphabet.ShiftRightHalf();
            this.UpdateText();
        }

        public void ResetLetters()
        {
            _alphabet.ResetSearchIndexes();
            this.UpdateText();
        }

        public void SelectLetter()
        {
            rtfTextBox.AppendText(_alphabet.GetCurrentLetter().ToString());
            _alphabet.ResetSearchIndexes();
            this.UpdateText();
        }

        private void morseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectLetterOrdering(Alphabet.eLetterOrder.MORSE_CODE);
        }

        private void alphabeticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectLetterOrdering(Alphabet.eLetterOrder.ALPHABETICAL);
        }

        private void selectLetterOrdering(Alphabet.eLetterOrder letterOrder)
        {
            switch (letterOrder)
            {
                case Alphabet.eLetterOrder.ALPHABETICAL:
                    alphabeticalToolStripMenuItem.Checked = true;
                    morseToolStripMenuItem.Checked = false;
                    break;

                case Alphabet.eLetterOrder.MORSE_CODE:
                    alphabeticalToolStripMenuItem.Checked = false;
                    morseToolStripMenuItem.Checked = true;
                    break;

                default:
                    MessageBox.Show("Non supported ordering. Defaulting to Alphabet.eLetterOrder.ALPHABETICAL");
                    alphabeticalToolStripMenuItem.Checked = true;
                    morseToolStripMenuItem.Checked = false;
                    break;
            }

            _alphabet.SetLetterOrder(letterOrder);
            Settings1.Default.LetterOrderingSetting = (int)letterOrder;
            Settings1.Default.Save();
            this.UpdateText();

        }



        public void EraseLastLetter()
        {
            if (rtfTextBox.Text.Length > 0)
            {
                rtfTextBox.Text = rtfTextBox.Text.Remove(rtfTextBox.Text.Length - 1);
            }

            rtfTextBox.ScrollToCaret();
        }
    }
}
