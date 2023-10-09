using System;

namespace _01 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }
    public class ArrayList<T> {
        private const int initialCapacity = 4;
        private T[] array;
        private int count;

        public ArrayList() {
            array = new T[initialCapacity];
            count = 0;
        }

        public int Count {
            get {
                return this.count;
            }
            private set {}
        }

        public T this[int index] {
            get {
                if(index >= this.Count || index < 0) {
                    throw new IndexOutOfRangeException("Invalid index: " + index);
                }
                return this.array[index];
            }
            set {
                if (index >= this.Count || index < 0) {
                    throw new IndexOutOfRangeException("Invalid index: " + index);
                }
                this.array[index] = value;
            }
        }

        public void Add(T item) {
            this.ArrayIsFullCapacity();
            array[count] = item;
            this.Count++;
        }

        public void ArrayIsFullCapacity() {
            if (array.Length == this.Count) {
                T[] extendedArr = new T[this.Count * 2];
                Array.Copy(array, extendedArr, this.Count);
                array = extendedArr;
            }
        }

        public T RemoveAt(int index) {
            if (index >= this.Count || index < 0) {
                throw new IndexOutOfRangeException("Invalid index: " + index);
            }

            T item = array[index];
            Array.Copy(array, index + 1, array, index, this.Count - index);
            this.Count--;

            return item;
        }
    }
}
