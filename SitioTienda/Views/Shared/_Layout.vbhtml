<!DOCTYPE html>
<html>
<head>
    <title>Mi Tienda</title>
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css" media="all" />
    <!-- Custom Theme files -->
    <!--theme-style-->
    <link href="~/Content/style.css" rel="stylesheet" type="text/css" media="all" />
    <!--//theme-style-->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="Mi Tienda" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!--theme-style-->
    <link href="~/Content/style4.css" rel="stylesheet" type="text/css" media="all" />
    <!--//theme-style-->
    <script src="~/Scripts/jquery.min.js"></script>
    <!--- start-rate---->
    <script src="~/Scripts/jstarbox.js"></script>
    <link rel="stylesheet" href="~/Content/jstarbox.css" type="text/css" media="screen" charset="utf-8" />
    <script type="text/javascript">
			jQuery(function() {
			jQuery('.starbox').each(function() {
				var starbox = jQuery(this);
					starbox.starbox({
					average: starbox.attr('data-start-value'),
					changeable: starbox.hasClass('unchangeable') ? false : starbox.hasClass('clickonce') ? 'once' : true,
					ghosting: starbox.hasClass('ghosting'),
					autoUpdateAverage: starbox.hasClass('autoupdate'),
					buttons: starbox.hasClass('smooth') ? false : starbox.attr('data-button-count') || 5,
					stars: starbox.attr('data-star-count') || 5
					}).bind('starbox-value-changed', function(event, value) {
					if(starbox.hasClass('random')) {
					var val = Math.random();
					starbox.next().text(' '+val);
					return val;
					}
				})
			});
		});
    </script>
    <!---//End-rate---->

