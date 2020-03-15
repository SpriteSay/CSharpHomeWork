using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Clock
    {
     
        DateTime alarmTime = DateTime.Now;

        public delegate void AlarmHandler(object sender,DateTime args);
        public delegate void TickHanlder(object sender,DateTime args);

        public event AlarmHandler OnAlarm;
        public event TickHanlder OnTick;

        public Clock()
        {
            OnAlarm += Alarm;
            OnTick += Tick;
        }

        public void Alarm(object sender,DateTime time)
        {
            Console.WriteLine("您设定的时间" + time + "到啦！");
        }

        public void Tick(object sender,DateTime time)
        {
            Console.WriteLine("现在是" + time );
        }

        public void Start()
        {
            while (true)
            {
                DateTime now = DateTime.Now;
                OnTick(this, now);
                if (now.ToString()==alarmTime.ToString())
                {
                    OnAlarm(this,alarmTime);
                }
                System.Threading.Thread.Sleep(1000);
            }
        }

        public void SetAlarmTime(DateTime atime)
        {
            Console.WriteLine(atime);
            alarmTime = atime;
        }
    }
}
