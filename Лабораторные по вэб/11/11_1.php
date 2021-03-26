<?php 
$date_start = '01.03.2016';
$date_end = '8.03.2029';
$interval_date = date_diff(date_create($date_start), date_create($date_end))->days + 1;
for ($i = 1; $i <= $interval_date; $i++) {
    $date_new = date('d.m.Y', (strtotime($date_start) + 86400 * ($i - 1)));
    echo $date_new . '<br>';
}
echo "<br> Стартовый день = " . $date_start . "<br>";
echo "<br> Конечный день = " . $date_end . "<br>";
echo "<br> Количество дней = " . $interval_date . "<br>";
?>