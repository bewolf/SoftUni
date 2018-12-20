<form>
    <textarea name="text" rows="10"></textarea><br>
    <input type="submit" value="Extract">
</form>

<?php

if (isset($_GET['text'])) {
    $input = htmlspecialchars(trim($_GET['text']));
    $words = preg_split('([^A-Z]+)', $input);
    foreach ($words as $word) {
        if (ctype_upper($word) && strlen($word) > 1) {
            echo $word . ', ';
        }
    }
}
var_dump($words);