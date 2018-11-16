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
			function dropOffer(id) {
			
				$.post('php/dropOffer.php', 'id=' + id, function(data) {
					
					location.reload();
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
	<center>
		<table style = 'color: white; margin-top : 15%; margin-bottom : 15%;' id = 'cart' cellpadding = '8em'>
			<hr/>
			<header>
				<div class = 'menuHeader'>Ваши заказы</div>
			</header>
			<hr/>
			<tr style = 'border-bottom : 1px solid rgb(229, 229, 229);'>
				<th><center><div class = 'menuTH'>ID</div></center></th>
				<th><center><div class = 'menuTH'>Клиент</div></center></th>
				<th><center><div class = 'menuTH'>Адрес</div></center></th>
				<th><center><div class = 'menuTH'>Стоимость</div></center></th>
				<th><center><div class = 'menuTH'>Готово</div></center></th></tr>
			</tr>
				
			<?php

				if(isset($_GET['id']) && isset($_GET['pas']) && $_GET['pas'] == 'Delishes228') {
					
					include "php/DB_Request.php";
					$link = Connect();
					
					$DriverQuery = "SELECT D.name, D.surname FROM drivers D WHERE D.id = ".$_GET['id'];
					$driver = mysqli_fetch_array(Request($link, $DriverQuery), MYSQLI_ASSOC);
					$DrN = $driver['name'].' '.$driver['surname'];
					echo "<h2>Здравствуйте, ".$DrN."!";
					
					$query = "SELECT O.id, CONCAT(O.name, ' ', O.Surname) AS FullName, O.phone, CONCAT(O.city, ', ', O.avenue, ', ', O.building, ', ', O.flat) AS address, O.total FROM offer O, drivers D WHERE D.id = O.driver_id AND D.id = ".$_GET['id'];
					$offers = Request($link, $query);
					
					while($offer = mysqli_fetch_array($offers, MYSQLI_ASSOC))
						echo "<tr style = 'border-bottom : 1px solid rgb(229, 229, 229);'><td>".$offer['id']."</td><td>".$offer['FullName']."</td><td>".$offer['address']."</td><td>".$offer['total']."</td><td><input onclick = 'dropOffer(".$offer['id'].");' type = 'checkbox' id = 'R".$offer['id']."'></input></td></tr>";
				}
			?>
		</table>
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
	<script src = "js/buyMeal.js"></script>
	<script src = "js/main.js"></script>
</html>