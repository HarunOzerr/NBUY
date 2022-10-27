//WHILE
// let i = 0;
// while (i < 10) {
//     console.log(i + '.JavaScript');
//     i++
// }

//DO WHILE
// let i = 0;
// do {
//     i++;
//     console.log(i + '.JavaScript');
// } while (i < 10);

//FOR
// for (let i = 0; i < 10; i++) {
//     console.log(i + 1 + '.JavaScript');
// }

//1-10 arasındaki sayıları toplayıp ekrana yazan program.
// let toplam = 0;
// let i = 1;
// while (i <= 10) {
//     toplam += i;
//     i++;
// }
// console.log('While İle: ' + toplam);

// let toplam2 = 0;
// for (let j = 1; j <= 10; j++) {
//     toplam2 += j;
// }
// console.log('For ile: ' + toplam2);

//Kullanıcının gireceği 3 sayıyı toplatan programı for kullanarak yazınız.

// let toplam = 0;
// let girilenSayi;
// for (let i = 1; i <= 3; i++) {
//     girilenSayi = Number(prompt(i + '.sayı: '));
//     toplam += girilenSayi;
// }
// console.log(toplam);

//Kullanıcı 0 girene kadar sayıları toplayıp sonucu consola yazan kodu yazınız.
//Örnekteki girilen sayıları da sonuçta yazdıralım.
// let toplam = 0;
// let girilenSayilar = [];
// let i = 0;
// do {
//     girilenSayilar[i] = Number(prompt(i + 1 + '. Sayıyı Giriniz: '));
//     toplam += girilenSayilar[i];  
//     i++;
// } while (girilenSayilar[i - 1] != 0);
// girilenSayilar.pop()
// for (let i = 0; i < girilenSayilar.length; i++) {
//     console.log(i + 1 + '. Sayı:\t' + girilenSayilar[i]);
// }
// console.log('Toplamı: ' + toplam);



//Kullanıcının istediği kadar sayı girmesini sağlayın.
//Sayı girişi bitişi için 0'a basılması gereksin.
//0'a basılıp sayı girişi bittiğinde kullanıcıya şu soruyu sorun: Tek mi Çift mi?
//Kullanıcı tek derse: tek sayıları ve toplamlarını
//Çift derse Çift sayıları ve toplamlarını yazdırın.
let sayilar = [];
let i = 0;
do {
    sayilar[i] = Number(prompt(i + 1 + '. Sayıyı Giriniz: '));
    console.log(sayilar[i]);
    i++;
} while (sayilar[i - 1] != 0);
sayilar.pop();
let sonucDizi = [];
let toplam = 0 ;
let tur;
let cevap = prompt('Tek mi Çift mi?');
console.log(cevap);
if (cevap.toLocaleLowerCase() == 'tek') {
    tur = 'Tek';
    for (let i = 0; i < sayilar.length; i++) {
        if (sayilar[i] % 2 === 1) {
            sonucDizi.push(sayilar[i])
            toplam+= sayilar[i]
        }  
    }
}else if (cevap.toLocaleLowerCase() == 'çift') {
    tur = 'Çift';
    for (let i = 0; i < sayilar.length; i++) {
        if (sayilar[i] % 2 === 0) {
            sonucDizi.push(sayilar[i])
            toplam+= sayilar[i]
        }  
    }
} else {
    console.log('Lütfen "Tek" ya da "Çift" yaz.')
}
console.log(sayilar);
console.log(tur + ' Sayılar: ' + sonucDizi);
console.log(tur + ' Sayıların Toplamı: ' + toplam);