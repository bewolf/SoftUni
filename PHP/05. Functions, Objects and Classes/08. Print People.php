<?php

class Person08
{
    public $name;
    public $age;
    public $occupation;

    public function __construct($name, $age, $occupation)
    {
        $this->name = $name;
        $this->age = $age;
        $this->occupation = $occupation;
        // echo $this->name . " - age: " . $this->age . ", occupation: " . $this->occupation;
    }
}

$lane = explode(' ', readline());
$persons = [];
while ($lane[0] != 'END') {

    $name = $lane[0];
    $age = $lane[1];
    $occupation = $lane[2];
    $lane = explode(' ', readline());
    $person = new Person08($name, $age, $occupation);
    array_push($persons, $person);
}
usort($persons, function ($a, $b) {
    return strcmp($a->age, $b->age);
});
for ($i = 0; $i < count($persons); $i++) {
    echo $persons[$i]->name . " - age: " .
        $persons[$i]->age . ", occupation: " .
        $persons[$i]->occupation . PHP_EOL;
}