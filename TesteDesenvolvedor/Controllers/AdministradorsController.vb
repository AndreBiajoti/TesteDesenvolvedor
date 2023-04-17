Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports TesteDesenvolvedor

Namespace Controllers
    Public Class AdministradorsController
        Inherits System.Web.Mvc.Controller

        Private db As New TesteDesenvolvedorBDEntities

        ' GET: Administradors
        Function Index() As ActionResult
            Return View(db.Administradors.ToList())
        End Function

        ' GET: Administradors/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim administrador As Administrador = db.Administradors.Find(id)
            If IsNothing(administrador) Then
                Return HttpNotFound()
            End If
            Return View(administrador)
        End Function



        ' GET: Administradors/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim administrador As Administrador = db.Administradors.Find(id)
            If IsNothing(administrador) Then
                Return HttpNotFound()
            End If
            Return View(administrador)
        End Function

        ' POST: Administradors/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="idAdministrador,Nome,senha")> ByVal administrador As Administrador) As ActionResult
            If ModelState.IsValid Then
                db.Entry(administrador).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Details/1")
            End If
            Return View(administrador)
        End Function



        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
