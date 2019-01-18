<?php
/**
 * Created by PhpStorm.
 * User: Georgi
 * Date: 15.1.2019 г.
 * Time: 20:09
 */

class Product
{
    /**
     * @var string
     */
    private $name;
    /**
     * @var float
     */
    private $cost;

    /**
     * Product constructor.
     * @param string $name
     * @param float $cost
     */
    public function __construct(string $name = '', float $cost = 0)
    {
        $this->setName($name);
        $this->setCost($cost);
    }

    /**
     * @param string $name
     */
    public function setName(string $name)
    {
        $this->name = $name;
    }

    /**
     * @param float $cost
     */
    public function setCost(float $cost)
    {
        if ($cost < 0) {
            throw new Exception("Money can not be negative");
        }
        $this->cost = $cost;
    }

    public function fill($name, $money)
    {
        $this->setName($name);
        $this->setCost($money);
    }

}