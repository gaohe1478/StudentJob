document.writeln("<!DOCTYPE html>");
document.writeln("<html>");
document.writeln("	<head>");
document.writeln("		<meta charset=\'utf-8\'>");
document.writeln("		<title></title>");
document.writeln("	</head>");
document.writeln("	<body>");
document.writeln("		<header id=\'site-header\' role=\'banner\' >");
document.writeln("		<!-- 个人中心按钮 -->");
document.writeln("			<div class=\'header-top\'>");
document.writeln("				");
document.writeln("				<div class=\'container\'>");
document.writeln("					");
document.writeln("					<div class=\'row\'>");
document.writeln("						");
document.writeln("						<div class=\'col-xs-12 col-sm-6 col-md-7\'>");
document.writeln("							");
document.writeln("							<div class=\'contact-info\'>");
document.writeln("								<strong>校园二手购物平台</strong>");
document.writeln("								</div>");
document.writeln("								");
document.writeln("						</div>");
document.writeln("						");
document.writeln("						<!-- 搜索框 -->");
document.writeln("						<div class=\'col-xs-12 col-sm-6 col-md-5\' >");
document.writeln("							<ul class=\'actions unstyled clearfix\'>");
document.writeln("								<li>");
document.writeln("									<div class=\'search-box\'>");
document.writeln("										<form action=\'#\' method=\'post\'>");
document.writeln("											<div class=\'input-iconed prepend\'>");
document.writeln("												<button class=\'input-icon\'><i class=\'iconfont-search\'></i></button>");
document.writeln("												<label for=\'input-search\' class=\'placeholder\'>搜索您需要的物品</label>");
document.writeln("												<input type=\'text\' name=\'q\' id=\'input-search\' class=\'round-input full-width\' required />");
document.writeln("											</div>");
document.writeln("										</form>");
document.writeln("									</div>");
document.writeln("								</li>");
document.writeln("								<!-- 消息提醒 -->");
document.writeln("								<li class=\'nav-item dropdown\'> <a id=\'notifications\' rel=\'nofollow\' data-target=\'#\' href=\'#\' data-toggle=\'dropdown\' aria-haspopup=\'true\' aria-expanded=\'false\' class=\'nav-link\'><i class=\'fa fa-bell-o\'></i><span class=\'badge bg-red badge-corner\'>12</span></a>");
document.writeln("								  <ul aria-labelledby=\'notifications\' class=\'dropdown-menu\'  style=\'background-color: #dcdcdc;\'>");
document.writeln("								    <li><a rel=\'nofollow\' href=\'#\' class=\'dropdown-item\'> ");
document.writeln("								        <div class=\'notification\'>");
document.writeln("								          <div class=\'notification-content\'><i class=\'fa fa-envelope bg-green\'></i>&nbsp 您有6条新的询问消息 </div>");
document.writeln("								          <div class=\'notification-time\'><small>4分钟前</small></div>");
document.writeln("								        </div></a></li>");
document.writeln("								    <li><a rel=\'nofollow\' href=\'#\' class=\'dropdown-item\'> ");
document.writeln("								        <div class=\'notification\'>");
document.writeln("								          <div class=\'notification-content\'><i class=\'fa fa-twitter bg-blue\'></i>&nbsp 您有2条新的订单消息</div>");
document.writeln("								          <div class=\'notification-time\'><small>5分钟前</small></div>");
document.writeln("								        </div></a></li>");
document.writeln("								   ");
document.writeln("										<li style=\'text-align: center;\'  role=\'separator\' class=\'divider\'></li>");
document.writeln("								    <li style=\'text-align: center;\'><a rel=\'nofollow\' href=\'#\'  data-toggle=\'modal\' data-target=\'#myModal\'> <span style=\'font-weight: 700;font-size: 14px;\'>查看所有信息</span></a></li> ");
document.writeln("								<!-- 	 <li><button class=\'btn btn-primary btn-lg\' data-toggle=\'modal\' data-target=\'#myModal\'>开始演示模态框</button></li> -->");
document.writeln("		");
document.writeln("								  </ul>");
document.writeln("								</li>");
document.writeln("								<!-- 个人中心 -->");
document.writeln("								");
document.writeln("								<li class=\'nav-item dropdown\' > <a id=\'notifications\' rel=\'nofollow\' data-target=\'#\' href=\'#\' data-toggle=\'dropdown\' aria-haspopup=\'true\' aria-expanded=\'false\' class=\'nav-link\'><i class=\'fa fa-user-o \'></i></a>");
document.writeln("								  <ul aria-labelledby=\'notifications\' class=\'dropdown-menu\'  style=\'background-color: #dcdcdc;\'>");

document.writeln("								    <li style=\'text-align: center;font-size: 14px;\'><a href=\'person.html\'><span style=\'font-weight: 700;\'>个人中心</span></a></li>");
document.writeln("								    <li style=\'text-align: center;\'  role=\'separator\' class=\'divider\'></li>");

