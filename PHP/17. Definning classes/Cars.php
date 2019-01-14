<?php
spl_autoload_register();

class Cars extends Vehicle
{
    /**
     * @var string
     */
    private $brand;

    /**
     * @var string
     */

    private $model;
    /**
     * @var int
     */
    private $year;

    public function __construct(int $numberOfDoors, string $color, $brand, $model, $year)
    {
        parent::__construct($numberOfDoors, $color);
        $this->setBrand($brand);
        $this->setModel($model);
        $this->setYear($year);


    }

    /**
     * @param string $brand
     */
    public function setBrand(string $brand)
    {
        $this->brand = $brand;
    }

    /**
     * @param string $model
     */
    public function setModel(string $model)
    {
        $this->model = $model;
    }

    /**
     * @param int $year
     */
    public function setYear(int $year)
    {
        if ($year < 1970 || $year > 2019) {
            throw new Exception('Invalid year');
        }
        $this->year = $year;
    }

    public function paint($color)
    {
        return parent::setColor($color);
    }
}