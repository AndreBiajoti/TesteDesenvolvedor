@ModelType TesteDesenvolvedor.Usuario
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Excluir</h2>

<h3>Tem certeza que deseja excluir este usuário?</h3>
<div>

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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Excluir" class="btn btn-default" /> 
             <a href="~/Usuarios" class="btn btn-default">Cancelar</a>
        </div>
    End Using
</div>
