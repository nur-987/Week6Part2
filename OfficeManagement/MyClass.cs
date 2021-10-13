using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement
{
    enum Position
    {
        User, Admin, SuperAdmin
    }
    class User
    {
        public int Id { get; set; }
        public Position Position { get; set; }
        public string Task { get; set; }
        public string Report { get; set; }

        public bool CompleteReport { get; set; }

    }

    class Admin : User
    {

    }

    class SuperAdmin : User
    {

    }


}
