<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="UTF-8">
		<title>Luxury Restaurant</title>
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">
		<link href="https://fonts.googleapis.com/css?family=Playfair+Display:700|Sintony:400,700" rel="stylesheet">
		<link rel="stylesheet" href="css/main.css">
		<script src = "js/libs/glm-ajax.js"></script>
		<script src = "js/libs/jquery-3.3.1.js"></script>
		<script>
			$(window).on("load", checkAuth);
			
			function dropMeal(id) {
				
				$.post('php/DeleteItem.php', 'id=' + id, function(data){
					
					location.reload();
				});
			}
			function auth() {
				
				$.post('php/authAdmin.php', 'hash=' + document.getElementById('hash').value , function(data){
					
					location.reload();
				});
			}
			function out() {
				$.post('php/outAdmin.php', '', function(data){
					
					location.reload();
				});
			}
			function checkAuth() {
				
				let editor = document.getElementById('editorForm');
				let auth = document.getElementById('authForm');
				
				$.post('php/checkAuth.php', "" , function(data){
					
					if(data == "OK") {
						
						editor.hidden = false;
						auth.hidden = true;
					}
					else {
						
						editor.hidden = true;
						auth.hidden = false;
					}
				});
			}
		</script>
	</head>
	<body>
    <header id="header" class="header">
		<div class="main-header">
			<table class="menu-table">
					<tr>
					    <td class ="menu_item">
						    <img src="img/logo.png">
						</td>
					    <td class="menu__item" id="ibt">
						    <a href="index.html">
							    Главная
						    </a>
					    </td>
						<td class="menu__item" id="cbt">
						    <a href="contacts.html">
							    О нас
						    </a>
					    </td>
					    <td class="menu__item" id="mbt">
						    <a href="menu.php">
							    Меню
						    </a>
					    </td>
					    <td class="menu__item1">
						<button class="book cta d-flex justify-content-center" onclick = 'document.location = "cart.php";'>
							<span class="book__icon"></span>
							Корзина
						</button>
						</td>
					</tr>
			</table>
		</div>
    </header>
		<?php

			include "php/DB_Request.php";
			$link = Connect();
			
			Request($link, "SET @ingrs := '';");
			Request($link, "SET @id := -1;");
			Request($link, "SET @oldid = -1;");
			
			$query =   "SELECT menu_info.id, menu_info.name, menu_info.description, menu_info.price, menu_info.weight, menu_info.unit, MAX(menu_info.ingrs_text) ingrs_text 
						FROM (SELECT DISTINCT MN.id, ML.name, ML.description, MN.price, MN.weight, (SELECT U.name FROM unit U WHERE ML.unit_id = U.id) AS unit, @oldid := @id AS prev_info_id, @id := MN.id AS cur_info_id, 
									@ingrs := CONCAT(IF(@oldid = @id, CONCAT(@ingrs, '<br/>'), ''), ttl_cnts.name, ': ', IF(I.fixed_amount, I.amount, TRUNCATE(I.amount * MN.weight / ML.weight, 3)), ' ', 
															(SELECT U.name 
															FROM unit U, product P
															WHERE P.unit_id = U.id AND P.id = ttl_cnts.id)) ingrs_text
							FROM menu MN, meal ML, reciepe R, ingredient I LEFT JOIN (SELECT P.id, P.name, SUM(S.amount) AS strd_cnt
																						FROM product P, storage_product S
																						WHERE P.id = S.product_id GROUP BY P.id) ttl_cnts
																			ON ttl_cnts.id = I.product_id AND ttl_cnts.strd_cnt >= I.amount
							WHERE I.reciepe_id = R.id AND ML.id = R.meal_id AND MN.meal_id = ML.id) menu_info
						WHERE menu_info.ingrs_text IS NOT NULL GROUP BY menu_info.id;";

			$menu = Request($link, $query);
			$rowCounter = 0;
		?>
		
			<center id = "authForm" style = "margin-bottom : 15%; margin-top : 15%;">
				<label for = "hash"><h3>Пароль: &nbsp</h3></label>
				<input name = "hash" id = "hash" placeholder = "Your password" required></input>
				<button onclick = "auth()">Войти</button>
			</center>

			<center id = "editorForm" hidden>
				<table width="70%" bgcolor="#FFFFFF" style = "border : 0px;" cellpadding = '8em'>
					<hr/>
						<header><div class = "menuHeader">Редактор меню</div> <div><button onclick = "out()">Выйти</button></div></header>
					<hr/>	
					<tr style = "border-bottom : 1px solid rgb(229, 229, 229);">
						<th><center><div class = 'menuTH'>Название</div></center></th>
						<th><center><div class = 'menuTH'>Ингредиенты</div></center></th>
						<th><center><div class = 'menuTH'>Описание</div></center></th>
						<th><center><div class = 'menuTH'>Цена</div></center></th>
						<th><center><div class = 'menuTH'>Вес</div></center></th>
						<th><center><div class = 'menuTH'>Действие</div></center></th>
					</tr>
					<?php while($menu_item = mysqli_fetch_array($menu, MYSQLI_ASSOC)): ?>
						<tr style = "border-bottom : 1px solid rgb(229, 229, 229);">
							<td><center><div class = 'nameCell'><?php echo $menu_item['name']; ?></div></center></td>
							<td>
								<center>
									<div class = 'ingrsCell'>
										<center>
											<?php echo str_replace('.000', '', $menu_item['ingrs_text']); ?>
										</center>
									</div>
								</center>
							</td>
							<td><center><div class = 'descrCell'><?php echo $menu_item['description']; ?></div></center></td>
							<td><center><div class = 'priceCell'><?php echo $menu_item['price']; ?> грн.</div></center></td>
							<td><center><div class = 'weightCell'><?php echo $menu_item['weight']." ".$menu_item['unit']; ?></div></center></td>
							<td><center><button class = 'buyButton' onclick = 'dropMeal("<?php echo (int)($menu_item['id']); ?>");'>Удалить!</button></center></td>
						</tr>
					<?php endwhile; ?>
				</table>
				<iframe src = "redact.php" width="70%" height = "1000px" scrolling = "no" style = "left : 0%; border : 0px; margin-bottom : 0px; display : block"></iframe>
			</center>
		

		<footer id="footer" class="footer">
			<div class="container">
				<div class="row">
					<div class="col-lg-12">
						<ul class="socials d-flex justify-content-center">
							<li class="socials__item socials__item_fb">
								<a href="#"></a>
							</li>
							<li class="socials__item socials__item_tw">
								<a href="#"></a>
							</li>
							<li class="socials__item socials__item_g">
								<a href="#"></a>
							</li>
						</ul>
					</div>
				</div>
				<div class="row">
					<div class="col-lg-4">
						<div class="line"></div>
					</div>
					<div class="col-lg-4">
						<div class="credits">
							2018 ©   All rights reserved
						</div>
					</div>
					<div class="col-lg-4">
						<div class="line"></div>
					</div>
				</div>
			</div>
		</footer>
	</body>
	<script src = "js/main.js"></script>
</html>