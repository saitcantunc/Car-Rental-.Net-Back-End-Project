using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarAddedError = "Araba eklenemedi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarUpdatedError = "Araba güncellenemedi";
        public static string CarDeleted = "Araba silindi";
        
        public static string ColorAdded = "Renk eklendi.";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";
        
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandAddedError = "Marka en az 2 karakterden oluşmalı.";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandUpdatedError = "Marka en az 2 karakterden oluşmalı.";
        public static string BrandDeleted = "Marka silindi";
        
        public static string MaintenanceTime = "Bakımdayız";
        public static string CarListed = "Arabalar listelendi";

        public static string AddedCustomer = "Müşteri başarıyla eklendi.";
        public static string DeletedCustomer = "Müşteri başarıyla silindi.";
        public static string UpdatedCustomer = "Müşteri başarıyla güncellendi.";


        public static string AddedUser = "Kullanıcı başarıyla eklendi.";
        public static string DeletedUser = "Kullanıcı başarıyla silindi.";
        public static string UpdatedUser = "Kullanıcı başarıyla güncellendi.";


        public static string AddedRental = "Araba Kiralama işlemi baraşıyla gerçekleşti.";
        public static string DeletedRental = "Araba Kiralama işlemi iptal edildi.";
        public static string UpdatedRental = "Araba Kiralama işlemi güncellendi.";
        public static string FailedRentalAddOrUpdate = "Bu araba henüz teslim edilmediği için kiralayamazsınız.";
        public static string ReturnedRental = "Kiraladığınız araç teslim edildi.";
        
        public static string ImagesAdded = "Resim başarıyla eklendi";
        public static string FailAddedImageLimit = "Resim sınırı aşıldı, bir arabaya ait en fazla 5 resim olabilir.";
        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatası.";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token başarılı.";
    }
}
