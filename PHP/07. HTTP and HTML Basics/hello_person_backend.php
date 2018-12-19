<?php
if (isset($_GET['person'])){
    $name = $_GET['person'];

    echo 'Hello, ' . $name . '!';
}
include('hello_person.php');