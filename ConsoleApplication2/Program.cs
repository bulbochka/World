using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Gender { Male, Female }  //мужчина/женщина
namespace ConsoleApplication2
{
    class Age
    {
        public int age_baby;
        public int age_pupils;
        public int age_grown;
        public int age_elderly;
        public int year;
        public string status;
        public string status2;

        public Age(int year)
        {
            if (year == 1 || year <= 5)
            {
                status = "Baby"; // ребенок
                status2 = "Cry";
                age_baby = year;
            }
            else if (year == 6 || year <= 17)
            {
                status = "Pupils"; //школьник
                status2 = "Scholl";
                age_pupils = year;
            }
            else if (year == 18 || year <= 50)
            {
                status = "Grown"; //взрослый
                status2 = "Work";
                age_grown = year;
            }
            else if (year >= 51)
            {
                status = "Elderly"; // пожилой
                status2 = "Garden";
                age_elderly = year;
            }
        }
    }

    class Persona : Age
    {
        public string name;
        
        public Persona(string name, int year) : base(year)
        {
            this.name = name;
            this.year = year;
        }

        virtual public void Show()
        {
            Console.WriteLine("Name {0}", name);
            Console.WriteLine("Year {0}", year);
            Console.WriteLine("Status {0}", status);
            Console.WriteLine("Status {0}", status2);
            Console.WriteLine("\n");
        }
    }

    class Civilization
    {
        List<Persona> people = new List<Persona>();

        public void Add(Persona p)
        {
            people.Add(p);
        }
        public void Add(string name, int year)
        {
            people.Add(new Persona(name, year));
        }

        public void Growth(Persona p) //развитие, рост
        {
            p.year++;
        }
        public void Move(Persona p)
        {

        }

        public void Show_All()
        {
            foreach (Persona p in people)
            {
                p.Show();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Masha", 49);
            Civilization c = new Civilization();
            c.Add(p);
            c.Show_All();
            c.Growth(p);
            c.Growth(p);
            c.Growth(p);
            c.Show_All();
        }
    }
}
