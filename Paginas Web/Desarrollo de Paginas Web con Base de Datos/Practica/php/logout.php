<?php
   session_start();
   
   if(session_destroy()) {
      header("Location: ../lab03.html");
   }
?>