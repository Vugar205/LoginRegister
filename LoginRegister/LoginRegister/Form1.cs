using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<User> users = new List<User>();
        int userId = 0;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtUserName.Text)
                && !string.IsNullOrWhiteSpace(txtPassword.Text) 
                && !string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    foreach (User us in users)
                    {
                        if(us.Name == txtUserName.Text)
                        {
                            MessageBox.Show("Bu istifadeci adi movcuddur");
                            ClearPassword();
                            ClearUsername();
                            return;
                        }
                    }
                    User user = new User();
                    userId++;
                    user.Id = userId;
                    user.Name = txtUserName.Text;
                    user.Password = txtPassword.Text;
                    users.Add(user);
                    ClearPassword();
                    ClearUsername();

                    dgwUser.Rows.Add();
                    dgwUser.Rows[users.Count-1].Cells[0].Value = user.Name;
                    dgwUser.Rows[users.Count - 1].Cells[1].Value = user.Password;

                    MessageBox.Show(user.Name+" siz müvəffəqiyyətlə qeydiyyatdan keçdiniz.");
                    


                }
                else
                {
                    MessageBox.Show("Şifrə və təkrarı uyğun gəlmir");
                    ClearPassword();
                }
            }
            else
            {
                MessageBox.Show("İstifadəçi adı və ya şifrə boş ola bilməz");
            }
        }
   
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserNameLogin.Text)
                 && !string.IsNullOrWhiteSpace(txtPasswordLogin.Text))
            {
                foreach (User us in users)
                {
                    if(us.Name == txtUserNameLogin.Text && us.Password == txtPasswordLogin.Text)
                    {
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Show();
                        this.Hide();

                        ClearPassword();
                        ClearUsername();
                        return;
                    }
                    
                }
                MessageBox.Show("İstifadəçi adı və ya şifrə yanlışdır");
            }
            else
            {
                MessageBox.Show("İstifadəçi adı və ya şifrə boş ola bilməz");
            }
        }
        public void ClearPassword()
        {
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
        }
        public void ClearUsername()
        {
            txtUserName.Text = string.Empty;
        }
    }
}
