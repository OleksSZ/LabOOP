using System.Collections.Generic;

namespace Lab22
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

        public bool AttendsClub(string club)
        {
            return Clubs.Contains(club);
        }
    }
}
