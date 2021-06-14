using System;

namespace Exercise4
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Greet();
            Student s1 = new Student();
            s1.SetAge(21);
            s1.Greet();
            s1.ShowAge();
            Teacher t1 = new Teacher();
            t1.SetAge(30);
            t1.Greet();
            t1.Explain();
        }
    }
}
