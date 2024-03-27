using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Timers;
using System.Threading.Tasks;

namespace Clock
{
     public delegate void clockTickandler();
    public delegate void clockAlarmHandler();
    class Clock
    {
        public clockTickandler clockTick;
        public clockTickandler clockAlarm;
        public void OnTick()
        {
            clockTick();
        }
        public void OnAlarm()
        {
            clockAlarm();
        }
        public void start(int time)//闹铃time秒后响铃
        {
            for(int i = 0; i < time; i++)
            {
                System.Threading.Thread.Sleep(1000);
                OnTick();
            }
            OnAlarm();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.clockTick += () =>
            {
                Console.WriteLine("滴答");
            };
            clock.clockAlarm += () =>
            {
                Console.WriteLine("闹铃响了，响了");
            };
            clock.start(9);
            Console.ReadKey();
        }
    }
}
