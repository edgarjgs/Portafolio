<?php
include('session.php');

$sql = "SELECT * FROM admin";
$result = mysqli_query($db, $sql);
if ($result){
    while($row = mysqli_fetch_assoc($result))
    $dataArray[] = $row;
}
//$dataArray = mysqli_fetch_array($result,MYSQLI_ASSOC);
$data = array(
    "data" => $dataArray
);
$myJSON = json_encode($data);

echo ($myJSON);

?>