<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type ="text/css" href="css/style.css">
    <title>Catalogo de productos</title>
</head>
<body>
    <h1 class="title">PRODUCTOS</h1>
    
    <div class="container">
        <?php
            include("conexion.php");
            $query = "SELECT * FROM productos";
            $resultado = $conexion->query($query);
            while ($row = $resultado->fetch_assoc()){
                ?>
                <div class="card">
                    <img src="data:imagen/jpg;base64, <?php echo base64_encode($row['imagen']);?>" alt="">
                    <h4><?php echo $row['nombre']; ?></h4>
                    <p><?php echo $row['descripcion']; ?></p>
                    <p><?php echo $row['precio']; ?></p>
                    <a href="#">comprar</a>
                </div>
            <?php
            }
        ?>
    </div>


</body>
</html>