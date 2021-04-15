
$('.wr-home-container').slick({
    slidesToShow: 1,
    slidesToScroll: 1,
    arrows: false,
    swipe: true,
    dots: true,
 });


 $('.portfolio-container').slick({
    slidesToShow: 1,
    slidesToScroll: 1,
    arrows: false,
    swipe: true,
    dots: true,
 });

 $('.slider-phone').slick({
   arrows: true,
   prevArrow: ".arrow-prev", 
   nextArrow: ".arrow-next", 
   slidesToShow: 1,
   slidesToScroll: 1,
   swipe: true,
   dots: true,
});

$('.pricing-table').slick({
  slidesToScroll: 1,
  slidesToShow: 1,
  arrows: false,
  dots: true,
  infinite: true,
  mobileFirst: true,
  swipe: true,
  responsive: [{
    breakpoint: 768,
    settings: 'unslick'
    // slickGoTo: 1
  }]
});

$('.team-contain').slick({
  slidesToScroll: 1,
  slidesToShow: 1,
  arrows: false,
  dots: true,
  infinite: true,
  // variableWidth: true,
  mobileFirst: true,
  responsive: [{
    breakpoint: 570,
    settings: 'unslick'
  }]
});

$('.blog-post-container').slick({
  slidesToScroll: 1,
  slidesToShow: 1,
  arrows: false,
  dots: true,
  infinite: false,
  // variableWidth: true,
  mobileFirst: true,
  responsive: [{
    breakpoint: 570,
    settings: 'unslick',
    // adaptiveHeight: true,
    // centerMode: true,
    // centerPadding: '40px',
  }]
});

 let btnsFilterContainer = document.querySelector('.filter'); 
 let removeClass = function(arr, className){
     arr
     .filter(btn => btn.classList.contains(className))
     .map(btn => btn.classList.remove(className));
 };
 
 btnsFilterContainer.addEventListener('click', function(e) {
     let target = e.target;
     if (!e.target.closest('button')) return;
     let btn = e.target.closest('button');
     if (btn.classList.contains('active')) return;
     let btns = document.querySelectorAll('.filter button');
     
 let arrBtns = Array.prototype.slice.call(btns);
 
     removeClass(arrBtns, 'active');
 
     btn.classList.add('active');
 
     let btnId = btn.id;
     let blocks = document.querySelectorAll('.block')
     let arrBlocks = Array.prototype.slice.call(blocks);
 
     removeClass(arrBlocks, 'hide');
     if (btnId == 'all') return;
 
     arrBlocks
     .filter(block => (block.dataset.var != btnId))
     .map(block => block.classList.add('hide'));
 });
 

 $("body").on('click', '[href*="#"]', function(e){
  var fixed_offset = 0;
  $('html,body').stop().animate({ scrollTop: $(this.hash).offset().top - fixed_offset }, 1000);
  e.preventDefault();
});