namespace Assignment_Advacned01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question01

            /*
             What is a generic class? Why use generics?
             */

            //Answer:

            // generic class is a class that can work with any data type
            //It allows you to creat a class that can b use with different types of data without need to write multtiple versions of the class for all types

            #endregion


            #region question02

            /*  
            Write a generic class Container<T> with Add and Get methods.

             */

            //Answer:

            /*
             
            class Container<T> 
            {

                private List<T> items = new List<T>();
                public void Add(T item)
                {
                    items.Add(item);
                }
                public T Get(int index)
                {
                    return items[index];
                }
            
             */


            #endregion

            #region question03
            /*
          What are multiple type parameters? Write Pair<TKey, TValue>.
             */
            //Answer:
            /*
             class Pair<TKey, TValue>
            {
                public TKey Key { get; set; }
                public TValue Value { get; set; }
                public Pair(TKey key, TValue value)
                {
                    Key = key;
                    Value = value;
                }

             
             */
            #endregion

            #region question04

            /*
           What is a generic method? Write Swap<T> method.
             */

            //Answer:

            /*
             generic method is a method that can work with any data type
            It allows you to create a method that can be used with different types of data without the need to write multiple versions of the method for all types.

            class Program
            {
            public static void swap<T>(ref T a, ref T b){
                T temp = a;
                a = b;
                b = temp;
            }

             */

            #endregion

            #region question05

            /*
              Write a generic method FindMax<T> that finds maximum value
             */

            //Answer:
            /*
             public static T FindMax<T>(T[] array)
            where T : IComparable<T>
            {
                if (array == null || array.Length == 0)
                {
                    throw new ArgumentException("Array cannot be null or empty.");
                }
                T max = array[0];
                foreach (T item in array)
                {
                    if (item.CompareTo(max) > 0)
                    {
                        max = item;
                    }
                }
                return max;
            }
             */

            #endregion

            #region question06

            /*
          What is a generic interface? Write IRepository<T>. 
             */
            //Answer:
            /*
             A generic interface is an interface that can work with any data type.
             It allows you to create an interface that can be implemented by different types of classes without the need to write multiple versions of the interface for all types
             Example:
             interface IRepository<T>
            {
                void Add(T item);
                T Get(int id);
                void Update(T item);
                void Delete(int id);
            }
             */ 

            #endregion

        }
    }
}
