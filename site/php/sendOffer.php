<?php
	
	$redirectMenu = '<script>setTimeout(function(){ document.location = "../menu.php"; }, 2500);</script>';
	
	include "DB_Request.php";
	$link = Connect();
	
	function pushOrder($name, $surname, $phone, $city, $avenue, $building, $flat, $comment, $mail, $meals) {
		
		$link = Connect();
		
		$query = "SELECT MAX(id) FROM offer";
		$id = mysqli_fetch_array(Request($link, $query), MYSQLI_NUM)[0] + 1;
		
		$start = date("Y-n-j H:i:s");
		
		$queryPush = "INSERT INTO offer VALUES(".$id.", '".$name."', '".$surname."', '".$phone."', '".$city."', '".$avenue."', '".$building."', '".$flat."', '".$comment."', '".$start."', '".$_COOKIE['total']."');";
		Request($link, $queryPush);
		
		$offeredMealId = (int)(mysqli_fetch_array(Request($link, "SELECT MAX(id) FROM offered_meal"), MYSQLI_NUM)[0]) + 1;
		
		foreach($meals as $meal) {
			
			$queryPushMeal = "INSERT INTO offered_meal VALUES(".$offeredMealId.", ".$id.", ".$meal['meal_id'].", ".$meal['count'].", 1);";
			Request($link, $queryPushMeal);
			
			foreach($meal['ids'] as $pr_id) {
				
				$queryUseProducts = "UPDATE storage_product SET amount = amount - ".$pr_id['used']." WHERE id = ".$pr_id['id'];
				Request($link, $queryUseProducts);
				
				$queryArchieveProducts = "INSERT INTO used_product VALUES(0, ".$pr_id['id'].", ".$offeredMealId.", ".$pr_id['used'].");";
				Request($link, $queryArchieveProducts);
			}
			
			$offeredMealId++;
		}
		
		include "mailSender.php";
		mailSend($mail, $id);
		
		echo "<html><head><link rel='stylesheet' href='../css/main.css'></head><body><center><div class = 'afterOfferDiv'><text>Ваш заказ принят! ID заказа: ".$id."</text></div></center></body><script>setTimeout(function(){ document.location = '../offer.php?id=".$id."'; }, 2500);</script></html>";
	}
	
	if(isset($_POST['name']) && isset($_POST['surname']) && isset($_POST['phone']) && isset($_POST['city']) && isset($_POST['avenue']) && isset($_POST['building']) && isset($_POST['flat']) && isset($_POST['mail']) &&
	   $_POST['name'] != "" && $_POST['surname'] != "" && $_POST['phone'] != "" && $_POST['city'] != "" && $_POST['avenue'] != "" && $_POST['building'] != "" && $_POST['flat'] != "" && $_POST['mail'] != "" &&
	   isset($_COOKIE['bought']) && $_COOKIE['bought'] != "" && $_COOKIE['bought'] != "{ }" && $_COOKIE['bought'] != null && 
	   isset($_COOKIE['total']) && $_COOKIE['total'] != 0 && $_COOKIE['total'] != null) {
		
		$productEnough = true;
		$meals = [];
		
		foreach(json_decode($_COOKIE['bought'], true) as $key => $value) {
			
			$product_ids = [];
			
			$query = "SELECT STP.id, SUM(STP.amount) AS has_amount, IF(I.fixed_amount, I.amount, TRUNCATE(I.amount * MN.weight / ML.weight, 3)) AS need_amount
					  FROM storage_product STP, product P, ingredient I, reciepe R, meal ML, menu MN
					  WHERE P.id = STP.product_id AND P.id = I.product_id AND R.id = I.reciepe_id AND ML.id = R.meal_id AND MN.meal_id = ML.id AND MN.id = ".$key." GROUP BY P.id";
					  
			$products = Request($link, $query);
			
			while($product = mysqli_fetch_array($products, MYSQLI_ASSOC)) {
				
				array_push($product_ids, ['id' => $product['id'], 'used' => $product['need_amount'] * $value]);
				if($product['has_amount'] < $product['need_amount'] * $value) {
							
					$productEnough = false;
					break;
				}
			}
			
			array_push($meals, ['meal_id' => $key, 'count' => $value, 'ids' => $product_ids]);
			if(!$productEnough) {
				
				echo "<html><head><link rel='stylesheet' href='../css/main.css'></head><body><center><div class = 'afterOfferDiv'><text>Извините, на складе недостаточно продуктов!</text></div></center></body>".$redirectMenu."</html>";
				break;
			}
		}
		
		if($productEnough)
			echo pushOrder($_POST['name'], $_POST['surname'], $_POST['phone'], $_POST['city'], $_POST['avenue'], $_POST['building'], $_POST['flat'], $_POST['comment'], $_POST['mail'], $meals);
	}
	else
		echo "<html><head><link rel='stylesheet' href='../css/main.css'></head><body><center><div class = 'afterOfferDiv'><text>Ваш заказ был пуст!</text></div></center></body>".$redirectMenu."</html>";
	
	include "dropCart.php";
?>