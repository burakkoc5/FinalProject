using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Productla ilgili veritabanı operasyonları
    public interface IProductDal : IEntityRepository<Product>
    {

        //Sadece producta özel imzalar
        List<ProductDetailDto> GetProductDetails();


    }
}


//Code Refactoring
