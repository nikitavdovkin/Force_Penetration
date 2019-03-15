<?php
require 'db.php';

$name = $_POST['name'];
$pass = $_POST['pass'];

if(!isset($name) || !isset($pass))
{
echo "Uncorrect data register. name: $name pass: $pass";
exit;
}

echo register_user($name, $pass);

?>