using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_otomasyon
{
    public interface IOgrenci<T>
    { 
        List<T> GetAllList();
        void GetAllDelete(T t);
        void GetAllUpdate(T t);
        void GetAllAdd(T t);
        int TotalNotListesi();

    }
}
