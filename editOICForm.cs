using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIT314_project
{
    public partial class editOICForm : Form
    {
        Timer t = new Timer();
        string user;
        string userID;

        public editOICForm()
        {
            InitializeComponent();
        }

        private void editOICForm_Load(object sender, EventArgs e)
        {
            try
            {
                string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                string Query = "SELECT * FROM personal_questions";
                MySqlConnection MyConn = new MySqlConnection(Conn);
                MySqlCommand cmd = new MySqlCommand(Query, MyConn);

                MyConn.Open();
                MySqlDataReader MyReader = cmd.ExecuteReader();

                while (MyReader.Read())
                {
                    string question = MyReader.GetString("questionContent");
                    personalQuestionComboBox.Items.Add(question);
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.dateTimeLabel.Text = "";
            this.currentUserLabel.Text += user;
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            // Get current date, time
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            // DATE, TIME
            string datetime = year + "-";

            // Padding leading zero
            if (month < 10)
            {
                datetime += "0" + month + "-";
            }
            else
            {
                datetime += month + "-";
            }

            if (day < 10)
            {
                datetime += "0" + day + " ";
            }
            else
            {
                datetime += day + " ";
            }

            if (hour < 10)
            {
                datetime += "0" + hour + ":";
            }
            else
            {
                datetime += hour + ":";
            }

            if (minute < 10)
            {
                datetime += "0" + minute + ":";
            }
            else
            {
                datetime += minute + ":";
            }

            if (second < 10)
            {
                datetime += "0" + second;
            }
            else
            {
                datetime += second + "";
            }
            dateTimeLabel.Text = datetime;
        }

        public void setCurrentUser(string user)
        {
            this.user = user;
        }

        public void setUserID(string userID)
        {
            this.userID = userID;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (this.oicIdInput.Text == "")
            {
                MessageBox.Show("No ID input", "Error Message");
            }
            else
            {
                try
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    string Query = "SELECT * FROM users WHERE userID = @userID AND userType = 'OIC'";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                    cmd.Parameters.AddWithValue("@userID", this.oicIdInput.Text);
                    MyConn.Open();
                    MySqlDataReader MyReader = cmd.ExecuteReader();

                    if (MyReader.Read())
                    {
                        this.oicIdInput.Text = MyReader.GetString("userID");
                        this.oicNameInput.Text = MyReader.GetString("userName");
                        this.personalQuestionComboBox.Text = MyReader.GetString("personalQuestion");
                        this.personalAnswerInput.Text = MyReader.GetString("personalAnswer");
                    }
                    else
                    {
                        MessageBox.Show("No record found", "Records");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (this.oicIdInput.Text == "" && this.oicNameInput.Text == "" ||
                personalQuestionComboBox.SelectedIndex == -1 ||
                personalAnswerInput.Text == null || personalAnswerInput.Text == "")
            {
                MessageBox.Show("No Record to Update", "Records");
            }
            else
            {
                try
                {
                    string Conn = "datasource=localhost;port=3306;username=root;password=;database=medisupply;sslMode=none";
                    string Query = "UPDATE users SET userID = @userID, userName = @userName, personalQuestion = @personalQuestion, personalAnswer = @personalAnswer WHERE userID = @userID";
                    MySqlConnection MyConn = new MySqlConnection(Conn);
                    MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                    cmd.Parameters.AddWithValue("@userID", this.oicIdInput.Text);
                    cmd.Parameters.AddWithValue("@userName", this.oicNameInput.Text);
                    cmd.Parameters.AddWithValue("@personalQuestion", this.personalQuestionComboBox.Items[personalQuestionComboBox.SelectedIndex].ToString());
                    cmd.Parameters.AddWithValue("@personalAnswer", personalAnswerInput.Text);

                    MyConn.Open();
                    MySqlDataReader MyReader = cmd.ExecuteReader();
                    MessageBox.Show("Data Updated", "Records");
                    MyConn.Close();
                    adminForm admin_form = new adminForm();
                    this.Hide();
                    admin_form.setCurrentUser(user);
                    admin_form.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            adminForm admin_form = new adminForm();
            this.Hide();
            admin_form.setCurrentUser(user);
            admin_form.setUserID(userID);
            admin_form.ShowDialog();
            this.Close();
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm login_form = new loginForm();
            MessageBox.Show("Successfully logout.\nThank you for using the program.", "Logout Message");
            this.Hide();
            login_form.ShowDialog();
            this.Close();
        }
    }
}
