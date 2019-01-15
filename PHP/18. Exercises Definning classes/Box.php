<?php
/**
 * Created by PhpStorm.
 * User: Georgi
 * Date: 15.1.2019 г.
 * Time: 12:43
 */

class Box
{
    /**
     * @var float
     */
    private $lenght;
    /**
     * @var float
     */
    private $width;
    /**
     * @var float
     */
    private $height;

    /**
     * Box constructor.
     * @param float $length
     * @param float $width
     * @param float $height
     */
    public function __construct(float $length, float $width, float $height)
    {
        $this->setLenght($length);
        $this->setWidth($width);
        $this->setHeight($height);
    }

    /**
     * @param float $lenght
     */
    private function setLenght(float $lenght)
    {
        if ($lenght <= 0){
            throw new Exception('Lenght can not be zero or negative');
        }
        $this->lenght = $lenght;
    }

    /**
     * @param float $width
     */
    private function setWidth(float $width)
    {
        if ($width <= 0){
            throw new Exception('Width can not be zero or negative');
        }
        $this->width = $width;
    }

    /**
     * @param float $height
     */
    private function setHeight(float $height)
    {
        if ($height <= 0){
            throw new Exception('Heigth can not be zero or negative');
        }
        $this->height = $height;
    }


    public function volume()
    {
        $volume = $this->width * $this->height * $this->lenght;
        echo "Volume - " . number_format($volume, 2) . "\n";
    }

    public function lateralSurfaceArea()
    {
        $lateralSurfaceArea = 2 * $this->height * $this->lenght + 2 * $this->width * $this->height;
        echo "Lateral Surface Area - " . number_format(round($lateralSurfaceArea, 2), 2) . "\n";
    }

    public function surfaceArea()
    {
        $surfaceArea = 2 * $this->height * $this->lenght + 2 * $this->width * $this->height + 2 * $this->lenght * $this->width;
        echo "Surface Area - " . number_format(round($surfaceArea, 2), 2) . "\n";
    }
}