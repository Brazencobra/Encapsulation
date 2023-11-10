using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    internal class Student
    {
        private string _name;
        private string _surname;
        private byte _avgpoint;

        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Trim().Length <= 16)
                {
                    _name = value.Trim();
                }
            }
        
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value.Trim().Length <= 20)
                {
                    _surname = value.Trim();
                }
            }
        }
        public byte AvgPoint 
        {
            get
            {
                return _avgpoint;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _avgpoint = value;
                }
            }
        }

        public Student(string name,string surname,byte avgpoint)
        {
            Name = name;
            Surname = surname;
            AvgPoint = avgpoint;
        }

    }
}
