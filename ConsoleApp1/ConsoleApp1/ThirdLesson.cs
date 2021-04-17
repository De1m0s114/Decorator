using System;
namespace ConsoleApp1
{
    public class ThirdLesson : Study
    {
        public ThirdLesson(Study study)
        {
            this.GoLesson();
        }
        public ThirdLesson()
        {
            this.GoLesson();
        }
        public  string GoLesson()
        {

            var s = "Go 3 lesson";
            Console.WriteLine(s);
            return s;
        }

    }

}
