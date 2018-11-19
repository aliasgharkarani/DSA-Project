using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Registration_System
{
    class NodeOperation
    {
        Node Head = null;

        public void InsertNode(string value)
        {
            Node temmp = new Node(value);           

            if (Head == null)
            {
                Head = temmp;
                
                return;
            }

            Node i = Head;

            while (i.link != null)
            {
                i = i.link;
            }
            i.link = temmp;
            temmp.Prev = i;
        }

        public void DisplayLinkedList(ListBox listView)
        {
            Node i = Head;

            while (i != null)
            {
                listView.Items.Add("Course Name = " + i.data + "\n");
                i = i.link;
            }
        }

        public void Searching(ComboBox precourse,string userinpcourse)
        {
            Node curr = Head;
            Node loc;
        

            while (curr != null)
            {
                if (curr.data == userinpcourse)
                {

                    loc = curr;
                    curr = curr.Prev;
                    while (curr!=null)
                    {
                        precourse.Items.Add("Course = " + curr.data + "\n");
                        curr = curr.Prev;
                    }
                       
                         
                    break;
                }
                curr = curr.link;
            }

        }      
    }
}
