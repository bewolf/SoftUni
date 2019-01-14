<?php

class ConnectDB
{
    public function DBConnect()
    {
        include "config.php";

        return new PDO("mysql:host=$servername;dbname=$dbName", $username, $password);
    }
}