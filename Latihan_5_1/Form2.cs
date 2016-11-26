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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            colorDialog1.Color = treeView1.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                treeView1.BackColor = colorDialog1.Color;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TreeNode ParentNode1;

            ParentNode1 = treeView1.Nodes.Add("Color");
            ParentNode1.Nodes.Add("Background Color");
            ParentNode1.Nodes.Add("Font Color");
            ParentNode1.Collapse();
        }
    }
}
