using System;
namespace ConsoleApp1
{
    public class FirstLesson : Study
    {
       
        public FirstLesson(Study study)
        {
             this.GoLesson();
        }
        public FirstLesson()
        {
            this.GoLesson();
        }
        public  string GoLesson()
        {

            var s = "Go 1 lesson";
            Console.WriteLine(s);
            return s;
        }
    }

}
