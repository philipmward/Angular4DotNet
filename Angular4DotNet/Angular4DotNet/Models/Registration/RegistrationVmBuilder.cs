﻿using Angular4DotNet.Models.Courses;
using Angular4DotNet.Models.Instructors;

namespace Angular4DotNet.Models.Registration
{
    public class RegistrationVmBuilder
    {
        public CourseVm[] GetCourseVms()
        {
            var courses = new[]
            {
                //in a real project this wouldn't happen or be here.
                new CourseVm {Number = "CREA101", Name = "Care of Magical Creatures", Instructor = "Rubeus Hagrid"},
                new CourseVm {Number = "DARD502", Name = "Defence Against the Dark Arts", Instructor = "Severus Snape"},
                new CourseVm {Number = "TRAN201", Name = "Transfiguration", Instructor = "Minerva McGonagall"}
            };
            return courses;
        }

        public InstructorVm[] GetInstructorVms()
        {
            var instructors = new[]
            {
                new InstructorVm {Name = "Rubeus Hagrid", Email = "hagrid@hogwarts.com", RoomNumber = 1001},
                new InstructorVm {Name = "Severus Snape", Email = "snape@hogwarts.com", RoomNumber = 105},
                new InstructorVm {Name = "Minerva McGonagall", Email = "mcgonagall@hogwarts.com", RoomNumber = 102}
            };
            return instructors;
        }
    }
}