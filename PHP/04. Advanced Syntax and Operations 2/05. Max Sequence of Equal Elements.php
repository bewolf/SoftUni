<?php

$lane = explode(" ", readline());
$number = 0;
$theMostSeq = 0;
for ($i = 0; $i < count($lane) - 1; $i++) {
    if ($lane{$i} == $lane[$i + 1]) {
        $number = $lane[$i];
        $theMostSeq++;
    } else {
        $theMostSeq = 1;
        $number = $lane[$i];
    }
}
$theMostSeq++;
echo "$theMostSeq  $number";