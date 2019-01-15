<?php
spl_autoload_register();
/**
 * $height = floatval(readline());
 * $width = floatval(readline());
 * $length = floatval(readline());
 * try {
 * $box = new Box($height, $width, $length);
 *
 * $box->volume();
 * $box->lateralSurfaceArea();
 * $box->surfaceArea();
 *
 * }catch (Exception $e){
 * echo $e->getMessage();
 * }
 */
$users = explode(';', rtrim(readline(), ';'));
$products = explode(';', rtrim(readline(), ';'));

$persons = new Persona();
$productsObj = new Product();

foreach ($users as $user) {
    $user_data = explode('=', $user);
    $user_name = $user_data[0];
    $user_money = $user_data[1];

    $persons->fill($user_name, $user_money);
    print_r($persons);
}

foreach ($products as $product) {
    $product_data = explode('=', $product);
    $product_name = $product_data[0];
    $product_cost = $product_data[1];

    $productsObj->fill($product_name, $product_cost);


    print_r($productsObj);
}
