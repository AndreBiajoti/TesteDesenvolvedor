@ModelType TesteDesenvolvedor.Usuario
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Detalhes</h2>

<div>
    <h4>Usuário</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nome)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Idade)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Idade)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Cidade)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Cidade)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Editar", "Edit", New With {.id = Model.idUsuario}) |
    @Html.ActionLink("Voltar", "Index")
</p>
