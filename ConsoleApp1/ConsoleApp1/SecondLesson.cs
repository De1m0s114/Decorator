using System;
namespace ConsoleApp1
{
    public class SecondLesson : Study
    {
        private Study _study;

        public SecondLesson(Study study)
        {
            _study = study;
            this.GoLesson();
            
        }


        public  string GoLesson()
        {
            var s = "Go 2 lesson";
            
            
            return _study.GoLesson() +s;
        }


    }

}
