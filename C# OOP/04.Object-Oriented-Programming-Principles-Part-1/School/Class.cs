namespace School
{
    using System;
    using System.Collections.Generic;
    public class Class : IComment
    {
        private string id;
        public List<Student> Students { get; private set; }
        public List<Teacher> Teachers { get; private set; }
        public string Comment { get; private set; }

        public Class(string id, List<Student> students, List<Teacher> teachers)
        {
            this.Id = id;
            this.Students = students;
            this.Teachers = teachers;
        }

        public string Id
        {
            get { return this.id; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Class identifier cannot be empty or null");
                }
                this.id = value; 
            }
        }

        public void MakeComment(string text)
        {
            this.Comment = text;
        }
    }
}
