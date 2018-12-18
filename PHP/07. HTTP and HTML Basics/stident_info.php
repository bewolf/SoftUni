<?php

if (isset($_POST['filter'])) {
    $names = $_POST['names'];
    $ages = $_POST['ages'];
    $delimeter = $_POST['delimeter'];
    $studentNames = explode($delimeter, $names);
    $studentAges = (explode($delimeter, $ages));

    for ($i = 0; $i < count($studentAges); $i++) {
        if ($studentAges[$i] < 18) {
            unset($studentAges[$i]);
            unset($studentNames[$i]);
        }
    }

}
include("student_info_frontend.php");