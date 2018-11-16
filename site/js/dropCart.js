function dropCart() {
	
	$.post('./php/dropCart.php');
	document.location = 'menu.php';
}