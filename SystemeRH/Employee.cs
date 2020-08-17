using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeRH
{
    public class Employee : IComparable<Employee>
    {
        private int id;
        private string nom;
        private string prenom;
        private double salaire;


        public int Id
        {
            get => id;
            set
            {
                if (value <= 0)
                {
                    throw new EmployeeDataException(1, value);
                }
                else
                {
                    this.id = value;
                }
            }
        }

        public string Nom
        {
            get => nom;
            set
            {
                if (!isValidNom(value))
                {
                    throw new EmployeeDataException(2, nom);
                }
                else
                {
                    this.nom = value;
                }
            }
        }

        public string Prenom
        {
            get => prenom;
            set
            {
                if (!isValidNom(value))
                {
                    throw new EmployeeDataException(3, prenom);
                }
                else
                {
                    this.prenom = value;
                }
            }
        }

        public double Salaire
        {
            get => salaire;
            set          // set(double value)
            {
                if (value < 0)
                {
                    throw new EmployeeDataException(4, value);
                }
                else
                {
                    this.salaire = value;
                }
            }
        }

        public Employee(int id, String nom, String prenom)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
        }

        public Employee(int id, String nom, String prenom, double salaire)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Salaire = salaire;
        }

        private bool isValidNom(String n)
        {
            bool r = true;
            foreach (char c in n)
                if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && (c != ' ' || c != '-'))
                    r = false;
            return r;
        }

        public Employee withSalaire(double salaire)
        {
            Salaire = salaire;
            return this;
        }

        public int CompareTo(Employee s)
        {
            return this.id - s.id;  // for ascending order
        }

        public override string ToString()
        {
            return "Employee [id=" + id + ", nom=" + nom + ", prenom=" + prenom + ", salaire=" + salaire + "]";
        }
    }
}
