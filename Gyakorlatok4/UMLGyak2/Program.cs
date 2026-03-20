namespace UMLGyak2
{
    public class MyTime
    {
        private int hour = 0;
        private int minute = 0;
        private int second = 0;

        //=================================================//
        public MyTime()
        {

        }

        public MyTime (int hour, int minute, int second)
        {
            //validate hour
            if(hour >= 0 && hour < 24)
            {
                this.hour = hour;
            }
            else
            {
                throw new ArgumentException("Invalid hour value!!");
            }

            //validate minute
            if (minute >= 0 && minute < 60)
            {
                this.minute = minute;
            }
            else
            {
                throw new ArgumentException("Invalid minute value!!");
            }

            //validate second
            if (second >= 0 && second < 60)
            {
                this.second = second;
            }
            else
            {
                throw new ArgumentException("Invalid second value!!");
            }

        }

        public void setTime(int hour, int minute, int second)
        {
            //validate hour
            if (hour >= 0 && hour < 24)
            {
                this.hour = hour;
            }
            else
            {
                throw new ArgumentException("Invalid hour value!!");
            }

            //validate minute
            if (minute >= 0 && minute < 60)
            {
                this.minute = minute;
            }
            else
            {
                throw new ArgumentException("Invalid minute value!!");
            }

            //validate second
            if (second >= 0 && second < 60)
            {
                this.second = second;
            }
            else
            {
                throw new ArgumentException("Invalid second value!!");
            }
        }

        public int getHour()
        {
            return this.hour;
        }

        public int getMinute()
        {
            return this.minute;
        }

        public int getSecond()
        {
            return this.second;
        }


        public void setHour(int hour)
        {
            if (hour >= 0 && hour < 24)
            {
                this.hour = hour;
            }
            else
            {
                throw new ArgumentException("Invalid hour value!!");
            }
        }

        public void setMinute(int minute)
        {
            //validate minute
            if (minute >= 0 && minute < 60)
            {
                this.minute = minute;
            }
            else
            {
                throw new ArgumentException("Invalid minute value!!");
            }
        }

        public void setSeconds(int seconds)
        {
            //validate second
            if (second >= 0 && second < 60)
            {
                this.second = second;
            }
            else
            {
                throw new ArgumentException("Invalid second value!!");
            }
        }
         

        public override string ToString()
        {
            string strHour;
            string strMinute;
            string strSecond;
            // adjunk hozzá egy vezető 0 karaktert
            if(this.hour >= 0 && this.hour < 10)
                strHour = "0" + this.hour;
            else
                strHour = "" + this.hour;


            if (this.minute >= 0 && this.minute < 10)
                strMinute = "0" + this.minute;
            else
                strMinute = "" + this.minute;


            if (this.second >= 0 && this.second < 10)
                strSecond = "0" + this.second;
            else
                strSecond = "" + this.second;



            return strHour + " : " + strMinute + " : " + strSecond;
        }

        public MyTime nextSecond()
        {
            MyTime retTime = new MyTime();
            retTime.setSeconds(this.second+1);
            return retTime;
        }

        public MyTime nextHour()
        {
            MyTime retTime = new MyTime();
            retTime.setHour(this.hour+1);
            return retTime;
        }

        public MyTime nextMinute()
        {
            MyTime retTime = new MyTime();
            retTime.setMinute(this.minute+1);
            return retTime;
        }



        public MyTime previousHour()
        {
            MyTime retTime = new MyTime();
            retTime.setHour(this.hour - 1);
            return retTime;
        }

        public MyTime npreviousMinute()
        {
            MyTime retTime = new MyTime();
            retTime.setMinute(this.minute - 1);
            return retTime;
        }

        public MyTime previousSecond()
        {
            MyTime retTime = new MyTime();
            retTime.setSeconds(this.second - 1);
            return retTime;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            MyTime time1 = new MyTime();
            time1.setTime(22, 0, 59);

            MyTime time2 = new MyTime(12,23,33); 

            Console.WriteLine("Az első idő érték: " + time1);
            Console.WriteLine("Az második idő érték: " + time2);
        }
    }
}
