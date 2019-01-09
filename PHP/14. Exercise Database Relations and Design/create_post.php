<h2>Create Post</h2>

<?php
include "hearder.php";
include "connect-db.php"
?>

<form method="post">
    <span>Enter Post Title</span> <input type="text" name="post_title"> <br><br>
    <span>Enter Post Content</span> <input type="text" name="post_content"> <br><br>
    <input type="submit" name="submit" value="Post">
</form>
<?php

if (isset($_POST['post_title']) && isset($_POST['post_content'])) {
    $title = $_POST['post_title'];
    $content = $_POST['post_content'];

    $stmt = $mysqli->prepare("INSERT INTO posts(title, content) VALUES (?, ?)");
    $stmt->bind_param("ss", $title, $content);
    $stmt->execute();
    if ($stmt->affected_rows == 1) {
        echo "Successfully create post!";

    } else die ("Insert post failed!");
}