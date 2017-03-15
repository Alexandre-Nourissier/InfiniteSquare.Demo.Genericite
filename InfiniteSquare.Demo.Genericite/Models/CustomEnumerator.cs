using System.Collections.Generic;

namespace InfiniteSquare.Demo.Genericite.Models
{
    /// <summary>
    /// Custom Enumerator reserved for CustomEnumerable and derivedClass for demonstration purpose, mimic standard enumerator implementation.
    /// It doesn't need to inherits from IEnumerator{T} because it implements Current, MoveNext() and Reset().
    /// </summary>
    /// <typeparam name="T">Type equal or derivated from CustomEnumerable</typeparam>
    public class CustomEnumerator<T> where T : CustomEnumerable
    {
        private int current = -1;     // Set to before next item
        private IList<CustomEnumerable> target; // Will be enumerated
        public CustomEnumerator(IList<CustomEnumerable> target)
        {
            this.target = target;
        }
        public void Reset() { current = -1; }
        public CustomEnumerable Current // Return current transaction
        { get { return target[current]; } }
        public bool MoveNext() // Move to next if there is one
        { return (++current < target.Count); }
    }

}
