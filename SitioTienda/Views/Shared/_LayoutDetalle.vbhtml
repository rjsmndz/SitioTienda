@code
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<!--banner-->
<div class="banner-top">
    <div class="container">
        <h1>Productos</h1>
        <em></em>
        <h2><a href="@Url.Action("Index", "Home")">Inicio</a><label>/</label>Productos</a></h2>
    </div>
</div>

<div class="product">
    <div class="container">
        <div class="col-md-9">
            @RenderBody()
            <div class="clearfix"></div>
        </div>
        <div class="col-md-3 product-bottom">
            <!--categories-->
            @Html.Action("Categorias")
            <!--initiate accordion-->
            <script type="text/javascript">
                $(function () {
                    var menu_ul = $('.menu-drop > li > ul'),
                           menu_a = $('.menu-drop > li > a');
                    menu_ul.hide();
                    menu_a.click(function (e) {
                        e.preventDefault();
                        if (!$(this).hasClass('active')) {
                            menu_a.removeClass('active');
                            menu_ul.filter(':visible').slideUp('normal');
                            $(this).addClass('active').next().stop(true, true).slideDown('normal');
                        } else {
                            $(this).removeClass('active');
                            $(this).next().stop(true, true).slideUp('normal');
                        }
                    });

                });
            </script>
            <!--//menu-->
            <section class="sky-form">
                @Html.Action("Descuentos")
            </section>

            <!---->
            <section class="sky-form">
                @Html.Action("Tipos")
            </section>

        </div>
    </div>

</div>

