<?php
spl_autoload_register();
include "header.php";

if ($_GET['product_form'] == 'add') {

    include "product_form.php";


    if ($_POST) {
        $name = $_POST['product_name'] ?? null;
        $price = $_POST['product_price'] ?? null;
        $description = $_POST['product_description'] ?? null;
        $category_id = $_POST['cat_id'] ?? null;

        $database = new ConnectDB();

        $result = $database->DBConnect();
        $sql = $result->prepare('INSERT INTO products (product_name, product_description, product_price, category_id)
                                              VALUES (:product_name, :product_description, :product_price, :category_id)');
        $sql->bindParam('product_name', $name);
        $sql->bindParam('product_description', $description);
        $sql->bindParam('product_price', $price);
        $sql->bindParam('category_id', $category_id);
        $sql->execute();
        $product_id = $result->lastInsertId();
        header('Location: view_product.php?product_id=' . $product_id);
    }


} else if ($_GET['product_form'] == 'edit') {
    echo $product_id = $_GET['product_id'];
}
