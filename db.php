<?php
require 'rb-mysql.php';

R::setup('mysql:host=localhost;dbname=id4164452_account', 'id4164452_nktkin', '12345678' );

if(!R::testConnection())
{
echo 'Cannot connect to the database.';
exit;
}


function register_user($name,$password)
{
$repeatChecker = R::findOne('users', 'name = ?', array($name));
if(isset($repeatChecker)) return "User $name is already exist.";
$user = R::dispense('users');
$user->name = $name;
$user->password = $password;
R::store($user);
return "User $user is created.";
}

function get_user($name)
{
$user = R::findOne('users', 'name = ?', array($name));
if(!isset($user)) return 'User is not found.';
return $user;
}

?>
