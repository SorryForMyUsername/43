using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_4
{
    internal struct Student
    {
        string fio;
        int group;
        int informatics;
        int physics;
        int history;

        public string FIO { get => fio; set => fio = value; }
        public int Group { get => group; set => group = value; }
        public int Informatics { get => informatics; set => informatics = value; }
        public int Physics { get => physics; set => physics = value; }
        public int History { get => history; set => history = value; }

        public Student(string fio, int group, int informatics, int physics, int history)
        {
            this.fio = fio;
            this.group = group;
            this.informatics = informatics;
            this.physics = physics;
            this.history = history;
        }

        public static Student Input()
        {
            Console.Write("ФИО: ");
            string fio = Console.ReadLine();
            Console.Write("Группа: ");
            int group = int.Parse(Console.ReadLine());
            Console.Write("Информатика: ");
            int informatics = int.Parse(Console.ReadLine());
            Console.Write("Физика: ");
            int physics = int.Parse(Console.ReadLine());
            Console.Write("История: ");
            int history = int.Parse(Console.ReadLine());

            Student newStudent = new Student();
            newStudent.FIO = fio;
            newStudent.Group = group;
            newStudent.Informatics = informatics;
            newStudent.Physics = physics;
            newStudent.History = history;

            return newStudent;
        }
    }
}
