<?php

header("Content-type: text/html; charset=utf-8");

if ($_SERVER['REQUEST_METHOD'] == 'GET') {
    if (!isset($_GET['steamid'])) {
        http_response_code(403);
    } elseif (isset($_GET['check'])) {
        $file = __DIR__ . '/data/' . $_GET['steamid'] . '/' . 'config.cfg';
        is_dir(__DIR__ . '/data/' . $_GET['steamid']) OR mkdir(__DIR__ . '/data/' . $_GET['steamid'], 0777, true);
        echo file_exists($file) ? filectime($file) : 0;
    } elseif (isset($_GET['download'])) {
        if(!isset($_GET['file'])) {
            http_response_code(403);
            exit;
        }
        $file = __DIR__ . '/data/' . $_GET['steamid'] . '/' . $_GET['file'];
        $data = @file_get_contents($file);
        echo $data;
    } else {
        http_response_code(403);
    }
} elseif ($_SERVER['REQUEST_METHOD'] == 'POST') {
    if (!isset($_POST['steamid']) || !isset($_POST['upload']) || !isset($_POST['filecfg']) || !isset($_POST['streams'])) {
        //http_response_code(403);
        echo "success:" . PHP_EOL;
        print_r($_POST);
        exit;
    }
    is_dir(__DIR__ . '/data/' . $_POST['steamid']) OR mkdir(__DIR__ . '/data/' . $_POST['steamid'], 0777, true);
    $file = __DIR__ . '/data/' . $_POST['steamid'] . '/' . $_POST['filecfg'];
    !file_exists($file) or unlink($file);
    file_put_contents($file, $_POST['streams']);
    echo 'success: uploaded ' . $_POST['filecfg'] . ' from ' . $_POST['steamid'];
} else {
    http_response_code(404);
    exit;
}

?>
