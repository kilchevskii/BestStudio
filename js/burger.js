function closeMenu() { 
    if(!document.querySelector(".menu-wrap").classList.contains("menu-active")) {  
        document.body.style.overflow = 'visible';
        } else {
        document.body.style.overflow = 'hidden';
        }
}

 $('.mobile-menu').on('click', function (e) {
    $('.menu-btn').toggleClass('menu-active')
    $('.menu-wrap').toggleClass('menu-active')   
    closeMenu()
})


