Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Index
        Function Index() As ActionResult
            Return View()
        End Function

        Function Productos() As ActionResult
            Return View()
        End Function
        Function Categorias() As PartialViewResult
            Return PartialView()
        End Function

        Function Descuentos() As PartialViewResult
            Return PartialView()
        End Function

        Function Tipos() As PartialViewResult
            Return PartialView()
        End Function

        Function ProductoDetalle() As ActionResult
            Return View()
        End Function
    End Class
End Namespace