<?php
	if(isset($_POST['hash']) && $_POST['hash'] == 'Delishes228') 
		setcookie('auth', 'OK', time() + 28800);
?>
