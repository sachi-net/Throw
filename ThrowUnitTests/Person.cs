using System;

namespace ThrowUnitTests
{
    public class Person : IEquatable<Person>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }

        public bool Equals(Person other)
        {
            if (other is null)
                return false;
            return other.Name.Equals(Name) && other.Address.Equals(Address) && 
                other.Age == Age && other.IsMarried == IsMarried;
        }
    }
}
