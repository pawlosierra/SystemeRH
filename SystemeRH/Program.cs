using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeRH
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();
            Employee e1 = new Employee(1, "Tremblay", "Pierre");
            e1.Salaire = 83.5;
            list.Add(e1);
            list.Add(new Employee(44, "Smith", "Anne").withSalaire(85.3));
            list.Add(new Employee(45, "Smith", "Anne").withSalaire(85.3));
            list.Add(new Employee(28, "Barros", "Renan", 81.4));
            list.Add(new Employee(17, "Picard", "Jean", 90.5));
            list.Add(new Employee(19, "Brown", "Mary", 88.5));

            Console.WriteLine("List is by default sorted by the inclusion order");
            foreach (Employee a in list)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("List sorted by id (default order)");
            list.Sort();
            foreach (Employee a in list)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("List sorted by name, prenom et Id");
            list.Sort(new NomPrenomIdComparer());
            foreach (Employee a in list)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("List sorted by salaire");
            list.Sort(new SalaireIdComparer());
            foreach (Employee a in list)
                Console.WriteLine(a);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
