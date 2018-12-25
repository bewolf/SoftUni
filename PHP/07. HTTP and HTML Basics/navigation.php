<?php

if (isset($_GET['tags']) && isset($_GET['months']) && isset($_GET['categories'])) {
    $tags = explode(', ', $_GET['tags']);
    $months = explode(', ', $_GET['months']);
    $categories = explode(', ', $_GET['categories']);

}
?>
<form>
    Categories: <input type="text" name="categories"><br><br>
    Tags: <input type="text" name="tags"><br><br>
    Months: <input type="text" name="months"><br><br>

    <input type="submit"/>

    <table>
        <tbody>
        <tr>
            <th>Categories</th>

        </tr>
        <tr>
            <td>
                <ul>
                    <?php foreach ($categories as $value): ?>

                        <li><?php echo $value; ?></li>

                    <?php endforeach; ?>
                </ul>
            </td>
        </tr>

        <tr>
            <th>Tags</th>
        </tr>
        <tr>
            <td>
                <ul>
                    <?php foreach ($tags as $value): ?>

                        <li><?php echo $value; ?></li>

                    <?php endforeach; ?>
                </ul>
            </td>
        </tr>

        <tr>
            <th>Months</th>
        </tr>
        <tr>
            <td>
                <ul>
                    <?php foreach ($months as $value): ?>

                        <li><?php echo $value; ?></li>

                    <?php endforeach; ?>
                </ul>
            </td>
        </tr>

        </tbody>
    </table>
</form>