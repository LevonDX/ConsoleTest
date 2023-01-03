namespace IEnumeratorTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection carCollection = new CarCollection();

            carCollection.Add(new Car("Mercedes"));
            carCollection.Add(new Car("BMW"));
            carCollection.Add(new Car("Opel"));
            carCollection.Add(new Car("Audi"));

            foreach (Car car in carCollection)
            {
                Console.WriteLine(car);
            }
        }
    }
}