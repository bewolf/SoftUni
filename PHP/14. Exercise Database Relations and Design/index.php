<h2>Home</h2>
<?php
include "connect-db.php";
include "hearder.php";

if (!$result) die ('Cannot read `posts` table from MySQL');

echo "<table border='2' '>\n";
echo "<tr><th>Title</th><th>Content</th><th>Date</th><th>Edit Post</th><th>Delete Post</th></tr>";
while ($row = $result->fetch_assoc()) {
    $title = htmlspecialchars($row['title']);
    $content = htmlspecialchars($row['content']);
    $date = htmlspecialchars($row['create_date']);


    echo "<tr><td>$title</td><td>$content</td><td>$date</td><td>Edit Post</td><td><a href='$id'>Delete Post</a> </td></tr>";

}

echo "</table>";