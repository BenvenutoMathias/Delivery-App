let aFood = document.getElementById('aFood');
let aDrink = document.getElementById('aDrink');
let aBread = document.getElementById('aBread');

let SectionFoods = document.getElementById('Foods');
let SectionDrinks = document.getElementById('Drinks');
let SectionBreads = document.getElementById('Breads');

let hidden = true;

const ChangeAttr = (element) => {

    if (hidden) {
        element.style.display = "flex";
        hidden = false;
    } else {
        element.style.display = "none";
        hidden = true;
    }
}
aFood.addEventListener("click", function () { ChangeAttr(SectionFoods) });
aDrink.addEventListener("click", function () { ChangeAttr(SectionDrinks) });
aBread.addEventListener("click", function () { ChangeAttr(SectionBreads) });

