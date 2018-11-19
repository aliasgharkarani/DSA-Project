using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Registration_System
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox3.Items.Count>0)
            {
                MessageBox.Show("You Are Not Eligible For This Course");
            }
            else if (comboBox1.SelectedText.ToString() != listBox3.Items.ToString())
            {
                MessageBox.Show("You Are Eligible For This Course");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(comboBox1.SelectedItem.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(comboBox1.SelectedItem.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                MessageBox.Show("You already checked elgibility!");
            }
            else if (listBox1.Items.Count <= 0)
            {
                gettinglist();
            }
            

        }

        public void gettinglist()
        {
            NodeOperation node = new NodeOperation();
            node.InsertNode("Basic Programming");
            node.InsertNode("PF");
            node.InsertNode("OOP");
            node.InsertNode("DS");
            // if(node.DisplayLinkedList.conttain)
            node.InsertNode("DBMS");

            node.DisplayLinkedList(listBox1);
            node.Searching(comboBox1, textBox1.Text);
            listBox1.Items.Add("---------------------------------------------------");

            NodeOperation node1 = new NodeOperation();
            node1.InsertNode("IICT");
            node1.InsertNode("BE");
            node1.InsertNode("DLD");
            node1.InsertNode("COL");
            node1.InsertNode("DCN");

            node1.DisplayLinkedList(listBox1);
            node1.Searching(comboBox1, textBox1.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}