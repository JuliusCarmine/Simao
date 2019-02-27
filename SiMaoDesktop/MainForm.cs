using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiMaoDesktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        ///=============================基本窗口布局=================================

        /// <summary>
        /// 程序加载
        /// 设置透明
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = BackColor;//设置窗口透明
        }

        #region 窗口移动
        Point mouseDownPoint = Point.Empty;//鼠标定点

        private void label1_MouseDown(object sender, MouseEventArgs e)//鼠标按下
        {
            if (e.Button == MouseButtons.Left)//鼠标按下的点
            {
                mouseDownPoint = new Point(-e.X, -e.Y);
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)//鼠标拖动
        {
            if (e.Button == MouseButtons.Left)//鼠标拖动的距离
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseDownPoint.X, mouseDownPoint.Y);
                Location = mouseSet;
            }
        }
        #endregion

        ///==========================================================================


















    }
}
