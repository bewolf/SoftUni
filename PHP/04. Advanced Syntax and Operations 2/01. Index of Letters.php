    <?php

    $lane = strtolower(readline());
    $lane = str_split($lane);

    for ($i = 0; $i < count($lane); $i++) {
        echo "$lane[$i] -> ". (ord($lane[$i])-97). PHP_EOL;
    }