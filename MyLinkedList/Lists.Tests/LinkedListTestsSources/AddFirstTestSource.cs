using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests.LinkedListTestsSources
{
    internal class AddFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, new LinkedList(new int[] { 1, 2, 3, 4 }), new LinkedList(new int[] { 1, 1, 2, 3, 4 }) };

            yield return new object[] { 2, new LinkedList(new int[] { 3, }), new LinkedList(new int[] { 2,3 }) };

            yield return new object[] { 10, new LinkedList(new int[] { }), new LinkedList(new int[] { 10 }) };

        }

    }
}
