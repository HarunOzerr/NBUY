// let urunler = [];
// urunler[0] = 'Samsung S21';
// urunler[1] = 'Iphone 11 Pro Max';
// urunler[123] = 'Bilgisayar';


// let urunler = ['Iphone 13', 'Iphone XR', 'Dell X5'];
// let fiyatlar = [15000, 35000, 45000];
// let renkler = ['Gold', 'Gri', 'Lacivert']

// urunler.forEach((urun, i)=> {
//     console.log(urun, fiyatlar[i], renkler[i]);
// });

// console.log(urunler);
// console.log(fiyatlar);
// console.log(renkler);


// let urun1 = [];
// urun1[0] = 'Iphone 13';
// urun1[1] = 25000;
// urun1[2] = 'Gold';
// urun1[3] = true;

// let urun2 = ['Iphone 11 Pro Max', 18900, 'Green', false ];
// let urun3 = ['Samsung S8 Plus', 12500, 'Black', true ];


// let urunler = [urun1, urun2, urun3];

// console.log(urun1, typeof urun1);
// console.log(urun2, typeof urun2);
// console.log(urun3, typeof urun3);
// console.log(urunler);


// let urun1 = 'Iphone 13, 25000, Yeşil, true';
// let urun1Dizi = urun1.split(', ');
// console.log(urun1, typeof urun1);
// console.log(urun1Dizi, typeof urun1Dizi);


let ogrenciler = ['Cemre','Harun','Mert','Osman']
let sonuc;
// sonuc = ogrenciler.length;
// sonuc = ogrenciler;
// sonuc = ogrenciler.toString();// Her bir elemanı tek bir parça halinde birleştirir.
// sonuc = ogrenciler.join('/');  // Her bir elemanın ayırma şekli olan virgülü içerisine yazdığımız işaret ve yazı ile değiştirirz.

ogrenciler [4] = 'Serhat';
ogrenciler.push('Aylin'); //İndex belirtmeden en sonuna eleman eklemek için pushtan yararlanılır.
ogrenciler.pop(); //Son elemanı silmek için pop() kullanabiliriz.

sonuc = ogrenciler.push('Aylin')
sonuc = ogrenciler.pop();
sonuc = ogrenciler.unshift('Aylin'); //Dizinin en başına eleman eklemek için unshift kullanırız.


console.log(ogrenciler);
console.log(sonuc);