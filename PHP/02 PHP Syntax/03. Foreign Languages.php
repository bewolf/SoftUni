<?php
$country = strtolower(readline("Country"));

switch ($country) {
    case "england":
    case "usa":
        echo "English";
        break;
    case "spain":
    case "argentina":
    case "mexico":
        echo "Spanish";
        break;
    default:
        echo "unknown";
        break;
}