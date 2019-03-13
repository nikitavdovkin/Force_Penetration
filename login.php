<?php
require 'db.php';

$name = $_POST['Name'];

if(!isset($name))
{
echo 'Uncorrect data.';
exit;
}

echo get_user($name);

?>