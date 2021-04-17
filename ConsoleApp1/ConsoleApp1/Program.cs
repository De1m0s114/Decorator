using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s= new FirstLesson(new ThirdLesson()) ;
            Console.ReadLine();
        }
    }

     public interface Study     
     {
     public abstract string GoLesson();
     }

}
