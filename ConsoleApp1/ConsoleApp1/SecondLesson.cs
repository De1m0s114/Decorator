using System;
namespace ConsoleApp1
{
    public class SecondLesson : Study
    {


        public SecondLesson(Study study)
        {
            this.GoLesson();
        }
        public SecondLesson()
        {
            this.GoLesson();
        }

        public  string GoLesson()
        {
            var s = "Go 2 lesson";
            Console.WriteLine(s);
            return s;
        }
    }

}
