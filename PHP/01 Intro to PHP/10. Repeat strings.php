<?php

$input = explode(" ", readline());

for ($i = 0; $i < count($input); $i++) {
    echo str_repeat($input[$i], strlen($input[$i]));
}