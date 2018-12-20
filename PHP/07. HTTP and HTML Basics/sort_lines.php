<?php

if (isset($_GET['lines'])) {
$sortedLines = htmlspecialchars(trim($_GET['lines']));
$city = preg_split('/[\s]+/', $sortedLines);
sort($city);
$city1 = implode("\n", $city);
}

?>
<form>
    <textarea rows="10" name="lines"><?= $city1 ?></textarea><br>
    <input type="submit" value="Sort">
</form>

