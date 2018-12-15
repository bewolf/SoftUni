<?php

class Person11
{
    private $name;
    private $age;

    public function __construct(string $name, int $age)
    {
        $this->name = $name;
        $this->age = $age;
    }


    public function getName(): string
    {
        return $this->name;
    }

    public function printPeople()
    {
        return "{$this->getName()} - {$this->getAge()}\n";
    }

    function getAge(): int
    {
        return $this->age;
    }


}

$n = readline();
$persons = [];

while ($n-- > 0) {
    $lane = explode(' ', readline());

    $name = $lane[0];
    $age = $lane[1];
    $persons[] = new Person11($name, $age);
}

$filteredPeope = array_filter($persons, function (Person11 $person) {
    return $person->getAge() > 30;
});
usort($filteredPeope, function (Person11 $p1, Person11 $p2) {
    return $p1->getName() <=> $p2->getName();
});

foreach ($filteredPeope as $person) {
    echo $person->printPeople();
}