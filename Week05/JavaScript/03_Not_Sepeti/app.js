let btnAdd = document.getElementById('btnAddNewNote');
let txtNoteName = document.getElementById('txtNoteName');
let completeId;

btnAdd.addEventListener('click', newTask);
txtNoteName.addEventListener('keypress', function(event) {
    if (event.key == 'Enter') {
        event.preventDefault();
        btnAdd.click();
    }
});
let notListesi = [
    { 'id': 1, 'notAdi': 'Not 1' },
    { 'id': 2, 'notAdi': 'Not 2' },
    { 'id': 3, 'notAdi': 'Not 3' },
    { 'id': 4, 'notAdi': 'Not 4' }
];

function displayNotes() {
    let ul = document.getElementById('note-list')
    ul.innerHTML='';
    if (notListesi.length == 0) {
        ul.innerHTML='<span style = "color:white; font-size:25px;">Not Listeniz boş!</span>';
    }
    for (const not of notListesi) {
        let li = `
        <li class="note">
        <label for=""><input class="txtNotGir" type="text" value="${not.notAdi}" id="${not.id}" readonly></label>
        <button id="completeButton" onclick="completeNote()"><i class="fa-solid fa-square-check" style="color: white; font-size:20px;"></i></button>
        <button id="deleteButton" onclick="removeNote(${not.id})"><i class="fa-solid fa-trash-can" style="color: white; font-size: 17px;"></i></button>
        </li>
        `;
        ul.insertAdjacentHTML('beforeend', li);
    }
}
function newTask (event) {
    event.preventDefault();
    if (isFull(txtNoteName.value)) {
        notListesi.push(
            {
                'id': notListesi.length+1,
                'notAdi': ilkHarfiBuyut(txtNoteName.value)
            }
        )
        displayNotes();
    }else {
        alert('Lütfen boş bırakmayınız!')
    }
    txtNoteName.value='';
    txtNoteName.focus();
};

function isFull (value) {
    if (value.trim() =='') {
        return false;
    }
    return true;
};

function ilkHarfiBuyut(value) {
    let ilkHarf = value[0].toUpperCase();
    let geriKalan = value.slice(1);
    return ilkHarf+geriKalan;
};

function removeNote(id) {
    let deletedId;
    for (const notIndex in notListesi) {
        if (notListesi[notIndex].id == id) {
            deletedId = notIndex;
        }
    };
    notListesi.splice(deletedId, 1);
    displayNotes();
}

displayNotes();