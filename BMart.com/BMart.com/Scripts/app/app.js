(
    function () {

        $(document).ready(function () {
            $("#btnGetProducts").bind("click", loadProducts);

            $('#btnAddProduct').bind("click", addProduct);
            function addProduct() {
                var product = {
                    Id: $("#txtId").val(),
                    Model: $("#model").val(),
                    Description: $("#desc").val(),
                    ImageUrl: $("#ImageUrl").val()
                };
                $.ajax({
                    url: "/wallmart/AddProduct",
                    method: "POST",
                    data: product,
                    success: function (response) {
                        console.log(response);
                        buildTable(response);
                    },
                    error: function (err) {
                        console.log(err);

                    }
                })
            }

            function buildTable(response) {
                $.each(response, function (index, item) {
                    var row = $("<tr>");
                    var id = $("<td>").text(item.Id);
                    var description = $("<td>").text(item.Description);

                    var Model = $("<td>").text(item.Model);
                    $(row).append(id)
                        .append(description)
                        .append(Model);
                    $(productsTable).append(row);
                });
            }
            var productsTable = $("#tblProducts");
            function loadProducts() {

                $.ajax({
                    url: "/wallmart/GetProducts",
                    method: "GET",
                    success: function (response) {
                        console.log(response);
                        buildTable();
                    },
                    error: function (err) {
                        console.log(err);
                    }
                })
            }
        });

    }
)();