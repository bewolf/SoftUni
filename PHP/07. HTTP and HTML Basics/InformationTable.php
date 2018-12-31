<form>
    Name: <input type="text" name="name"> <br><br>
    Phone Number: <input type="text" name="phone"><br><br>
    Age: <input type="text" name="age"><br><br>
    Address: <input type="text" name="address"><br><br>
    <input type="submit" value="Submit">
</form>

<?php
if (isset($_GET['name']) &&
    isset($_GET['phone']) &&
    isset($_GET['address']) &&
    isset($_GET['age'])) {
    $name = $_GET['name'];
    $phone = $_GET['phone'];
    $age = $_GET['age'];
    $address = $_GET['address'];

}
?>
<table style="border: 1px solid black">
    <tr>
        <th style=" border-bottom: 1px solid black; background-color: orange" width="150px" align="left">Name</th>
        <td align="right" width="150px"><?php echo $name ?></td>
    </tr>
    <tr>
        <th style=" border-bottom: 1px solid black; background-color: orange" width="150px" align="left">Phone Number</th>
        <td align="right" width="150px"><?php echo $age ?></td>
    </tr>
    <tr>
        <th style=" border-bottom: 1px solid black; background-color: orange" width="150px" align="left">Age</th>
        <td align="right" width="150px"><?php echo $phone ?></td>
    </tr>
    <tr>
        <th style=" border-bottom: 1px solid black; background-color: orange" width="150px" align="left">Address</th>
        <td align="right" width="150px"><?php echo $address ?></td>
    </tr>

</table>
