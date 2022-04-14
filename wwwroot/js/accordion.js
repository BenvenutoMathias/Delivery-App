// Prevent EventDefault
let dropdown = document.querySelectorAll(".dropdwn");
console.log(dropdown);
for (let i = 0; i < dropdown.length; i++) {
    const element = dropdown[i];
    element.addEventListener("click", function (e) {
        e.preventDefault();
    });
    
}

// Accordion Desplegable 
var acc = document.getElementsByClassName("accordion");
var i;

for (i = 0; i < acc.length; i++) {
  acc[i].addEventListener("click", function() {
    this.classList.toggle("activa");
    var panel = this.nextElementSibling;
    if (panel.style.maxHeight) {
      panel.style.maxHeight = null;
    } else {
      panel.style.maxHeight = panel.scrollHeight + "px";
    }
  });
}