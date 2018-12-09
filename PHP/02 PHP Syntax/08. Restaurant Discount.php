<?php

$smallHall = 2500;
$terrace = 5000;
$greatHall = 7500;
$smallHallCapacit = 50;
$terraceCapacit = 100;
$greatHallCapacit = 120;

$normalDisc = 5;
$goldDisc = 10;
$platinumDisc = 15;

$normalPrice = 500;
$goldPrice = 750;
$platinumPrice = 1000;

$groupSize = readline();
$packageType = readline();

if ($groupSize <= 50) {
    $hallName = "Small Hall";
    switch ($packageType) {
        case "Normal":
            $price =
                (($smallHall + $normalPrice) -
                    (($smallHall + $normalPrice) * ($normalDisc / 100)))
                / $groupSize;
            break;
        case "Gold":
            $price = (($smallHall + $goldPrice) -
                    (($smallHall + $goldPrice) * ($goldDisc / 100)))
                / $groupSize;
            break;
        case "Platinum":
        case "Gold":
            $price = (($smallHall + $platinumPrice) -
                    (($smallHall + $platinumPrice) * ($platinumDisc / 100)))
                / $groupSize;
            break;
    }
}
if ($groupSize > 50 && $groupSize <= 100) {
    $hallName = "Terrace";
    switch ($packageType) {
        case "Normal":
            $price =
                (($terrace + $normalPrice) -
                    (($terrace + $normalPrice) * ($normalDisc / 100)))
                / $groupSize;
            break;
        case "Gold":
            $price = (($terrace + $goldPrice) -
                    (($terrace + $goldPrice) * ($goldDisc / 100)))
                / $groupSize;
            break;
        case "Platinum":
        case "Gold":
            $price = (($terrace + $platinumPrice) -
                    (($terrace + $platinumPrice) * ($platinumDisc / 100)))
                / $groupSize;
            break;
    }
}
if ($groupSize > 100 && $groupSize <= 120) {
    $hallName = "Great Hall";
    switch ($packageType) {
        case "Normal":
            $price =
                (($greatHall + $normalPrice) -
                    (($greatHall + $normalPrice) * ($normalDisc / 100)))
                / $groupSize;
            break;
        case "Gold":
            $price = (($greatHall + $goldPrice) -
                    (($greatHall + $goldPrice) * ($goldDisc / 100)))
                / $groupSize;
            break;
        case "Platinum":
        case "Gold":
            $price = (($greatHall + $platinumPrice) -
                    (($greatHall + $platinumPrice) * ($platinumDisc / 100)))
                / $groupSize;
            break;
    }
}
if ($groupSize > 1 && $groupSize <= 120) {
    echo "We can offer you the $hallName \r\nThe price per person is " .
        round($price, 2) . "$";
} else {
    echo "We do not have an appropriate hall.";
}