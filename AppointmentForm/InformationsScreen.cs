using Business.Concrete;
using DataAccess.Concrate.EntityFramework;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppointmentForm
{
    public partial class InformationsScreen : Form
    {
        public InformationsScreen()
        {
            InitializeComponent();
        }

        private void btnGuncellekaydet_Click(object sender, EventArgs e)
        {
            User user = new User();
            UserManager userManager = new UserManager(new EfUserDal());
            var resault = userManager.GetAllId(LoginScreen.resaultUserId);
            bool resaultt = true;
            foreach (var item in userManager.GetAll())
            {
                if (txtGuncelleTC.Text == item.TC)
                {
                    resaultt = false;
                }
            }
            if (txtGuncelleName.Text!="" && txtGuncelleSifre.Text!="" && txtGuncelleSurname.Text!="" && txtGuncelleTC.Text!="" && txtGuncelleMail.Text!="")
            {
                if (resaultt || txtGuncelleTC.Text == resault[0].TC)
                {
                    foreach (var item in resault)
                    {
                        item.Name = txtGuncelleName.Text;
                        item.Sifre = txtGuncelleSifre.Text;
                        item.Surname = txtGuncelleSurname.Text;
                        item.TC = txtGuncelleTC.Text;
                        item.Mail = txtGuncelleMail.Text;
                        userManager.Update(item);

                        MainScreen mainScreen = new MainScreen();
                        mainScreen.Visible = true;
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu!!!");
                }
            }
            else
            {
                MessageBox.Show("Bilgiler boş geçilemez!!!!");
            }

        }

        private void btnGuncelleIptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void InformationsScreen_Load(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.GetAllId(LoginScreen.resaultUserId);
            foreach (var item in userManager.GetAllId(LoginScreen.resaultUserId))
            {
                txtGuncelleMail.Text = item.Mail;
                txtGuncelleName.Text = item.Name;
                txtGuncelleSifre.Text = item.Sifre;
                txtGuncelleSurname.Text = item.Surname;
                txtGuncelleTC.Text = item.TC;
            }
            txtGuncelleTC.MaxLength = 11;
        }

        private void txtGuncelleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtGuncelleSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtGuncelleTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
