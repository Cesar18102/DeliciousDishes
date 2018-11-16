<?php

	function BuyMeal($id, $count) {
		
		include "DB_Request.php";
		$link = Connect();
		
		$query = "SELECT price FROM menu WHERE id = ".$id;
		$meal = mysqli_fetch_array(Request($link, $query), MYSQLI_ASSOC);
		
		if(!isset($meal) || $meal == null)
			return '{ "false" : "Неверный идентификатор блюда"}';
		else {
			
			if(true) { //check if meal can be cooked (through the storage)
			
				if(!isset($_COOKIE['bought']))
					setcookie('bought', '{ }', time() + 1800);
				
				if(!isset($_COOKIE['total']))
					setcookie('total', $meal['price'], time() + 1800);
				
				$bought = json_decode($_COOKIE['bought'], true);				
				$bought[$id] = (isset($bought[$id])? $bought[$id] : 0) + $count;
				
				setcookie('bought', json_encode($bought), time() + 1800);
				setcookie('total', $_COOKIE['total'] + $meal['price'] * $count, time() + 1800);
				
				return '{ "true" : "Добавлено в корзину" }';
			}
			else 
				return '{ "false" : "На складе недостаточно продуктов"}';
		}
	}
	
	if(isset($_POST['id']) && isset($_POST['count']) && $_POST['id'] != null && $_POST['id'] != "" && $_POST['count'] > 0)
		echo BuyMeal($_POST['id'], $_POST['count']);
	else
		echo '{ "false" : "Некорректный ввод" }';
?>