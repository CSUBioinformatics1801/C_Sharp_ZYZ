using System;
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
    public partial class Form_test : Form
    {
        public Form_test()
        {
            InitializeComponent();
            IniListView();
            AddDataAndPic();
        }

        private void IniListView()
        {
            //添加列头，设置宽度，显示位置
            listView1.Columns.Add("名称", 120, HorizontalAlignment.Center);
           // listView1.Columns.Add("名编号称", 120, HorizontalAlignment.Center);
         //   listView1.Columns.Add("描述", 200, HorizontalAlignment.Center);

            //设置属性
            listView1.GridLines = true;//显示网格线
            listView1.HideSelection = false;//失去焦点时显示当前选择的项
            listView1.HoverSelection = true;//当鼠标指针停留数秒时自动选择项
            listView1.FullRowSelect = true; //选中一行
            listView1.View = View.Details;

            //设置图像列表
            ImageList myImage = new ImageList();//创建图像列表
            myImage.ImageSize = new Size(20, 20);//设置图标大小
            myImage.Images.Add(Resource1._01);
            myImage.Images.Add(Resource1._02);
            myImage.Images.Add(Resource1._03);
            listView1.SmallImageList = myImage;//设置大图标集合

            ImageList myImage2 = new ImageList();//创建图像列表
            myImage2.ImageSize = new Size(40, 40);//设置图标大小
            myImage2.Images.Add(Resource1._01);
            myImage2.Images.Add(Resource1._02);
            myImage2.Images.Add(Resource1._03);
            listView1.LargeImageList = myImage2;
        }

        //ListView中添加数据、图片
        private void AddDataAndPic()
        {
            
            ListViewItem lv1 = new ListViewItem("one");
           // lv1.SubItems.Add("001");
           // lv1.SubItems.Add("第一行第三列");
            lv1.ImageIndex = 0;//指定图像索引

            ListViewItem lv2 = new ListViewItem("two");
           // lv2.SubItems.Add("002");
           // lv2.SubItems.Add("第二行第三列");
            lv2.ImageIndex = 1;//指定图像索引

            ListViewItem lv3 = new ListViewItem("three");
           // lv3.SubItems.Add("003");
           // lv3.SubItems.Add("第三行第三列");
            lv3.ImageIndex = 2;//指定图像索引

            listView1.Items.Add(lv1);
            listView1.Items.Add(lv2);
            listView1.Items.Add(lv3);
        }
        public void add_item(string item_name,int item_index)
        {
            ListViewItem item = new ListViewItem(item_name);
            item.ImageIndex = 0;
            listView1.Items.Add(item);
        }

        //修改ListView数据
        private void UpdateDate()
        {
            listView1.Items[0].SubItems[2].Text = "哈哈1";
            listView1.Items[1].SubItems[2].Text = "哈哈2";
            listView1.Items[2].SubItems[2].Text = "哈哈3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDate();
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
    }
}
