<?php

class Vehicle
{
    /**
     * @var int
     */
    private $numberOfDoors;
    /**
     * @var string
     */
    private $color;

    /**
     * Vehicle constructor.
     * @param int $numberOfDoors
     * @param string $color
     */
    public function __construct(int $numberOfDoors = null, string $color = null)
    {
        $this->setNumberOfDoors($numberOfDoors);
        $this->setColor($color);
    }

    /**
     * @return int
     */
    public function getNumberOfDoors(): int
    {
        return $this->numberOfDoors;
    }

    /**
     * @param int $numberOfDoors
     */
    protected function setNumberOfDoors(int $numberOfDoors)
    {
        $this->numberOfDoors = $numberOfDoors;
    }

    /**
     * @return string
     */
    public function getColor(): string
    {
        return $this->color;
    }

    /**
     * @param string $color
     */
    protected function setColor(string $color)
    {
        $this->color = $color;
    }

}