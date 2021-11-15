using System;

/// <summary>
/// Ячейка списка.
/// </summary>
namespace LinkedList.Model
{
    public class Item<T>
    {
        private T data = default(T);
        /// <summary>
        /// Данные в ячейке.
        /// </summary>
        public T Data
        {
            get => data;
            set
            {
                if (value != null) 
                    data = value;
                else 
                    throw new ArgumentNullException(nameof(value));
            }
        }
        /// <summary>
        /// Указатель на следующую ячейку списка.
        /// </summary>
        public Item <T> Next { get; set; }

        public Item (T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
