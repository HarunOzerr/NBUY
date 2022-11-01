const display = document.querySelector('.calculator-input');
const keys = document.querySelector('.calculator-keys');
let displayValue = '0';

updateDisplay();

function updateDisplay() {
    display.value = displayValue;
}

keys.addEventListener('click', function() {
    const element = event.target;
    if (!element.matches('button')) return;
    if (element.classList.contains('operator')) {
        console.log('Bir operatöre tıklandı');
    }else if (element.classList.contains('decimal')){
        console.log('Ondalık sayı yazmak üzere . işaretine tıklandı.');
    }else if (element.classList.contains('clear')) {
        console.log('Temizleme butonuna tıklandı.');
    }else {
        console.log('Bir rakama tıklandı.');
    }
});