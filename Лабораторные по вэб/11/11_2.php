<?php $name = "������";
$message = "��� ����?";
$send = "������: " . $name . ", ���� ��������: " . $message;
$to = "suvorovipad2@gmail.com";
$from = "suvorovipad2@gmail.com";
$subject = "������ � �����"; // ���� ��������� 
// ���������, ���������� �� ��������� � ��� ������, ��������� ��� ��������� 
$headers = "From: $from\r\nReplay-To: $from\r\nContent-type: text/plain; charset=utf-8\r\n";
// ������� php ��� �������� ������ (���� ����������, ����, ����� � ���������, ���������) 
mail($to, $subject, $send, $headers);
