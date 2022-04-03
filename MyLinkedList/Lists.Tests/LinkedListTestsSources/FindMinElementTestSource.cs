using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests.LinkedListTestsSources
{
    internal class FindMinElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(new int[] { 1, 2, 3, 4, 0, 7 }), 0 };

            yield return new object[] { new LinkedList(new int[] { 3, 17, 8, 1 }), 1 };

            yield return new object[] { new LinkedList(new int[] { 2 }), 2 };
        }
    }
}
