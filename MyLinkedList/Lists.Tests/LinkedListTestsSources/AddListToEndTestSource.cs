using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests.LinkedListTestsSources
{
    internal class AddListToEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {new LinkedList(new int[] { 1, 2, 3, 4, 0, 7 }), new LinkedList(new int[] { 1,9,15 }), new LinkedList(new int[] { 1, 2, 3, 4, 0, 7, 1, 9, 15 }) };

            yield return new object[] {new LinkedList(new int[] { 3, 1, 17, 1, 8, 19, 23, 1 }), new LinkedList(new int[] { 23, 1, 15, 8 }), new LinkedList(new int[] { 3, 1, 17, 1, 8, 19, 23, 1, 23, 1, 15, 8 }) };

            yield return new object[] {new LinkedList(new int[] { 2 }), new LinkedList(new int[] {9, 4, 8}), new LinkedList(new int[] { 2, 9, 4, 8 }) };
        }
    }
}
