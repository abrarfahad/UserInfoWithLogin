using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInfoWithLogin.Helpers;

namespace UserInfoWithLogin
{
    public partial class PaidUserHome : Form
    {
        public PaidUserHome()
        {
            InitializeComponent();
            tblUserControls.ColumnCount = 2;
        }

        private void PaidUserHome_Load(object sender, EventArgs e)
        {
            //lblWelcomeMessage.Text += Helpers.Instance.LoggedInUser.UserName + " and User Type: " + Instance.UserType; ;
            Entities.Users u = new Entities.Users() { EmailAddress = "test@aiub.edu", Id = 1, Password = "121212", UpdatedDate = DateTime.Now, UserName = "test Name", UserType = 0 };
            var props = u.GetType().GetProperties();
            tblUserControls.RowCount = props.Length;
            int rowCount = 0;
            foreach (var prop in props)
            {
                var lb = new Label() { Name = "lbl" + prop.Name, Text = prop.Name };
                tblUserControls.Controls.Add(lb, 0, rowCount);

                var tb = new TextBox() { Name = "txt" + prop.Name, Text = prop.GetValue(u, null).ToString() };
                tblUserControls.Controls.Add(tb, 1, rowCount);

                this.tblUserControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));

                tb.Click += Lb_Click;

                rowCount++;
            }
        }

        private void Lb_Click(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            txtControlName.Text = ctrl.Name;
            txtControlValue.Text = ctrl.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ctrl = tblUserControls.Controls.Find(txtControlName.Text, false)[0] as Control ;
            ctrl.Text = txtControlValue.Text;
        }
    }
}
