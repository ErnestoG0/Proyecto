<?php
    require_once('conexion.php');

    if (empty($_POST['nombre']) || empty($_POST['categoria'])){
        echo "Por favor llene los campos correspondientes";
    }else{  
        $nombre =$_POST['nombre'];
        $categoria = $_POST['categoria'];
        $tipo = $_POST['tipo'];
        $descripcion = $_POST['descripcion'];
        $precio = $_POST['precio'];
        $imagen = addslashes(file_get_contents($_FILES ['imagen']['tmp_name']));
        $query = "INSERT INTO productos (categoria, tipo, nombre, descripcion, precio, imagen) 
        VALUES ('$categoria', '$tipo', '$nombre', '$descripcion', '$precio', '$imagen')";
        $resultado = $conexion->query($query);

        if ($resultado){
            echo "Se han insertado los datos";
        } else {
            echo "Los datos no se han insertado";
        }
    }
?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="css/style.css">
    <title>Ingreso de datos</title>
</head>
<body>
    <center>
    <h1>Datos productos</h1>
    <form method="POST" enctype="multipart/form-data">
        <h1>Ingrese informacion</h1>
        <label>Categoria:</label>
        <input type="text" name="categoria"><br><br>
        <label>Tipo:</label>
        <input type="text" name="tipo"><br><br>
        <label>Nombre:</label>
        <input type="text" name="nombre"><br><br>
        <label>Descripción:</label>
        <input type="text" name="descripcion"><br><br>
        <label>Precio:</label>
        <input type="double" name="precio"><br><br>
        <label>Foto: </label>
        <input type="file" name="imagen" required=""><br><br>
        <center>
            <input type="submit" name="Guardar" value="Guardar">
            <button><a href="consulta.php">Consultar</a></button>
        </center>
    </form>
    </center>
</body>
</html>