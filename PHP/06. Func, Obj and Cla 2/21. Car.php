<?php

class Car
{
    public $brand;
    public $model;
    public $year;

    public function __construct($brand, $model)
    {
        $this->brand = $brand;
        $this->model = $model;
    }

    function setYear($year)
    {
        if ($year > 2018) {
            echo 'Year must not be more than 2018';
        } else {
            $this->year = $year;
        }
    }

    public function getBrand()
    {
        return $this->brand;
    }

    public function getModel()
    {
        return $this->model;
    }

    public function getYear()
    {
        return $this->year;
    }
}

$cars = [];

for ($i = 0; $i < 4; $i++) {
    $car = explode(' ', readline());
    $brand = $car[0];
    $model = $car[1];
    $year = $car[2];
    $cars[$i] = new Car($brand, $model);
    $cars[$i]->setYear($year);

}

foreach ($cars as $car) {
    $brand1[] = $car->brand;
    $model1[] = $car->model;
    $year1[] = $car->year;
}
array_multisort($brand1, SORT_ASC, $model1, SORT_ASC, $year1, SORT_ASC, $cars);

class carModelDetails{
    public $engine;
    public $doorCount;
    public $horsepower;
    public $color;

    /**
     * carModelDetails constructor.
     * @param $engine
     * @param $doorCount
     * @param $horsepower
     * @param $color
     */
    public function __construct($engine, $doorCount, $horsepower, $color)
    {
        $this->engine = $engine;
        $this->doorCount = $doorCount;
        $this->horsepower = $horsepower;
        $this->color = $color;
    }
}