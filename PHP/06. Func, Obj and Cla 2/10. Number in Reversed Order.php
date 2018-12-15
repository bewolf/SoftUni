<?php

class DecimaNumber
{
    private $number;

    public function __construct($number)
    {
        $this->setNumber($number);
    }

    public function getNumber()
    {
        return $this->number;
    }

    private function setNumber($number)
    {
        $this->number = $number;
    }

    public function ReversedOrder()
    {

        echo strrev($this->number);
    }
}

$lane = new DecimaNumber(readline());
$lane->ReversedOrder();