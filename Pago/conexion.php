<?php
    $server = 'database-1.can0dvlvifnp.us-west-2.rds.amazonaws.com';
    $username = 'ProyAdmin123';
    $password = 'Pa$$w0rd123';
    $database = 'Tienda';
        
    try {
        $conn = new PDO("mysql:host=$server;dbname=$database",$username,$password);
        echo("Se conecto Correctamente a la base de datos");
    } catch(PDOExeption $exp){
        echo("No se Pudo conectar a la base de Datos :( , error: $exp");
    }
    return $conn;

?>
