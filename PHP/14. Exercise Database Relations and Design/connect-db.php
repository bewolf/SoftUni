<?php


$mysqli = new mysqli('localhost', 'root', '','blog');
//$mysqli->set_charset('utf8');

if ($mysqli->connect_errno) die ('Cannot connect ot MySQL');

$result = $mysqli->query('SELECT * FROM posts ORDER by create_date');
