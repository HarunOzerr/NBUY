let sonuc;

sonuc = Number('10.6'); //Sonuç:10.6
sonuc = parseInt('10.6'); //Sonuç:10
sonuc = parseInt('10abc'); //Sayısal bir değer yakalayana kadar alır sonrasını siler ve yazdırır. Sonuç: 10
sonuc = parseInt('10abc34');
sonuc = parseInt('Aw10abc'); //NaN verir.
sonuc = parseInt('10.abc')
sonuc = parseFloat('10.6abc') //Float olduğu için 10.6 verir.

let sayi = 15.468756;
sonuc = sayi.toFixed(); //Yuvarlayarak tam sayıyı yazdırır. Sonuç:15
let sayi2 = 15.968756;
sonuc = sayi2.toFixed() //Sonuç:16 
sonuc = sayi.toPrecision(6); // onladık basamağının kaç basamak göstereceğini belirleriz.

sonuc = Math.round(2.4); //Direkt olarak yuvarlama methodu
sonuc = Math.round(2.5);
sonuc = Math.ceil(2.2); //ondalık basamağı ne olursa olsun her zaman tavana yani üste yuvarlar.
sonuc = Math.floor(2.9); //Ondalık basamağı ne olursa olsun her zaman tabana yani aşağıya yuvarlar.
sonuc = Math.pow(2,3);//üs alma methodu 2üssü3=8
sonuc = Math.sqrt(25);// Karekökünü bulma.
sonuc = Math.abs(-5);//Mutlak değeri verir. sonuç=5
sonuc = Math.min(43,56,12,8); //Aralarından en küçük sayıyı yani minimumum bulur.
sonuc = Math.max(43,56,12,8); //Aralarından en büyük sayıyı yani maximum bulur.
sonuc = Math.random(); //Random sayı üretir.
sonuc = parseInt(Math.random()*10)+1; //Sayıya *10 vererek 0-10 arası random sayı ürettiririz. sonuna +1 ekleyerek 10'u da dahil etmiş oluruz.




console.log(sonuc, typeof sonuc);