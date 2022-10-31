let sonuc;
// let taskList = document.getElementById('task-list');
// sonuc = taskList.children;
// sonuc = taskList.children[0];
// sonuc = taskList.firstElementChild.innerText;
// sonuc = taskList.lastElementChild.innerText;


// sonuc = document.getElementById('title');
// sonuc = sonuc.parentElement.parentElement.parentElement;


// taskList = document.querySelector('.task'); //Görev 1'i seçer.
// sonuc = taskList.nextElementSibling.nextElementSibling; //2 sonrakini seçmeyi sağlar yani Görev 3
// sonuc = sonuc.previousElementSibling.innerText; // En son seçilenden bir öncekini seçer yani Görev 2
let ul = document.getElementById('task-list');
sonuc = ul.children;
sonuc = ul.children[0].children[0].children[0].checked=true;

console.log(sonuc);