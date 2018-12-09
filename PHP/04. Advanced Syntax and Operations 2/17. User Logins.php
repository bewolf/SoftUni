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

switch ($input[0]) {

    case "login":
        $input = explode(" -> ", readline());
        while ($input[0] != "end") {
            if ($users[$input[0]] == $password) {
                echo $users[$input[0]] . " : logged in successfully" . PHP_EOL;
            } else {
                echo $users[$input[0]] . " : logged failed" . PHP_EOL;
                $counter++;
            }
        }
        breal;
}

/*
foreach ($logins as $key => $value) {
echo "$key: $value" . PHP_EOL;
}
echo "unsuccessful login attempts: " . $counter;
*/