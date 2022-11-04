const display = document.querySelector('.calculator-input');
const keys = document.querySelector('.calculator-keys');
let displayValue = '0';
let firstValue = null;
let operator = null;
let waitingForSecondValue = false;

updateDisplay();

function updateDisplay() {
    display.value = displayValue.replace('.' , ',');
}

keys.addEventListener('click', function() {
    const element = event.target;
    const value = element.value;
    if (!element.matches('button')) return;
    switch (value) {
        case '+':
        case '-':
        case '*':
        case '/':
        case '=':
            handleOperator(value);
            break;

        case '.':
            inputDecimal();
            break;

        case 'clear':
            clearDisplay();
            break;
        
        default:
            inputNumber(value);
    }

    // if (element.classList.contains('operator')) {
    //     handleOperator(element.value);
    //     updateDisplay();
    //     return;
    // }
    // if (element.classList.contains('decimal')){
    //     inputDecimal();
    //     return;
    // }
    // if (element.classList.contains('clear')) {
    //     clearDisplay();
    //     return;
    // }
    // inputNumber(element.value);
});

function inputNumber(num) {
    // displayValue = num;
    // displayValue += num;
    if (waitingForSecondValue) {
        displayValue = num;
        waitingForSecondValue = false;
    }else {
        displayValue = displayValue == '0' ? num : displayValue + num
    }
    updateDisplay();
}

function inputDecimal() {
    if (!displayValue.includes('.')) {
        displayValue += '.';
        updateDisplay();   
    }
}

function clearDisplay() {
    displayValue = '0';
    firstValue = null;
    waitingForSecondValue = false;
    updateDisplay();
}

function handleOperator(nextOperator) {
    let value = parseFloat(displayValue);
    if(operator && waitingForSecondValue) {
        operator = nextOperator;
        return;
    }
    if (firstValue == null) {
        firstValue = value;
    }else if(operator) {
        const result = calculate(firstValue, operator, value);
        displayValue = `${parseFloat(result.toFixed(7))}`
        firstValue = result;
    }
    waitingForSecondValue = true;
    operator = nextOperator;
    updateDisplay();
}

function calculate (num1, op, num2) {
    if (op === '+') return num1 + num2;
    if (op === '-') return num1 - num2;
    if (op === '*') return num1 * num2;
    if (op === '/') return num1 / num2;
    return num2;
}