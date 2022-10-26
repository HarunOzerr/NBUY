let ders = 'Bahçeşehir Üniversitesi Wissen Akademie Iğdır';
let sonuc;

sonuc = ders.toLowerCase(); //Metni Küçük harfe dönüştürme
sonuc = ders.toLocaleLowerCase(); //Küçük harfe dönüştürürken bozulmamasını istersek bu kullanılır.

sonuc = ders.toUpperCase(); //Metni büyük harfe dönüştürür.
sonuc = ders.toLocaleUpperCase(); //Metni büyük harfef dönüştürürken bozulmaması için bu kullanılır.i yi İ olarak yapması gibi.

sonuc = ders.length;
sonuc = ders[0];
sonuc = ders[29];
sonuc = ders[44];

sonuc = ders.slice(0,10);
sonuc = ders.slice(20,5); //Yanlış kullanım.
sonuc = ders.slice(10);

sonuc = ders.substring(0,10);
sonuc = ders.substring(10,0);
sonuc = ders.substring(20,25);

sonuc = ders.replace('Iğdır','İstanbul');
sonuc = ders.replace(' ','-') //İlk gördüğü boşluğu - olarak değiştirir. HEPSİNİ DEĞİL.
sonuc = ders.trim(); //Başa ve sona koyulan fazla boşlukları kaldırır.
sonuc = ders.trimStart();//Baştaki boşlukları kaldırır.
sonuc = ders.trimEnd();//Sondaki boşlukları kaldırır.

sonuc = ders.indexOf('A');
sonuc = ders.toLocaleLowerCase().indexOf('a');

sonuc=ders.split(' ');
// console.log(sonuc[3]);

sonuc = ders.includes('Akademie'); //İçerisinde geçip geçmediğini true false olarak gösterir.
sonuc = ders.startsWith('B') //Ders stringi startsWith içerisine yazılan ile mi başlıyor? True false olarak döndürür.
sonuc = ders.endsWith('Iğdır') //Ders stringi endsWith içerisine yazılan ile mi bitiyor? True false olarak döndürür.





console.log(sonuc);




// Kullanıcının girdiği bir cümlenin kaç sözcükten oluştuğunu bulunuz.
// let cumle = prompt('Lütfen bir cümle giriniz.');
// let sozcukDizisi = cumle.split(' ');
// console.log(sozcukDizisi.length);
