<%@ page contentType="text/html; charset=UTF-8" %>
<html>
    <head>
        <title>Hello Ge</title>
        <link rel="stylesheet" href="../css/site.css"></link>
        <style>
            .margined {
                margin: 15px 0 15px 0;
            }
        </style>
    </head>
    <body class="center">
        <h1 class="larger">${message}</h1>
        <div>Player Score: ${score}</div>
        <div class="margined">DistrictId: ${districtId}</div>
        <div class="margined">DistId 1: ${distId1}</div>
        <div class="margined">DistId 2: ${distId2}</div>
    </body>
</html>