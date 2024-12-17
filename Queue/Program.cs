namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            queue<int> q = new queue<int>();

            #region integration test of enqueue,dequeue,isempty andpeek
            #region Integration Test To Enqueu And Deque 

            #region unitesting of enqueue
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            #endregion

            #region unit testing of dequeue
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            #endregion
            q.Enqueue(7);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            #endregion


            #region isEmpty Unit Testing
            Console.WriteLine(q.ISEmpty());
            q.Enqueue(18);
            Console.WriteLine(q.ISEmpty());
            #endregion

            #region Peek Unit Testing
            Console.WriteLine(q.Peek());
            #endregion
            #endregion

            #region unit test of capacity
            Console.WriteLine($"Capacity : {q.Capacity()}");
            #endregion

            #region unit test of count
            Console.WriteLine(q.Count());
            q.Enqueue(157);
            q.Enqueue(257);
            Console.WriteLine(q.Count());

            #endregion

            #region unit test of Trimeexces
            Console.WriteLine($"Capacity : {q.Capacity()}");
            Console.WriteLine($"count : {q.Count()}");
            q.TrimEcxess();
            Console.WriteLine($"Capacity : {q.Capacity()}");
            Console.WriteLine($"count : {q.Count()}");


            #endregion

            #region unit testing of clear
            q.Clear();
            Console.WriteLine($"Capacity : {q.Capacity()}");
            Console.WriteLine($"count : {q.Count()}");

            #endregion

            #region UnitTestOfToArray
            q.Enqueue(154);
            q.Enqueue(15478);
            q.Enqueue(84485);
            int[] arr = q.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            #endregion

            #region Unit Testing Of contains
            Console.WriteLine(q.Contains(154));
            Console.WriteLine(q.Contains(15478));
            Console.WriteLine(q.Contains(20000));



            #endregion



        }
    }
}
