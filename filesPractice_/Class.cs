using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesPractice_
{
    public class Class
    {
        private string Instructor;
        private string Subject;
        private int CourseNumber;
        private string CourseName;
        private string Room;

        public string instructor
        {
            get { return Instructor; }
            set { Instructor = value; }

        }

        public string subject
        {
            get { return Subject; }
            set { Subject = value; }
        }

        public int courseNumber
        {
            get { return CourseNumber; }
            set { CourseNumber = value; }
        }

        public string courseName
        {
            get { return CourseName; }
            set { CourseName = value; }
        }

        public string room
        {
            get { return Room; }
            set { Room = value; }
        }

        public override string ToString()
        {
            return $"Course: {subject} {courseNumber}\nName: {courseName}\nInstructor: {instructor}\nRoom: {room}\n";
        }
    }
}

