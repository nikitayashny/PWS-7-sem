<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASMX Simplex Service AJAX Call</title>
    <!-- Подключаем jQuery для выполнения AJAX-запросов -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            // Обработчик клика на кнопке
            $("#submitBtn").click(function (e) {
                e.preventDefault(); // Предотвращаем стандартное поведение кнопки

                // Получаем значения из полей ввода
                var x = $("#xValue").val();
                var y = $("#yValue").val();

                // Формируем JSON-запрос
                var dataToSend = JSON.stringify({ x: parseInt(x), y: parseInt(y) });


                // Выполняем AJAX-запрос
                $.ajax({
                    type: "POST",
                    url: "http://localhost:4325/Simplex.asmx/AddS", 
                    data: JSON.stringify({ req: JSON.stringify({ x: parseInt(x), y: parseInt(y) }) }), // Передаем строку JSON в качестве параметра 'req'
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {
                        // Отображаем результат (только значение sumres)
                        $("#result").text("Result: " + response.d);
                    },
                    error: function (xhr, status, error) {
                        // Обработка ошибок
                        console.log(xhr.responseText);
                        $("#result").text("Error: " + error);
                    }
                });

            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>ASMX Service AJAX Example</h2>
            <label for="xValue">Enter X:</label>
            <input type="text" id="xValue" /><br />
            <label for="yValue">Enter Y:</label>
            <input type="text" id="yValue" /><br />
            <button id="submitBtn">Calculate Sum</button><br /><br />
            <div id="result"></div>
        </div>
    </form>
</body>
</html>
