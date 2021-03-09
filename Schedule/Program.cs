using System;
using System.Text;

namespace Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher KAA = new Teacher("Кирсанова", "Ал", "Ал");
            Teacher TSM = new Teacher("Трубина", "Соф", "Мар");
            Teacher TAV = new Teacher("Трубин", "Ан", "Вик");

            Lesson programming = new Lesson(8, "Программирование", "Дом", KAA);
            Lesson math = new Lesson(7, "Математика", "3", TSM);
            Lesson physics = new Lesson(6, "Физика", "4", TAV);

            Day Monday = new Day("Понедельник");

            Monday.AddLesson(physics);
            Monday.AddLesson(programming);
            Monday.AddLesson(math);

            Console.WriteLine(Monday.ShowDay());
        }
    }

    class Lesson
    {
        public int number;
        public string name;
        public string hall;
        public Teacher teacher;

        public Lesson(int number, string name, string hall, Teacher teacher)
        {
            this.number = number;
            this.name = name;
            this.hall = hall;
            this.teacher = teacher;
        }

        public string Show()
        {
            return number + ") " + "\"" + name + "\" " + "[" + hall + "] " + "(" + teacher.Introduce() + ")";
        }
            

    }

    class Teacher
    {
        public string surName;
        public string firstName;
        public string lastName;

        public Teacher(string surName, string firstName, string lastName)
        {
            this.surName = surName;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string Introduce()
        {
            return surName + " " + firstName[0] + ". " + lastName[0] + ".";
        }
    }
    class Day
    {
        string name;
        Lesson[] lessons = new Lesson[8];

        public Day(string name)
        {
            this.name = name;
        }

        public void AddLesson(Lesson lesson)
        {
            lessons[lesson.number - 1] = lesson;
        }

        public string ShowDay()
        {

            StringBuilder DaysScheldule = new StringBuilder();
            DaysScheldule.Append(this.name + "\n\n");

            int lessonsNumber = 1;

            foreach (Lesson lesson in lessons)
            {
                if (lesson != null)
                {
                    DaysScheldule.Append(lesson.Show() + "\n");
                }
                else
                {
                    DaysScheldule.Append(lessonsNumber + ")" + "\n");
                }
                lessonsNumber++;
            }

            return DaysScheldule.ToString();
        }
    }
}