document.writeln("								    <li style=\'text-align: center;\'><a href=\'cart.html\'>我的订单</a></li>");
document.writeln("								    <li style=\'text-align: center;\'><a href=\'productlists.html\'>我的发布</a></li>");
document.writeln("								    <li style=\'text-align: center;\'  role=\'separator\' class=\'divider\'></li>");
document.writeln("								    <li style=\'text-align: center;font-size: 14px; \'><a href=\'#\'><span style=\'font-weight: 700;\'>退出登录</span></a></li>");
document.writeln("										");
document.writeln("								  </ul>");
document.writeln("								</li>");
document.writeln("								");
document.writeln("				<!-- 购物车模块 -->				");
document.writeln("								<li data-toggle=\'sub-header\' data-target=\'#sub-cart\' style=\'margin-left: 20px;\'>");
document.writeln("									<a href=\'javascript:void(0);\' id=\'total-cart\'>");
document.writeln("										<i class=\'fa fa-shopping-cart\'></i>");
document.writeln("									</a>");
document.writeln("									<div id=\'sub-cart\' class=\'sub-header\' style=\'background-color: #dcdcdc;\'>");
document.writeln("										<div class=\'cart-header\'>");
document.writeln("											<span style=\'color: #000000;\'>您的购物车是空的...</span>");
document.writeln("											<small><a href=\'cart.html\'>(See All)</a></small>");
document.writeln("										</div>");
document.writeln("										<ul class=\'cart-items product-medialist unstyled clearfix\'></ul>");
document.writeln("										<div class=\'cart-footer\'>");
document.writeln("											<div class=\'cart-total clearfix\'>");
document.writeln("												<span class=\'pull-left uppercase\'>总计</span>");
document.writeln("												<span class=\'pull-right total\'>$ 0</span>");
document.writeln("											</div>");
document.writeln("											<div class=\'text-right\' >");
document.writeln("												<a href=\'cart.html\' class=\'btn btn-default btn-round view-cart\' style=\'color: #000000;\'>进入购物车</a>");
document.writeln("											</div>");
document.writeln("										</div>");
document.writeln("									</div>");
document.writeln("								</li>");
document.writeln("							</ul>");
document.writeln("						</div>");
document.writeln("					</div>");
document.writeln("				</div>");
document.writeln("				<div class=\'cart-notification\'>");
document.writeln("					<ul class=\'unstyled\'></ul>");
document.writeln("				</div>");
document.writeln("			</div>");
document.writeln("			");
document.writeln("			<div class=\'main-header-wrapper\'>");
document.writeln("				<div class=\'container\'>");
document.writeln("					<div class=\'main-header\'>");
document.writeln("						");
document.writeln("						<div class=\'actions\'>");
document.writeln("							");
document.writeln("							<div class=\'clearfix\'></div>");
document.writeln("							<!-- 登录、注册等按钮 -->");
document.writeln("							<nav id=\'tiny-menu\' class=\'clearfix\'  >");
document.writeln("								<ul class=\'user-menu\'>");
document.writeln("									<li><a href=\'login.html\'>登录</a></li>");
document.writeln("									<!-- <li><a href=\'register.html\'>注册</a></li> -->");
document.writeln("									<li><a href=\'feedback.html\'>反馈</a></li>");
document.writeln("									");
document.writeln("								</ul>");
document.writeln("							</nav>");
document.writeln("		");
document.writeln("						</div>");
document.writeln("						<!-- 网站logo -->");
document.writeln("						<div class=\'logo-wrapper\'>");
document.writeln("							<a href=\'index.html\' class=\'logo\' title=\'Star二手购\'>");
document.writeln("								<img src=\'img/logo.png\' alt=\'Star二手购\' />");
document.writeln("							</a>");
document.writeln("						</div>");
document.writeln("						<!-- class=\'active\' -->");
document.writeln("						<!-- 物品分类展示 -->");
document.writeln("						<nav id=\'site-menu\' role=\'navigation\' >");
document.writeln("							<ul class=\'main-menu hidden-sm hidden-xs\'>");
document.writeln("								<li >");
document.writeln("									<a href=\'index.html\'>首页</a>");
document.writeln("								</li>");
document.writeln("								<li>");
document.writeln("									<a href=\'category.html\'>生活百货</a>");
document.writeln("								</li>");
document.writeln("								<li>");
document.writeln("									<a href=\'category.html\'>数码电器</a>");
document.writeln("								</li>");
document.writeln("								<li>");
document.writeln("									<a href=\'category.html\'>学习资料</a>");
document.writeln("								</li>");
document.writeln("								<li>");
document.writeln("									<a href=\'category.html\'>运动健身</a>");
document.writeln("								</li>");
document.writeln("								<li>");
document.writeln("									<a href=\'category.html\'>男女美妆</a>");
document.writeln("								</li>");
document.writeln("								<li>");
document.writeln("									<a href=\'category.html\'>其他</a>");
document.writeln("								</li>");
document.writeln("							</ul>");
document.writeln("						</nav>");
document.writeln("					</div>");
document.writeln("				</div>");
document.writeln("			</div>");
document.writeln("		</header>");
document.writeln("		");
document.writeln("	</body>");
document.writeln("</html>");
document.writeln("");
document.writeln("");