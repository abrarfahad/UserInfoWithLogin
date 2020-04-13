using System;
using System.Net.Mail;
using System.Windows.Forms;
using UserInfoWithLogin.Data;
using UserInfoWithLogin.Entities;
using UserInfoWithLogin.Helpers;

namespace UserInfoWithLogin
{
    public partial class PersonalInfo : Form
    {
        //string id,userName, password, email;
        Users user;
        DataAccess dataAccess;

        private void PersonalInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PersonalInfo_Leave(object sender, System.EventArgs e)
        {
            MessageBox.Show("Leaved");
        }

        private void PersonalInfo_Load(object sender, System.EventArgs e)
        {
            lblWelcomeMessage.Text += user.UserName+" and User Type: "+ Instance.UserType;
            txtID.Text = user.Id.ToString();
            UserInfo userInfo = dataAccess.GetById<UserInfo, int>(user.Id);
            if (userInfo != null)
            {
                txtFatherName.Text = userInfo.FatherName;
                txtMotherName.Text = userInfo.MotherName;
                txtFirstName.Text = userInfo.FirstName;
                txtMiddleName.Text = userInfo.MiddleName;
                txtLastName.Text = userInfo.LastName;
                txtPresentAddress.Text = userInfo.PresentAddress;
                cbBloodGroup.SelectedIndex = userInfo.BloodGroup;
                dtpDOB.Value= userInfo.DOB;
            }
            rbMale.Checked = true;

        }

        public PersonalInfo(Users _user)
        {
            InitializeComponent();
            user = _user;
            dataAccess = new DataAccess();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Do You Want To Save?", "Save User Personal Details", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Save();
            }
            else if(dr==DialogResult.No)
            {
                MessageBox.Show("Your Data are not saved!!");
            }          
        }

        private void Save()
        {
            DateTime dt = this.dtpDOB.Value.Date;
            var cbval = cbBloodGroup.SelectedItem;
            var cbIndex = cbBloodGroup.SelectedIndex;
            string checkedRb="";
            if (rbMale.Checked)
            {
                checkedRb = rbMale.Text;
            }else if (rbFemale.Checked)
            {
                checkedRb = rbFemale.Text;
            }
            UserInfo userInfo = new UserInfo()
            {
                BloodGroup = cbBloodGroup.SelectedIndex,
                DOB = dt,
                FatherName = txtFatherName.Text,
                FirstName = txtFirstName.Text,
                Id = user.Id,
                LastName = txtLastName.Text,
                MiddleName = txtMiddleName.Text,
                MotherName = txtMotherName.Text,
                PresentAddress = txtPresentAddress.Text,
                UpdatedDate = DateTime.Now
            };

            DataAccess dataAccess = new DataAccess();
            int affectedRowCount = dataAccess.Insert<UserInfo>(userInfo, false);
            if (affectedRowCount > 0)
            {
                MessageBox.Show("Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Unable to save.");
            }
        }

        private void txtFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var text = (sender as TextBox).Text;
            
            if (string.IsNullOrWhiteSpace(text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, $"First Name should not be left blank!");
                
            }
            else if (text.Length>0 && text.Length <= 3)
            {
                e.Cancel = true;
                txtFatherName.Focus();
                errorProvider1.SetError(txtFirstName, "First Name Should not be less than or equals 3 character");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtMiddleName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var middleNameTextbox = sender as TextBox;
            if (string.IsNullOrEmpty(middleNameTextbox.Text))
            {
                e.Cancel = true;
                middleNameTextbox.Focus();
                errorProvider1.SetError(middleNameTextbox, $"Middle Name Should Not be Empty!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(middleNameTextbox, "");
            }
        }

        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var tbControl = sender as TextBox;
            if (string.IsNullOrEmpty(tbControl.Text))
            {
                e.Cancel = true;
                tbControl.Focus();
                errorProvider1.SetError(tbControl, "Last Name Should Not Be Empty");
            }
            else if (!IsValidEmailAddress(tbControl.Text))
            {
                e.Cancel = true;
                tbControl.Focus();
                errorProvider1.SetError(tbControl, "This Should Be an Email Address");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbControl, "");
            }
        }

        public bool IsValidEmailAddress(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException fe)
            {
                return false;
            }
        }
    }
}
