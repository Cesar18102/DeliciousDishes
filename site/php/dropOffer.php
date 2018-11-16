<?php
	if(isset($_POST['id'])) {
		
		include "DB_Request.php";
		$link = Connect();
				
		$query = "DELETE FROM offer WHERE id = ".$_POST['id'];
		Request($link, $query);
		
		$delQuery = "DELETE FROM offered_meal WHERE offer_id = ".$_POST['id'];
		Request($link, $delQuery);
	}
?>
