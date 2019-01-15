<?php

include "header.php";
spl_autoload_register();

$database = new ConnectDB();
$result = $database->DBConnect();
$product_id = $_GET['product_id']??null;
$sql = $result->prepare("SELECT product_id, 
                                          product_name,
                                          product_description,
                                          product_price,
                                          product_create_date
                                  FROM shop.products
                                  WHERE product_id= :product_id");
$sql->bindParam(':product_id', $product_id);
$sql->execute();

while ($result = $sql->fetch(PDO::FETCH_ASSOC)) {
    $number = $result['product_id'];
    $name = $result['product_name'];
    $price = $result['product_price'];
    $description = $result['product_description'];
    $create_date = $result['product_create_date'];

    echo 'ID: ' . $number . '<br>' .
        'Name: ' . $name . '<br>' .
        'Description: ' . $description . '<br>' .
        'Price: ' . $price . '<br>' .
        'Created' . $create_date;
}

include "footer.php";