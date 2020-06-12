$.fn.isInViewport = function() {
  var elementTop = $(this).offset().top;
  var elementBottom = elementTop + $(this).outerHeight();

  var viewportTop = $(window).scrollTop();
  var viewportBottom = viewportTop + $(window).height();

  return elementBottom > viewportTop && elementTop < viewportBottom;
};

$(window).scroll(function () {
  if ($('.co-counter-wrapper').isInViewport()) {
    if(!$('.co-counter-wrapper').hasClass('isInViewport')){
      $('.counter').each(function() {
        var $this = $(this),
            countTo = $this.attr('data-count');
      
        $({
          countNum: $this.text()
        }).animate({
          countNum: countTo
        }, {
          duration: 2000,
          easing: 'linear',
          step: function() {
            $this.text(commaSeparateNumber(Math.floor(this.countNum)));
          },
          complete: function() {
            $this.text(commaSeparateNumber(this.countNum));
          }
        });
      });
    }

  $('.co-counter-wrapper').addClass('isInViewport');
  } 
}); 

function commaSeparateNumber(val) {
  while (/(\d+)(\d{3})/.test(val.toString())) {
    val = val.toString().replace(/(\d+)(\d{3})/, "$1" + "'" + "$2");
  }
  return val;
}