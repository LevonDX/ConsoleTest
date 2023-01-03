using System.Collections;

namespace IEnumeratorTest
{
    class CarCollection : IEnumerable<Car>
    {
        private List<Car> internalCarCollection;

        public CarCollection()
        {
            internalCarCollection = new List<Car>();
        }

        public void Add(Car car)
        {
            internalCarCollection.Add(car);
        }

        public IEnumerator<Car> GetEnumerator()
        {
            for (int i = 0; i < internalCarCollection.Count; i++)
            {
                yield return internalCarCollection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}