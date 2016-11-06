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
    End Class
End Namespace