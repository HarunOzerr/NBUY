/*
1) Prompt aracılığı ile kullanıcıdan bir saniye değeri alın.
Örneğin 1500. Ardından bu girilen değerin kaç dakika, kaç saniye olduğunu hesaplayıp konsola düzgün bir şekilde yazdırın.
Örnek sonuç: 
Girilen değer: 1270
Sonuç: 21 dakika 10 saniye
*/

// let saniye = parseInt(prompt('Çevrilmesini istediğiniz saniye değeri girin:'));
// let dakika = parseInt(saniye / 60);
// saniye = saniye % 60;
// console.log('Sonuç: ' + dakika + ' Dakika ' + saniye + ' Saniye.');

//Öneri: Girilen saniye değerlerini 1 saat 45dk 00 sn şeklinde gösterin.




/*
2) Kullanıcıya her defasında 100'den büyük bir sayı girmesi için prompt ile veri girmesini isteyin.
Eğer farklı bir değer girerse tekrardan değer girmesi talebinde bulunun.
Kullanıcı 100 den büyük bir sayı veya boş satıra onay verene kadar döngüye devam edilmelidir.
Burada kullanıcının sadece sayısal değerler gireceğini farzedin.
Ayrıca sayısal değerleri kontrol için bir kod yazmak ile uğraşmayın.
*/
// let sayi;
// sayi = Number(prompt('100den büyük bir sayı giriniz.'));
// do {
// sayi = Number(prompt('Tekrar 100den büyük bir sayı giriniz.'));
// } while (sayi <= 100 && sayi != '');


/*
3) 1 den büyük olup 1 veya kendisi haricinde hiçbir sayıya kalansız bölünemeyen sayılara asal sayı denir.
Örneğin 5 bir asal sayıdır. Çünkü 2,3 ve 4 e kalansız bölünemez.
2 den n'ye kadar olan asal sayıları bulan kodu yazınız.
Örneğin n = 10 için sonuç 2,3,5,7 olacaktır.
NOT: Kod her türlü n değeri için çalışmalıdır, sabit bir sayı değildir.
*/

// ---------------------- 1. ÇÖZÜM---------------------------
// let n = prompt('Bir sayı giriniz.');
// let asalMi;
// for (let i = 2; i <= n; i++) {
//     asalMi = true;
//     for (let j = 2; j < i; j++) {
//         if (i % j === 0) {
//             asalMi=false;
//         }
        
//     }
//     if (asalMi === true) {
//         console.log(i);
//     }
// }

// -------------------------- 2. ÇÖZÜM -----------------------
// let n = prompt('Bir sayı giriniz.')

// nextPrime:
// for (let i = 2; i <= n; i++) {
//     for (let j = 2; j < i; j++) {
//         if (i % j === 0) {
//             continue nextPrime; // nextPrime olarak belirlenen satıra geri döner. Kod bloğunu o satırdan tekrar başlatır.        
//         }
//     }
//     console.log(i);
// }

let yil = prompt('Bir yıl giriniz.');
if (yil % 4 == 0 && yil % 100 == 0 ) {
    console.log(object);
}



