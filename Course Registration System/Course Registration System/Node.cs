using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Registration_System
{
   public class Node
    {
        public Node Prev; //Previous
        public string data;
        public Node link; //Next

        public Node(string value)
        {
            data = value;
            link = null;
            Prev = null;
        }
    }
}
