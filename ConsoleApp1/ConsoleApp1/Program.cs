using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s= new ThirdLesson(new SecondLesson(new FirstLesson()));
            Console.ReadLine();
        }
    }

     public interface Study     
     {
     public abstract string GoLesson();
 
    }

}
