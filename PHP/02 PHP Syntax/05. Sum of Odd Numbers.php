<?php

$counter = readline();
$sum = null;
$oddNum = 1;
for ($i = 1; $i <= $counter; $i++) {
    $sum += $oddNum;
    echo "$oddNum \r\n";
    $oddNum += 2;
}
echo "Sum: $sum";