<?php
spl_autoload_register();

$myVehicle = new Vehicle(4, 'red');

try {
    $b1 = new Bicycle(0,'Red',5,false);
    print_r($b1);
} catch (Exception $e) {
    echo "Error found. Call system admin!\n";
    echo $e->getMessage();
}

