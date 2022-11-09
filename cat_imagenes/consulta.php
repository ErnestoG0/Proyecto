<?php
include "../Configuracion/conexion.php";
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Datos guardados</title>
</head>
<body>
    <center>
        <h1>Imagenes guardadas</h1>
        <table>
            <tr>
               <td>Id</td>
               <td>Categoria</td>
               <td>Tipo</td>
               <td>Nombre</td>
               <td>Descripcion</td>
               <td>Precio</td>
               <td>Imagen</td>
            </tr>
            <?php
            $query = mysqli_query($conexion, "SELECT * FROM productos");
            $result = mysqli_num_rows($query);

            if($result = 0) 
                while ($data = mysqli_fetch_array($$query))
                    ?>
                <tr>
                   <td><?php echo $data['id'] ?></td>
                   <td><?php echo $data['categoria'] ?></td>
                   <td><?php echo $data['tipo'] ?></td>
                   <td><?php echo $data['nombre'] ?></td>
                   <td><?php echo $data['descripcion'] ?></td>
                   <td><?php echo $data['precio'] ?></td>
                   <td><img heigh="50px" src="data:image/jpg; base64, <?php echo base64_encode($data['imagen']) ?>"></td>
                </tr>
                }
            }
            ?>
        </table>
    </center>
    
</body>
</html>