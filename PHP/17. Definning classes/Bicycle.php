<?php

spl_autoload_register();

class Bicycle extends Vehicle
{
    /**
     * @var boolean
     */
    private $rideTheBike;

    /**
     * @var boolean
     */
    private $forSkirt;

    /**
     * @return bool
     */

    public function __construct($numberOfDoors =0, $color, $isForSkirt, $rideTheBike)
    {
        parent::__construct($numberOfDoors, $color);
        $this->setForSkirt($isForSkirt);
        $this->setRideTheBike($rideTheBike) ;
    }

    public function isForSkirt(): bool
    {
        return $this->forSkirt;
    }

    /**
     * @param bool $forSkirt
     */
    private function setForSkirt(bool $forSkirt)
    {
        $this->forSkirt = $forSkirt;
    }

    /**
     * @return bool
     */
    public function isRideTheBike(): bool
    {
        return $this->rideTheBike;
    }

    /**
     * @param bool $rideTheBike
     */
    private function setRideTheBike(bool $rideTheBike)
    {
        $this->rideTheBike = $rideTheBike;
    }

}