using System;
namespace ConsoleApp1
{
    public class FirstLesson : Study
    {
       

        public FirstLesson()
        {
            this.GoLesson();
        }
        public  string GoLesson()
        {

            var s = "Go 1 lesson";
            
            return s;
        }

    }

}
