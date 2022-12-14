'use strict';

let gorevListesi = [
    {'id': 1, 'gorevAdi': 'Görev 1'},
    {'id': 2, 'gorevAdi': 'Görev 2'},
    {'id': 3, 'gorevAdi': 'Görev 3'},
    {'id': 4, 'gorevAdi': 'Görev 4'}
];

let ul = document.getElementById('task-list');
// let ul = document.querySelector('#task-list'); //Diğer seçme yolu

for (const gorev of gorevListesi) {
    let li = `
        <li class="task list-group-item">
            <div class="form-check">
                <input type="checkbox" id="${gorev.id}" class="form-check-input">
                <label for="${gorev.id}" class="form-check-label">${gorev.gorevAdi}</label>
            </div>
        </li>
    `;
    ul.insertAdjacentHTML('beforeend', li);
}

// let btnEkle = document.querySelector('#btnAddNewTask');
// btnEkle.addEventListener('click', function(event){
//     //btnEkle adlı elemente tıklandığı zaman çalışacak kodlar burada.
//     //Buraya gelen event parametresi ilgili elementin gerçekleşen click olayı ile ilgili bilgileri barındırıyor.
//     event.preventDefault();
//     console.log('btnEkle tıklandı!');
// });

// let btnTemizle = document.querySelector('#btnClear');
// btnTemizle.addEventListener('click', clearAll); //Normalde () yaparak çalışmasını isteriz ama bu komutta () yapmadan sadece hangi function çağıralacaksa ismini yazarız.

// function clearAll(event){
//     event.preventDefault();
//     console.log('temizlendi');
// };

let btnAdd = document.querySelector('#btnAddNewTask');
btnAdd.addEventListener('click', newTask);

function newTask(event){
    event.preventDefault();
    event.target.classList.add('btn-warning');
    event.target.style.display='none';
    console.log(event.target);
}


