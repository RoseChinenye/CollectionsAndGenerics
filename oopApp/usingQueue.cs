
namespace oopApp
{
    public class T
    {
        public string? FirstName;
        public string? LastName;
    }
    public class usingQueue
    {
        Queue<T>? queue;
        public void Queue() 
        {
            queue = new Queue<T>();

            queue.Enqueue(new T() { FirstName = "Obianuju", LastName = "Okeke" });
            queue.Enqueue(new T() { FirstName = "Chinenye", LastName = "Ugwunwa" });
            queue.Enqueue(new T() { FirstName = "Rose", LastName = "Onah" });

            Console.WriteLine("My name is {0}", queue.Peek().FirstName);
        }
    }
}
