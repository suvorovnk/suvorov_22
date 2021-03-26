<?php $name = "Максим";
$message = "Как дела?";
$send = "Привет: " . $name . ", хочу спросить: " . $message;
$to = "suvorovipad2@gmail.com";
$from = "suvorovipad2@gmail.com";
$subject = "Узнать о делах"; // тема сообщения 
// заголовки, отвечающие за кодировку и тип письма, оставляем без изменений 
$headers = "From: $from\r\nReplay-To: $from\r\nContent-type: text/plain; charset=utf-8\r\n";
// функция php для отправки письма (кому отправляем, тема, текст в сообщении, заголовки) 
mail($to, $subject, $send, $headers);
