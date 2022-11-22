<?php
   include('config.php');
   session_start();
   
   $user_check = $_SESSION['login_user'];
   
   $ses_sql = mysqli_query($db,"select * from admin where username = '$user_check' ");
   
   $row = mysqli_fetch_array($ses_sql,MYSQLI_ASSOC);
   
   $name_session = $row['name'];
   $_SESSION ['name_session'] = $name_session;
   $login_session = $row['username'];
   
   if(!isset($_SESSION['login_user'])){
      header("Location: ../lab03.html");
      die();
   }
?>