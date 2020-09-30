﻿using System;
using System.Collections.Generic;
using System.Data;

namespace z2
{
    class Student
    {

        public string name;
        public string state;

        public Student(string _name)
        {
            name = _name;
            state = "";
        }
        public virtual void Study() { }
        public void Read()
        {
            state += "Read ";
        }
        public virtual void Write()
        {
            state += "Write ";
        }
        public virtual void Relax()
        {
            state += "Relax ";
        }

    }

    class GoodStudent : Student
    {
        public GoodStudent(string name)
            : base(name) { state += "good "; }
        public override void Study()
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
        }
    }

    class BadStudent : Student
    {
        public BadStudent(string name)
            : base(name) { state += "bad "; }
        public override void Study()
        {
            Relax();
            Relax();
            Relax();
            Relax();
            Read();
        }
    }

    class Group
    {
        public string Name;
        private List<Student> StudentList;
        public Group(string _name)
        {
            Name = _name;
            StudentList = new List<Student>() { };
        }
        public void AddStudent(Student st)
        {
            StudentList.Add(st);
        }
        public void GetInfo()
        {
            Console.WriteLine("Group " + Name);
            StudentList.ForEach(delegate (Student st)
            {
                Console.WriteLine("Group " + Name);
                Console.WriteLine(st.name);
            });
        }
        public void GetFullInfo()
        {
            Console.WriteLine("Group " + Name);
            StudentList.ForEach(delegate (Student st)
            {
                Console.WriteLine("Group " + Name);
                Console.WriteLine(st.name + " " + st.state);
            });
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new GoodStudent("Oleksandr");
            Student b = new GoodStudent("Roman");
            Student c = new BadStudent("Kiril");
            Group K25 = new Group("K-25");
            K25.AddStudent(a);
            K25.AddStudent(b);
            K25.AddStudent(c);
            a.Study();
            b.Study();
            c.Study();
            K25.GetInfo();
            K25.GetFullInfo();

        }
    }
}
