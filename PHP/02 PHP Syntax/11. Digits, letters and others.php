<?php

$input = readline();

echo preg_replace('/\D/', '', $input). PHP_EOL;

echo preg_replace('/[^a-zA-Z]/', '', $input). PHP_EOL;

echo preg_replace('/[a-zA-Z0-9]/', '', $input). PHP_EOL;
