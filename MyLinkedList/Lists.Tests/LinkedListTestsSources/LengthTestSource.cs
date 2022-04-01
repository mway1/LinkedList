using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests.LinkedListTestsSources
{
    internal class LengthTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {new LinkedList(new int[] { 1, 2, 3, 4, 5, 7 }),6 };

            yield return new object[] {new LinkedList(new int[] { 3, 2, 8, 10 }),4 };

            yield return new object[] {new LinkedList(new int[] { 2 }),1 };
            
            yield return new object[] {new LinkedList(new int[] {  }),0 };
        }
    }
}
