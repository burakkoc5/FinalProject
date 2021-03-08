using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Aynı kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu üründe bir isim zaten var.";
        public static string CategoryLimitExceeded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Hatalı şifre.";
        public static string SuccessfulLogin= "Başarılı giriş.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated= "Access Token başaarıyla oluşturuldu.";
        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
