using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_otomasyon
{
    public class ogrenci : IOgrenci<ogrenci>
    {
        public string OkulNo { get; set; }
        public string Sinif { get; set; }
        public string Bolum { get; set; }
        public string McNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Yas { get; set; }
        public string Cinsiyet { get; set; }

        public void GetAllAdd(ogrenci t)
        {

        }

        public void GetAllDelete(ogrenci t)
        {
            throw new NotImplementedException();
        }

        public List<ogrenci> GetAllList()
        {
            throw new NotImplementedException();
        }

        public void GetAllUpdate(ogrenci t)
        {
            throw new NotImplementedException();
        }

        public int TotalNotListesi()
        {
            throw new NotImplementedException();
        }

    }
    public class InsaatOgrenci : IOgrenci<ogrenci>
    {
        public string OkulNo { get; set; }
        public string Sinif { get; set; }
        public string Bolum { get; set; }
        public string McNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Yas { get; set; }
        public string Cinsiyet { get; set; }

        public void GetAllAdd(ogrenci t)
        {

        }

        public void GetAllDelete(ogrenci t)
        {
            throw new NotImplementedException();
        }

        public List<ogrenci> GetAllList()
        {
            throw new NotImplementedException();
        }

        public void GetAllUpdate(ogrenci t)
        {
            throw new NotImplementedException();
        }

        public int TotalNotListesi()
        {
            throw new NotImplementedException();
        }

    }
    public class notlar : IDersler<notlar>
    {

        public string Ders { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }
        public double Ortalama { get; set; }
        public string Harf { get; set; }

        public void GetAllAdd(notlar t)
        {
            throw new NotImplementedException();
        }
        public void GetAllDelete(notlar t)
        {
            throw new NotImplementedException();
        }
        public List<notlar> GetAllList()
        {
            throw new NotImplementedException();
        }

        public void GetAllUpdate(notlar t)
        {
            throw new NotImplementedException();
        }
        public int TotalDersListesi()
        {
            throw new NotImplementedException();
        }
    }
    public class Bolumler
    {


    }
    public class BMG : IDersler<notlar>
    {
        public void GetAllAdd(notlar t)
        {
            throw new NotImplementedException();
        }

        public void GetAllDelete(notlar t)
        {
            throw new NotImplementedException();
        }

        public List<notlar> GetAllList()
        {
            throw new NotImplementedException();
        }

        public void GetAllUpdate(notlar t)
        {
            throw new NotImplementedException();
        }

        public int TotalDersListesi()
        {
            throw new NotImplementedException();
        }
    }
    public class Algoritma : IDersler<notlar>
    {
        public void GetAllAdd(notlar t)
        {
            throw new NotImplementedException();
        }

        public void GetAllDelete(notlar t)
        {
            throw new NotImplementedException();
        }

        public List<notlar> GetAllList()
        {
            throw new NotImplementedException();
        }

        public void GetAllUpdate(notlar t)
        {
            throw new NotImplementedException();
        }

        public int TotalDersListesi()
        {
            throw new NotImplementedException();
        }
    }
    public class VeriYapilari : IDersler<notlar>
    {
        public void GetAllAdd(notlar t)
        {
            throw new NotImplementedException();
        }

        public void GetAllDelete(notlar t)
        {
            throw new NotImplementedException();
        }

        public List<notlar> GetAllList()
        {
            throw new NotImplementedException();
        }

        public void GetAllUpdate(notlar t)
        {
            throw new NotImplementedException();
        }

        public int TotalDersListesi()
        {
            throw new NotImplementedException();
        }
    }
    public class Mekanik : IDersler<notlar>
    {
        public void GetAllAdd(notlar t)
        {
            throw new NotImplementedException();
        }

        public void GetAllDelete(notlar t)
        {
            throw new NotImplementedException();
        }

        public List<notlar> GetAllList()
        {
            throw new NotImplementedException();
        }

        public void GetAllUpdate(notlar t)
        {
            throw new NotImplementedException();
        }

        public int TotalDersListesi()
        {
            throw new NotImplementedException();
        }
    }
    public class Teknikcizim : IDersler<notlar>
    {
        public void GetAllAdd(notlar t)
        {
            throw new NotImplementedException();
        }

        public void GetAllDelete(notlar t)
        {
            throw new NotImplementedException();
        }

        public List<notlar> GetAllList()
        {
            throw new NotImplementedException();
        }

        public void GetAllUpdate(notlar t)
        {
            throw new NotImplementedException();
        }

        public int TotalDersListesi()
        {
            throw new NotImplementedException();
        }
    }
    public class HidroMekanik : IDersler<notlar>
    {
        public void GetAllAdd(notlar t)
        {
            throw new NotImplementedException();
        }

        public void GetAllDelete(notlar t)
        {
            throw new NotImplementedException();
        }

        public List<notlar> GetAllList()
        {
            throw new NotImplementedException();
        }

        public void GetAllUpdate(notlar t)
        {
            throw new NotImplementedException();
        }

        public int TotalDersListesi()
        {
            throw new NotImplementedException();
        }
    }
}
