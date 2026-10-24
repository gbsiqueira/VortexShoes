
const carrosseis = document.querySelectorAll(".cards-produtos-populares");

carrosseis.forEach((carrossel) => {
    carrossel.addEventListener("wheel", (e) => {
        if (window.innerWidth < 768) return;

        e.preventDefault();
        carrossel.scrollLeft += e.deltaY;
    });
});