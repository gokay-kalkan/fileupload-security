﻿# fileupload-security
Bu projede Home Controllerın Index actionunda resim dosyası yüklerken resimlerin uzantısına göre izin verdiğimiz uzantılara göre kontrol sağlayıp yüklenmesine izin veriyorum. Resim dosyası yüklerken content type değerine göre yani şu şekilde image/jpeg image/png tarzında content type değerlerine göre kontrol sağlanırsa kötü niyetli bir kişi sisteme burp suite gibi uygulamalarla isteği gönderirken araya girip yükleyeceği .exe uzantılı dosyanın content typenı uygulama üzerinden değiştirip gönderebilir. Uzantı exe olmasına rağmen izin verilen image/jpeg uzantılı content type değerine izin verdirerek dosyayı sunucuya yükleyebilir. 
