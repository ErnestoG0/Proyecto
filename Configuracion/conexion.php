

<?php
$servidor = 'database-1.can0dvlvifnp.us-west-2.rds.amazonaws.com';
$usuario = 'ProyAdmin123';
$password = 'Pa$$w0rd123';
$database = 'Tienda';

$conexion = mysqli_connect($servidor,$usuario,$password,$database)or die(mysql_error());

?>