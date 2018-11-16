<?php
      function mailSend($mail, $id) {

          require_once "SendMailSmtpClass.php"; // подключаем класс
          $mailText = "Сеть ресторанов Core47! Ваш заказ принят! <br/>Ссылка для отслеживания заказа: http://178.151.184.183/deliciousdishes/offer.php?id=".$id;

          $mailSMTP = new SendMailSmtpClass('jewelfiltermarket@gmail.com', 'a56552239B', 'ssl://smtp.gmail.com', 'Олег', 465); // создаем экземпляр класса
          // $mailSMTP = new SendMailSmtpClass('логин', 'пароль', 'хост', 'имя отправителя');

          $headersClient = "MIME-Version: 1.0\r\n";
          $headersClient .= "Content-type: text/html; charset=utf-8\r\n"; // кодировка письма
          $headersClient .= "From: Core47 <delicious.dishes.kh@gmail.com>\r\n"; // от кого письмо
          $headersClient .= "To: <" . $_POST['mail'] . ">\r\n";
          $result = $mailSMTP->send($_POST['mail'], "Сеть ресторанов Core47 : Ваш заказ", $mailText, $headersClient); // отправляем письмо
      }
?>	