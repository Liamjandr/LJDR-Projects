let menu = document.querySelector('#menu-icon');
let navbar = document.querySelector('.navbar');

menu.onclick =()=>{
    menu.classList.toggle('fa-bars');
    navbar.classList.toggle('open');

}


let sections = document.querySelectorAll('')
let navLinks = document.querySelectorAll('nav .navbar a')

window.onscroll = () => {
    sections.forEach(sec => {
        let top = wwindow.scrollY;
        let offset = sec.offsetTop;
        let height = sec.offsetHeight;
        let id = sec.getAttribute('id');


        if(top >= offset && top < offset + height){
            navLinks.forEach(links => {
                links.classList.remove('activenav');
                document.querySelector('nav .navbar a [href*= ' + id + ']').classList.add('activenav');
            });
        }

    }
    );



};