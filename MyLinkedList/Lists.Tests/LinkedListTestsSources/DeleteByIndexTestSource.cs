using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests.LinkedListTestsSources
{
    internal class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {2, new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { 1, 2, 4 }) };

            yield return new object[] {1, new LinkedList(new int[] { 3, 2 }), new LinkedList(new int[] { 3 }) };

            yield return new object[] {0, new LinkedList(new int[] { 2 }), new LinkedList(new int[] { }) };

        }

    }
}
