using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests.LinkedListTestsSources
{
    internal class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {2, 1, new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { 1, 2, 1, 3, 4 }) };

            yield return new object[] { 0,10, new LinkedList(new int[] { 3,2 }), new LinkedList(new int[] { 10, 3, 2 }) };

            //yield return new object[] { 0, 4, new LinkedList(new int[] { }), new LinkedList(new int[] { 4 }) };

        }

    }
}
