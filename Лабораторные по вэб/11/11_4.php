<?php 
echo date("d.m.Y",1356361195). "<br>"; //24.12.2012 
echo (date("d = F = Y ")). "<br>"; //Выведет 04 = September = 2001
echo (date("l dS F Y h:I:s A")). "<br>";
$date_today = date("m.d.y"). "<br>"; //присвоено 12.03.15
$today[1] = date("H:i:s"). "<br>"; //присвоит 1 элементу массива 18:32:17
echo("Текущее время: $today[1] и дата: $date_today "). "<br>";
?>