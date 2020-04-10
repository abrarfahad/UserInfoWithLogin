using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInfoWithLogin.Data;
using UserInfoWithLogin.Helpers;

namespace UserInfoWithLogin
{
    public partial class FreeUserHome : Form
    {
        DataAccess dataAccess;
        List<Entities.Users> users;
        public FreeUserHome()
        {
            InitializeComponent();
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mou\Documents\Db\test2DB.mdf;Integrated Security=True;Connect Timeout=30";
            dataAccess = new DataAccess(ConnectionString);

            clbUsers.CheckOnClick = true;

            users = dataAccess.GetList<Entities.Users>("");

            lbSelectedUsers.DisplayMember = "UserName";
            lbSelectedUsers.ValueMember = "Id";

            clbUsers.DisplayMember = "UserName";
            clbUsers.ValueMember = "Id";

            lbAdminUser.DisplayMember = "UserName";
            lbAdminUser.ValueMember = "Id";


            checkedListBox1.DisplayMember = "UserName";
            checkedListBox1.ValueMember = "Id";

            checkedListBox1.CheckOnClick = true;

            listBox1.DisplayMember = "UserName";
            listBox1.ValueMember = "Id";

            lbUsers.DisplayMember = "UserName";
            lbUsers.ValueMember = "Id";
        }

        private void FreeUserHome_Load(object sender, EventArgs e)
        {
            //lblWelcomeMessage.Text += Helpers.Instance.LoggedInUser.UserName + " and User Type: " + Instance.UserType; ;
            
            
            foreach (var item in users)
            {
                clbUsers.Items.Add(item, false);
            }

            foreach (var user in users)
            {
                checkedListBox1.Items.Add(user);
            }
        }

        private void clbUsers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           // lblWelcomeMessage.Text = sender.GetType().ToString();
            if (e.NewValue == CheckState.Checked)
            {
                lbSelectedUsers.Items.Add(users[e.Index]);
            }
            else {
                lbSelectedUsers.Items.Remove(users[e.Index]);
            }

        }

        private void btnUsersToAdmin_Click(object sender, EventArgs e)
        {
            lbAdminUser.Items.Clear();
            foreach (var item in clbUsers.CheckedItems)
            {
                lbAdminUser.Items.Add(item);
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                //MessageBox.Show(e.Index.ToString());
                listBox1.Items.Add(checkedListBox1.Items[e.Index]);
            }
            else
            {
                listBox1.Items.Remove(checkedListBox1.Items[e.Index]);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            lbUsers.Items.Clear();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                lbUsers.Items.Add(item);
                var user = (Entities.Users)item;
            }
        }
    }
}
