let sonuc;
//getElementById
sonuc = document.getElementById('title');
sonuc = document.getElementById('title').id;
sonuc = document.getElementById('title').className;
sonuc = document.getElementById('title').classList;

document.getElementById('title').style.fontSize='50px';
document.getElementById('title').style.color='red';
// document.getElementById('title').style.display='none';

//querySelector
//querySelector ile ister class'ı istersek id'yi seçtirebiliriz.
sonuc = document.querySelector('#title');
sonuc = document.querySelector('div'); //1'den fazla div var ise yukarıdan aşağıya karşılaştığı ilk div'i seçer.
sonuc = document.querySelector('.h1');

sonuc = document.querySelector('li');
sonuc = document.querySelector('li:first-child'); // li'lerin içindeki 1. yi seç, ilkini seç.
sonuc = document.querySelector('li:last-child'); // li'lerin içindeki sonuncuyu seç.
sonuc = document.querySelector('li:nth-child(2)'); // li'lerin istediğimiz sıradakini seç.


console.log(sonuc);