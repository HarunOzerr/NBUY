let simdi = new Date();
sonuc = simdi;

//Bilgiyi getirmek için get kullanıyoruz.
sonuc = simdi.getDate(); // Tarihin gününü sayı olarak gösterir.
sonuc = simdi.getDay(); // Haftanın kaçıncı günü olduğunu sayıyla gösterir. 
sonuc = simdi.getFullYear(); //Yılı getirir.
sonuc = simdi.getHours(); // Saati getirir.
sonuc = simdi.getTime(); //Tarihin seri numarasını getirir.

//Bilgiyi değiştirmek için set kullanıyoruz.
simdi.setFullYear(2035); //Yıl bilgisini değiştirir.
simdi.setMonth(3) // Ay bilgisini değiştirir.
sonuc = simdi;

let suAn = new Date();
sonuc = suAn;
let kacYilSonra=5;
sonuc = new Date(suAn.setFullYear(suAn.getFullYear()+kacYilSonra));


simdi = new Date();
sonuc = simdi;

let dogumTarihi= new Date(2000, 03, 16)
sonuc = simdi.getFullYear() - dogumTarihi.getFullYear();

let milisecond = simdi - dogumTarihi;
let second = milisecond / 1000;
let minute = second / 60;
let hour = minute / 60;
let day = hour / 24;

sonuc = parseInt(day);
console.log(dogumTarihi);
console.log(sonuc);