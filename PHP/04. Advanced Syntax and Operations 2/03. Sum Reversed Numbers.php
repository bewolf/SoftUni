    <?php

    $lane = explode(" ", readline());
    $sum = 0;
    foreach ($lane as $element){
        $element = strrev($element);
        $sum += intval($element);
    }
    echo $sum;
