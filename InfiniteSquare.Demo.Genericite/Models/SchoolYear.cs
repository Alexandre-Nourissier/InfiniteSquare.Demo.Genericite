using System.Collections.Generic;

namespace InfiniteSquare.Demo.Genericite.Models
{

    /// <summary>
    /// Can be Enumerate even if it doesn't inherits from IEnumerable{Student} because it expose a public GetEnumerator returning an IEnumerator{CustomEnumerable}
    /// </summary>
    public class SchoolYear
    {
        public int Year { get; set; }
        public List<CustomEnumerable> Courses { get; set; }

        /// <summary>
        /// Implement GetEnumerator(), allowing the use of foreach on an instance of SchoolYear to Enumerate through Courses
        /// </summary>
        /// <returns>a CustomEnumerator for objects of type CustomEnumerable</returns>
        public CustomEnumerator<CustomEnumerable> GetEnumerator()
        {
            return new CustomEnumerator<CustomEnumerable>(Courses);
        }
    }
}
