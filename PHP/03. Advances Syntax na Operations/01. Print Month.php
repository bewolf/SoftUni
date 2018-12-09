<?php

$month = ["January", "February", "March", "April", "May", "June", "July",
    "August", "September", "October", "November", "December"];

$input = readline();

if ($input < 1 || $input > 12) {
    echo "Invalid Month!";
} else {
    echo $month[$input -1];
}