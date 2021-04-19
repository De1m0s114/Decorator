using System;
namespace ConsoleApp1
{
    public class ThirdLesson : Study
    {
        private Study _study;
        public ThirdLesson(Study study)
        {
            _study = study;
            this.GoLesson();
             
        }

        public  string GoLesson()
        {

            var s = "Go 3 lesson";
            Console.WriteLine(_study.GoLesson() + s);
            return _study.GoLesson()+s;
        }
        

    }

}
