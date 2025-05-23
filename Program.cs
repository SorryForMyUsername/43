using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_4
{
    internal class Program
    {
        /// <summary>
        /// Описать структуру с полями: 
        /// ФИО (string), группа, информатика, физика, история. 
        /// Создать массив или коллекцию из n объектов данной струтуры. 
        /// Ввод данных осуществлять с клавиатуры. 
        /// Сведения об объектах вывести в табличном виде. 
        /// В случае отсутствии информации об объектах вывести 
        /// сообщение об отсутствии объектов. 
        /// Определить средний балл оценок по каждому предмету. 
        /// Вывести сведения о студентах, 
        /// средний балл которых выше 4 и вывести их кол-во.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                Console.WriteLine("Выберите действие:\n" +
                    "1. Добавить нового студента\n" +
                    "2. Вывести всех студентов\n" + 
                    "3. Вывести студентов, у которых средний балл выше 4.0\n" +
                    "4. Выход\n");

                int choise = Console.ReadKey(true).KeyChar - '0';
                switch (choise)
                {
                    case 1: students.Add(Student.Input()); break;
                    case 2: OutputStudents(students); break;
                    case 3: OutputSmartStudents(students, 4); break;
                    case 4: return;
                }
                Console.WriteLine();
            }
        }

        static void OutputStudents(List<Student> students)
        {
            if(students.Count == 0)
            {
                Console.WriteLine("Информация о студентах отсутствует!");
                return;
            }

            Console.WriteLine($"{"ФИО", -35} {"Группа", -7} {"Информатика", -12} {"Физика", -7} {"История", -10} {"Средний балл", 15}");
            foreach(Student student in students)
            {
                Console.WriteLine($"{student.FIO, -35} {student.Group, 7} {student.Informatics, 12} {student.Physics, 7} {student.History, 10} {(double)(student.Informatics + student.Physics + student.History) / 3, 15:f2}");
            }
            Console.WriteLine($"Среднее значение: {students.Average(s => s.Informatics),38:f2} {students.Average(s => s.Physics), 7:f2} {students.Average(s => s.History), 10:f2}");
        }

        static void OutputSmartStudents(List<Student> students, int minAverageScore)
        {
            List<Student> smartStudents = students.Where(s => (double)(s.Informatics + s.Physics + s.History) / 3 >= 4).ToList();

            OutputStudents(smartStudents);

            Console.WriteLine($"\nКол-во студентов со средним баллом выше 4 - {smartStudents.Count}");
        }
    }
}
