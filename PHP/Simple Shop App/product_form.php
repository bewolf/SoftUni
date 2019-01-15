<h2>Add product</h2>


<form method="post">
    Product name:<input type="text" name="product_name"><br>
    Product price:<input type="text" name="product_price"><br>
    Product description:<input type="text" name="product_description"><br>

    Product category
    <select name="cat_id">
        <option value=""></option>

        <?php
        spl_autoload_register();
        $database = new ConnectDB();

        $result = $database->DBConnect();
        $sql = $result->prepare("SELECT category_id,
                                          category_name
                                          FROM categories");
        $sql->execute();

        while ($result = $sql->fetch(PDO::FETCH_ASSOC)) {
            $name = $result['category_name'];
            $cat_id = $result['category_id'];

            echo '<option value=' . $cat_id . '>' . $name . '</option>';
        }
        ?>
    </select>

    <br> <input type="submit" value="Add product">
</form>