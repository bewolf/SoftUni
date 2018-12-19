<?php

if (isset($_POST['filter'])) {
    $names = $_POST['names'];
    $ages = $_POST['ages'];
    $delimeter = $_POST['delimeter'];
    $studentNames = explode($delimeter, $names);
    $studentAges = (explode($delimeter, $ages));
    $next = $_GET['next'];
    for ($i = 0; $i < count($studentAges); $i++) {
        if ($studentAges[$i] < 18) {
            unset($studentAges[$i]);
            unset($studentNames[$i]);
        }
    }

    if ($next == '1'){
        var_dump($studentNames);
    }

}
include("student_info_frontend.php");