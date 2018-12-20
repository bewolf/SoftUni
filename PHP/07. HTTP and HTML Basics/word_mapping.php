<?php

if (isset($_GET['text'])) {
    $input = explode(' ', strtolower($_GET['text']));
    $input = preg_replace('/[^A-Za-z0-9\-]/', '', $input);
    $counter = 1;
    $sorted = [];
    foreach ($input as $item) {
        if (!array_key_exists($item, $sorted)) {
            array_push($sorted, $item);
            $sorted[$item] = 1;
        } else {
            $sorted[$item] += 1;
        }
    }

}
var_dump($sorted);
?>
<form>
    <textarea name="text" rows="10"></textarea><br>
    <input type="submit" value="Count words">
    <table>
        <tbody>
        <?php foreach ($sorted as $value): ?>

            <tr style="border: 1px solid black;">
                <td style="border: 1px solid black;"><?= $value ?></td>
            </tr>
        <?php endforeach; ?>
        </tbody>
    </table>
</form>

