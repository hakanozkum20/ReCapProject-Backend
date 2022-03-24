using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi.";
        public static string CarNameInvalid = "Araç ismi geçersiz.";
        public static string MaintenanceTime = "Sistem servis dışı.";
        public static string CarListed = "Araçlar listelendi";
        public static string BrandListed = "Modeller listelendi.";
        public static string CarIdListed = "Araç listelendi.";
        public static string DetailListed = "Detaylı listeleme yapıldı.";
        public static string CarNoAvailable = "Araç kiralanamaz. Teslim edilmemiş.";
        public static string RentalAdded = "Araç kiralama işlemi tamamlandı.";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string UserListed = "Kullanıcılar listelendi.";
        public static string CustomerListed = "Müşteriler listelendi.";
        public static string CarCountOfBrandError = "Bir modelden 10 tane araç olabilir.";
        public static string CarNameAllreadyExists = "Aynı isimden bir araba mevcut.";
        public static string BrandLimitExceded="Markalar 15 den fazla olamaz.Limit aşıldığı için yeni araç eklenemiyor.";
        public static string CarImagesListed="Resimler Listelendi.";
        public static string CarImageListedById ="Id deki resim getirildi.";
        public static string  AuthorizationDenied = "Yetkiniz yok";
        public static string ListedByUserId = "Kullanıcı listelendi.";
        public static string UserRegistered = "Kayıt olundu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string CarUpdated = "Araç güncellendi";
    }
}
