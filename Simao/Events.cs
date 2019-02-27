using System;
using System.Windows.Forms;

namespace Simao
{
    public abstract class Events
    {
        /// <summary>
        /// 更换图片
        /// </summary>
        /// <param name="label"></param>
        public abstract void ChangeGif(Label label, int eventTicks, ref int temper);
        /// <summary>
        /// 修改属性
        /// </summary>
        /// <param name="number"></param>
        public abstract void ChangeNum(int number);

        #region
        /// <summary>
        /// 更换为事件计时器
        /// </summary>
        /// <param name="timerBase">基础计时器</param>
        /// <param name="timerEvent">事件计时器</param>
        //public static void EventTimerOn(Timer timerBase, Timer timerEvent)
        //{
        //    timerBase.Enabled = false;
        //    timerEvent.Enabled = true;
        //}
        /// <summary>
        /// 还原为基础计时器
        /// </summary>
        /// <param name="timerBase">基础计时器</param>
        /// <param name="timerEvent">时间计时器</param>
        //public static void BaseTimerOn(Timer timerBase, Timer timerEvent)
        //{
        //    timerBase.Enabled = false;
        //    timerEvent.Enabled = true;
        //}
        #endregion

    }

    /// <summary>
    /// 空事件
    /// </summary>
    public class NoEvent : Events
    {
        public override void ChangeGif(Label label, int eventTicks, ref int temper)
        {

        }

        public override void ChangeNum(int number)
        {

        }
    }

    /// <summary>
    /// 给糖
    /// </summary>
    public class GiveCandy : Events
    {
        public override void ChangeGif(Label label, int eventTicks, ref int temper)
        {
            switch (eventTicks)
            {
                case 1:
                    label.Image = Properties.Resources.呐;
                    break;
                case 2:
                    label.Image = Properties.Resources.哼;
                    break;
                case 3:
                    label.Image = Properties.Resources.呐;
                    break;
                case 4:
                    label.Image = Properties.Resources.吐舌头;
                    temper = 300;
                    break;
            }
        }

        public override void ChangeNum(int number)
        {

        }
    }

    /// <summary>
    /// 四毛毛飞
    /// </summary>
    public class Fly : Events
    {
        public override void ChangeGif(Label label, int eventTicks, ref int temper)
        {
            switch (eventTicks)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    label.Image = Properties.Resources.四毛毛飞;
                    temper = 700;
                    break;
            }
        }

        public override void ChangeNum(int number)
        {

        }
    }

    /// <summary>
    /// 不哄
    /// </summary>
    public class BuHong : Events
    {
        public override void ChangeGif(Label label, int eventTicks, ref int temper)
        {
            switch (eventTicks)
            {
                case 1:
                    label.Image = Properties.Resources.你不哄着我;
                    break;
                case 2:
                    label.Image = Properties.Resources.你让我生气;
                    break;
                case 3:
                    label.Image = Properties.Resources.你是故意的;
                    break;
                case 4:
                    label.Image = Properties.Resources.我要打死你;
                    temper = -1300;
                    break;
            }
        }

        public override void ChangeNum(int number)
        {
            throw new NotImplementedException();
        }
    }
}