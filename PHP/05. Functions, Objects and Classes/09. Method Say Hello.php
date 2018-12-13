<?php

class Person09
{
    public $name;

    function greetings($name)
    {
        $this->name = $name;
        echo $this->name . " says \"Hello\"!";
    }
}

$name = readline();
$person = new Person09($name);
$person->greetings($name);