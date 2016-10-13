/**
 * Created by ZYH on 14-3-17.
 */
 $(document).ready(function($) {
 	
 	/*MainForm.aspx-start*/
 		//weibo lists/
 			//default
/* 			setInterval(function(){
 				var guestid=$("#btnguestId").val(),
		 				listid="WeiboFocus";
		 				alert(guestid);
				$.ajax({
					url: "WeiBoList.aspx",
					cache: false,
					type: "POST",
					data:{
						guestid:guestid,
						optionName:"other",
						listid:listid,
						userId:guestid
					},
					dataType: "html",
					success: function (data) {
						
					}
				});

 			}, 5000);*/
		var guestid=$("#btnguestId").val();
		$("#weiboselect>div").on('click', function () {
			var optionName="show",
				listid = $(this).attr("id"),								
				userId = $("#btnmasterId").val();			
				$(this).addClass('selected');			
				$("#weiboselect>div[id!="+listid+"]").removeClass('selected');				
			$.ajax({
				url: "WeiBoList.aspx",
				cache: false,
				type: "POST",
				dataType: "html",
				data: {
					optionName:optionName,
					listid:listid,					
					userId: userId,
					guestid:guestid					
				},
				success: function (data) {
					$("#personalweibo").html(data);
				}
			});
		});
		//发表微博buttom
		 $("#btnPublish").on('click', function () {
            var optionName="save",
            	listid="WeiboPersonal",
            	authorId = $("#btnmasterId").val(),
				authorName =$("#btnmasterName").val(),
				content =$("#txtPubContent").val(),
               	isOriginal = "原创",
				transmitNumber = 0,
				zanNumber = 0,
				reviewNumber = 0,
				favsNumber = 0;
				if (content==""||content==null){
					alert("微博内容不能为空");
				} else{
				 $.ajax({
		                url: "WeiboList.aspx",
		                cache: false,
		                type: "POST",
		                dataType: "html",
		                data: {
		                	optionName:optionName,
		                	listid:listid,
		                    authorId:authorId,
		                    authorName:authorName,
		                    content:content,                    
		                    isOriginal:isOriginal,
		                    transmitNumber:transmitNumber,
		                    zanNumber:zanNumber,
		                    reviewNumber:reviewNumber,
		                    favsNumber:favsNumber,
		                    guestid:guestid,
		                },
		                success: function (data) {
		                    $("#personalweibo").html(data);
						   $("#txtPubContent").val("");
				
		                }
		            });
				};

        });	
		/*MainForm.aspx-end*/


		/*Favorites-start*/
		$("#ibtnFavs").on('click',  function() {			
			/* Act on the event */
				var ud = $("#btnmasterId").val();
				/*confirm(ud);*/
			window.open("UserFavorites.aspx?userid="+ud+"","height=100, width=400, top=100,left=200,toolbar=no, menubar=no, scrollbars=no, resizable=no,location=no,status=no");
		});
		/*Favorites-end*/

/*		//error
		$(".authorName").on('click',function(){
			var guestid = $("#btnguestId").val();
			alert(guestid);
				
					$.ajax({
						url: "MainForm.aspx",
						cache: false,
						type: "POST",
						data: {
							guestid:guestid
						},
						dataType: "html",
						success: function (data) {

						}
					});
		});*/





 });