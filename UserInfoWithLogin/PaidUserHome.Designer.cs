namespace UserInfoWithLogin
{
    partial class PaidUserHome
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
            this.tblUserControls = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtControlValue = new System.Windows.Forms.TextBox();
            this.txtControlName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(1, 9);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(168, 39);
            this.lblWelcomeMessage.TabIndex = 1;
            this.lblWelcomeMessage.Text = "Welcome,";
            this.lblWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblUserControls
            // 
            this.tblUserControls.ColumnCount = 2;
            this.tblUserControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tblUserControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tblUserControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblUserControls.Location = new System.Drawing.Point(12, 72);
            this.tblUserControls.Name = "tblUserControls";
            this.tblUserControls.Size = new System.Drawing.Size(709, 357);
            this.tblUserControls.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change Value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtControlValue
            // 
            this.txtControlValue.Location = new System.Drawing.Point(413, 459);
            this.txtControlValue.Name = "txtControlValue";
            this.txtControlValue.Size = new System.Drawing.Size(194, 20);
            this.txtControlValue.TabIndex = 3;
            // 
            // txtControlName
            // 
            this.txtControlName.Location = new System.Drawing.Point(161, 459);
            this.txtControlName.Name = "txtControlName";
            this.txtControlName.Size = new System.Drawing.Size(167, 20);
            this.txtControlName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Control Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Control Value :";
            // 
            // PaidUserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtControlName);
            this.Controls.Add(this.txtControlValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tblUserControls);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Name = "PaidUserHome";
            this.Text = "PaidUserHome";
            this.Load += new System.EventHandler(this.PaidUserHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.TableLayoutPanel tblUserControls;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtControlValue;
        private System.Windows.Forms.TextBox txtControlName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}