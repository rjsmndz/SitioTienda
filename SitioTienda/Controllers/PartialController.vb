Imports System.Web.Mvc

Namespace Controllers
    Public Class PartialController
        Inherits Controller

        ' GET: Partial
        Function Categorias() As PartialViewResult
            Return PartialView()
        End Function
    End Class
End Namespace