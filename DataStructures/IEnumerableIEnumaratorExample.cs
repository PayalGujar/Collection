using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Players
    {
        private int runs;
        private string name;

        public Players(int runs,string name)
        {
            this.runs = runs;
            this.name = name;

        }

        public override string ToString()
        {
            return $"{runs} {name}";
        }

    }

    public class Team : IEnumerable
    {
        private Players[] player;
        public Team()
        {
            player = new Players[3]
            {
                new Players(100, "Sachin"),
                new Players(200,"Dhoni"),
                new Players(150,"Virat")

            };
        }
        public IEnumerator GetEnumerator()
        {
            return player.GetEnumerator();
        }
    }
    public class IEnumerableIEnumaratorExample
    {
        public static void Main(string[] args)
        {
            Team team = new Team();
            foreach(Players item in team)
            {
                Console.WriteLine(item);
            }
        }
    }
}




