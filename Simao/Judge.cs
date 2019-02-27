namespace Simao
{
    public class Judge
    {
        /// <summary>
        /// 由心情值判断情绪类型
        /// </summary>
        /// <param name="temper">心情值</param>
        /// <param name="temperType">情绪类型</param>
        /// <param name="tg">情绪类型的对象</param>
        /// <returns>情绪类型</returns>
        public static ref string JudgeTemper(int temper, ref string temperType, ref TemperGif tg, ref int eventNumber)
        {
            if (temper <= -1500)
            {
                temperType = "给糖";
                eventNumber = 1;
            }
            else if (temper > -1500 && temper <= -1200)
            {
                temperType = "发火";
                tg = new Angry();

            }
            else if (temper > -1200 && temper <= -400)
            {
                temperType = "生气";
                tg = new Bad();

            }
            else if (temper > -400 && temper < 200)
            {
                temperType = "一般";
                tg = new Normal();
            }
            else if (temper >= 200 && temper < 600)
            {
                temperType = "开心";
                tg = new Good();
            }
            else if (temper >= 600 && temper < 1300)
            {
                temperType = "快乐";
                tg = new Happy();
            }
            else if (temper >= 1300)
            {
                temperType = "四毛毛飞";
                eventNumber = 2;
            }
            return ref temperType;
        }

        public static void JudgeHungry(int hungry)
        {
            if (hungry <= 60)
            {

            }
            else if (hungry > 60 && hungry <= 100)
            {

            }
            else if (hungry > 100)
            {


            }


        }


        public static void JudgeEvent(int eventNumber, ref Events es)
        {
            switch (eventNumber)
            {
                case 1:
                    es = new GiveCandy();
                    break;
                case 2:
                    es = new Fly();
                    break;
                case 255:
                    es = new BuHong();
                    break;


            }
        }




    }
}
