<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Student Info</title>
</head>
<body>
<form method="post">
    <div>
        Delimeter:
        <select name="delimeter" id="">
            <option value="|">|</option>
            <option value=",">,</option>
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
    if (isset($studentNames, $studentAges)):?>
        <table border="1" cellpadding="0">
            <thead>
            <th>Name</th>
            <th>Age</th>
            </thead>
            <tbody>
            <?php for ($count = 0; $count < count($studentNames); $count++): ?>
                <tr>
                    <td><?= $studentNames[$count]; ?></td>
                    <td><?= $studentAges[$count]; ?></td>
                </tr>
            <?php endfor; ?>
            </tbody>
        </table>
    <?php endif; ?>
    <a href="?next=1" name="next">Next</a><br>
    <a href="" name="previous">Previous </a>

</form>
</body>
</html>