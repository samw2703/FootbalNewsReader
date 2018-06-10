using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalNewsReader.Models
{
    class Player
    {
        public int Id { get; }
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public Player(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
