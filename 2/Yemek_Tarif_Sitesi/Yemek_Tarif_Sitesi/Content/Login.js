// Sayfa yüklendiğinde çalışacak işlemler
$(document).ready(function () {
    // Kullanıcı adı alanının üzerine gelindiğinde
    $("label[for='Username']").hover(
        function () {
            $(this).css("font-size", "20px");
        },
        function () {
            $(this).css("font-size", "inherit");
        }
    );

    // Parola alanının üzerine gelindiğinde
    $("label[for='Password']").hover(
        function () {
            $(this).css("font-size", "20px");
        },
        function () {
            $(this).css("font-size", "inherit");
        }
    );
});