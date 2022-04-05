using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests.LinkedListTestsSources
{
    internal class DeleteAllByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 3, new LinkedList(new int[] { 1, 2, 3, 4, 3, 0, 7 }), new LinkedList(new int[] { 1, 2, 4, 0, 7 }), 2 };

            yield return new object[] { 1, new LinkedList(new int[] { 3, 1, 17, 1, 8, 19, 23, 1 }), new LinkedList(new int[] { 3, 17, 8, 19, 23 }), 3 };

            yield return new object[] { 2, new LinkedList(new int[] { 2 }), new LinkedList(new int[] { }), 1 };
        }
    }
}
