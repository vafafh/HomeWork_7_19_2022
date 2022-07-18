$(document).ready(function () {
    var connection = new signalR.HubConnectionBuilder().withUrl('/chathub').build();

    connection.start();

    connection.on('online', function (id) {
     
        let span = $(`#${id} span`);
        span.addClass('bg-success');
        span.removeClass('bg-secondary');
    })

    connection.on('ofline', function (id) {
        let span = $(`#${id} span`);
        span.removeClass('bg-success');
        span.addClass('bg-secondary');
    })

    $(document).on('click', '.userItem', function () {

        let fullName = $(this).attr("data-userName")
        let userId = $(this).attr('id');
        $('.senderUsername').text(fullName);
        $('#userId').val(userId);
    })



    $(document).on('click', '.sendMessage', function (){

        connection.invoke('Sender', $('#userId').val(),$('#message').val())
        
    })

    connection.on('jsSender', function (id, message) {
        console.log(message)
        let mesaj = $(`<li class="list-group-item">${message}</li>`)

        $(".receiveMessage").append(mesaj);
    })
})