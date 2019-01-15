<?php
if (isset($_GET['Persona'])){
    $name = $_GET['Persona'];

    echo 'Hello, ' . $name . '!';
}
include('hello_person.php');