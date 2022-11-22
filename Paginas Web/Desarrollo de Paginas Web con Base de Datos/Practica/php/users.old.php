<?php
include('session.php');
$sql    = "SELECT * FROM admin";
$result = mysqli_query($db, $sql);

$myJSON = mysqli_fetch_array($result,MYSQLI_ASSOC);
$myJSON = json_encode($myJSON);
echo $myJSON;

/*  while ($row    = mysqli_fetch_array($result, MYSQLI_ASSOC))
{
    echo "User: {$row["username"]} <br>";
}*/
//$active = $row['active'];
//$count  = mysqli_num_rows($result);

?>
