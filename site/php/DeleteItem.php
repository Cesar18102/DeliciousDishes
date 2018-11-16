<?php
	if(isset($_POST['id'])) {
		
		include "DB_Request.php";
		$link = Connect();
				
		$query = "DELETE FROM menu WHERE id = ".$_POST['id'];
		Request($link, $query);
	}
?>
