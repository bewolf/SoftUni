<?php
include "header.php";

if ($_GET['edit_product'] == 'add') {
    $name = $_POST['product_name']??null;
    $price = $_POST['product_price']??null;
    $description = $_POST['product_description']??null;

    include "add_product_form.php";

    print_r($_POST);


} else if ($_GET['edit_product' == 'edit']) {

}
