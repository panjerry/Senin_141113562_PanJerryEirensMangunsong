using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Latihan_5_1
{
    public partial class Form1 : Form
    {
        string filename;
        //Boolean newfile = false;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Enabled = false;
            buttonSave.Enabled = false;
            labelFilename.Text = "";

            ContextMenu klikkananmenu = new ContextMenu();
            klikkananmenu.MenuItems.Add("Cut", cutToolStripMenuItem_Click);
            klikkananmenu.MenuItems.Add("Copy", copyToolStripMenuItem_Click);
            klikkananmenu.MenuItems.Add("Paste", pasteToolStripMenuItem_Click);
            klikkananmenu.MenuItems.Add("Delete", deleteToolStripMenuItem_Click);

            richTextBox1.ContextMenu = klikkananmenu;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog window_open_dialog = new OpenFileDialog();

            if (window_open_dialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream_read = new StreamReader(File.OpenRead(window_open_dialog.FileName));
                richTextBox1.Text = stream_read.ReadToEnd();
                stream_read.Dispose();
                //
                richTextBox1.Enabled = true;
                buttonSave.Enabled = true;
                filename = window_open_dialog.FileName;
                labelFilename.Text = filename;
            }
        }

        private void saveFile(RichTextBox rb)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.DefaultExt = "*.rtf";
            sf.Filter = "RTF Files|*.rtf";
            if (richTextBox1.Text == null) return;
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK & sf.FileName.Length > 0)
                rb.SaveFile(sf.FileName);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save this file ?", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (richTextBox1.Text != null)
            {
                if (dr == DialogResult.Yes) saveFile(richTextBox1);
                else if (dr == DialogResult.No)
                {
                    richTextBox1.Focus();
                }
                else if (dr == DialogResult.Cancel) return;
                richTextBox1.Text = "";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StreamWriter stream_write = new StreamWriter(filename);
            stream_write.Write(richTextBox1.Text);
            stream_write.Dispose();
            //
            labelFilename.Text = filename;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ChildForm = new Form2();
            ChildForm.Show();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void Color1_Click(object sender, EventArgs e)
        {
            DialogResult warna = colorDialog1.ShowDialog();
            if (warna == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void textboxArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
