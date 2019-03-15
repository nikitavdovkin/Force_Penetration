<?php
require 'db.php';

$name = $_POST['name'];

if(!isset($name))
{
echo "Uncorrect data login. $name";
exit;
}

echo get_user($name);

?>