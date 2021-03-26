<?php
setcookie("login", "admin");
setcookie("password", 123);
setcookie("mycookie", 123, time() + 60);
setcookie("mycookie[s1]", "cookie1");
setcookie("mycookie[s2]", "cookie2");
setcookie("mycookie[s3]", "cookie3");
foreach ($_COOKIE as $name => $val) {
    echo $name = $val. "<br>";
}
setcookie("mycookie",123, time() + 60*60, '/admin');
setcookie("mycookie",123, time() + 60*60, '/', "demo.mysite.com" );
?>