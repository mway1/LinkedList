using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests.LinkedListTestsSources
{
    internal class SortInAscendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(new int[] { 1, 2, 3, 4, 0, 7 }), new LinkedList(new int[] { 0, 1, 2, 3, 4, 7 }) };

            yield return new object[] { new LinkedList(new int[] { 3, 17, 8, 1 }), new LinkedList(new int[] { 1, 3, 8, 17 }) };

            yield return new object[] { new LinkedList(new int[] { 2 }), new LinkedList(new int[] { 2 }) };
        }
    }
}
