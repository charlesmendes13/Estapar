// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    // Mask

    $("#Placa").mask("AAA 9A99");
    $("#Cpf").mask("999.999.999-99");

    // UpperCase

    $("#Placa").keyup(function () {
        $(this).val($(this).val().toUpperCase());
    });

});