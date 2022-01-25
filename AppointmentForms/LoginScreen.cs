using Business.Concrete;
using DataAccess.Abstrack;
using DataAccess.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentForms
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnKullaniciGirisi_Click(object sender, EventArgs e)
        {
            UserManager user = new UserManager(new EfUserDal());
            
            foreach (var us in user.GetAll())
            {
                if (txtTC.Text==us.TC && txtSifre.Text==us.Sifre)
                {
                    MessageBox.Show("giriş yapılıyor");
                }
            }
        }
    }
}
