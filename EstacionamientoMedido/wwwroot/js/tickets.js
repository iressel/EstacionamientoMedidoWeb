$(document).on('click', '#comprobante', function () {
    debugger;
    let _clientDocumentNumber = $("input#ClientDocumentNumber").val();
    let _clientName = $("input#ClientName").val();
    let _patent = $("input#Patent").val();
    let _vehicleModel = $("input#VehicleModel").val();
    let _vehicleBrand = $("#BrandId").val();
    let _checkIn = $("input#CheckIn").val();
    let _checkOut = $("input#CheckOut").val();
    let _street = $("input#Street").val();
    let _streetHeight = $("input#StreetHeight").val();
    let _clientEmail = $("input#ClientEmail").val();

    let parameters =
    {
        clientDocumentNumber: _clientDocumentNumber,
        clientName: _clientName,
        patent : _patent,
        vehicleModel : _vehicleModel,
        vehicleBrand : _vehicleBrand,
        checkIn : _checkIn,
        checkOut : _checkOut,
        street : _street,
        streetHeight : _streetHeight,
        clientEmail : _clientEmail
    };

    $.ajax({
        type: "POST",
        dataType: 'json',
        url: "/Tickets/Create",
        data: parameters,
        async: false,
        success: function (result) {
            debugger;
            let _ticketId = result.ticketId;
            $.ajax({
                type: "GET",
                url: "/Tickets/Comprobante",
                data: { ticketId: _ticketId },
                success: function (data) {
                    debugger;
                    let printWindow = window.open('', '', '_blank');
                    printWindow.document.write(data);
                    printWindow.document.close();
                    printWindow.print();
                    window.location.href = "/Tickets/Index";
                },
                error: function (error) {
                    debugger;
                    console.log(error);
                }
            });
        },
        error: function (error) {
            alert(error);
        }
    });
});