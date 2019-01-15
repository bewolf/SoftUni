<?php
spl_autoload_register();

$height = floatval(readline());
$width = floatval(readline());
$length = floatval(readline());
try {
    $box = new Box($height, $width, $length);

    $box->volume();
    $box->lateralSurfaceArea();
    $box->surfaceArea();

}catch (Exception $e){
    echo "ti da vidish!";
    echo $e->getMessage();
}