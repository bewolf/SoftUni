<?php

include "header.php";
spl_autoload_register();

$database = new ConnectDB();
$result = $database->DBConnect();

$sql = $result->prepare("SELECT product_id, product_name, product_price FROM products");
$sql->execute();

echo '<table border="1">';
echo '<tr><th>№</th><th>Name</th><th>Price</th><th>View product</th><th>Delete product</th><th>Edit product</th></tr>';

while ($result = $sql->fetch(PDO::FETCH_ASSOC)) {
    $number = $result['product_id'];
    $name = $result['product_name'];
    $price = $result['product_price'];

    echo '<tr >   
                  <td>' . $number . '</td> 
                  <td >' . $name . '</td > 
                  <td >' . $price . '</td >
                  <td><a href="view_product.php?product_id=' . $number . '">View</a></td>
                  <td><a href="?product_id=' . $number . '">Delete</a></td>
                  <td><a href="view_product.php?edit_product=' . $number . '">Edit</a></td>
          </tr >';
}
echo '<tr><td><a href="edit_product.php?edit_product=add">Add product</a></td></tr>';
echo '</table>';

if (isset($_GET['product_id'])) {

    $product_id = $_GET['product_id'];
    $delete = new DeleteProduct();
    $delete->DeleteOneProduct($product_id);
    echo 'Deleted product ID: ' . $product_id;
}


include "footer.php";