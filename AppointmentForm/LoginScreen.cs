using Business.Concrete;
using DataAccess.Concrate.EntityFramework;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentForm
{
    public partial class LoginScreen : Form
    {
        public static int resaultUserId=1002;
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserManager user = new UserManager(new EfUserDal());
            bool result=false;
            foreach (var us in user.GetAll())
            {
                if (txtSifre.Text==us.Sifre && txtTC.Text==us.TC)
                {
                    resaultUserId = us.Id;
                    MainScreen mainScreen = new MainScreen();//DİREK LOADI ÇALIŞIR
                    mainScreen.Visible = true;
                    result = true;
                    this.Hide();
                }
 
            }
            if (!result)
            {
                MessageBox.Show("TC no ya da şifre yanlış");
                txtSifre.Clear();
                txtTC.Clear();
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            pnlGiris.Visible = false;
            pnlKayitOl.Visible = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            User user = new User();
            UserManager userManager = new UserManager(new EfUserDal());
            bool resault = true;
            foreach (var item in userManager.GetAll())
            {
                if (txtKayitTC.Text==item.TC)
                {
                    resault = false;
                }
            }
            if (txtKayitName.Text!="" && txtKayitSurname.Text!= "" && txtKayitTC.Text!= "" && txtKayitMail.Text!= "" && txtKayitSifre.Text!= "" && txtKayitTC.Text.Length==11)
            {
                if (resault)
                {
                    user.Name = txtKayitName.Text;
                    user.Surname = txtKayitSurname.Text;
                    user.TC = txtKayitTC.Text;
                    user.Mail = txtKayitMail.Text;
                    user.Sifre = txtKayitSifre.Text;
                    userManager.Add(user);

                    MessageBox.Show("Kayıt işlemi Başarıyla Geerçekleşti!!!");
                    pnlGiris.Visible = true;
                    pnlKayitOl.Visible = false;
                }
                else
                {
                    MessageBox.Show("Tc de hata olmadığından emin olunuz!!!");
                }
                
            }
            else
            {
                MessageBox.Show("Bilgileri boş bırakmadığınızdan ve Tc nin doğru girildiğinden emin olunuz!!!", "İşlem başarısız");
            }
            txtKayitName.Clear();
            txtKayitSurname.Clear();
            txtKayitMail.Clear();
            txtKayitTC.Clear();
            txtKayitSifre.Clear();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            txtKayitTC.MaxLength = 11;
            txtTC.MaxLength = 11;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlGiris.Visible = true;
            pnlKayitOl.Visible = false;
            txtKayitName.Clear();
            txtKayitSurname.Clear();
            txtKayitMail.Clear();
            txtKayitTC.Clear();
            txtKayitSifre.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            txtSifre.PasswordChar = '\0';
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            txtSifre.PasswordChar = '*';
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtKayitTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKayitName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtKayitSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKayitSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKayitTC_Leave(object sender, EventArgs e)
        {
            //if (txtKayitTC.Text.Length != 11)//çalışmadı
            //{
            //    MessageBox.Show("TC Kimlik Numaranızı eksik girdiniz!\nLütfen tekrar deneyin.");
            //    txtKayitTC.Clear();
            //    //txtKayitTC.Focus();
            //}
        }

        private void txtKayitTC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtKayitMail_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
