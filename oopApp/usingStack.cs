
namespace oopApp
{
    public class Person
    {
        public string? FirstName;
        public string? LastName;
        public int Age;

    }
    public class usingStack
    {
        
        public void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new();

            stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            // Now look at the top item, pop it, and look again.
            Console.WriteLine("First person is: {0}", stackOfPeople.Peek().FirstName);
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop().FirstName);
            Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek().FirstName);
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop().FirstName);
            Console.WriteLine("\nFirst person item is: {0}", stackOfPeople.Peek().FirstName);
            Console.WriteLine("Popped off {0}", stackOfPeople.Pop().FirstName);
            try
            {
                Console.WriteLine("\nnFirst person is: {0}", stackOfPeople.Peek().FirstName);
                Console.WriteLine("Popped off {0}", stackOfPeople.Pop().FirstName);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("\nError! {0}", ex.Message);
            }
        }



    }
}
