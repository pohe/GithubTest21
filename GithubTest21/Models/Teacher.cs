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
        public string Number { get; set; }
        //Her er der sket en ændring

        public Teacher(string name, string course, string number)
        {
            Name = name;
            Course = course;
            Number = number;
        }
    }
}
