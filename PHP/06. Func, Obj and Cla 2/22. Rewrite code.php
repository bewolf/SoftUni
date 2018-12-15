<?php

class math{
    private $firstNum;
    private $secondNum;

    public function __construct($firstNum, $secondNum)
    {
        $this->firstNum = $firstNum;
        $this->secondNum = $secondNum;
    }
public function setFirstNum($firstNum)
    {
        $this->firstNum = $firstNum;
    }
public function setSecondNum($secondNum)
    {
        $this->secondNum = $secondNum;
    }


    function math_sum($a, $b)
    {
        return $a + $b;
    }
    function math_check_if_zero($x)
    {
        if ($x == 0) {
            echo "division by zero is not possible";
            exit;
        }
    }
    function math_div($a, $b)
    {
        math_check_if_zero($a);
        math_check_if_zero($b);
        return $a / $b;
    }


}


echo math_sum(2, 3);
echo math_div(1, 2);