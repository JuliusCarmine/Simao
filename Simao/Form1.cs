using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Simao
{
    public partial class SiMao : Form
    {
        //=================  界面设置  =========================================
        #region 窗口移动和窗口透明

        public SiMao()
        {
            InitializeComponent();

            //int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            //int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width - 20, Screen.PrimaryScreen.WorkingArea.Height - this.Height - 10);




        }


        Point mouseDownPoint = Point.Empty;//鼠标定点

        private void label1_MouseDown(object sender, MouseEventArgs e)//鼠标按下
        {
            if (e.Button == MouseButtons.Left)//鼠标按下的点
            {
                mouseDownPoint = new Point(-e.X, -e.Y);




            }
            if (e.Button == MouseButtons.Right)//鼠标右键降低心情值
            {
                mouseRightClick++;
                temper = temper - 120;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)//鼠标拖动
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseDownPoint.X, mouseDownPoint.Y);
                Location = mouseSet;

            }
        }

        private void SiMao_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = BackColor;
            MessageBox.Show(
@"===============================
  本应用程序仅供微信表情《四毛》爱好者个人使用
===============================

四毛是一只软萌糯傻白甜的小龙猫，在桌面静静看你
如果因为冷落生了气，别忘记双击几下哄哄她呦~~

如需退出或再次查看帮助，请右键任务栏小图标

===============================
  表情作者：@叔婆饭spfan
  软件作者：@JuliusV （萌萌森林1号树洞---八毛）
  联系邮箱：JuliusCarmine@outlook.com
===============================", "可爱的四毛", MessageBoxButtons.OK);

        }
        #endregion
        //=====================================================================

        //================== 基本属性  =========================================
        #region 属性值

        string temperType = null;//情绪类型
        string temperTypeStatu = null;//当前情绪类型

        int eventTicks = 0;//局部计时器tick数
        int eventNumber = 0;//事件值
        int temper = 0;//心情值
        //int hungery = 100;//饥饿值
        int mouseRightClick = 0;


        bool end = false;//标记程序退出
        bool close = false;//确认关闭


        TemperGif tg = new Normal();
        Events es = new NoEvent();

        #endregion
        //=====================================================================

        //=================  任务栏右键 ==========================================
        #region 任务栏控制
        private void 控制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// 退出的时候播放暗中观察
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            end = true;
            label1.Image = Properties.Resources.暗中观察;
        }
        #endregion
        //========================================================================


        private void timerBase_Tick(object sender, EventArgs e)
        {
            ///退出的处理
            if (close)
            {
                this.Close();
            }
            if (end)
            {
                end = false;
                close = true;
            }


            if (eventNumber != 0)
            {
                return;
            }



            //情绪值减一
            temper--;

            Judge.JudgeTemper(temper, ref temperType, ref tg, ref eventNumber);//根据心情值判断情绪类型
            if (temperType != temperTypeStatu)//如果情绪值改变，随机变换一张图片
            {
                tg.ChangeGif(label1);
                temperTypeStatu = temperType;//并将心情状态改为当前情绪类型
            }



        }






        private void timerRandom_Tick(object sender, EventArgs e)
        {
            temperTypeStatu = null;
        }

        /// <summary>
        /// 事件计时器流程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEvent_Tick(object sender, EventArgs e)
        {
            eventTicks++;
            if (eventTicks >= 1 && eventTicks <= 4)
            {
                es.ChangeGif(label1, eventTicks, ref temper);
            }
            else
            {
                if (mouseRightClick > 30)
                {
                    mouseRightClick = 0;
                }


                eventTicks = 0;
                eventNumber = 0;

                timerEvent.Enabled = false;
                timerBase.Enabled = true;
            }
        }

        private void timerFast_Tick(object sender, EventArgs e)
        {
            心情值ToolStripMenuItem.Text = "心情值： " + temper.ToString();

            if (mouseRightClick > 30)
            {
                eventNumber = 255;
                mouseRightClick = 0;
            }




            if (eventNumber != 0)
            {
                Judge.JudgeEvent(eventNumber, ref es);
                timerEvent.Enabled = true;
                timerBase.Enabled = false;
            }

        }

        /// <summary>
        /// 双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_DoubleClick(object sender, EventArgs e)
        {
            temper = temper + 150;
            if (temperType != temperTypeStatu)//如果情绪值改变，随机变换一张图片
            {
                tg.ChangeGif(label1);
                temperTypeStatu = temperType;//并立即将心情状态改为当前情绪类型
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
@"===============================
  本应用程序仅供微信表情《四毛》爱好者个人使用
===============================

四毛是一只软萌糯傻白甜的小龙猫，在桌面静静看你
如果因为冷落生了气，别忘记双击几下哄哄她呦~~

如需退出或再次查看帮助，请右键任务栏小图标

===============================
  表情作者：@叔婆饭spfan
  软件作者：@JuliusV （萌萌森林1号树洞---八毛）
  联系邮箱：JuliusCarmine@outlook.com
===============================", "可爱的四毛", MessageBoxButtons.OK);
        }
    }
}
