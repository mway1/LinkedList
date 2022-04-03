using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests.LinkedListTestsSources
{
    internal class FindMaxElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(new int[] { 1, 2, 3, 4, 5, 7 }), 7 };

            yield return new object[] { new LinkedList(new int[] { 3, 17, 8, 10 }), 17 };

            yield return new object[] { new LinkedList(new int[] { 2 }), 2 };
        }
    }
}
