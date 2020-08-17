using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeRH
{
    class NomPrenomIdComparer:IComparer<Employee>
    {
        public int Compare(Employee e1, Employee e2)
        {
            int r = e1.Nom.CompareTo(e2.Nom);
            if (r == 0) { r = e1.Prenom.CompareTo(e2.Prenom); }
            if (r == 0) { r = e1.Id - e2.Id; }
            return r;
        }
    }
}
