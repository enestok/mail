using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Net.Mail;

namespace mailGonder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool MailGonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();

            ePosta.From = new MailAddress("" + txtGonderenMail.Text + "");

            var splitMails = txtAliciMail.Text.Split(';').ToList();
            foreach (string hasSplitted in splitMails)
            {
                ePosta.To.Add(hasSplitted.ToString());
            }

            ePosta.Subject = txtKonu.Text;
            ePosta.Body = txtRichMesaj.Text;
            //ePosta.Attachments.Add(new Attachment(@"D:\dosya1.txt"));

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials= new NetworkCredential("" + txtGonderenMail.Text + "", "" + txtGonderenSifre.Text + "");

            smtp.Port = 587; // gmail port numarası
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;

            object userState = ePosta;
            bool kontrol = true;

            try
            {
                smtp.SendAsync(ePosta,(object)ePosta);
                MessageBox.Show("mail gönderildi."); 
            }
            catch (Exception)
            {
                kontrol = false;
                MessageBox.Show("mail gönderme işlemi başarısız!");
            }

            return kontrol;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailGonder(txtKonu.Text, txtRichMesaj.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // btnGonder.Image = Properties.Resources.sendOff;
        }

        private void btnGonder_MouseLeave(object sender, EventArgs e)
        {
            btnGonder.Image = Properties.Resources.sendOff;
        }

        private void btnGonder_MouseMove(object sender, MouseEventArgs e)
        {
            btnGonder.Image = Properties.Resources.sendOn;
        }

        private void btnAliciEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAliciEkle_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

       
    }
}
