using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class GeneologyComposite : Person
    {
        private List<Person> members = new List<Person>();

        private int budget = 0;
        public int Budget { get; set; }

        public void addMember(Person member) {
            members.Add(member);
        }
        public void removeMember(Person member) {
            members.Remove(member);
        }
        public int BornAndExist()
        {
            foreach (Person member in members) {
                Budget+= member.BornAndExist();
            }
            return Budget;
        }
    }
}

