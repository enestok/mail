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
            string GonderenMail = txtGonderenMail.Text;
            string GonderenSifre = txtGonderenSifre.Text; 
            string AliciMail = txtAliciMail.Text;
            string MailKonu = txtKonu.Text;
            string MailIcerik = txtRichMesaj.Text;

            MailMessage ePosta = new MailMessage();

            ePosta.From = new MailAddress("" + GonderenMail + "");  // gönderici 

            
            var splitMails = AliciMail.Split(';').ToList();   
            foreach (string hasSplitted in splitMails)
            {
                ePosta.To.Add(hasSplitted.ToString());  // alıcı
            }

            ePosta.Subject = MailKonu; // mail konusu\başlığı
            ePosta.Body = MailIcerik; // mail içeriği

            List<string> a = openFileDialog1.FileNames.ToList();

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK && result != DialogResult.Cancel &&
                    openFileDialog1.FileNames.ToString() != "") 
            {
                for (int i = 0; i < a.Count; i++)
                {
                    ePosta.Attachments.Add(new Attachment(a[i].ToString()));
                }
            }
            
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials= new NetworkCredential("" + GonderenMail + "", "" + GonderenSifre + "");

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
            btnAliciEkle.Image = Properties.Resources.iconAddOn_50x50;
        }

        private void btnAliciEkle_MouseLeave(object sender, EventArgs e)
        {
            btnAliciEkle.Image = Properties.Resources.iconAddd;
        }

        private void button2_Click(object sender, EventArgs e) // btnAddAttach
        {
            openFileDialog1.Title = "Dosya Seç..";

            openFileDialog1.FileName = "";

            openFileDialog1.Multiselect = true;

            openFileDialog1.ShowDialog();

            List<string> a = openFileDialog1.FileNames.ToList(); //path listesi

            selectedFilePanel1.AddTool(a);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RefreshLocation();
            //MessageBox.Show(txtRichMesaj.Rtf);
        }

    }
}
