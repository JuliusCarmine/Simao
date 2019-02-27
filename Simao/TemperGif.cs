using System;
using System.Windows.Forms;

namespace Simao
{
    public abstract class TemperGif
    {
        public abstract void ChangeGif(Label lable);
    }

    /// <summary>
    /// 发火
    /// </summary>
    public class Angry : TemperGif
    {
        public override void ChangeGif(Label label)
        {
            Random r = new Random();

            switch (r.Next(0, 4))
            {
                case 0:
                    label.Image = Properties.Resources.生气;
                    break;
                case 1:
                    label.Image = Properties.Resources.好气啊;
                    break;
                case 2:
                    label.Image = Properties.Resources.懒得理你;
                    break;
                case 3:
                    label.Image = Properties.Resources.砸你;
                    break;
            }
        }
    }
    /// <summary>
    /// 生气
    /// </summary>
    public class Bad : TemperGif
    {
        public override void ChangeGif(Label label)
        {
            Random r = new Random();

            switch (r.Next(0, 5))
            {
                case 0:
                    label.Image = Properties.Resources.哭;
                    break;
                case 1:
                    label.Image = Properties.Resources.烦;
                    break;
                case 2:
                    label.Image = Properties.Resources.哼哼;
                    break;
                case 3:
                    label.Image = Properties.Resources.哎;
                    break;
                case 4:
                    label.Image = Properties.Resources.什么;
                    break;
            }
        }
    }
    /// <summary>
    /// 一般
    /// </summary>
    public class Normal : TemperGif
    {
        public override void ChangeGif(Label label)
        {
            Random r = new Random();

            switch (r.Next(0, 6))
            {
                case 0:
                    label.Image = Properties.Resources.乖1;
                    break;
                case 1:
                    label.Image = Properties.Resources.吃;
                    break;
                case 2:
                    label.Image = Properties.Resources.跳绳;
                    break;
                case 3:
                    label.Image = Properties.Resources.吃包子;
                    break;
                case 4:
                    label.Image = Properties.Resources.略;
                    break;
                case 5:
                    label.Image = Properties.Resources.害羞;
                    break;
            }
        }
    }
    /// <summary>
    /// 开心
    /// </summary>
    public class Good : TemperGif
    {
        public override void ChangeGif(Label label)
        {
            Random r = new Random();

            switch (r.Next(0, 5))
            {
                case 0:
                    label.Image = Properties.Resources.比心;
                    break;
                case 1:
                    label.Image = Properties.Resources.耶;
                    break;
                case 2:
                    label.Image = Properties.Resources.弹唱;
                    break;
                case 3:
                    label.Image = Properties.Resources.哇啊;
                    break;
                case 4:
                    label.Image = Properties.Resources.加油;
                    break;

            }
        }
    }
    /// <summary>
    /// 快乐
    /// </summary>
    public class Happy : TemperGif
    {
        public override void ChangeGif(Label label)
        {
            Random r = new Random();

            switch (r.Next(0, 4))
            {
                case 0:
                    label.Image = Properties.Resources.高兴;
                    break;
                case 1:
                    label.Image = Properties.Resources.哈哈;
                    break;
                case 2:
                    label.Image = Properties.Resources.哇1;
                    break;
                case 3:
                    label.Image = Properties.Resources.太棒啦;
                    break;
            }
        }
    }






}
