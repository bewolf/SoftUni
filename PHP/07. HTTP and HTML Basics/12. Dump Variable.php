<html>
<form method="post">
    Enter variable: <input type="text" name="input"><br>
    <input type="submit" value="Submit">


</form>

</html>

<?php

// Check the keys "name" or "age" exist

if (isset($_POST["input"])) {
    echo var_dump($_POST["input"]);
    echo "Welcome " . htmlspecialchars($_POST['input']) . ". <br />";
}
