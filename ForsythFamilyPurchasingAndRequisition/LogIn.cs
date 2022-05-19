using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForsythFamilyPurchasingAndRequisition
{
    /*This form allows the user to login to the system and verifies the user.
    * When we soft code this, let's also bring in the user information as persistent data.
    * We will use this to display the user name on the main menu and use their permissions for our role-based access.
    */ 
    public partial class LogIn : Form
    {

        
        public LogIn()
        {
            
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            loginValidation();

        }

        private void loginValidation()
        {
            /*Validates User Login
             * Will need to be soft coded
            */
            //The following statement will have to be soft-coded once we connect to the database.
            /* Also, the array will need to be changed to an object array and we will pull in
             * all of the user information (if valid) to use as persistent data.
            */
            // Create db objects
            MedSystemDataSet md = new MedSystemDataSet();
            MedSystemDataSetTableAdapters.StaffLoginTableAdapter staffLoginAdapter = new MedSystemDataSetTableAdapters.StaffLoginTableAdapter();
            DataTable loginTable = new DataTable();
            staffLoginAdapter.Fill(md.StaffLogin);
            loginTable = md.Tables["StaffLogin"];
            MedSystemDataSetTableAdapters.StaffTableAdapter staffAdapter = new MedSystemDataSetTableAdapters.StaffTableAdapter();
            staffAdapter.Fill(md.Staff);
            DataTable staff = new DataTable();
            staff = md.Tables["Staff"];

            lbCorrectPass.Hide();

            string[] userIDS = new string[loginTable.Rows.Count];
            string[] users = new string[loginTable.Rows.Count];
            string[] passwords = new string[loginTable.Rows.Count];
            // Populate arrays
            for(int i =0; i < loginTable.Rows.Count; i++)
            {
                userIDS[i] = loginTable.Rows[i]["StaffID"].ToString();
                users[i] = loginTable.Rows[i]["StaffUser"].ToString();
                passwords[i] = loginTable.Rows[i]["StaffPassword"].ToString();
                
                
            }
            //Test print to get passwords
            
            bool granted = false;
            string userName = txtUserName.Text;
            string userPass = txtPassword.Text;
            for (int i = 0; i < users.Length; ++i)
            {

                string validName = users[i];
                string validPass = passwords[i];
                
                if (userName == validName && userPass == validPass)
                {
                    granted = true;
                    DataTable userInfo = md.Tables["Staff"];
                    DataRow userID = userInfo.Rows.Find(userIDS[i]);
                    
                    Properties.Settings.Default.UserName = userID["First_Name"].ToString();
                    Properties.Settings.Default.UserID = int.Parse(userID["StaffID"].ToString());
                    
                    if (!userID.IsNull("Manager"))
                    {
                        Properties.Settings.Default.sessionPer = (int)userID["Manager"];

                    }
                    Console.WriteLine(Properties.Settings.Default.sessionPer);
                    var mainMenu = new MainMenu();
                    this.Hide();
                    mainMenu.ShowDialog();
                    this.Close();


                    break;
                }



            }
            if (granted == false)
            {
                //MessageBox.Show("Invalid User Name or Password. Try Again");
                lbCorrectPass.Show();
                System.Media.SystemSounds.Asterisk.Play();
                //Console.Beep();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
            
        }
    }
}
