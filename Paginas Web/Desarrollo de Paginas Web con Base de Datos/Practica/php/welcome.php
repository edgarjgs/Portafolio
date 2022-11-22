<?php
include('session.php');
?>
<!DOCTYPE html>
<html lang="en">

<head>
   <meta charset="UTF-8">
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <meta http-equiv="X-UA-Compatible" content="ie=edge">
   <title>Main Page</title>
   <link rel="stylesheet" href="../css/bootstrap.min.css">`
   <script src="../script/jquery-3.3.1.min.js"></script>
   <link rel="stylesheet" href="http://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css">
   <script src="http://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js"></script>
   <script src="../script/lab03.js"></script>
</head>
<body>
   <div class="container">
      <nav class="navbar navbar-expand-lg navbar-light bg-light">
         <a class="navbar-brand" href="#"><img src="../img/cover1.png" width="120"></a>
         <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
         </button>
         <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav mr-auto">
               <li class="nav-item active">
                  <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
               </li>
               <li class="nav-item">
                  <a class="nav-link" href="#">Inventory</a>
               </li>
               <li class="nav-item">
                  <a class="nav-link" is = "users" href="">Users</a>
                  <!--href="users.php"  -->
            </ul>
            <!--<div class="form-inline my-2 my-lg-0">
            <strong><-?php echo $name_session;?></strong>
            &nbsp;&nbsp;
            <img src="../img/user.png" height="35">
            &nbsp;&nbsp;
            <a class="btn btn-outline-primary my-2 my-sm-0" href="logout.php">Logout</a>
         </div>-->
            <div class="form-inline my-2 my-lg-0">
               <img src="../img/user.png" height="35">
               &nbsp;&nbsp;
               <strong>
                  <?php echo $name_session;?></strong>
               &nbsp;&nbsp;
               <a class="btn btn-outline-primary my-2 my-sm-0" href="logout.php">Logout</a>
            </div>
         </div>
      </nav>
      <div id="dataarea">
      <table id="myTable" class="display" style="width:100%">
      <thead>
         <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Username</th>
         </tr>
      </thead> 
      <tfoot>
         <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Username</th>
         </tr>
      </tfoot>
   </table>
</div>
</div>
</body>

</html>