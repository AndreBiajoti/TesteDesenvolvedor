@ModelType TesteDesenvolvedor.Administrador
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Seu perfil</h2>

<div>
    <h4>Administrador</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nome)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.senha)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.senha)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Editar perfil", "Edit", New With {.id = Model.idAdministrador}) 
    
</p>
