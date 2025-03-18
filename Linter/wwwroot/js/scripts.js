

window.addEventListener("load", function () {

});

//const observador = new IntersectionObserver((entries) => {
//    entries.forEach((entry) => {
//        console.log(entry)
//        if (entry.isIntersecting) {
//            entry.target.classList.add('show')
//        } else {
//            entry.target.classList.remove('show');
//        }
//    });
//})
////seleciona todos os elementos com hidden
//const hiddenElements = document.querySelectorAll('.hidden');
//hiddenElements.forEach((element) => observador.observe(element));


if (typeof observador === 'undefined') {
    const observador = new IntersectionObserver((entries) => {
        entries.forEach((entry) => {
            console.log(entry);
            if (entry.isIntersecting) {
                entry.target.classList.add('show');
            //} else {
            //    entry.target.classList.remove('show');
            }
        });
    });

    // Seleciona todos os elementos com a classe "hidden"
    const hiddenElements = document.querySelectorAll('.hidden');
    hiddenElements.forEach((element) => observador.observe(element));
}

if (typeof observador === 'undefined') {
    const observador = new IntersectionObserver((entries) => {
        entries.forEach((entry) => {
            console.log(entry);
            if (entry.isIntersecting) {
                entry.target.classList.add('show');
            //} else {
            //    entry.target.classList.remove('show');
            }
        });
    });

    const hiddenElements = document.querySelectorAll('.hidden-left');
    hiddenElements.forEach((element) => observador.observe(element));
}

if (typeof observador === 'undefined') {
    const counters = document.querySelectorAll(".counter");

    counters.forEach(counter => {
        let initialCount = 0
        const finalCount = counter.dataset.count
        console.log(finalCount)
    })
}

//const square = document.getElementById("square");

//square.animate([{
//    transform: "translateX(0)", 
//    opacity: 1, 
//}
//{
//    transform: "translateX", 
//    opacity: 0.25, 
//}
//], {
//    duration: 2000,
//})
