<?php

class Cconexion{
    
    static function ConexionDB(){
        $server = 'sql.freedb.tech';
        $username = 'freedb_AdProTienAd';
        $password = 'hwGsZ7PHU9egUT#';
        $database = 'freedb_ProTienAd';
        
        try {
            $conn = new PDO("mysql:host=$server;dbname=$database",$username,$password);
            echo("Se conecto Correctamente a la base de datos");
        } catch(PDOExeption $exp){
            echo("No se Pudo conectar a la base de Datos :( , error: $exp");
        }
        return $conn;
    }
}
?>
