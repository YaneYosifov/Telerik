namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Teacher : Person, IComment
    {
        private List<Discipline> disciplines;
        public string Comment { get; private set; }

        public Teacher(string name, IEnumerable<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines.ToList();
        }

        public List<Discipline> Disciplines
        {
            get { return new List<Discipline>(this.disciplines); }
            private set 
            {
                if (value.Count < 1)
                {
                    throw new ArgumentOutOfRangeException("Disciplines must be > 0");
                }
                this.disciplines = value; 
            }
        }

        public void MakeComment(string text)
        {
            this.Comment = text;
        }
    }
}
