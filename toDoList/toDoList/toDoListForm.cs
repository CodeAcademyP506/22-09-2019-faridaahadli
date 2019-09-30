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
    public partial class toDoListForm : Form
    {
        Form1 form=new Form1();
        string path = @"C:\Users\HP\Desktop\New folder\toDo.txt";
        public CheckedListBox listBox { get { return lstBoxDo; } }
        public toDoListForm(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }
        List<ToDo> toDos = new List<ToDo>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UInt64 i;
            var user = form.users.First(p => form.textBox.Text == p.Username);
            var toDoObj = new ToDo(txtBxListItem.Text, user);
            var check = File.ReadAllText(path);
           
            if (check.Length != 0)
            {
                string last = File.ReadAllLines(path).Last();
                i = Convert.ToUInt64(last.Split(',')[1]);
                toDoObj.Id = i + 1;
               
            }
           


            toDos.Add(toDoObj);
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using(StreamWriter sw=new StreamWriter(path,true))
                {
                    sw.WriteLine($"{toDoObj.Title},{toDoObj.Id},{toDoObj.User.Id}");
                }
            lstBoxDo.Items.Add(txtBxListItem.Text);
        }

        private void lstBoxDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxDo.CheckOnClick)
            {
                lstBoxDo.Items.Remove(this);
            }
        }
    }
    
}
