using System;
using System.Collections.Generic;

namespace Lab21
{
    public class Student
    {
        public string FullName { get; set; }
        public List<string> Clubs { get; set; }

        public Student(string name, List<string> clubs)
        {
            FullName = name;
            Clubs = clubs;
        }

        // Перевірка, чи студент відвідує гурток
        public bool AttendsClub(string club)
        {
            return Clubs.Contains(club);
        }
    }
}
