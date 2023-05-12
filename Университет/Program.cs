using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Students
    {
        public string surname;
        public string name;
        public string lastname;
        public int group;
        public string[] marks;

        public Students(string surname, string name, string lastname, int group, string[] marks)
        {
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.group = group;
            this.marks = marks;
        }
    }
    public class Teachers
    {
        public string surname;
        public string name;
        public string lastname;
        public string[] subjects;

        public Teachers(string surname, string name, string lastname, string[] subjects)
        {
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.subjects = subjects;
        }
    }
    public class Managers
    {
        public string surname;
        public string name;
        public string lastname;
        public string lvl;
        public string order;

        public Managers(string surname, string name, string lastname, string lvl, string order)
        {
            this.surname = surname;
            this.name = name;
            this.lastname = lastname;
            this.lvl = lvl;
            this.order = order;
        }
    }
    internal class Program
    {
        static List<Students> InputStudents(List<Students>students)
        {
            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string lastname = Console.ReadLine();
            Console.WriteLine("Введите группу");
            int group = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите предметы и оценки через запятую (предмет,оценка,предмет,оценка...)");
            string[] marks = Console.ReadLine().Split(',');
            Students student = new Students(surname, name, lastname, group, marks);
            students.Add(student);
            return students;
        }
        static List<Teachers> InputTeacherss(List<Teachers>teachers)
        {
            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string lastname = Console.ReadLine();
            Console.WriteLine("Введите предметы через запятую (предмет,предмет...)");
            string[] subjects= Console.ReadLine().Split(',');
            Teachers teacher = new Teachers(surname, name, lastname,subjects);
            teachers.Add(teacher);
            return teachers;
        }
        static List<Managers> InputManagers(List<Managers> managers)
        {
            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string lastname = Console.ReadLine();
            Console.WriteLine("Введите уровень доступа приказа" +"\n"+"s - студенты"+ "\n" + "t - преподаватели"+ "\n" + "m - управленцы"+ "\n" + "a - все");
            string lvl = Console.ReadLine();
            Console.WriteLine("Введите приказ");
            string order = Console.ReadLine();
            Managers manager = new Managers(surname, name, lastname, lvl, order);
            managers.Add(manager);
            return managers;
        }
        static void Menu(List<Students> students, List<Teachers> teachers, List<Managers> managers)
        {
            Console.Write(@"
Добро пожаловать в систему университета Шуток

1)Ввод данных
2)Запросы

Введите любой символ или оставьте строку пустой для выхода

Ввод:");
            string n1 = Console.ReadLine();
            Console.Clear();
            string bt = "0";
            string kt = "0";
            switch (n1)
            {
                case "1":
                    while (bt == "0")
                    {
                        Console.Write(@"
1) Добавить студента
2) Добавить преподавателя
3) Добавить приказ

Введите любой символ или оставьте строку пустой чтобы вернуться назад

Ввод:");
                        string n2 = Console.ReadLine();
                        Console.Clear();
                        string at = "1";
                        switch (n2)
                        {
                            case "1":
                                while (at == "1")
                                {
                                    InputStudents(students);
                                    Console.Clear();
                                    Console.Write(@"
1)Продолжить ввод

Введите любой символ или оставьте строку пустой чтобы вернуться назад

Ввод:");
                                    at = Console.ReadLine();
                                    Console.Clear();
                                }
                                break;
                            case "2":
                                at = "1";
                                while (at == "1")
                                {
                                    InputTeacherss(teachers);
                                    Console.Clear();
                                    Console.Write(@"
1)Продолжить ввод

Введите любой символ или оставьте строку пустой чтобы вернуться назад

Ввод:");
                                    at = Console.ReadLine();
                                    Console.Clear();
                                }

                                break;
                            case "3":
                                at = "1";
                                while (at == "1")
                                {
                                    InputManagers(managers);
                                    Console.Clear();
                                    Console.Write(@"
1)Продолжить ввод

Введите любой символ или оставьте строку пустой чтобы вернуться назад

Ввод:");
                                    at = Console.ReadLine();
                                    Console.Clear();
                                }
                                break;
                            default:
                                Menu(students, teachers, managers);
                                bt = "";
                                break;

                        }
                    }
                    break;

                case "2":
                    while (kt == "0")
                    {
                        Console.Write(@"
1) Вывести список приказов
2) Вывести должников преподавателя (по ФИО)
3) Вывести долги студента

