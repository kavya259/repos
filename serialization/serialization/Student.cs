using System;
using System.Collections.Generic;
using System.Text;

namespace serialization
{
    [Serializable]
    class Student
    {
         int id;
        string name;

       
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
