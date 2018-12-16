<?php

class Car
{
    private $model;
    private $fuelAmount;
    private $fuelCost;
    private $distanceTraveled;

    public function __construct(string $model, float $fuelAmount,
                                float $fuelCost, float $distanceTraveled = 0)
    {
        $this->model = $model;
        $this->fuelAmount = $fuelAmount;
        $this->fuelCost = $fuelCost;
        $this->distanceTraveled = $distanceTraveled;
    }

    /**
     * @return string
     */
    public function getModel(): string
    {
        return $this->model;
    }

    /**
     * @return float
     */
    public function getFuelAmount(): float
    {
        return $this->fuelAmount;
    }

    /**
     * @return float
     */
    public function getFuelCost(): float
    {
        return $this->fuelCost;
    }

    /**
     * @return float
     */
    public function getDistanceTraveled(): float
    {
        return $this->distanceTraveled;
    }

    public function Drive($model, $distance)
    {
        $model = $this->model;
        $distance += $this->distance;
        if (1) {
            echo $model . PHP_EOL . $distance;
        } else {
            echo "Insufficient fuel for the drive";
        }

    }
}

$n = intval(readline());
$cars = [];

while ($n-- > 0) {

    $input = explode(' ', readline());
    $model = $input[0];
    $fuelAmount = $input[1];
    $fuelCost = $input[2];

    $cars[] = new Car($model, $fuelAmount, $fuelCost);
}

$input = explode(' ', readline());

while ($input != "End") {

    $model = $input[1];
    $distance = $input[2];
    $input = explode(' ', readline());

}