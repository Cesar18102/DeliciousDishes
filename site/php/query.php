<?php
		
	function Query($query) {
			
		include "DB_Request.php";
		$link = Connect();
			
		$datas = Request($link, $query);
		$result = '';
		
		if($datas != null) {
			
			while($data = mysqli_fetch_array($datas, MYSQLI_ASSOC)) {
				
				$result .= '{ ';
				
				foreach($data as $key => $value)
					$result .= '"'.$key.'" : "'.$value.'", ';
					
				$result = substr($result, 0, strlen($result) - 2).'}, ';
			}
		}
		
		return '['.($result? substr($result, 0, strlen($result) - 2) : '').']';
	}
	
	if(isset($_POST['query']) && $_POST['query'] != null && $_POST['query'] != "" && 
	   isset($_POST['pas']) && $_POST['pas'] != null && $_POST['pas'] != "" && sha1($_POST['pas']) == "15daac6f164636a8c35e7a04e7e7f387b49424f5")
		echo Query($_POST['query']);
?>