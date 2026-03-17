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

        }
    }
}
