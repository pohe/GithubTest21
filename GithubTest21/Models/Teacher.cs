using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubTest21.Models
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Course { get; set; }
        public ushort Age { get; set; }

        public Teacher(string name, string course, ushort age)
        {
            Name = name;
            Course = course;
            Age = age;
        }
    }
}
