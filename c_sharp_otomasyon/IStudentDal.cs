using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_otomasyon
{
     interface IStudentDal
    {
        void Add();
        void Update();
        void Delete();  

    }
    class Kimlik : IStudentDal
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    class Karne : IStudentDal
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    class StudentManager
    {
        public void Update(IStudentDal studentDal)
        {
            studentDal.Update();
        }
    }

}
