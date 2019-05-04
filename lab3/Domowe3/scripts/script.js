//zmienna do pamietania które zdjecie
var slideIndex = 0;
showSlides();

function showSlides() {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");
    //schowaj każde zdjecie
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    slideIndex++;
    if (slideIndex > slides.length) { slideIndex = 1 }
    //nie uzywaj zadnej z kropek
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    //pokaz zdjecie
    slides[slideIndex - 1].style.display = "block";
    //daj kropke jako aktywna
    dots[slideIndex - 1].className += " active";
    setTimeout(showSlides, 4000); // zmień co 4 sekundy
}