Введите любой символ или оставьте строку пустой чтобы вернуться назад

Ввод:");
                        string n3 = Console.ReadLine();
                        Console.Clear();
                        string ct = "0";
                        switch (n3)
                        {
                            case "1":
                                while (ct == "0")
                                {
                                    Console.Write(@"
1) Приказы для студентов
2) Приказы для преподавателей
3) Приказы для управленцев
4) Приказы для всех

Введите любой символ или оставьте строку пустой чтобы вернуться назад

Ввод:");
                                    string n4 = Console.ReadLine();
                                    Console.Clear();
                                    switch (n4)
                                    {
                                        case "1":
                                            for (int i = 0; i < managers.Count; i++)
                                            {
                                                if (managers[i].lvl == "s")
                                                {
                                                    Console.WriteLine(managers[i].order);
                                                    Console.Write(managers[i].name + " " + managers[i].surname + " " + managers[i].lastname);
                                                    Console.WriteLine();
                                                }
                                            }
                                            break;
                                        case "2":
                                            for (int i = 0; i < managers.Count; i++)
                                            {
                                                if (managers[i].lvl == "t")
                                                {
                                                    Console.WriteLine(managers[i].order);
                                                    Console.Write(managers[i].name + " " + managers[i].surname + " " + managers[i].lastname);
                                                    Console.WriteLine();
                                                }
                                            }
                                            break;
                                        case "3":
                                            for (int i = 0; i < managers.Count; i++)
                                            {
                                                if (managers[i].lvl == "m")
                                                {
                                                    Console.WriteLine(managers[i].order);
                                                    Console.Write(managers[i].name + " " + managers[i].surname + " " + managers[i].lastname);
                                                    Console.WriteLine();
                                                }
                                            }
                                            break;
                                        case "4":
                                            for (int i = 0; i < managers.Count; i++)
                                            {
                                                if (managers[i].lvl == "a")
                                                {
                                                    Console.WriteLine(managers[i].order);
                                                    Console.Write(managers[i].name + " " + managers[i].surname + " " + managers[i].lastname);
                                                    Console.WriteLine();
                                                }
                                            }
                                            break;
                                        default:
                                            ct = "";
                                            break;
                                    }
                                }
                                break;
                            case "2":
                                Console.WriteLine("Введите ФИО преподавателя");
                                string[] FIO = Console.ReadLine().Split(' ');
                                for (int i = 0; i < teachers.Count(); i++)
                                {
                                    if (teachers[i].surname == FIO[0] && teachers[i].name == FIO[1] && teachers[i].lastname == FIO[2])
                                    {
                                        for (int z = 0; z < teachers[i].subjects.Length; z++)
                                        {
                                            for (int j = 0; j < students.Count(); j++)
                                            {
                                                for (int k = 0; k < students[j].marks.Length; k += 2)
                                                {
                                                    if (teachers[i].subjects[z] == students[j].marks[k] && students[j].marks[k+1] == "Д")
                                                    {
                                                        Console.WriteLine(students[j].surname + " " + students[j].name + " " + students[j].lastname + " " + teachers[i].subjects[z]);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                break;
                            case "3":
                               Console.WriteLine("Введите ФИО студента");
                               string[] fio = Console.ReadLine().Split(' ');
                                for (int i = 0; i <students.Count(); i++)
                                {
                                    if (students[i].surname == fio[0] && students[i].name == fio[1] && students[i].lastname == fio[2])
                                    {
                                    for (int j = 0; j < students[i].marks.Length; j += 2)
                                        {
                                        if (students[i].marks[j+1] == "Д")
                                            {
                                            for (int k = 0; k < teachers.Count(); k++)
                                                {
                                                    for (int z = 0; z < teachers[k].subjects.Length; z++)
                                                    {
                                                        if (students[i].marks[j] == teachers[k].subjects[z])
                                                        {
                                                            Console.WriteLine(teachers[k].surname + " " + teachers[k].name + " " + teachers[k].lastname + " " + teachers[k].subjects[z]);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                break;

                            default:
                                kt = "";
                                Menu(students, teachers, managers);
                                break;
                        }
                    }
                    break;

            }
        }
        static void Main()
        {
            List<Students> Students = new List<Students>();
            List<Teachers> Teachers = new List<Teachers>();
            List<Managers> Managers = new List<Managers>();
            Menu(Students, Teachers, Managers);

        }
    }
}
