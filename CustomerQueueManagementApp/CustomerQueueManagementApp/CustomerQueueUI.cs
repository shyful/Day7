using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueManagementApp
{
    public partial class CustomerQueueUI : Form
    {
        public CustomerQueueUI()
        {
            InitializeComponent();
        }
        Queue<Customer> customerQueue=new Queue<Customer>();
        Customer aCustomer = new Customer();
        //List<Customer> list=new List<Customer>();
        int i = 1;
        private void enqueueButton_Click(object sender, EventArgs e)
        {
            
            
            aCustomer.serialno = i++.ToString();
            aCustomer.name = nametextBox.Text;
            aCustomer.complain = complaintextBox.Text;
            customerQueue.Enqueue(aCustomer);
            //list.Add(aCustomer);

            string[] row =
            {
                aCustomer.serialno, aCustomer.name, aCustomer.complain
            };

            var listviewitem = new ListViewItem(row);
            waitingQueueListView.Items.Add(listviewitem);
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            aCustomer = customerQueue.Dequeue();
            sntextBox.Text = aCustomer.serialno;
            cntextBox.Text = aCustomer.name;
            cmltextBox.Text = aCustomer.complain;
            waitingQueueListView.Items.RemoveAt(0);
        }
    }
}
