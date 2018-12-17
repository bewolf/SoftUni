<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Student Info</title>
</head>
<body>
<div>
    Delimeter:
    <select name="delimeter" id="">
        <option value=",">,</option>
        <option value="|">|</option>
        <option value="&">&</option>
    </select>
</div>
<div>
    Names:
    <input type="text" name="names">
</div>
<div>
    Ages:
    <input type="text" name="ages">
</div>
<div>
    <input type="submit" name="filter" value="Filter">
</div>
<?php
if (isset($names, $ages)):?>
    <table border="1" cellpadding="0">
        <thead>
        <th>Name</th>
        <th>Age</th>
        </thead>
        <tbody>

        </tbody>
    </table>
<?php endif ?>
</body>
</html>