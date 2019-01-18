<?php
declare(strict_types=1);

$speed = intval(readline());
$zone = readline();
function getLimit($zone): int
{
    switch ($zone) {
        case 'motorway':
            $limit = 130;
            break;
        case 'interstate':
            $limit = 90;
            break;
        case 'city':
            $limit = 50;
            break;
        case 'residential':
            $limit = 20;
            break;
        default:
            $limit = 1000;
            break;
    }
    return $limit;
}

$limit = getLimit($zone);


function getInfraction($speed, $limit)
{
    $difference = $speed - $limit;
    switch ($difference) {
        case
            $difference > 1 && $difference <= 20:
            echo "speeding";
            break;
        case
            $difference > 20 && $difference <= 40:
            echo "excessive speeding";
            break;
        case
            $difference > 40:
            echo "reckless driving";
            break;
    }
}

echo getInfraction($speed, $limit);