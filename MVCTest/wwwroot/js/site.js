// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const testText = document.getElementById('inputText');
testText.addEventListener('input', changeColor);

function changeColor() {
    const colorArr = ['red', 'blue', 'orange', 'violet', 'gray']
    document.body.style.background = colorArr[Math.ceil(Math.random()*4)];
};