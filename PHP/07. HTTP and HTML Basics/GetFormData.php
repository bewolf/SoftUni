<form>
    <input type="text" name="name" placeholder="Name"><br>
    <input type="text" name="age" placeholder="Age"><br>
    <input type="radio" name="gender" id="male" value="Male"> <label for="male">Male </label><br>
    <input type="radio" name="gender" id="female" value="Female"> <label for="female">Female</label> <br>
    <input type="submit">
</form>
<?php
if (isset($_GET['name']) &&
    isset($_GET['age']) &&
    isset($_GET['gender']) ){
    $name = $_GET['name'];
    $age = $_GET['age'];
    $gender = $_GET['gender'];
echo "My name $name. I am $age years old. I am $gender.";
}
