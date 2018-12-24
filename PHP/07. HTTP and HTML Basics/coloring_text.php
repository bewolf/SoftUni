<form>
    Name: <input type="text" name="input">
    <input type="submit"/>

</form>
<?php
if (isset($_GET['input'])) {
    $input = str_split($_GET['input']);
    for ($i = 0; $i < count($input); $i++) {
        if (ord($input[$i]) % 2 == 0) {
            echo '<i style="color: red;">' . $input[$i] . '</i> ';
        } else {
            echo '<i style="color: blue;">' . $input[$i] . '</i> ';
        }
    }
}