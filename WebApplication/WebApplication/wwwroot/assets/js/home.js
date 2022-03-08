var clock = $('.clock').FlipClock({
    clockFace: 'DailyCounter',
    autoStart: false,
    callbacks: {
      stop: function() {
        $('.message').html('The clock has stopped!')
      }
    }
});

// set time
clock.setTime(5320880);

// countdown mode
clock.setCountdown(true);

// start the clock
clock.start();

$('.owl-carousel').owlCarousel({
  loop:true,
  margin:10,
  nav:true,
  responsive:{
      0:{
          items:1
      },
      600:{
          items:3
      },
      1000:{
          items:5
      }
  }
})

$(function (){
  let openBtn = $(".open-btn");
  openBtn.click(function () {
    if ($(this).parent().parent().next().hasClass("d-none")) {
      $(this).parent().parent().next().removeClass("d-none");
      $(this).parent().parent().parent().parent().addClass("scroll");
      $(this).html("<i class='fa-solid fa-minus'></i>");
    }else{
      $(this).parent().parent().next().addClass("d-none");
      $(this).parent().parent().parent().parent().removeClass("scroll");
      $(this).html("<i class='fa-solid fa-plus'></i>");
    }
  })
})

var slider = document.getElementById("myRange");
var output = document.getElementById("demo");
output.innerHTML = slider.value;

slider.oninput = function() {
  output.innerHTML = this.value;
}

$(function () {
  let openDropBtn = $(".open-drop-btn");
  openDropBtn.click(function () {
    if ($(this).next().hasClass("d-none")) {
      $(this).next().removeClass("d-none");
      $(this).children().attr("class","fa-solid fa-angle-up");
    }else{
      $(this).next().addClass("d-none");
      $(this).children().attr("class","fa-solid fa-angle-down");
    }
  })
})