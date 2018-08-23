$(document).ready(function () {
    $('#Gender').on('change', function () {

        var selectedGender = $('#Gender').val();
                             
            filterProperties(selectedGender);
    });

    $('#PropertyType').on('change', function () {

        var propType = $('#PropertyType').val();
        console.log(propType);
        
        $.ajax({
            url: '/Home/Index',
            data: { propertyType : propType },
            cache: false,
            type: "POST",
            dataType: "html",

            success: function (data, textStatus, XMLHttpRequest)
            {
                console.log("Success");
                $("#propertyContainer").html(data); // HTML DOM replace
            }
        });
         
    });
});

function filterProperties(filter) {
    
    
    table = document.getElementById("propertyListing");
    tr = table.getElementsByTagName("tr");

    // Loop through all table rows, and hide those who don't match the search query
    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[0];
        if (td)
        {
            
            if ($.trim(td.innerHTML) == filter) {
                tr[i].style.display = "";
            } else {
                if (filter != "All") {
                    tr[i].style.display = "none";
                }
                else {
                    tr[i].style.display = "";
                }
                

            }
        }
    }


}