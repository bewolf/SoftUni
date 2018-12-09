<?php
$input = readline();
$strings[] = null;

while ($input != "end") {
    $strings[] .= $input;
    $input = readline();
}
foreach ($strings as $string) {
    echo $string . " = " . strrev($string) . "\r\n";
}