<?php

class Person
{
    public $name;
    public $age;
}

$ivan = new Person();
echo(count(get_object_vars($person)));