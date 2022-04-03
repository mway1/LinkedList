using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests.LinkedListTestsSources
{
    internal class FindFirstIndexByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new LinkedList(new int[] { 1, 2, 3, 4, 5, 7 }),1  };

            yield return new object[] { 10,new LinkedList(new int[] { 3, 2, 8, 10 }), 3 };

            yield return new object[] { 1,new LinkedList(new int[] { 2 }),-1 };
        }
    }
}
