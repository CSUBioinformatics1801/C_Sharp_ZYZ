using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Temp
{
    public partial class Form2 : Form
    {
        List<string> imageLists = new List<string>();
        private string path = Application.StartupPath;
        public Form2()
        {
            InitializeComponent();
            ini_treeview_nodes();
            IniListView();
        }
        private void ini_treeview_nodes()
        {
            for (int n_1 = 0; n_1 < 2; n_1++)
            {
                treeView1.Nodes.Add("Node_" + n_1.ToString());
                for (int n_2 = 0; n_2 < 4; n_2++)
                {
                    TreeNode node = new TreeNode();
                    node.Text = n_1.ToString() + "." + n_2.ToString();
                    node.ImageIndex = 4 * n_1 + n_2;
                    node.SelectedImageIndex = 4 * n_1 + n_2;
                    treeView1.Nodes[n_1].Nodes.Add(node);
                    
                }
            }
        }
        private void IniListView()
        {
            listView1.Columns.Add("Name", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Group", 120, HorizontalAlignment.Center);
            listView1.SmallImageList = initial_imagelist(20);
            listView1.LargeImageList = initial_imagelist(40);
        }
        public ImageList initial_imagelist(int size)
        {
            ImageList temp_image = new ImageList();
            temp_image.ImageSize = new Size(size, size);
            temp_image.Images.Add(Resource1._01);
            temp_image.Images.Add(Resource1._02);
            temp_image.Images.Add(Resource1._03);
            temp_image.Images.Add(Resource1._04);
            temp_image.Images.Add(Resource1._05);
            temp_image.Images.Add(Resource1._06);
            temp_image.Images.Add(Resource1._07);
            temp_image.Images.Add(Resource1._08);
            return temp_image;
        }
        public void add_listview_item(string item_name, int item_index)
        {
            ListViewItem item = new ListViewItem(item_name);
            item.ImageIndex = item_index;
            item.SubItems.Add(item_name);
            listView1.Items.Add(item);
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();
            string select_node = e.Node.Text;
            switch (select_node)
            {
                case "Node_0":
                    for(int group1 = 0; group1 < 4; group1++)
                    {
                        add_listview_item(group1.ToString(), group1);
                    }break;
                case "Node_1":
                    for(int group2 = 4; group2 < 8; group2++)
                    {
                        add_listview_item(group2.ToString(), group2);
                    }break;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = textBox1.Text;
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.folderBrowserDialog1.SelectedPath.Trim() != "")
                    textBox1.Text = this.folderBrowserDialog1.SelectedPath.Trim();
                if (textBox1.Text.Trim() == "") return;

                imageListlarge.Images.Clear();
                listView1.Items.Clear();
                imageLists.Clear();
                bindListView();//reload Listview
            }
        }
        private void bindListView()
        {
            DirectoryInfo dir = new DirectoryInfo(@textBox1.Text.Trim());
            string[] files = new string[100];
            string ext = "";
            foreach (FileInfo d in dir.GetFiles())
            {
                ext = System.IO.Path.GetExtension(textBox1.Text.Trim() + d.Name);
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png") //only Jpg,png
                {
                    imageLists.Add(textBox1.Text.Trim() + "\\" + d.Name);
                }
            }
            for (int i = 0; i < imageLists.Count; i++)
            {
                imageListlarge.Images.Add(System.Drawing.Image.FromFile(imageLists[i].ToString()));
                listView1.Items.Add(System.IO.Path.GetFileName(imageLists[i].ToString()), i);
                listView1.Items[i].ImageIndex = i;
                listView1.Items[i].Name = imageLists[i].ToString();
            }
        }
        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }
        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }
        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }
        private void TileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.GridLines = true;
            listView1.HideSelection = false;
            listView1.HoverSelection = true;
            listView1.FullRowSelect = true; 
            listView1.View = View.Details;
        }
    }
}
