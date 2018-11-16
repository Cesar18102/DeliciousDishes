<!DOCTYPE html>
<html lang="en" style = "height : 100%">
	<head >
		<meta charset="UTF-8">
		<title>Luxury Restaurant</title>
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">
		<link href="https://fonts.googleapis.com/css?family=Playfair+Display:700|Sintony:400,700" rel="stylesheet">
		<link rel="stylesheet" href="css/main.css">
		<script src = "js/libs/glm-ajax.js"></script>
		<script src = "js/libs/jquery-3.3.1.js"></script>
		<script>
			$(window).on("load", GetInputs);
			
			function GetInputs() {
				let count = document.getElementById("ingrsn").value;
				let tbl = document.getElementById("List");
				tbl.innerHTML = "<tr><th>Название ингридиента</th><th>Количество ингридиента</th></tr>";

				<?php
					include "php/DB_Request.php";
					$link = Connect();
								
					$products = Request($link, "SELECT name FROM product");
				 	$options = "";
				 	while ($product = mysqli_fetch_array($products, MYSQLI_ASSOC))
				 		$options .= '<option>'.$product['name'].'</option>';
					
					$categQuery = Request($link, "SELECT name FROM category");
					$categOptions = "";
					while ($categ = mysqli_fetch_array($categQuery, MYSQLI_ASSOC))
						$categOptions .= '<option>'.$categ['name'].'</option>';
					
					$unitQuery = Request($link, "SELECT name FROM unit");
					$unitOptions = "";
					while ($unit = mysqli_fetch_array($unitQuery, MYSQLI_ASSOC))
						$unitOptions .= '<option>'.$unit['name'].'</option>';
				?>
				
				document.getElementById('categs').innerHTML = '<?php echo $categOptions; ?>'
				document.getElementById('mealUnit').innerHTML = '<?php echo $unitOptions; ?>'

				for(let i = 0; i < count; i++)
				{
					tbl.innerHTML += 
					`<tr>
					    <td>
					    <select required name = "ingr` + i + `">` +
					    	<?php echo '`'.$options.'`' ?>
					    + `</select>
					    </td>
					    <td>
					    <input required name = "ingrC` + i + `" type = "number" min = "1" value = "1"></input>
					    </td>
					</tr>`;
				}
			}
		</script>
	</head>
	<body style = "height : 100%">
		<center>
		
		<form action = "php/AddItem.php" method = "POST">
			<table width="70%" bgcolor="#FFFFFF" style = "margin-bottom : 1%; border : 0px;" cellpadding = '8em'>
			
				<hr/>
					<header><div class = "menuHeader">Добавить позицию</div></header>
				<hr/>	
				<tr style = "border-bottom : 1px solid rgb(229, 229, 229);">
					<th><center><div class = 'menuTH'>Название</div></center></th>
					<th><center><div class = 'menuTH'>Категория</div></center></th>
					<th><center><div class = 'menuTH'>Ингредиенты</div></center></th>
					<th><center><div class = 'menuTH'>Описание</div></center></th>
					<th><center><div class = 'menuTH'>Цена</div></center></th>
					<th><center><div class = 'menuTH'>Вес</div></center></th>
					<th><center><div class = 'menuTH'>Единицы измерения</div></center></th>
				</tr>
				<tr style = "border-bottom : 1px solid rgb(229, 229, 229);">
					<td><center><div class = 'nameCell'><input required name ="name" class = "addName"> </input></div></center></td>
					<td><center><select class = 'nameCell' name = "categ" id = "categs" required></select></center></td>
					<td>
						<center>
							<div class = 'ingrsCell'>
                                <input required type="number" min = "1" value="1" id ="ingrsn" onchange="GetInputs()" name = "ingrs" class = "addIngrs"> </input>
							</div>
						</center>
					</td>
					<td><center><div class ='descrCell'><input required name = "desc" class = "addDescription"> </input></div></center></td>
					<td><center><div class = 'priceCell'><input required name = "price" type = "number" min = "1" value="1" class = "addPrice"> </input></div></center></td>
					<td><center><div class = 'weightCell'><input required name = "weight" type = "number" min = "1" value="1" class = "addWeight"> </input></div></center></td>
					<td><center><div class = 'weightCell'><select required name = "unit" id = "mealUnit"></select></div></center></td>
					</tr>
			</table>
			<table id = "List" width="70%" bgcolor="#FFFFFF" style = "margin-bottom : 1% border : 0px;" cellpadding = '8em'>

			</table>
			<center><button type = "submit" style = " margin-top: 1%;">Добавить</button></center>
		</form>	
		</center>
	</body>
	<script src = "js/main.js"></script>
</html>