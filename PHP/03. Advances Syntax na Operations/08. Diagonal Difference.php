<?php

$matrixSize = intval(readline());
$matrix = [];
$leftDiagonal = 0;
$rightDiagonal = 0;
for ($i = 0; $i < $matrixSize; $i++) {
    $matrix[] = explode(" ", readline());
}
for ($i = 0; $i < $matrixSize; $i++) {
    $leftDiagonal += $matrix[$i][$i];
    $rightDiagonal += $matrix[$i][$matrixSize - 1 - $i];
}
echo abs($rightDiagonal + -$leftDiagonal);