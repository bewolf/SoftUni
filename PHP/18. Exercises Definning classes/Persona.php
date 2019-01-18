<?php
/**
 * Created by PhpStorm.
 * User: Georgi
 * Date: 15.1.2019 г.
 * Time: 20:09
 */

class Persona
{
    /**
     * @var string
     */
    private $name;
    /**
     * @var float
     */
    private $money;
    /**
     * @var array
     */
    private $bagOfProducts;

    /**
     * Person constructor.
     * @param string $name
     * @param float $money
     * @param array $bagOfProducts
     */
    public function __construct(string $name = '', float $money = 0)
    {
        $this->setName($name);
        $this->setMoney($money);
        $this->bagOfProducts = [];
    }

    /**
     * @param string $name
     */
    private function setName(string $name)
    {
        $this->name = $name;
    }

    /**
     * @param float $money
     */
    private function setMoney(float $money)
    {
        if ($money < 0) {
            throw new Exception('Money can not be negative');
        }
        $this->money = $money;
    }

    public function fill($name, $money)
    {
        $this->setName($name);
        $this->setMoney($money);
    }

}