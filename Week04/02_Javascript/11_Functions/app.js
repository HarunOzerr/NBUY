// function selamVer(){
//     console.log('Merhaba Java Script');
// }

// selamVer();


// function selamVer(isim = ''){
//     console.log('Merhaba ' + isim);
// }
// selamVer('Harun');
// selamVer('Hrn');
// selamVer();


// function yasHesapla(dogumYili){
//     return new Date().getFullYear() - dogumYili;
// }

// console.log(yasHesapla(2000));
// let yas = yasHesapla(2000);
// if (yas < 30) {
//     console.log('Yaşınız uygun değildir.');
// }else {
//     console.log('Kabul edildiniz.');
// }

//Bir tutar bilgisi alıp, bu tutarın kdv sini hesaplayıp geri döndüren function.

// function kdvHesapla(tutar){
    // let sonuc = (tutar * 0.18).toFixed(2); //1. YAZILIŞ
    
    // 2. YAZILIŞ
    // let sonuc = tutar * 0.18;
    // sonuc = sonuc.toFixed(2);
    // return sonuc;
// }
// console.log(kdvHesapla(4875));


// function kdvHesapla(){
//     for (let arguments = 0; arguments < arguments.length; arguments++) {
//         console.log(arguments[i] * 0.18);
//     }
// }

// kdvHesapla(45, 75, 180);


// Kendisine gönderilecek tutar bilgilerini kullanarak kdv'leri hesaplayıp,
// geriye hesaplanmış kdv'leri içinde barından bir dizi döndüren function.

function kdvHesapla(){
    let sonuc = [];
    let kdv = 0;
    for (let i = 0; i < arguments.length; i++) {
        kdv = arguments[i] * 0.18;
        kdv = kdv.toFixed(2);
        sonuc.push(kdv); //kdv yi sonuç dizinine eklemenin 1. yöntemi
        // sonuc[i] = kdv; // kdv yi sonuç dizinine eklemenin 2. yöntemi.
        return sonuc;
    }
}

console.log(kdvHesapla(100, 450, 728));
