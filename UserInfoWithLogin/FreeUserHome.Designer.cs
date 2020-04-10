namespace UserInfoWithLogin
{
    partial class FreeUserHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.clbUsers = new System.Windows.Forms.CheckedListBox();
            this.lbSelectedUsers = new System.Windows.Forms.ListBox();
            this.lbAdminUser = new System.Windows.Forms.ListBox();
            this.btnUsersToAdmin = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(12, 9);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(168, 39);
            this.lblWelcomeMessage.TabIndex = 1;
            this.lblWelcomeMessage.Text = "Welcome,";
            this.lblWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clbUsers
            // 
            this.clbUsers.FormattingEnabled = true;
            this.clbUsers.Location = new System.Drawing.Point(19, 88);
            this.clbUsers.Name = "clbUsers";
            this.clbUsers.Size = new System.Drawing.Size(120, 94);
            this.clbUsers.TabIndex = 2;
            this.clbUsers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbUsers_ItemCheck);
            // 
            // lbSelectedUsers
            // 
            this.lbSelectedUsers.FormattingEnabled = true;
            this.lbSelectedUsers.Location = new System.Drawing.Point(186, 88);
            this.lbSelectedUsers.Name = "lbSelectedUsers";
            this.lbSelectedUsers.Size = new System.Drawing.Size(120, 95);
            this.lbSelectedUsers.TabIndex = 3;
            // 
            // lbAdminUser
            // 
            this.lbAdminUser.FormattingEnabled = true;
            this.lbAdminUser.Location = new System.Drawing.Point(186, 211);
            this.lbAdminUser.Name = "lbAdminUser";
            this.lbAdminUser.Size = new System.Drawing.Size(120, 95);
            this.lbAdminUser.TabIndex = 4;
            // 
            // btnUsersToAdmin
            // 
            this.btnUsersToAdmin.Location = new System.Drawing.Point(19, 211);
            this.btnUsersToAdmin.Name = "btnUsersToAdmin";
            this.btnUsersToAdmin.Size = new System.Drawing.Size(120, 23);
            this.btnUsersToAdmin.TabIndex = 5;
            this.btnUsersToAdmin.Text = "Send To Admin List";
            this.btnUsersToAdmin.UseVisualStyleBackColor = true;
            this.btnUsersToAdmin.Click += new System.EventHandler(this.btnUsersToAdmin_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(366, 88);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 6;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(566, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.Location = new System.Drawing.Point(566, 211);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(120, 95);
            this.lbUsers.TabIndex = 8;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(411, 211);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 9;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // FreeUserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnUsersToAdmin);
            this.Controls.Add(this.lbAdminUser);
            this.Controls.Add(this.lbSelectedUsers);
            this.Controls.Add(this.clbUsers);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Name = "FreeUserHome";
            this.Text = "FreeUserHome";
            this.Load += new System.EventHandler(this.FreeUserHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.CheckedListBox clbUsers;
        private System.Windows.Forms.ListBox lbSelectedUsers;
        private System.Windows.Forms.ListBox lbAdminUser;
        private System.Windows.Forms.Button btnUsersToAdmin;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Button btnAddUser;
    }
}