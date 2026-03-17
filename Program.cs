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
        }
    }
}
