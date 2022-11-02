let btnAdd = document.getElementById('btnAddNewNote');
let txtNoteName = document.getElementById('txtNoteName');
btnAdd.addEventListener('click', newNote);

txtNoteName.addEventListener('keypress', function(event){
    if (event.key == 'Enter') {
        event.preventDefault();
        btnAdd.click();
    }
});

let notListesi = [
    {'id': 1, 'notAdi': 'Not 1'},
    {'id': 2, 'notAdi': 'Not 2'},
    {'id': 3, 'notAdi': 'Not 3'}
];

let ul = document.getElementById('not-list')

function displayNotes() {
    let ul = document.getElementById('not-list');
    ul.innerHTML='';
}

for (const not of notListesi) {
    let li = `
    <li class="note">
    <label for=""><input type="text" value="${not.notAdi}" id="${not.id}"></label>
    <button id="completeButton"><i class="fa-solid fa-square-check" style="color: white; font-size:20px;"></i></button>
    <button id="deleteButton"><i class="fa-solid fa-trash-can" style="color: white; font-size: 17px;"></i></button>
    </li>`;
    ul.insertAdjacentHTML('beforeend', li);
}

function newNote(event) {
    event.preventDefault();
        notListesi.push(
            {
                'id': notListesi.length + 1,
                'notAdi': txtNoteName.value
            }
        )
    txtNoteName.value = '';
    txtNoteName.focus();
}
displayNotes();