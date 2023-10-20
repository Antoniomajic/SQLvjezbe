

$(document).foundation();

$.ajax('https://localhost:7169/api/v1/Customer',   // request url
    {
        success: function (data, status, xhr) {// success callback function
            // console.log(data);
            for(let i=0;i<data.length;i++){
                $('#data').append('<li>' + data[i].firstName + " " + data[i].lastName + '</li>');
            }
    }
});

$('#add').click();(function(){

    let customer = {firstName: $('#firstName').val(), lastName: $('lastName').val()};

    $.ajax('https://localhost:7169/api/v1/Customer', {
        type: 'POST',  // http method
        dataType: 'json',
        contentType: 'application/json',
        data: { firstName: $('#firstName').val(), lastName: $('lastName').val() },  // data to submit
        success: function (data, status, xhr) {
            $('#data').append('<li>' + $('#firstName').val() + " " + $('lastName').val() + '</li>');
        },
        error: function (jqXhr, textStatus, errorMessage) {
                alert(errorMessage);
        }
    });

    return false;
}); 
