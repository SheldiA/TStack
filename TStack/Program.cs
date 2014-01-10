using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TStack
{
    class Program
    {
        class Week:IEnumerable
        {
            private string[] week = { "mon","tues","wen","thr","fri","sat","sun"};
            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < week.Length; ++i)
                    yield return week[i];
            }
        }
        enum Week1 { mon, tues, wen, thr, fri, sat, sun };

        protected static void UserRequestEventHandler(object sender, UserRequestEventsArgs e)
        {
            if (e.Request == RequestType.push)
                Console.WriteLine("push!");
            else
                Console.WriteLine("pop!");
        }

        static void Main(string[] args)
        {
            /*Week week = new Week();
            foreach (string day in week)
                System.Console.WriteLine(day);
            System.Console.ReadLine();*/
           
            TStack<int> stack = new TStack<int>();
            stack.OnRequest += new TStack<int>.UserRequest(UserRequestEventHandler);
            for (int i = 1; i < 5; ++i)
                stack.Push(i);
            for (int i = 0; i < 6; ++i)
                Console.WriteLine(stack.Pop().ToString());
            
            System.Console.ReadLine();
        }
    }
}
