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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        int resulDoctors = default;
        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            
            Appointment appointment = new Appointment();
            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentDal());
            DoctorsManager doctorsManager = new DoctorsManager(new EfDoctorsDal());

            if (cmbClock.Text !="")
            {
                appointment.Tarih = dtpHistory.Value;
                appointment.Saat = cmbClock.Text;
                foreach (var item in doctorsManager.GetAllByProfession(cmb1111.Text))//doktorlarda arama yapıyor ve adı combobox ile aynı olanın ıd sini alıp randevulara ekliyor
                {
                    if (cmbDoctor.Text == item.Name)
                    {
                        resulDoctors = item.Id;
                    }
                }
                appointment.DoctorId = resulDoctors;
                appointment.UserId = LoginScreen.resaultUserId;//Bu çalışıcak mı kontrol et bi ara
                appointmentManager.Add(appointment);
                MessageBox.Show("Kayıt işlemi Başarıyla Gerçekleşti!!!");
            }
            else
            {
                MessageBox.Show("Alanlardan hiçbiri boş bırakılamaz. Eğer saat kısmında seçenek yoksa doktorun o günkü randevuları dolmuştur.");
            }

            cmbDoctor.Text = "";
            cmbClock.Text = "";
            cmb1111.Text = "";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnRandevuAlMenu_Click(object sender, EventArgs e)
        {
            pnlAppointment.Visible = false;
            pnlMakeAppioment.Visible = true;
            pnlDoktorlar.Visible = false;
            pnlRandevuSil.Visible = false;
            

            dtpHistory.MinDate = DateTime.Today;

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            cmb1111.Items.Add("Dişci");
            cmb1111.Items.Add("Cerrah");
            cmb1111.Items.Add("Kulak Burun Boğaz");
            cmb1111.Items.Add("Aile Hekimliği");
            cmbClock.Items.Add("09:10");
            cmbClock.Items.Add("10:10");
            cmbClock.Items.Add("11:10");
            cmbClock.Items.Add("13:10");
            cmbClock.Items.Add("14:10");
            cmbClock.Items.Add("15:10");
            pnlDoktorlar.Visible = false;
            pnlAppointment.Visible = true;
            pnlMakeAppioment.Visible = false;
            pnlRandevuSil.Visible = false;
            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentDal());
            dgvRandevularım.DataSource = appointmentManager.Getir(LoginScreen.resaultUserId);
            dgvRandevularım.Columns[5].Visible = false;
            dgvRandevularım.Columns[0].Visible = false;
            dgvRandevularım.Columns[1].HeaderText = "Bölüm";
            dgvRandevularım.Columns[2].HeaderText = "Doktor Adı";

        }

        private void btnAppointmentMenu_Click(object sender, EventArgs e)
        {
            
            pnlDoktorlar.Visible = false;
            pnlAppointment.Visible = true;
            pnlMakeAppioment.Visible = false;
            pnlRandevuSil.Visible = false;
            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentDal());
            dgvRandevularım.DataSource = appointmentManager.Getir(LoginScreen.resaultUserId);
            dgvRandevularım.Columns[5].Visible = false;
            dgvRandevularım.Columns[0].Visible = false;
            dgvRandevularım.Columns[1].HeaderText = "Bölüm";
            dgvRandevularım.Columns[2].HeaderText = "Doktor Adı";
        }

        private void cmb1111_Leave(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            if (cmb1111.Text==null)
            {
                MessageBox.Show("Bölüm seçmeden doktor seçemezsiniz");
            }
            else
            {
                DoctorsManager doctorsManager = new DoctorsManager(new EfDoctorsDal());
                foreach (var item in doctorsManager.GetAllByProfession(cmb1111.Text))
                {
                    cmbDoctor.Items.Add(item.Name.ToString());
                }
            }
            
        }

        private void cmbDoctor_Leave(object sender, EventArgs e)
        {
            

            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentDal());
            DoctorsManager doctorsManager = new DoctorsManager(new EfDoctorsDal());
            foreach (var item in doctorsManager.GetAllByProfession(cmb1111.Text))//doktorlarda arama yapıyor ve adı combobox ile aynı olanın ıd sini alıp randevulara ekliyor
            {
                if (cmbDoctor.Text == item.Name)
                {
                    resulDoctors = item.Id;
                }
            }

            foreach (var appointmnent in appointmentManager.GetAll())
            {
                var re = appointmnent.Tarih.Day;
                if (appointmnent.DoctorId == resulDoctors && re==dtpHistory.Value.Day)
                {
                    switch (appointmnent.Saat)
                    {
                        case "09:10":
                            cmbClock.Items.Remove("09:10");
                            break;
                        case "10:10":
                            cmbClock.Items.Remove("10:10");
                            break;
                        case "11:10":
                            cmbClock.Items.Remove("11:10");
                            break;
                        case "13:10":
                            cmbClock.Items.Remove("13:10");
                            break;
                        case "14:10":
                            cmbClock.Items.Remove("14:10");
                            break;
                        case "15:10":
                            cmbClock.Items.Remove("15:10");
                            break;
                        default:
                            break;
                    }
                }
            }
            

        }

        private void btnDoktorlar_Click(object sender, EventArgs e)
        {
            pnlDoktorlar.Visible = true;
            pnlAppointment.Visible = false;
            pnlMakeAppioment.Visible = false;
            pnlRandevuSil.Visible = false;
            DoctorsManager doctorsManager = new DoctorsManager(new EfDoctorsDal());
            dgvDoktorlar.DataSource = doctorsManager.GetAll();
            dgvDoktorlar.Columns[0].Visible = false;
            dgvDoktorlar.Columns[1].HeaderText = "Doktor Adı";
            dgvDoktorlar.Columns[2].HeaderText = "Doktorun Bölümü";
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
           
            pnlDoktorlar.Visible = false;
            pnlAppointment.Visible = false;
            pnlMakeAppioment.Visible = false;
            pnlRandevuSil.Visible = true;

            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentDal());
            dgvRandevuSil.DataSource = appointmentManager.Getir(LoginScreen.resaultUserId);
            dgvRandevuSil.Columns[5].Visible = false;
            dgvRandevuSil.Columns[0].HeaderText = "Randevu Numarası";
            dgvRandevuSil.Columns[1].HeaderText = "Bölüm";
            dgvRandevuSil.Columns[2].HeaderText = "Doktor Adı";

        }

        private void btnSil_Click(object sender, EventArgs e)//Burası seçip silme işlemini yapmalı test et bağlantıları kurunca
        {
            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentDal());
            foreach (var item in appointmentManager.GetAllByUserId(LoginScreen.resaultUserId))
            {
                if (item.Id.ToString()==txtSilinicekId.Text)
                {
                    appointmentManager.Delete(item);
                    
                    dgvRandevuSil.DataSource = appointmentManager.GetAllByUserId(LoginScreen.resaultUserId);
                }
            }
            
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            InformationsScreen informationsScreen = new InformationsScreen();
            informationsScreen.Visible = true;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void txtSilinicekId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pnlRandevuSil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb1111_MouseClick(object sender, MouseEventArgs e)
        {
            cmbDoctor.Text = "";
        }
    }
}
