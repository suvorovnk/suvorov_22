<?php
$values = array(10, "5", 1.5, "0.05", null, true, false);
foreach ($values as $value) {
    if (is_int($value)==true)
    {
    echo "�������� ";
    var_export($value);
    echo "-�����<br/>";
    }
    else
    {
    echo "�������� ";
    var_export($value);
    echo "-�������<br/>";
    }
}
?>