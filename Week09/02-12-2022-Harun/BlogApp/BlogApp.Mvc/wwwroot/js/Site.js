﻿function convertToShortDate(dateString) {
    const shortDate = new Date(dateString).toLocaleDateString('tr-TR');
    return shortDate;
}

function convertFirstLetterToUpperCase(text) {
    const convertedText = text.charAt(0).toUpperCase() + text.slice(1).toLowerCase();
    return convertedText;
}