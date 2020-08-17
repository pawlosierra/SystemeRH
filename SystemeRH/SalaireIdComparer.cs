using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeRH
{
    class SalaireIdComparer:IComparer<Employee>
    {
        public int Compare(Employee e1, Employee e2)
        {
            int r;
            if (e1.Salaire > e2.Salaire)
            {
                r = 1;
            }
            else if (e1.Salaire == e2.Salaire)
            {
                r = 0;
            }
            else
            { // s1.Grade<s2.Grade
                r = -1;
            }
            if (r == 0)
            {
                r = e1.Id - e2.Id;
            }
            return r;
        }
    }
}
