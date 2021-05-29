﻿using diyetUygulamasi.database;
using diyetUygulamasi.entities;
using diyetUygulamasi.PanelIslemleri;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace diyetUygulamasi
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
              InitializeComponent(); 
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
        

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            panelIslemleri.oturumuKapat();
        }
            


        private void btnEkle_Click(object sender, EventArgs e)
        {
            db.admin.kisiEkle(new diyetisyen(txtTc.Text,txtAd.Text,txtSoyad.Text, txtId.Text, txtParola.Text));
            panelIslemleri.formTemizle(Application.OpenForms["frmAdmin"]);
        }





        //private void adminFormKapatma(object sender, FormClosingEventArgs e)
        //{
        //    //Açık formlardan adı Form1 olanı yakalıyor.
        //    var anaForm = Application.OpenForms["Form1"];
        //    //Anaformu kapatıyor.
        //    if (anaForm != null) anaForm.Close();
        //}

    }
}