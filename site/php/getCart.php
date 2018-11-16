<?php
		
	function GetCart() {
			
		include "DB_Request.php";
		$link = Connect();
			
		$cartHTML = "<center><table style = 'color: white;' id = 'cart' cellpadding = '8em'><hr/><header><div class = 'menuHeader'>Ваш заказ</div>".
					"</header><hr/><tr style = 'border-bottom : 1px solid rgb(229, 229, 229);'>".
					"<th><center><div class = 'menuTH'>Название</div></center></th>".
					"<th><center><div class = 'menuTH'>Вес</div></center></th>".
					"<th><center><div class = 'menuTH'>Количество</div></center></th></tr>";
			
		if(isset($_COOKIE['bought']) && $_COOKIE['bought'] != null)
			foreach(json_decode($_COOKIE['bought'], true) as $key => $value) {
					
				$query = "SELECT menu.id, meal.name, menu.price, menu.weight FROM menu, meal WHERE meal.id = menu.meal_id AND menu.id = ".$key;
				$meal = mysqli_fetch_array(Request($link, $query), MYSQLI_ASSOC);
					
				$cartHTML .= "<tr style = 'border-bottom : 1px solid rgb(229, 229, 229);'><td>".$meal['name']."</td><td>".$meal['weight']."</td><td>".$value."</td></tr>";
			}
			
		$cartHTML .= "<tr colspan = '3'><td><br/>Итого: ".(isset($_COOKIE['total'])? $_COOKIE['total'] : 0)." грн.</td></tr></table><br/><br/>".
					 "<div style = 'display : inline'><button class='cta' onclick = 'dropCart();'>Очистить козрину</button></div>&nbsp&nbsp&nbsp".
					 '<div style = "display : inline"><button class="cta" type = "submit">Заказать!</button></div></center>';
		return $cartHTML;
	}
	
	echo GetCart();
?>