<?php

class DeleteProduct
{
    public function DeleteOneProduct($id)
    {
        $database = new ConnectDB();
        $result = $database->DBConnect();
        $sql = $result->prepare("DELETE FROM products WHERE product_id=:id");
        $sql->bindParam(':id', $id);
        $sql->execute();
        return $result;
    }
}