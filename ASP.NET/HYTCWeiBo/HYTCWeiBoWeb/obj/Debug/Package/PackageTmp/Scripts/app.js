/**
 * Created by ZYH on 14-3-17.
 */
 $(document).ready(function($) {

 	TweenMax.to($(".headerfix"), 0,{y:-44});
 	$(".headerbox").mouseenter(function() {
 		/* Act on the event */ 		
 		TweenMax.to($(".headerfix"), 0.7,{y:0});
 		TweenMax.to($(".flowerpic"), 0.7,{y:-10});
 	}).mouseleave(function() {
 		/* Act on the event */
 		 TweenMax.to($(".headerfix"), 1,{y:-44,delay:10});
	     TweenMax.to($(".flowerpic"), 0.9,{y:10,delay:10});
 	});



 });





