﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diyetUygulamasi.entities
{
    public class diyetisyen : kisi , IEkleme
    {
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

        public List<hasta> hastalar { get; set; }

        public diyetisyen(string _tc, string _ad, string _soyad, string _id, string _sifre)
        {
            tc = _tc;
            ad = _ad;
            soyad = _soyad;
            kullaniciAdi = _id;
            sifre = _sifre;
            isAdmin = false;
            hastalar = new List<hasta>();
        }

        public void kisiEkle(kisi kisi)
        {
            
            hastalar.Add((hasta)kisi);
        }
            
            
    }
}