</head>
<body>
    <!--header-->
    <div class="header">
        <div class="container">
            <div class="head">
                <div class=" logo">
                    <a href="index.html"><img src="~/images/logo.png" alt=""></a>
                </div>
            </div>
        </div>
        <div class="header-top">
            <div class="container">
                <div class="col-sm-5 col-md-offset-2  header-login">
                    <ul>
                        <li><a href="login.html">Ingresar</a></li>
                        <li><a href="register.html">Registrarse</a></li>
                        <li><a href="checkout.html">Ordenar</a></li>
                    </ul>
                </div>

                <div class="col-sm-5 header-social">
                    <ul>
                        <li><a href="#"><i></i></a></li>
                        <li><a href="#"><i class="ic1"></i></a></li>
                        <li><a href="#"><i class="ic2"></i></a></li>
                        <li><a href="#"><i class="ic3"></i></a></li>
                        <li><a href="#"><i class="ic4"></i></a></li>
                    </ul>

                </div>
                <div class="clearfix"> </div>
            </div>
        </div>

        <div class="container">

            <div class="head-top">

                <div class="col-sm-8 col-md-offset-2 h_menu4">
                    <nav class="navbar nav_bottom" role="navigation">

                        <!-- Brand and toggle get grouped for better mobile display -->
                        <div class="navbar-header nav_2">
                            <button type="button" class="navbar-toggle collapsed navbar-toggle1" data-toggle="collapse" data-target="#bs-megadropdown-tabs">
                                <span class="sr-only">Toggle navigation</span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                            </button>

                        </div>
                        <!-- Collect the nav links, forms, and other content for toggling -->
                        <div class="collapse navbar-collapse" id="bs-megadropdown-tabs">
                            <ul class="nav navbar-nav nav_1">
                                <li><a class="color" href="index.html">Inicio</a></li>

                                <li class="dropdown mega-dropdown active">
                                    <a class="color1" href="#" class="dropdown-toggle" data-toggle="dropdown">Mujer<span class="caret"></span></a>
                                    <div class="dropdown-menu ">
                                        <div class="menu-top">
                                            <div class="col1">
                                                <div class="h_nav">
                                                    <h4>Casual</h4>
                                                    <ul>
                                                        <li><a href="product.html">Blusas</a></li>
                                                        <li><a href="product.html">Pantalones</a></li>
                                                        <li><a href="product.html">Jackets y Abrigos</a></li>
                                                        <li><a href="product.html">Accesorios</a></li>
                                                    </ul>
                                                </div>
                                            </div>
                                            <div class="col1">
                                                <div class="h_nav">
                                                    <h4>Deportiva</h4>
                                                    <ul>
                                                        <li><a href="product.html">Sudaderas</a></li>
                                                        <li><a href="product.html">Licras</a></li>
                                                        <li><a href="product.html">Camisetas</a></li>
                                                        <li><a href="product.html">Accesorios</a></li>
                                                    </ul>
                                                </div>
                                            </div>
                                            <div class="col1">
                                                <div class="h_nav">
                                                    <h4>Infantil</h4>
                                                    <ul>
                                                        <li><a href="product.html">Camisetas</a></li>
                                                        <li><a href="product.html">Pantalones</a></li>
                                                        <li><a href="product.html">Shorts</a></li>
                                                        <li><a href="product.html">Abrigos</a></li>
                                                        <li><a href="product.html">Bebé</a></li>
                                                        <li><a href="product.html">Accesorios</a></li>

                                                    </ul>

                                                </div>
                                            </div>
                                            <div class="col1">
                                                <div class="h_nav">
                                                    <h4>A la Medida</h4>
                                                    <ul>
                                                        <li><a href="product.html">Solicitud</a></li>
                                                    </ul>
                                                </div>
                                            </div>
                                            <div class="col1 col5">
                                                <img src="~/images/me.png" class="img-responsive" alt="">
                                            </div>
                                            <div class="clearfix"></div>
                                        </div>
                                    </div>
                                </li>
                                <li class="dropdown mega-dropdown active">
                                    <a class="color2" href="#" class="dropdown-toggle" data-toggle="dropdown">Hombre<span class="caret"></span></a>
                                    <div class="dropdown-menu mega-dropdown-menu">
                                        <div class="menu-top">
                                            <div class="col1">
                                                <div class="h_nav">
                                                    <h4>Submenu1</h4>
                                                    <ul>
                                                        <li><a href="product.html">Accessories</a></li>
                                                        <li><a href="product.html">Bags</a></li>
                                                        <li><a href="product.html">Caps & Hats</a></li>
                                                        <li><a href="product.html">Hoodies & Sweatshirts</a></li>

                                                    </ul>
                                                </div>
                                            </div>
                                            <div class="col1">
                                                <div class="h_nav">
                                                    <h4>Submenu2</h4>
                                                    <ul>
                                                        <li><a href="product.html">Jackets & Coats</a></li>
                                                        <li><a href="product.html">Jeans</a></li>
                                                        <li><a href="product.html">Jewellery</a></li>
                                                        <li><a href="product.html">Jumpers & Cardigans</a></li>
                                                        <li><a href="product.html">Leather Jackets</a></li>
                                                        <li><a href="product.html">Long Sleeve T-Shirts</a></li>
                                                    </ul>
                                                </div>
                                            </div>
                                            <div class="col1">
                                                <div class="h_nav">
                                                    <h4>Submenu3</h4>

                                                    <ul>
                                                        <li><a href="product.html">Shirts</a></li>
                                                        <li><a href="product.html">Shoes, Boots & Trainers</a></li>
                                                        <li><a href="product.html">Sunglasses</a></li>
                                                        <li><a href="product.html">Sweatpants</a></li>
                                                        <li><a href="product.html">Swimwear</a></li>
                                                        <li><a href="product.html">Trousers & Chinos</a></li>

                                                    </ul>

                                                </div>
                                            </div>
                                            <div class="col1">
                                                <div class="h_nav">
                                                    <h4>Submenu4</h4>
                                                    <ul>
                                                        <li><a href="product.html">T-Shirts</a></li>
                                                        <li><a href="product.html">Underwear & Socks</a></li>
                                                        <li><a href="product.html">Vests</a></li>
                                                        <li><a href="product.html">Jackets & Coats</a></li>
                                                        <li><a href="product.html">Jeans</a></li>
                                                        <li><a href="product.html">Jewellery</a></li>
                                                    </ul>
                                                </div>
                                            </div>
                                            <div class="col1 col5">
                                                <img src="~/images/me1.png" class="img-responsive" alt="">
                                            </div>
                                            <div class="clearfix"></div>
                                        </div>
                                    </div>
                                </li>
                                <li><a class="color3" href="product.html">Promociones</a></li>
                                <li><a class="color4" href="404.html">Nosotros</a></li>
                                <li><a class="color6" href="contact.html">Contacto</a></li>
                            </ul>
                        </div><!-- /.navbar-collapse -->

                    </nav>
                </div>
                <div class="col-sm-2 search-right">
                    <ul class="heart">
                        <li>
                            <a href="wishlist.html">
                                <span class="glyphicon glyphicon-heart" aria-hidden="true"></span>
                            </a>
                        </li>
                        <li><a class="play-icon popup-with-zoom-anim" href="#small-dialog"><i class="glyphicon glyphicon-search"> </i></a></li>
                    </ul>
                    <div class="cart box_1">
                        <a href="checkout.html">
                            <h3>
                                <div class="total">
                                    <span class="simpleCart_total"></span>
                                </div>
                                <img src="~/images/cart.png" alt="" />
                            </h3>
                        </a>
                        <p><a href="javascript:;" class="simpleCart_empty">Carrito vacío</a></p>

                    </div>
                    <div class="clearfix"> </div>

                    <!----->
                    <!---pop-up-box---->
                    <link href="~/Content/popuo-box.css" rel="stylesheet" type="text/css" media="all" />
                    <script src="~/Scripts/jquery.magnific-popup.js" type="text/javascript"></script>
                    <!---//pop-up-box---->
                    <div id="small-dialog" class="mfp-hide">
                        <div class="search-top">
                            <div class="login-search">
                                <input type="submit" value="">
                                <input type="text" value="Buscar.." onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Buscar..';}">
                            </div>
                            <p>Mi Tienda</p>
                        </div>
                    </div>
                    <script>
			$(document).ready(function() {
			$('.popup-with-zoom-anim').magnificPopup({
			type: 'inline',
			fixedContentPos: false,
			fixedBgPos: true,
			overflowY: 'auto',
			closeBtnInside: true,
			preloader: false,
			midClick: true,
			removalDelay: 300,
			mainClass: 'my-mfp-zoom-in'
			});

			});
                    </script>
                    <!----->
                </div>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <!--banner-->
    <div class="banner">
        <div class="container">
            <section class="rw-wrapper">
                <h1 class="rw-sentence">
                    <span>Moda &amp; Belleza</span>
                    <div class="rw-words rw-words-1">
                        <span>Diseños Únicos</span>
                        <span>Creamos Estilo</span>
                        <span>A tu Gusto</span>
                        @*<span>Nemo enim ipsam</span>
                        <span>Temporibus autem</span>
                        <span>intelligent systems</span>*@
                    </div>
                    <div class="rw-words rw-words-2">
                        <span>Nuestra Ropa...</span>
                        <span>... Tu Estilo</span>
                        @*<span>Sed ut perspiciatis unde</span>
                        <span>There are many variation</span>
                        <span>The generated Lorem Ipsum</span>
                        <span>Excepteur sint occaecat</span>*@
                    </div>
                </h1>
            </section>
        </div>
    </div>
    <!--content-->
    <div class="content">
        @RenderBody()
    </div>
    <!--//content-->
    <!--//footer-->
    <div class="footer">
        <div class="footer-middle">
            <div class="container">
                <div class="col-md-3 footer-middle-in">
                    <a href="index.html"><img src="~/images/log.png" alt=""></a>
                    <p>Creamos moda a tu estilo</p>
                </div>

                <div class="col-md-3 footer-middle-in">
                    <h6>Información</h6>
                    <ul class=" in">
                        <li><a href="404.html">Nosotros</a></li>
                        <li><a href="contact.html">Contacto</a></li>
                        <li><a href="#">Devoluciones</a></li>
                        <li><a href="contact.html">Mapa del Sitio</a></li>
                    </ul>
                    <ul class="in in1">
                        <li><a href="#">Mis ördenes</a></li>
                        <li><a href="wishlist.html">Lista de Deseos</a></li>
                        <li><a href="login.html">Ingresar</a></li>
                    </ul>
                    <div class="clearfix"></div>
                </div>
                <div class="col-md-3 footer-middle-in">
                    <h6>Etiquetas</h6>
                    <ul class="tag-in">
                        <li><a href="#">Ropa</a></li>
                        <li><a href="#">Moda</a></li>
                        <li><a href="#">Tshirt</a></li>
                        <li><a href="#">Shorts</a></li>
                        <li><a href="#">Accesorios</a></li>
                    </ul>
                </div>
                <div class="col-md-3 footer-middle-in">
                    <h6>Boletin</h6>
                    <span>Subscribase para recibir novedades</span>
                    <form>
                        <input type="text" value="Ingrese su e-mail" onfocus="this.value='';" onblur="if (this.value == '') {this.value ='Ingrese su E-Mail';}">
                        <input type="submit" value="Subscribirme">
                    </form>
                </div>
                <div class="clearfix"> </div>
            </div>
        </div>
        <div class="footer-bottom">
            <div class="container">
                <ul class="footer-bottom-top">
                    <li><a href="#"><img src="~/images/f1.png" class="img-responsive" alt=""></a></li>
                    <li><a href="#"><img src="~/images/f2.png" class="img-responsive" alt=""></a></li>
                    <li><a href="#"><img src="~/images/f3.png" class="img-responsive" alt=""></a></li>
                </ul>
                <p class="footer-class">&copy; 2016 Mi Tienda. Todos los derechos reservado | Diseño por  <a href="http://w3layouts.com/" target="_blank">MI tienda</a> </p>
                <div class="clearfix"> </div>
            </div>
        </div>
    </div>
    <!--//footer-->
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="~/Scripts/simpleCart.min.js"> </script>
    <!-- slide -->
    <script src="~/Scripts/bootstrap.min.js"></script>
    <!--light-box-files -->
    <script src="~/Scripts/jquery.chocolat.js"></script>
    <link rel="stylesheet" href="~/Content/chocolat.css" type="text/css" media="screen" charset="utf-8">
    <!--light-box-files -->
    <script type="text/javascript" charset="utf-8">
		$(function() {
			$('a.picture').Chocolat();
		});
    </script>


</body>
</html>