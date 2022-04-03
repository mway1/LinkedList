using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests.LinkedListTestsSources
{
    internal class ChangeValueByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, 15, new LinkedList(new int[] { 1, 2, 3, 4, 5, 7 }), new LinkedList(new int[] { 1, 2, 15, 4, 5, 7 }) };

            yield return new object[] { 0, 7, new LinkedList(new int[] { 3, 2, 8, 10 }), new LinkedList(new int[] { 7, 2, 8, 10 }) };

            yield return new object[] { 0, 15, new LinkedList(new int[] { 2 }), new LinkedList(new int[] { 15 }) };
        }
    }
}
