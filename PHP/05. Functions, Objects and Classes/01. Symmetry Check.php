<?php

function isPallindrome ($input){
    $reversed = strrev($input);
    if ($input == $reversed){
        echo "true";
    } else {
        echo "false";
    }
}
echo isPallindrome(readline());