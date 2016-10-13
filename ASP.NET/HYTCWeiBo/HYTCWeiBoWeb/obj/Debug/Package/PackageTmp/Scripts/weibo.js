 $(document).ready(function($) {	

		//点赞,收藏-start
		var guestid=$("#btnguestId").val()
		$(".itembtn").on('click', function() {
			var optionName=$(this).attr('name'),
				listid = $("#weiboselect").find('.selected').attr('id'),	
				userId = $("#btnmasterId").val(),
				guestid = $("#btnguestId").val(),
				weiboId=$(this).parents('.item').find('.weiboId').val(),
				authorId=$(this).parents('.item').find('.authorId').val();	
			/*alert(weiboId+authorId+optionName);*/
			$.ajax({
				url: "WeiBoList.aspx",
				cache: false,
				type: "POST",
				data: {
					optionName:optionName,
					listid:listid,
					weiboId: weiboId,
					authorId:authorId,					
					userId:userId,
					guestid:guestid
					
				},
				dataType: "html",
				success: function (data) {
					$("#personalweibo").html(data);					
							
				}
			});
		});

		//-点赞,收藏-end

		/*展开评论-start*/
		var flag=true;
		$(".btnOpenReview").on('click', function(event) {			
			var relistbox=$(this).parents(".item").find('.reviewlistbox'),
				weiboId=$(this).parents('.item').find('.weiboId').val(),
				reviewlistcontent=$(this).parents('.item').find('.reviewlistcontent');
			if (flag) {
				$(this).val("收起评论");
					$.ajax({
		                url: "ReviewList.aspx",
		                type: "POST",
		                dataType: "html",
		                data: {		                	
		                	weiboId:weiboId
		                },
		                success: function (data) {
		                	reviewlistcontent.html(data);
		                },
		                error:function() {		                	
		                	alert("评论加载失败，请稍后");
		                }
		            });		

					relistbox.fadeIn('slow');	
				
				flag=false;
			} else{
				$(this).val("查看评论");				
				relistbox.fadeOut('slow');
				$(this).parents(".item").find(".btnPubReview").fadeOut('slow');
				$(this).parents(".item").find(".reviewContent").fadeOut('slow',function(){
						$(this).parents(".item").find(".reviewContent").val("");
					});
				flag=true;
			};
			
			/* Act on the event */
		});
 		/*展开评论-end*/
		/* 点击评论按钮*/
		$(".btnReview").on('click',function() {
			$(this).parents(".item").find(".btnPubReview").fadeIn('slow');
			$(this).parents(".item").find(".reviewContent").fadeIn('slow').val("").focus();
			/* Act on the event */
		});
	

		/*发表评论-start*/
		$(".btnPubReview").on('click',function(){
			var recontent =$(this).parents('.item').find('.reviewContent').val(),
				weiboId=$(this).parents('.item').find('.weiboId').val(),
				reauthorId=$("#btnguestId").val(),
				reauthorname=$("#btnguestName").val(),
				reviewlistbox=$(this).parents('.item').find('.reviewlistbox'),
				reviewlistcontent=$(this).parents('.item').find('.reviewlistcontent'),
				reviewContent=$(this).parents('.item').find('.reviewContent');
				/*alert(weiboId+reauthorId+reauthorname+recontent);*/
				if (recontent=="") {
					alert("评论内容不能为空！");
				}else{
					//评论数加1
		            var optionName="review",
		            	listid = $("#weiboselect").find('.selected').attr('id'),
		            	userId = $("#btnmasterId").val();
		            $.ajax({
						url: "WeiBoList.aspx",
						cache: false,
						type: "POST",
						data: {
							optionName:optionName,
							listid:listid,		
							userId:userId,
							weiboId: weiboId,
							guestid:guestid
						},
						dataType: "html",
						success: function (data) {
							$("#personalweibo").html(data);					
							/*alert(date.title);	*/			
						}
					});
		            //评论列表加数据，后显示
		            $.ajax({
		                url: "ReviewList.aspx",
		                cache: false,
		                type: "POST",
		                dataType: "html",
		                data: {
		                	recontent:recontent,
		                	weiboId:weiboId,
		                	reauthorId:reauthorId,
		                	reauthorname:reauthorname
		                },
		                success: function (data) {
		                   /*reviewlistbox.fadeIn('slow');*/// two css
		                   reviewlistcontent.html(data);              
						   reviewContent.val("");							
						
		                },
		                error:function() {
		                	/* Act on the event */
		                	/*alert("评论加载失败，请稍后");*/
		                }
		            });

				};
		});
		/*发表评论-end*/
		/* 关注-start*/
		$(".btnadd").on('click',function(){
			var optionName="addFocus",
				userId = $("#btnguestId").val(),
				listid = $("#weiboselect").find('.selected').attr('id'),
				authorId=$(this).parents('.item').find('.authorId').val();
				/*alert(optionName);*/
					$.ajax({
						url: "WeiBoList.aspx",
						cache: false,
						type: "POST",
						data: {
							optionName:optionName,
							authorId:authorId,					
							userId:userId,
							listid:listid,
							guestid:guestid
						},
						dataType: "html",
						success: function (data) {
							$("#personalweibo").html(data);
						}
					});
		});
		
/*		$("#btnFocus")*/
		$("#btnFocus").on('click',function(){
			var optionName="addFocus",
				userId = $("#btnguestId").val(),
				listid = $("#weiboselect").find('.selected').attr('id'),
				authorId=$("#btnmasterId").val();
				/*alert(optionName);*/
					$.ajax({
						url: "WeiBoList.aspx",
						cache: false,
						type: "POST",
						data: {
							optionName:optionName,
							authorId:authorId,					
							userId:userId,
							listid:listid,
							guestid:guestid
						},
						dataType: "html",
						success: function (data) {
							/*$("#personalweibo").html(data);*/
						}
					});
		});
		/* 关注-end*/
		//转发
		var  optionName,listid,userId,guestid,guestname,weiboId;
		$("#btnTrans").on('click',function(){
			$(".transmitbgbox").fadeIn('slow');	
		  		optionName=$(this).attr('name');
				listid = $("#weiboselect").find('.selected').attr('id');	
				userId = $("#btnmasterId").val();
				guestid = $("#btnguestId").val();
				guestname=$("#btnguestName").val();
				weiboId=$(this).parents('.item').find('.weiboId').val();		
				/*alert(optionName+listid+userId+guestid+guestname+weiboId);*/			
		});
		$("#transCancle").on('click',function(){
			$(".transmitbgbox").fadeOut('slow');		
		});
		$("#transYes").on('click',function(){
			var transContent=$("#txtTransContent").val();
			alert(optionName+"|"+listid+"|"+userId+"|"+guestid+"|"+guestname+"|"+weiboId);	
			$.ajax({
					url: "WeiBoList.aspx",
					cache: false,
					type: "POST",
					data: {
						optionName:optionName,
						weiboId:weiboId,					
						userId:userId,
						listid:listid,
						guestid:guestid,
						guestname:guestname,
						transContent: transContent
					},
					dataType: "html",
					success: function (data) {
						$("#personalweibo").html(data);
						$(".transmitbgbox").fadeOut('slow');
						$("#txtTransContent").val("");
					}
				});			
		});

});