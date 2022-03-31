using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests.LinkedListTestsSources
{
    internal class DeleteLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { 1, 2, 3 }) };

            yield return new object[] {new LinkedList(new int[] { 3, 2 }), new LinkedList(new int[] {3 }) };

            yield return new object[] {new LinkedList(new int[] {2}), new LinkedList(new int[] {  }) };

        }

    }
}
