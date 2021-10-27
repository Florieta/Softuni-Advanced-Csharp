

using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private readonly HashSet<Person> members;

        public Family()
        {
            this.members = new HashSet<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
            => this.members.OrderByDescending(p => p.Age).FirstOrDefault();
        //{
        //    Person person = this.members.OrderByDescending(p => p.Age).FirstOrDefault();
        //    return person;
        //}
    }
}
