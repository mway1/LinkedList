﻿using System;
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
