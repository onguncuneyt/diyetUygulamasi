﻿using diyetUygulamasi.entities;
using diyetUygulamasi.PanelIslemleri;
using System;
using System.Linq;
using System.Windows.Forms;


namespace diyetUygulamasi
{
    public partial class hastaEkle : Form
    {
        public hastaEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            hasta hasta = new hasta(txtTc.Text, txtAd.Text, txtSoyad.Text);
            diyetisyenFacade.hastaEkle(hasta);
            

            Form acikForm = Application.OpenForms["hastaEkle"];
            GroupBox gbHastaEkle = (GroupBox)acikForm.Controls["gbHastaTxt"];

            panelIslemleri.formTemizle(gbHastaEkle);
        }
    }
}