<html>
<form method="post">

    <select name="calculate" id="calculate">
        <option value="Sum" name="sum">Sum</option>
        <br>
        <option value="Subtract" name="subtract">Subtract</option>
        <br>
    </select> <br><br><br>


    Number 1: <input type="text" name="number1"> <br><br>
    Number 2: <input type="text" name="number2"> <br><br>

    <?php if (isset($result)): ?>

        Result:
        <input type="text" disabled readonly value="<?= $result; ?>">

    <?php endif; ?>
    <input type="submit" name="submit" value="Result">
</form>

</html>