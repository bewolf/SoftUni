<form>
    <textarea rows="10" name="lines"><?php $city ?></textarea><br>
    <input type="submit" value="Sort">
</form>
<?php

if (isset($_GET['lines'])) {
    $sortedLines = $_GET['lines'];
    $city = preg_split('/[\s]+/', $sortedLines);
    sort($city);
    var_dump($city);
}