<?php
$values = array(10, "5", 1.5, "0.05", null, true, false);
foreach ($values as $value) {
    if (is_int($value)==true)
    {
    echo "Значение ";
    var_export($value);
    echo "-целое<br/>";
    }
    else
    {
    echo "Значение ";
    var_export($value);
    echo "-нецелое<br/>";
    }
}
?>