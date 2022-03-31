using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests.LinkedListTestsSources
{
    internal class DeleteFromBeginingElementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 4, new LinkedList(new int[] { 1, 2, 3, 4, 5, 7 }), new LinkedList(new int[] { 5, 7 }) };

            yield return new object[] { 2, new LinkedList(new int[] { 3, 2, 8, 10 }), new LinkedList(new int[] { 8,10 }) };

            yield return new object[] { 1, new LinkedList(new int[] { 2 }), new LinkedList(new int[] { }) };
        }
    }
}
