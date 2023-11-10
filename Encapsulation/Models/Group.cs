using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    internal class Group
    {
        private string _no;
        private int _studentLimit;
        private Student[] _students = new Student[0];

        public string No 
        {
            get
            {
                return _no;
            }
            set
            {
                value = value.Trim();
                if (value.Length == 5 && DigitCounter(value) == true && LetterCounter(value) == true)
                {
                    _no = value;
                }
                else
                {
                    Console.WriteLine("Duzdun ad yaz");
                }
            }
        }
        public int StudentLimit 
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (value >= 5 && value <= 18) 
                {
                    _studentLimit = value;
                }
            }
        }
        public Student[] Students 
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
            } 
        }

        public Group(string no,int studentlimit)
        {
            No = no;
            StudentLimit = studentlimit;
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = student;
            //Student[] newstudents = new Student[_students.Length + 1];
            //for (int i = 0; i < _students.Length; i++)
            //{
            //    newstudents[i] = _students[i];
            //}
            //newstudents[newstudents.Length - 1] = student;
            //_students = newstudents;
        }

        public void FilterByName(string text)
        {
            text = text.ToLower();
            string[] TextName = new string[0];
            for (int i = 0; i < _students.Length; i++)
            {
                string FullName = _students[i].Name + " " + _students[i].Surname;
                if (FullName.Trim().ToLower().Contains(text) == true)
                {
                    Array.Resize(ref TextName, TextName.Length + 1);
                    TextName[TextName.Length - 1] = FullName;
                }
            }
            foreach (string item in TextName)
            {
                Console.WriteLine(item);
            }
        }

        public bool DigitCounter(string text)
        {
            text = text.Trim();
            byte count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) == true)
                {
                    count ++;
                }
            }
            if (count == 3) 
            {
                return true;
            }
            return false;
        }

        public bool LetterCounter(string text)
        {
            text = text.Trim();
            byte count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]) == true)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            return false;
        }
    }
}
