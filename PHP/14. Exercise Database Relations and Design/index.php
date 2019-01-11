<h2>Home</h2>
<?php
include "connect-db.php";
include "hearder.php";

if (!$result) die ('Cannot read `posts` table from MySQL');

echo "<table border='2' '>\n";
echo "<tr><th>№</th><th>Title</th><th>Content</th><th>Date</th></tr>";
while ($row = $result->fetch_assoc()) {
    $title = htmlspecialchars($row['title']);
    $content = htmlspecialchars($row['content']);
    $date = htmlspecialchars($row['create_date']);
    $id = htmlspecialchars($row['post_id']);

    echo "<tr>
                <td>$id</td>
                <td>$title</td>
                <td>$content</td>
                <td>$date</td>
           </tr>";
}

echo "</table>";