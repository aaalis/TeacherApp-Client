using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeacherApp.Models;

namespace TeacherApp.Services
{
    public static class MockDataStore
    {
        public static List<Student> Students
        {
            get
            {
                return new List<Student>()
                {
                    new Student{ Id = 1, Name = "Иванов И.И."},
                    new Student{ Id = 2, Name = "Сидоров И.И."},
                    new Student{ Id = 3, Name = "Горшенев И.И."},
                    new Student{ Id = 4, Name = "Федоров И.И."},
                    new Student{ Id = 5, Name = "Назаров Д. М"},
                    new Student{ Id = 6, Name = "Петров И.И."},
                    new Student{ Id = 7, Name = "Кузнецов Д. Е."},
                    new Student{ Id = 8, Name = "Орлов А. Д."},
                    new Student{ Id = 9, Name = "Игнатьев Л. С."},
                    new Student{ Id = 10, Name = "Плотникова Т. М."},
                    new Student{ Id = 11, Name = "Пономарева К. С."},
                    new Student{ Id = 12, Name = "Карпов Е. А."},
                    new Student{ Id = 13, Name = "Власова М. Л."},
                    new Student{ Id = 14, Name = "Савин Р. Д."},
                    new Student{ Id = 15, Name = "Фомин С. А."},
                    new Student{ Id = 16, Name = "Белоусов Д. М."},
                    new Student{ Id = 17, Name = "Лаврентьева Ф. Д."},
                    new Student{ Id = 18, Name = "Никитин И. М."},
                    new Student{ Id = 19, Name = "Балашов Д. И."},
                    new Student{ Id = 20, Name = "Лавров С. А."}
                };
            }
        }

        public static List<Group> Groups
        {
            get
            {
                return new List<Group>()
                {
                    new Group{ Id = 1, Name = "ИС-20-1", Students = Students.Where(x=>x.Id <= 15)},
                    new Group{ Id = 2, Name = "БУ-22-1", Students = Students.Where(x=> x.Id > 10 & x.Id <= 17)},
                    new Group{ Id = 3, Name = "КА-19-1", Students = Students.Where(x=>x.Id > 17)}
                };
            }
        }

        public static List<Lesson> Lessons
        {
            get
            {
                return new List<Lesson>()
                {
                     new Lesson{ Id = 1, Datetime = DateTime.Now.AddDays(-10.0), Discipline = "Базы данных", Group = Groups[0]},
                     new Lesson{ Id = 2, Datetime = DateTime.Now.AddDays(-8.0), Discipline = "Анализ больших данных", Group = Groups[1]},
                     new Lesson{ Id = 3, Datetime = DateTime.Now.AddDays(-6.0), Discipline = "Проектирование ИС", Group = Groups[2]},
                };
            }
        }
    }
}
