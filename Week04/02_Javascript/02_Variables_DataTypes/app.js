/*
    EcmaScript
    Değişkenler tanımlanırken 3 farklı keyword kullanılabilir.
    1)var
    2)left
    3)const(sabit)
    
    - ES6 ile birikte artık Modern JavaScript tabiri kullanılmaya başlanmıştır. Bu süreçte let ve couns kullanın, var kullanmaktan kaçının.


    - JS'te değişken tanımlanırken tip belirtilmez.
    - Bu, değişkenlerin tipi olmadığı anlamına gelmez.
    - JS motoru bir değişkene değer atanması esnasında o değere göre tipi belirler.
    - Eğer henüz bir değişkene değer atanmamışsa undefined olarak belirlenir.
*/


// let yas = 20;
// console.log(yas);

// let ad = 'Geç kalan Sema';
// let soyad = 'Geç kalan Harun';
// console.log(ad);
// console.log(soyad);
// console.log(ad,soyad);

// let firstName = 'Harun';
// let lastName = 'Özer';
// console.log(firstName + ' ' + lastName);

// alt alta normal değişken tanımlama
// let sayi1 = 15;
// let sayi2 = 25;
// let sayi3 = 35;

//  Tek satırda
// let s1 = 15, s2 = 45, s3 = 55;

//  Virgül ile alt alta
// let say1 = 25,
//     say2 = 55,
//     say3 = 48;

// let durum = true;

// sayi1 = 125;
// console.log(sayi1);

// let toplam=0;
// toplam = toplam + say1;

// const benimDogumYilim = 2000;
// console.log('Benim Doğum Yılım: '+ benimDogumYilim);

/*
    -Bildiğimiz değişken isimlendirme yöntemlerini burada da kullanabiliriz.
    Değişekenleri genellikle camelCase ile isimlendiririz.
    -Değişken isminde haf, rakam, $ ve _ olabilir.
    -Değişken ismi rakamla başlayamaz.
    -Reserved Keyword'ler (halihazırda değişeken olarak kullanılan yazımlar) değişken adı olarak kullanılamaz.

    -Const sabit değerleri tutmak için kullanılır. Genellikle tamamen büyük harf ile isimlendirilir.


*/

// const PI_SAYISI = 3.14;
// const _PI_SAYISI = 3.14;

// const RENK_1 = 'Sarı';
// const RENK_2 = 'Lacivert';
// let renk_3 = 'Yeşil';

// console.log(RENK_1, renk_3, RENK_2);


// ----------------------------DATA TYPES------------------------

//  1)NUMBER
// let sayi1 = 100;
// console.log(sayi1);
// console.log(typeof sayi1); // typeof Tipini Gösterir
// console.log(typeof (sayi1)); //Tipini Gösterir typeof'tan sonra parantez içine de yazılabilir.

// let sayi2 = 17.5;
// console.log(sayi2);
// console.log(typeof sayi2); //Yan yana 2 değişken yazdırıldığında virgülden sonra text olarak tırnak içinde yazdırıyor. kafanı karıştırma.

// let sayi3 = 25/0;
// console.log(sayi3, typeof sayi3); //Infinity sonucu verir.

// let sayi4 = 'Okul' / 25
// console.log(sayi4, typeof sayi4); //NaN sonucu verir Not a Number

// let sayi5 = 45645646454564546578999999999999999999999999999999999999999999999999999997897897797897987897897987987897987897978797897978789456789999999999999999999999999999999999999999999n
// console.log(sayi5, typeof sayi5);

// let sayi6 = sayi5 * 99999999999999999999999999999999999999999999999999999999999999999999999999999999n
// console.log(sayi6, typeof sayi6);

//STRING
/*
    String ifadeler üç farklı şekilde ifade edilebilir.
    1) Tek tırnak ile ('')
    2) Çift tırnak ile ("")
    3) Backtiks (``) alt+noktalı virgül
*/

// let ad = '"Harun"';
// let soyad = '\'Özer\'';
// let adSoyad = ad + " " + soyad
// console.log(adSoyad, typeof adSoyad);

// let adres = 'Başakşehir Mah.\n\tNurettin Topçu Cad. Özlem Apt. No:6\n\tBaşakşehir';
// console.log(adres);

// let adSoyad = 'Harun Özer';
// let yas = 22;
// let kanGrubu = 'A Rh+'
// let kilo = 76;
// let cinsiyet = 'Erkek';

// console.log('Sayın ' + adSoyad + ', ' + yas + ' yaşındasınız.\n' + 'Kilo: ' + kilo + '\nKan Grubunuz: ' + kanGrubu + '\nCinsiyet: ' + cinsiyet + '\n\n\n');

// console.log(`Sayın ${adSoyad}, ${yas} yaşındasınız.
// Kilonuz: ${kilo}
// Kan Grubunuz: ${kanGrubu}
// Cinsiyetiniz: ${cinsiyet}
// `);

//BOOLEAN
// let durum = true;
// console.log(durum, typeof durum);
// let ad = 'Halil';
// console.log(ad, typeof ad);

//null, undefined
// let yas;
// console.log(yas, typeof yas); //Değer verilmediğinden tipi belli değil. O yüzden undefined olarak getirir.
// yas = null; //Değişkeni object olarak belirler.
// yas = 12/0
// console.log(yas, typeof yas);

//JavaScriptte CHAR diye bir tip yoktur!

//CONVERT DATA TYPES

// let durum = false;
// console.log(durum, typeof durum);

// let metin = 'Durumunuz ' + durum + ' şeklindedir.';
// console.log(metin, typeof metin);

// let durumMetin = String(durum)
// console.log(durumMetin, typeof durumMetin);

// let sayi = 25;
// let metin2 = sayi + ' yaşındasınız.';
// console.log(metin2, typeof metin2);
// let sayiMetin = String(sayi);
// console.log(sayiMetin, typeof sayiMetin);

// let metinSayi = '455';
// console.log(metinSayi, typeof metinSayi);
// let metinSayiNumber = Number(metinSayi);
// console.log(metinSayiNumber, typeof metinSayiNumber);

// let sayiMetin = '       145         ';
// console.log(sayiMetin, typeof sayiMetin);
// let sayi = Number(sayiMetin);
// console.log(sayi, typeof sayi);

// number--> 2 üzeri 53-1
//n olarak belirlediğimizde bigint olarak geçer.
// let sayi = 1254n;
// console.log(sayi, typeof sayi);

// console.log(Number(true));
// console.log(Number(false));


// Sadece sayılar değer olan 0'ı false olarak alır. Diğerlerinin hepsini true olarak alır.
// console.log(Boolean(0));
// console.log(Boolean(1));
// console.log(Boolean(789));
// console.log(Boolean(-564));
// console.log(Boolean('0'));

// let a;
// a = '' + 1 + 0; console.log(a, typeof a);
// a = '' - 1 + 0; console.log(a, typeof a);
// a = true + false; console.log(a, typeof a);
// a = 6 / '3'; console.log(a, typeof a);
// a = 4 + 5 + 'px'; console.log(a, typeof a);
// a = '$' + 4 + 5; console.log(a, typeof a);
// a = '4px' - 2; console.log(a, typeof a);
// a = '       -9      ' + 5; console.log(a, typeof a);
// a = null + 1; console.log(a, typeof a);
// a = undefined + 1; console.log(a, typeof a);

