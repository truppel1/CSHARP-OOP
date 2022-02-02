using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixação
{
    class Rooms
    {
        public string _name;
        public string _email;
   
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length < 2)
                {
                    _name = value;
                }
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (value != null)
                {
                    _email = value;
                }
            }
        }
        public int Room;
           public Rooms(string name, string email, int room)
        {
            _name = name;
           _email = email;
            Room = room;
        }  
        public override string ToString()
        {
            return Room + ": "
                + Name + ", "
                + Email + "";
        }


    }
}
