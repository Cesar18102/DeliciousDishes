function loadCart(cartID) {
	
	$.post('./php/getCart.php', function(data) {
		
		document.getElementById(cartID).innerHTML = data;
	});
}