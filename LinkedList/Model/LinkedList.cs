using System;
using System.Collections;

namespace LinkedList.Model
{
    /// <summary>
    /// Односвязный список.
    /// </summary>
    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// Голова списка.
        /// </summary>
        public Item <T> Head { get; private set; }

        /// <summary>
        /// Хвост списка.
        /// </summary>
        public Item <T> Tail { get; private set; }

        /// <summary>
        /// Количество ячеек в списке.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public LinkedList()
        {
            Clear(); 
        }

        /// <summary>
        /// Конструктор с входными данными.
        /// </summary>
        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        /// <summary>
        /// Добавление в конец списка.
        /// </summary>
        public void Add (T data)
        {
            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        /// <summary>
        /// Удалить первое вхождение в список.
        /// </summary>
        public void Delete(T data)
        {
            int x = Count;
            if(Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;

                }
                var current = Head.Next;
                var previous = Head;


                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(data);
            } 
                
        }

        /// <summary>
        /// Удаление конца
        /// </summary>

        public void DeleteBack()
        {
            var current = Head.Next;
            var previous = Head;
            while (previous != null)
            {
                if (current.Next == null)
                {
                    current = null;
                    previous.Next = current;
                    Tail = previous;
                    Count--;
                    break;
                }
                previous = current;
                current = previous.Next;
            }
        }

        /// <summary>
        /// Добавить с начала
        /// </summary>

        public void PushFront(T data)
        {
            if (Head != null)
            {
                var item = new Item<T>(data);
                item.Next = Head;
                Head = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        /// <summary>
        /// Добавить после n элемента
        /// </summary>

        public void AddInPosition (T data, T position)
        {
            var item = new Item<T>(data);
            var current = Head;
            while (current != null)
            {
                if (current.Data.Equals(position))
                {
                    var missing = current.Next;
                    current.Next = item;
                    current = current.Next;
                    current.Next = missing;
                    Count++;
                }
                else
                {
                    current = current.Next;
                }
            }
        }

        /// <summary>
        /// Найти по значению
        /// </summary>

        public Item<T> SearchData (T data)
        {
            var current = Head;
            Item<T> found = null;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    found = current;
                    break;
                }
                current = current.Next;
                
            }
            return found;
        }

        /// <summary>
        /// Очистка списка.
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        /// <summary>
        /// Устанавливаем голову и хвост
        /// </summary>
        /// <param name="data"></param>

        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            return "Linked List" + Count + "Элементов";
        }
    }
}
