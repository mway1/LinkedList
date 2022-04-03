using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests.LinkedListTestsSources
{
    internal class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(new int[] { 1, 2, 3, 4, 5, 7 }), new LinkedList(new int[] { 7, 5, 4, 3, 2, 1 }) };

            yield return new object[] { new LinkedList(new int[] { 3, 2, 8, 10 }), new LinkedList(new int[] { 10, 8, 2, 3}) };

            yield return new object[] { new LinkedList(new int[] { 2 }), new LinkedList(new int[] { 2 }) };
        }
    }
}
