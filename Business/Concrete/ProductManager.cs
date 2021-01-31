using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;
        private InMemoryProductDal InMemoryProductDal;

        public ProductManager(InMemoryProductDal InMemoryProductDal)
        {
            this.InMemoryProductDal = InMemoryProductDal;
        }

        public List<Product> GetAll()
        {
            //İş Kodları
            //Örnek: Yetkisi var mı?
            //Bütün kuralları geçitikten sonra alttaki kodu çalıştırıyor.
            return _ProductDal.GetAll();
            
        }
    }
}
