using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toDoList
{
    public partial class Form1 : Form
    {

       internal List<User> users = new List<User>()
       {
         new User("Farida", "feride2"),

         new User("Leman", "leman2"),
       };

       public Form1()
       {
            InitializeComponent();
       }
        public TextBox textBox { get { return txtBxUsername; } }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\HP\Desktop\New folder\toDo.txt";
            toDoListForm form = new toDoListForm(this);
           using(StreamReader sr=new StreamReader(path))
            {
                var reader = sr.ReadLine();
                reader = sr.ReadLine();
                while (reader!=null)
                {
                    var user = users.First(p =>textBox.Text == p.Username);
                    if(user.Id== Convert.ToUInt64(reader.Split(',')[2]))
                        form.listBox.Items.Add(reader.Split(',')[0]);
                    reader = sr.ReadLine();
                }
            }
            form.Show();
            this.Hide();
        }

    }
}
