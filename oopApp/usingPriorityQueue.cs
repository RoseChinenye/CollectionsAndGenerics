namespace oopApp;

    public class people
    {
        public string? FirstName;
        public string? LastName;
    }
        public class usingPriorityQueue
        {
    
    
        PriorityQueue<people, int> priorityQueue = new();
            public void getPriorityQueue()
            {
        

                priorityQueue.Enqueue(new people() { FirstName = "Obianuju", LastName = "Okeke" }, 3);
                priorityQueue.Enqueue(new people() { FirstName = "Chinenye", LastName = "Ugwunwa" }, 1);
                priorityQueue.Enqueue(new people() { FirstName = "Rose", LastName = "Nwankwo" }, 2);

                Console.WriteLine("My name is {0}", priorityQueue.Dequeue().FirstName);
                Console.WriteLine("My name is {0}", priorityQueue.Dequeue().FirstName);
                Console.WriteLine("My name is {0}", priorityQueue.Dequeue().FirstName);
    }
        }


