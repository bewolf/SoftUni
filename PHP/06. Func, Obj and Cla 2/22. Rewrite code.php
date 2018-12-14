<?php

class math{
    public $firstNum;
    public $secondNum;

    public function __construct($firstNum, $secondNum)
    {
        $this->firstNum = $firstNum;
        $this->secondNum = $secondNum;
    }
    function math_sum($a, $b)
    {
        return $a + $b;
    }

    function math_div($a, $b)
    {
        math_check_if_zero($a);
        math_check_if_zero($b);
        return $a / $b;
    }

    function math_check_if_zero($x)
    {
        if ($x == 0) {
            echo "division by zero is not possible";
            exit;
        }
    }
}


echo math_sum(2, 3);
echo math_div(1, 2);