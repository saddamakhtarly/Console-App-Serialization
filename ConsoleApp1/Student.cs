using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
    class Student
    {
       
        public int id;
        public string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
