$(function () {

    $('.numbers').on("click", function () {
        var numb = $(this).text();
        var firstNumb = $('#firstNumb').val();
        if ($('#result').val() !== "null") {
            $('#calcul').val("");
            $('#result').val("null");
        }
        $('#calcul').val($('#calcul').val() + numb);
        if ($('#calcNumb').val() === "null" && $('#SecondNumb').val() === "null") {
            $('#firstNumb').val($('#calcul').val());
        }
        else {
            $('#SecondNumb').val($('#calcul').val());
        }
        console.log($('#firstNumb').val());
        console.log($('#SecondNumb').val());
        console.log($('#result').val());
    });

    $('.methodOfCulc').on("click", function () {
        var numb = $('#calcul').val();
        var text = $(this).text();
        var res;
        $('#formula').text($('#formula').text() + $('#calcul').val());             
        var last = $('#formula').text().slice(-1);
        if (last.length !== 0) {
            // в случае ввода знака повторно, меняет его в формуле
            if (isFinite(last)) {
                $('#formula').text($('#formula').text() + text);
            }
            else {
                $('#formula').text($('#formula').text().replace(/.$/, text));
            }
        }
        if ($('#calcNumb').val() === "null") {
            $('#calcNumb').val(text);
        }
        calculate();
        $('#calcNumb').val(text);
    });

    function calculate() {
        if ($('#SecondNumb').val() !== "null") {
            switch ($('#calcNumb').val()) {
                case "+":
                    res = $('#firstNumb').val() + $('#SecondNumb').val();
                    break;
                case "*":
                    res = $('#firstNumb').val() * $('#SecondNumb').val();
                    break;
                case "-":
                    res = $('#firstNumb').val() - $('#SecondNumb').val();
                    break;
                case "/":
                    if ($('#SecondNumb').val() !== "0") {
                        res = $('#firstNumb').val() / $('#SecondNumb').val();
                    }
                    else {
                        res = "Cannot divide by zero";
                    }
                    break;
            }
            if (res !== "Cannot divide by zero") {
                $('#result').val(res);
                $('#firstNumb').val(res);
                $('#calcul').val(res);
            } 
            else
                alert(res);
        }
        else {
            $('#calcul').val("");
        }
    }

    function clearAll() {
        $('#formula').text("");
        $('#calcul').val("");
        $('#result').val("null");
        $('#firstNumb').val("null");
        $('#SecondNumb').val("null");
        $('#calcNumb').val("null");
    }

    $('#equally').on("click", function () {
        var equally = $(this);
        equally.prop('disabled', 'disabled');
        var numb = $('#calcul').val();
        calculate();
        $('#formula').text($('#formula').text() + numb + "=" + $('#calcul').val());

        var formula = $('#formula').text();
        var data = {
            calcFormula: formula
        };

        if ($('#SecondNumb').val() !== "null" && $('#result').val() !== "null") {
            $.ajax({
                url: '/Home/Index',
                type: "POST",
                data: JSON.stringify(data),
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    console.log(data);
                    clearAll();

                },
                failure: function (data) {
                    console.log(data);
                }
            });
        }
        else {
            clearAll();
        }
        equally.prop('disabled', false);
    });

    $('#clearAll').on("click", function () {
        clearAll();
        $('.methodOfCulc').prop('disable', false);
        $('.numbers').prop('disable', false);
        $('#clearCalc').prop('disable', false);
    });

    $('#clearCalc').on("click", function () {
        $('#calcul').val("");
    });

    $('.expression').on("click", function () {
        var text = $(this).text();
        var result = /[^=]*$/.exec(text)[0];
        $('#firstNumb').val(result);
        $('#result').val(result);
        $('#calcul').val(result);
    });
});