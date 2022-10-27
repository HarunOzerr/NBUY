// let obje1 = {
//     'urunAd':'Iphone 13',
//     'urunFiyat':37569,
//     'urunRenk':'Gri',
//     'onayli':true
// }

// let obje2 = {
//     'urunAd':'Iphone 13',
//     'urunFiyat':37569,
//     'urunRenk':'Gri',
// }

// if (obje2.onayli==undefined) {
//     console.log('Lütfen admin ile iletişime geçiniz.');
// }else {
//     if (obje2.onayli==true) {
//         console.log('Bu Ürün Satışta.');
//     }else {
//         console.log('Gelince Haber Ver.');
//     }
// }




// console.log(obje1);
// console.log(obje1.urunFiyat);
// obje1.urunFiyat=45000;
// console.log(obje1.urunFiyat);
// obje1.urunAdet = 5;
// console.log(obje1);


// let ogrenci1 = {
//     'ogrenciNo':144,
//     'ogrenciAd':'Harun',
//     'ogrenciSoyad':'Özer',
//     'ogrenciYas':22,
//     'ogrenciAktif':true
// }
// ogrenci1.cinsiyet = 'Erkek';
// if ('cinsiyet' in ogrenci1) {
//     console.log(ogrenci1.cinsiyet);
// }else {
//     console.log('Böyle bir özellik tanımlı değil.');
// }

// let kisi1 = {
//     'Ad Soyad':'Serhan Cankuş',
//     'Doğum Tarihi':'11.05.1999',
//     'kidemYili':14
// }

// console.log(kisi1["Ad Soyad"]);
// console.log(kisi1.kidemYili);

// let product1 = {
//     productId:12,
//     productName:'Samsung S8 Plus',
//     productPrice:6324
// };

// let product2 = {
//     productId:13,
//     productName:'Iphone 11 Pro Max',
//     productPrice:16873
// };
// let product3 = {
//     productId:14,
//     productName:'Xiaomi Note 10',
//     productPrice:9374
// };

// let products = [product1,product2,product3];
// console.log(products);


// Ayrı ayrı eklemek yerine tek başlıkta ekleme seçeneği.
// let products = [
//     {
//         id:13,
//         name:'Iphone',
//         price:19763
//     },
//     {
//         id:14,
//         name:'Samsung',
//         price:8763
//     },
//     {
//         id:15,
//         name:'Xiaomi',
//         price:7428
//     }
// ];
// console.log(products);
// console.log(products[2].price + ' ' + products[2].name);


let category1 = {};
category1.name='telefon';
let category2 = {};
category2.name='Bilgisayar'
let categories = {category1,category2};
console.log(categories);