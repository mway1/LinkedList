using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class LinkedList
    {
        private Node _root;

        private Node _tail;

        public int this[int index]
        {
            get
            {
                if (index<0 || index>= Length)
                {
                    throw new IndexOutOfRangeException("This index doesn't exist");
                }
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }
                return crnt.Value;
            }

            set
            {

                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException("This index doesn't exist");
                }
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }
                crnt.Value=value;
            }
        }

        public int Length
        {
            get
            {
                int count = 0;
                Node crnt = _root;

                while (crnt != null)
                {
                    crnt = crnt.Next;
                    count++;
                }

                return count;
            }
            private set
            {
            }
        }

        public LinkedList()
        {
            _root = null;

            _tail = null;
        }

        public LinkedList(int value)
        {
            _root = new Node(value);
            _tail = _root;
        }

        public LinkedList(int[] array)
        {
            if (array.Length == 0)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                _root = new Node(array[0]);
                Node crnt = _root;
                for (int i=1; i< array.Length; i++)
                {
                    crnt.Next = new Node(array[i]);
                    crnt = crnt.Next;
                }
                _tail = crnt;
            }
        }

        public void AddToEnd(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }

            else
            {
                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
        }

        public void AddFirst(int value)
        {
            if (_root is null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                Node crnt = _root;
                _root = new Node(value);
                _root.Next = crnt;
            }
        }

        public void AddByIndex(int index, int value)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (_root is null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                if (index == 0)
                {
                    AddFirst(value);
                }
                else
                {
                    Node previousNode = GetNodeByIndex(index - 1);
                    Node nextNode = GetNodeByIndex(index);
                    Node newNode = new Node(value);
                    previousNode.Next = newNode;
                    newNode.Next = nextNode;
                }
            }
        }

        public void DeleteLast()
        {
            if (_tail is null)
            {
                throw new Exception("Nothing to delete, add elemenets");
            }
            if (Length < 2)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                Node prevLast = GetNodeByIndex(Length - 2);
                prevLast.Next = null;
                _tail = prevLast;
            }
        }

        public void DeleteFirst()
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to delete, add elemenets");
            }
            _root = _root.Next;
        }

        public void DeleteByIndex(int index)
        {
            if (_tail is null)
            {
                throw new Exception("Nothing to delete, add elemenets");
            }
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                _root = _root.Next;
            }
            else
            {
                Node prevNode = GetNodeByIndex(index - 1);
                Node nextNode = prevNode.Next.Next;
                prevNode.Next = nextNode;
                if (index == Length)
                {
                    _tail = prevNode;
                }
            }
        }

        public void DeleteFromEndElements(int count)
        {
            if(Length < 1)
            {
                throw new Exception("Nothing to delete");
            }
            if (count < 1 || count > Length)
            {
                throw new ArgumentException("Incorrect number");
            }
            if (Length == count)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                Node newLastNode = GetNodeByIndex(Length - count - 1);
                newLastNode.Next = null;
                _tail = newLastNode;
            }
        }

        public void DeleteFromBeginingElements(int count)
        {
            if (Length < 1)
            {
                throw new Exception("Nothing to delete");
            }
            if (count < 1 || count > Length)
            {
                throw new ArgumentException("Incorrect number");
            }
            if (Length == count)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                Node newLastNode = GetNodeByIndex(count);
                _root = newLastNode;
            }
        }

        public void DeleteElementsByIndex(int count,int index)
        {
            if (Length < 1)
            {
                throw new Exception("Nothing to delete");
            }
            if (index < 0 || index > Length - 1)
            {
                throw new ArgumentException("Incorrect number");
            }
            Node prevDelete = GetNodeByIndex(index - 1);
            Node nextDelete = GetNodeByIndex(index+count);

            if (index == 0)
            {
                _root = nextDelete;
            }
            else
            {
                prevDelete.Next = nextDelete;
            }
            _tail = GetNodeByIndex(Length - 1);
        }

        public int FindFirstIndexByValue(int value)
        {
            if (Length ==0)
            {
                throw new Exception("Nothing to find");
            }

            int firstIndex = -1;
            Node crnt = _root;

            for (int i = 0; i < Length; i++)
            {
                if (crnt.Value == value)
                {
                    firstIndex = i;
                    break;
                }
                crnt = crnt.Next;
            }
            return firstIndex;
        }

        public void ChangeValueByIndex(int index, int value)
        {
            if (Length == 0)
            {
                throw new Exception("Nothng to change");
            }
            if (index < 0 || index > Length - 1)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            Node newvalue = GetNodeByIndex(index);
            newvalue.Value = value;
        }

        public void Reverse()
        {
            if (Length == 0)
            {
                throw new Exception("Nothng to reverse");
            }

            Node crnt = _root;
            Node tmp;

            while (crnt.Next != null)
            {
                tmp = crnt.Next;
                crnt.Next = tmp.Next;
                tmp.Next = _root;
                _root = tmp;
            }
            _tail = crnt;
        }

        public int FindMaxElement()
        {
            if (Length == 0)
            {
                throw new Exception("Add elements, nothing to find");
            }
            Node crnt = _root;
            int max = crnt.Value;

            while (crnt != null)
            {
                if (crnt.Value > max)
                {
                    max = crnt.Value;
                }
                crnt = crnt.Next;
            }
            return max;
        }
        
        public int FindMinElement()
        {
            if (Length == 0)
            {
                throw new Exception("Add elements, nothing to find");
            }
            Node crnt = _root;
            int min = crnt.Value;

            while (crnt != null)
            {
                if (crnt.Value < min)
                {
                    min = crnt.Value;
                }
                crnt = crnt.Next;
            }
            return min;
        }
        public int FindIndexOfMaxElement()
        {
            if (Length == 0)
            {
                throw new Exception("Add elements, nothing to find");
            }
            Node crnt = _root;
            int max = crnt.Value;
            int index = 0;
            int indexOfMax = 0;

            while (crnt != null)
            {
                if (crnt.Value > max)
                {
                    max = crnt.Value;
                    indexOfMax = index;
                }
                index++;
                crnt = crnt.Next;
            }
            return indexOfMax;
        }
        
        public int FindIndexOfMinElement()
        {
            if (Length == 0)
            {
                throw new Exception("Add elements, nothing to find");
            }
            Node crnt = _root;
            int min = crnt.Value;
            int index = 0;
            int indexOfMin = 0;

            while (crnt != null)
            {
                if (crnt.Value < min)
                {
                    min = crnt.Value;
                    indexOfMin = index;
                }
                index++;
                crnt = crnt.Next;
            }
            return indexOfMin;
        }

        public void SortInAscending()
        {
            int l = Length;
            Node crnt;
            Node prev;

            for (int i = l - 2; i >= 0; i--)
            {
                if (i == 0)
                {
                    crnt = _root;

                    if (crnt.Next != null && crnt.Value > crnt.Next.Value)
                    {
                        _root = crnt.Next;
                        crnt.Next = _root.Next;
                        _root.Next = crnt;
                    }
                    prev = _root;
                }
                else
                {
                    prev = GetNodeByIndex(i - 1);
                    crnt = prev.Next;
                }

                while (crnt.Next != null && crnt.Value > crnt.Next.Value)
                {
                    prev.Next = crnt.Next;
                    crnt.Next = prev.Next.Next;
                    prev.Next.Next = crnt;

                    prev = prev.Next;
                }
            }

            _tail = GetNodeByIndex(l - 1);
        }

        public void SortInDescending()
        {
            int l = Length;
            Node crnt;
            Node prev;

            for (int i = l - 2; i >= 0; i--)
            {
                if (i == 0)
                {
                    crnt = _root;

                    if (crnt.Next != null && crnt.Value < crnt.Next.Value)
                    {
                        _root = crnt.Next;
                        crnt.Next = _root.Next;
                        _root.Next = crnt;
                    }
                    prev = _root;
                }
                else
                {
                    prev = GetNodeByIndex(i - 1);
                    crnt = prev.Next;
                }

                while (crnt.Next != null && crnt.Value < crnt.Next.Value)
                {
                    prev.Next = crnt.Next;
                    crnt.Next = prev.Next.Next;
                    prev.Next.Next = crnt;

                    prev = prev.Next;
                }
            }

            _tail = GetNodeByIndex(l - 1);
        }

        public int DeleteFirstByValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("Add elements, nothing to delete");
            }

            Node crnt = _root;

            for(int i = 0; i < Length; i++)
            {
                int index = i;
                if (crnt.Value == value)
                {
                    DeleteByIndex(index);
                    return index;
                }
                crnt = crnt.Next;
            }
            _tail = GetNodeByIndex(Length - 1);
            return -1;
        }
        
        public int DeleteAllByValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("Add elements, nothing to delete");
            }

            Node crnt = _root;
            int count = 0;
            int index = 0;

            while (crnt != null)
            {
                index = FindFirstIndexByValue(value);

                if (index != -1)
                {
                    DeleteByIndex(index);
                    count++;
                }

                crnt = crnt.Next;
            }
            _tail = GetNodeByIndex(Length - 1);
            return count;
        }

        public void AddListToEnd(LinkedList list)
        {
            if (_root == null || list._root == null)
            {
                throw new NullReferenceException();
            }
            _tail = GetNodeByIndex(Length - 1);
            _tail.Next = list._root;
            _tail = list._tail;
        } 
        
        public void AddListToBegining(LinkedList list)
        {
            if (_root == null || list._root == null)
            {
                throw new NullReferenceException();
            }
            Node tmp = _root;
            list._tail.Next = tmp;
            _root = list._root;
        }
        
        public void AddListByIndex(int index, LinkedList list)
        {

            if (_root == null || list._root == null)
            {
                throw new NullReferenceException();
            }
            if (index > Length || index < 0)
            {
                throw new ArgumentException("index is wrong");
            }
            else if (index == 0)
            {
                AddListToBegining(list);
            }
            else
            {
                Node prevNode = GetNodeByIndex(index - 1);
                Node nextNode = GetNodeByIndex(index);
                prevNode.Next = list._root;
                list._tail = GetNodeByIndex(Length - 1);
                list._tail.Next = nextNode;
            }
        }




        public override string ToString()
        {
            string s = "";
            Node crnt = _root;

            while (crnt != null)
            {
                s += $"{crnt.Value} ";
                crnt = crnt.Next;
            }

            return s;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is LinkedList))
            {
                return false;
            }

            LinkedList list = (LinkedList)obj;

            if (list.Length != this.Length)
            {
                return false;
            }

            Node thisCrnt = this._root;
            Node listCrnt = list._root;

            while (thisCrnt != null)
            {
                if (thisCrnt.Value != listCrnt.Value)
                {
                    return false;
                }

                thisCrnt = thisCrnt.Next;
                listCrnt = listCrnt.Next;
            }

            return true;
        }

        private Node GetNodeByIndex(int index)
        {
            Node crnt = _root;
            for (int i = 1; i <= index; i++)
            {
                crnt = crnt.Next;
            }

            return crnt;
        }

    }
}
