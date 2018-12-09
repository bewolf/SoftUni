<?php

$input = readline();
if (strlen($input) <= 20) {
    echo $input . str_repeat("*", 20 - strlen($input));
} else {
    echo substr($input, 0, 20);
}