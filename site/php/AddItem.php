<?php
    if(isset($_POST["name"]) && isset($_POST["ingrs"]) && isset($_POST["desc"]) && isset($_POST["price"]) && isset($_POST["weight"]) && isset($_POST['categ']) && isset($_POST['unit']))
    {
		include "DB_Request.php";
		$link = Connect();
		
		$maxID = mysqli_fetch_array(Request($link, "SELECT (MAX(id) + 1) AS id FROM meal"), MYSQLI_ASSOC)['id'];
		$mealId = mysqli_fetch_array(Request($link, "SELECT IF(COUNT(MEALS.id) = 1, MEALS.id, ".$maxID.") AS id FROM (SELECT id, MAX(id) FROM meal WHERE name = '".$_POST["name"]."') MEALS"), MYSQLI_ASSOC)['id'];
		
		if($mealId == $maxID) {
			 
			$categID = mysqli_fetch_array(Request($link, "SELECT id FROM category WHERE name = '".$_POST['categ']."'"), MYSQLI_ASSOC)['id'];
			$unitID = mysqli_fetch_array(Request($link, "SELECT id FROM unit WHERE name = '".$_POST['unit']."'"), MYSQLI_ASSOC)['id'];
			
			$InsMeal = "INSERT INTO meal VALUES(".$mealId.", ".$categID.", '".$_POST['name']."', '".$_POST['desc']."', '".$_POST['weight']."', ".$unitID.");";
			Request($link, $InsMeal);
			
			$recId = mysqli_fetch_array(Request($link, "SELECT (MAX(id) + 1) AS id FROM reciepe"), MYSQLI_ASSOC)['id'];
			$pushReciepeQuery = "INSERT INTO reciepe VALUES(".$recId.", ".$mealId.", 'Просто смешайте все');";
			Request($link, $pushReciepeQuery);
			
			$ingrId = mysqli_fetch_array(Request($link, "SELECT (MAX(id) + 1) AS id FROM ingredient"), MYSQLI_ASSOC)['id'];
			for($i = 0; $i < $_POST['ingrs']; $i++) {

				$productId = mysqli_fetch_array(Request($link, "SELECT id FROM product WHERE name = '".$_POST["ingr".$i]."'"), MYSQLI_ASSOC)['id'];
				$InsRec = "INSERT INTO ingredient VALUES(".$ingrId.", '".$mealId."', '".$productId."', '".$_POST["ingrC".$i]."', 0);";
				Request($link, $InsRec);
				$ingrId++;
			}
		}
		
		$menuId = mysqli_fetch_array(Request($link, "SELECT (MAX(id) + 1) AS id FROM menu"), MYSQLI_ASSOC)['id'];
			$InsMenu = "INSERT INTO menu VALUES(".$menuId.", '".$mealId."', '".$_POST['price']."', '".$_POST["weight"]."');";
			Request($link, $InsMenu);
    }
    else echo "<html><link rel='stylesheet' href='../css/main.css'><h1>Неверно введенные данные</h1><html>";

?>
