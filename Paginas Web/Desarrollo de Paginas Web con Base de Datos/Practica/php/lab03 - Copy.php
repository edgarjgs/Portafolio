<!DOCTYPE html>
<html lang="en">
   <head>
      <meta charset="UTF-8">
      <meta name="viewport" content="width=device-width, initial-scale=1.0">
      <meta http-equiv="X-UA-Compatible" content="ie=edge">
      <link rel="stylesheet" href="css/bootstrap.min.css">
      <title>lab 03</title>
   </head>
   <body>
      <div class="container">
         <?php        
     //       $usr = $_GET["user"]; 
     //       $pwd = $_GET["pwd"]; 
            $usr = $_POST["user"]; 
            $pwd = $_POST["pwd"]; 
            echo "<h1>Bienvenid@ <br></h1>";
            echo "<h3>";

            echo $usr . " " . $pwd;
            echo "</h3>";
            
          ?>
      </div>
   </body>
</html>