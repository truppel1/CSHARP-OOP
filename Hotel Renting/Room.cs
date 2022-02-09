using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Renting
{
    internal class Room
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Room(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
