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
                    new Group{ Id = 1, Name = "ИС-20-1", Students = Students.Where(x=>x.Id <= 12)},
                    new Group{ Id = 2, Name = "БУ-22-1", Students = Students.Where(x=> x.Id > 12 & x.Id <= 17)},
                    new Group{ Id = 3, Name = "КА-19-1", Students = Students.Where(x=>x.Id > 17)}
                };
            }
        }

        public static List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>()
                {
                     new Discipline{ Id = 1, Name = "Базы данных"},
                     new Discipline{ Id = 2, Name = "Анализ больших данных"},
                     new Discipline{ Id = 3, Name = "Проектирование ИС"},
                };
            }
        }

        public static List<Lesson> Lessons
        {
            get
            {
                return new List<Lesson>()
                {
                     new Lesson{ Id = 1, Datetime = DateTime.Now.AddDays(-10.0), LessonDiscipline = Disciplines[0], Group = Groups[0], Classroom = "3-404"},
                     new Lesson{ Id = 2, Datetime = DateTime.Now.AddDays(-8.0), LessonDiscipline = Disciplines[1], Group = Groups[1], Classroom = "3-405"},
                     new Lesson{ Id = 3, Datetime = DateTime.Now.AddDays(-6.0), LessonDiscipline = Disciplines[2], Group = Groups[2], Classroom = "3-406"},
                };
            }
        }

        public static List<AcademicPlan> AcademicPlans
        {
            get
            {
                return new List<AcademicPlan>() 
                {
                    new AcademicPlan(1, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 1),
                    new AcademicPlan(2, Disciplines[1], new List<TaskAcademicPlan>() 
                                                            { 
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 1),
                    new AcademicPlan(3, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 1),
                    new AcademicPlan(4, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 2),
                    new AcademicPlan(5, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 2),
                    new AcademicPlan(6, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 2),
                    new AcademicPlan(7, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 3),
                    new AcademicPlan(8, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 3),
                    new AcademicPlan(9, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 3),
                    new AcademicPlan(10, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 4),
                    new AcademicPlan(11, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 4),
                    new AcademicPlan(12, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 4),
                    new AcademicPlan(13, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 5),
                    new AcademicPlan(14, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 5),
                    new AcademicPlan(15, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 5),
                    new AcademicPlan(16, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 6),
                    new AcademicPlan(17, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 6),
                    new AcademicPlan(18, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 6),
                    new AcademicPlan(19, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 7),
                    new AcademicPlan(20, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 7),
                    new AcademicPlan(21, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 7),
                    new AcademicPlan(22, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 8),
                    new AcademicPlan(23, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 8),
                    new AcademicPlan(24, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 8),
                    new AcademicPlan(25, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 9),
                    new AcademicPlan(26, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 9),
                    new AcademicPlan(27, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 9),
                    new AcademicPlan(28, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 10),
                    new AcademicPlan(29, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 10),
                    new AcademicPlan(30, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 10),
                    new AcademicPlan(31, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 11),
                    new AcademicPlan(32, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 11),
                    new AcademicPlan(33, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 11),
                    new AcademicPlan(34, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 12),
                    new AcademicPlan(35, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 12),
                    new AcademicPlan(36, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 12),
                    new AcademicPlan(37, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 13),
                    new AcademicPlan(38, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 13),
                    new AcademicPlan(39, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 13),
                    new AcademicPlan(40, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 14),
                    new AcademicPlan(41, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 14),
                    new AcademicPlan(42, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 14),
                    new AcademicPlan(43, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 15),
                    new AcademicPlan(44, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 15),
                    new AcademicPlan(45, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 15),
                    new AcademicPlan(46, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 16),
                    new AcademicPlan(47, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 16),
                    new AcademicPlan(48, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 16),
                    new AcademicPlan(49, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 17),
                    new AcademicPlan(50, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 17),
                    new AcademicPlan(51, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 17),
                    new AcademicPlan(52, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 18),
                    new AcademicPlan(53, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 18),
                    new AcademicPlan(54, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 18),
                    new AcademicPlan(55, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 19),
                    new AcademicPlan(56, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 19),
                    new AcademicPlan(57, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 19),
                    new AcademicPlan(58, Disciplines[0], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(1, "Построение и описание модели «Сущность-связь»", 0, 7),
                                                                new TaskAcademicPlan(2, "Построение схемы данных", 0, 7),
                                                                new TaskAcademicPlan(3, "Построение запросов", 0, 7),
                                                            }, 20),
                    new AcademicPlan(59, Disciplines[1], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Выбор данных", 0, 7),
                                                                new TaskAcademicPlan(4, "Многомерный анализ", 0, 7),
                                                                new TaskAcademicPlan(5, "Загрузка и обработка данных", 0, 8)
                                                            }, 20),
                    new AcademicPlan(60, Disciplines[2], new List<TaskAcademicPlan>()
                                                            {
                                                                new TaskAcademicPlan(3, "Моделирование бизнес-процесса", 0, 7),
                                                                new TaskAcademicPlan(4, "Разработка технического задания", 0, 7),
                                                                new TaskAcademicPlan(5, "Эскизное проектирование", 0, 8)
                                                            }, 20),

                };
            }
        }
    }
}
