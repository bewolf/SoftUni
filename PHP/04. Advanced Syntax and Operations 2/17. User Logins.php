<?php

$input = explode(" -> ", readline());
$users = [];
$username = null;
$password = null;
$counter = 0;
$logins = [];

while ($input[0] != "login") {
    $username = $input[0];
    $password = $input[1];
    $users[$username] = $password;
    $input = explode(" -> ", readline());
}
while ($input[0] == "login" || $input[0] != "end") {
    $input = explode(" -> ", readline());
    if ($users[$input[0]] == $input[1]) {
        echo $input[0] . " : logged in successfully" . PHP_EOL;
    } else {
        echo $input[0] . " : login failed" . PHP_EOL;
        $counter++;
    }
}
echo "unsuccessful login attempts: " . $counter;

/*
foreach ($logins as $key => $value) {
echo "$key: $value" . PHP_EOL;
}
*/