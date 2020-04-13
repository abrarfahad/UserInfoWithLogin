using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInfoWithLogin.Data;
using UserInfoWithLogin.Entities;

namespace UserInfoWithLogin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtPassword.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtUserName.Focus();
        }

       
        private void LogIn()
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mou\Documents\Db\test2DB.mdf;Integrated Security=True;Connect Timeout=30";

            string sql = "select Id,password,UserName,EmailAddress,UpdatedDate,UserType" +
                " from [Users] where UserName='" + txtUserName.Text
                + "' and Password='" + txtPassword.Text + "'";

            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);

            DataTable dt = new DataTable();

            sqlCmd.Connection.Open();
            //var affectedRowCount=sqlCmd.ExecuteNonQuery();
            dt.Load(sqlCmd.ExecuteReader());
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Success!");
                Entities.Users user = new Users()
                {
                    Id = dt.Rows[0].Field<int>("Id"),//Int32.Parse(dt.Rows[0][0].ToString())
                    UserName = dt.Rows[0].Field<string>("UserName"), //dt.Rows[0][2].ToString(),
                    Password = dt.Rows[0][1].ToString(),
                    EmailAddress = dt.Rows[0][3].ToString(),
                    UpdatedDate = DateTime.Parse(dt.Rows[0][4].ToString()),
                    UserType = dt.Rows[0].Field<int>("UserType")
                };

                Helpers.Instance.LoggedInUser = user;

                var userType = dt.Rows[0].Field<int>("UserType");
                if (userType == (int)Entities.Users.UserTypeEnum.Admin)
                {
                    PersonalInfo personalInfo = new PersonalInfo(user);
                    personalInfo.Show();
                }
                else if (userType == (int)Entities.Users.UserTypeEnum.FreeUser)
                {
                    FreeUserHome freeUserHome = new FreeUserHome();
                    freeUserHome.Show();
                }
                else if (userType == (int)Entities.Users.UserTypeEnum.PaidUser)
                {
                    PaidUserHome paidUserHome = new PaidUserHome();
                    paidUserHome.Show();
                }

                this.Hide();
            }
            else
            {
                DataAccess dataAccess = new DataAccess(ConnectionString);
                List<Entities.Users> users = dataAccess.GetList<Entities.Users>();
                //Entities.Users user = dataAccess.GetById<Entities.Users, int>(2);
                //MessageBox.Show(user.UserName);
                //int rowsInserted = dataAccess.Insert(new Entities.Users()
                //{
                //    Id = 4,
                //    UserName = "admin4",
                //    EmailAddress = "admin4@gmail.com",
                //    Password = "1234",
                //    UpdatedDate = DateTime.Now
                //}
                //, false);
                MessageBox.Show("Login Failed!!");

            }
            sqlCmd.Connection.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                LogIn();
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            Control_Blank_Validating(sender, e,"User Name");
        }

        private void Control_Blank_Validating(object sender, CancelEventArgs e,string ControlNameToShowUser)
        {
            var control = sender as Control;
            if (control != null)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    e.Cancel = true;
                    control.Focus();
                    errorProvider1.SetError(control, $"{ControlNameToShowUser} should not be left blank!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(control, "");
                }
            }
            
        }


        private void Control_MinMaxLength_Validating(object sender, CancelEventArgs e, string ControlNameToShowUser, int maxlength,int minLength) {
            var control = sender as Control;
            if (control != null)
            {
                if (control.Text.Length<minLength)
                {
                    e.Cancel = true;
                    control.Focus();
                    errorProvider1.SetError(control, $"{ControlNameToShowUser} should greater than {minLength} char.");
                }
                else if (control.Text.Length > maxlength)
                {
                    e.Cancel = true;
                    control.Focus();
                    errorProvider1.SetError(control, $"{ControlNameToShowUser} should Less than {maxlength} char.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(control, "");
                }
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            if (control.Text.Trim().Length<=0)
            {
                e.Cancel = true;
                control.Focus();
                errorProvider1.SetError(control, $"Password should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(control, "");
            }
        }
    }
}
