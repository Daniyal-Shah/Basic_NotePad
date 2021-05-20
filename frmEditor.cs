using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            newToolStripMenuItem.ShortcutKeys =Keys.Control | Keys.N;
        }

        private void file_MenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmEditor obj = new frmEditor();
            obj.Show();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog obj = new OpenFileDialog();
            obj.Filter= "Text files (*.txt)|*.txt";

            if(obj.ShowDialog()== DialogResult.OK)
            {
                textBox.LoadFile(obj.FileName, RichTextBoxStreamType.PlainText);
            }



        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog obj = new SaveFileDialog();
            obj.Filter = "Text files (*.txt)|*.txt";
            
            if (obj.ShowDialog() == DialogResult.OK)
            {
                textBox.SaveFile(obj.FileName, RichTextBoxStreamType.PlainText);   
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog obj = new FontDialog();
            if (obj.ShowDialog() == DialogResult.OK)
            {                
                textBox.Font = obj.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog obj = new ColorDialog();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = obj.Color;
            }
        }
    }
}
