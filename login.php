<?php
require 'db.php';

$name = $_POST['name'];
$_SESSION['id'] = $row['id'];

if(!isset($name))
{
echo "Uncorrect data login. $name";
exit;
}

echo get_user($name);
echo get_id($_SESSION);

?>