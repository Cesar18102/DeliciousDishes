function buyMeal(id, count, callback, cbparam) {
	
	$.post('./php/buyMeal.php', 'id=' + id + '&count=' + count, function(data) {
		
		let result = JSON.parse(data);
		callback.call(undefined, cbparam, result['true']? result['true'] : result['false']);
	});
}

function buyFlagUp(FlagId, textContent) {
	
	let flag = $("#" + FlagId);
	
	flag.attr('style', 'opacity : 1; transition : opacity 1s;');
	flag.prop('innerHTML', textContent);
	setTimeout(function(){ flag.attr('style', 'opacity : 0; transition : opacity 1s;'); }, 1000);
}