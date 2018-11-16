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
	    <br/>
	    <br/>
	    <div><text><p style="color:white">Заполните эту форму пожалуйста</p></text></div>
	    <br/>
	    <div id = 'userFromDiv'>
		<form id = 'userForm' method = 'POST' action = 'php/sendOffer.php'>
		    <table>
			<tr>
			    <td><label for = 'surname'><p style="color:white">Фамилия:</p></label></td>
			    <td><input id = 'surname' type = 'text' name = 'surname' placeholder = 'Зубенко' required></input></td>
			</tr>
			<tr>
			    <td><label for = 'name'><p style="color:white">Имя:</p></label></td>
			    <td><input id = 'name' type = 'text' name = 'name' placeholder = 'Михаил' required></input></td>
			</tr>
			<tr>
			    <td><label for = 'name'><p style="color:white">Телефон:</p> </label></td>
			    <td><input id = 'name' type = 'tel' name = 'phone' placeholder = '+380978015528' required></input></td>
			</tr>
			<tr>
			    <td><label for = 'name'><p style="color:white">E-Mail:</p> </label></td>
			    <td><input id = 'name' type = 'email' name = 'mail' placeholder = 'example.ex@gmail.com' required></input></td>
			</tr>
			<tr>
			    <td><label for = 'city'><p style="color:white">Населенный пункт:</p></label></td>
			    <td><input id = 'city' type = 'text' name = 'city' placeholder = 'Харьков' required></input></td>
			</tr>
			<tr>
			    <td><label for = 'avenue' ><p style="color:white">Улица:</p> </label></td>
			    <td><input id = 'avenue' type = 'text' name = 'avenue' placeholder = 'Проспект Науки' required></input></td>
			</tr>
			<tr>
			    <td><label for = 'building'><p style="color:white">Дом:</p></label></td>
			    <td><input id = 'building' type = 'text' name = 'building' placeholder = '28' required></input></td>
			</tr>
			<tr>
			    <td><label for = 'flat'><p style="color:white">Квартира:</p></label></td>
			    <td><input id = 'flat' type = 'text' name = 'flat' placeholder = '16' required></input></td>
			</tr>
			<tr>
			    <td><label for = 'comment'><p style="color:white">Комментарий:</p></label></td>
			    <td><textarea id = 'comment' type = 'text' name = 'comment' cols="40" rows="5" maxlength = "100" style = 'max-height : 100px; min-height : 100px;' ></textarea></td>
			</tr>
		    </table>
		    <div id = 'cart' style = 'margin-bottom : 30%;'></div>
		</form>
	    </div>
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
    <script src = "js/dropCart.js"></script>
    <script src = "js/getCart.js"></script>
    <script src = "js/main.js"></script>
    
    <script>
	loadCart('cart');
    </script>
</html>