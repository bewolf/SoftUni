<?php

class Person
{
    public $name;
    public $age;

    public function __construct($name, $age)
    {
        $this->name = $name;
        $this->age = $age;
        echo $this->name . ' ' . $this->age;
    }
}
$name = readline();
$age = readline();
$ivan = new Persona($name, $age );