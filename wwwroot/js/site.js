//  Menu hamburguesa

const d = document;
const menuBtn = d.querySelector('#menu');
const menuLst = d.querySelector('header .menu');

menuBtn.onclick = () => {
    let text;
    menuLst.classList.toggle('active') ? text = '&times;' : text = '&equiv;';
    menuBtn.innerHTML = text;
}

