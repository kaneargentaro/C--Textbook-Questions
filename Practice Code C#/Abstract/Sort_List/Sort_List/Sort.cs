using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_List
{
    class Sort<TYPE> where TYPE : IComparable
    {
        private List<TYPE> numberlist = new List<TYPE>();

       public void Add(List<int> sort)
        {
            numberlist.Add(sort);
        }

        TYPE Minimum<TYPE>(TYPE first, TYPE second)
            where TYPE : IComparable<TYPE>
            {
                TYPE result = first;
                if (second.CompareTo(first) < 0)
                    result = second;
            Console.WriteLine("Minimum number is {0}", result);
            return result;
            }

        TYPE Maximum<TYPE>(TYPE first, TYPE second)
             where TYPE : IComparable<TYPE>
        {
            TYPE result = first;
            if (first.CompareTo(second) < 0)
                result = first;
            Console.WriteLine("Maximum number is {0}", result);
            return result;
        }
    }
}
