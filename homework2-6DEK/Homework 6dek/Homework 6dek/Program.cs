using System;

namespace Homework_6dek
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            Teacher tch1 = new Teacher();
            Person p1 = new Person();
            stu1.Study();
            tch1.Explain();
            p1.SetAge(8);
            stu1.ShowAge(58);
            p1.Greet();
        }
    }
}
