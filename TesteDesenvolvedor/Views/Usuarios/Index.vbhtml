@ModelType IEnumerable(Of TesteDesenvolvedor.Usuario)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Cadastro de usuário(s)</h2>

<p>
    @Html.ActionLink("Cadastrar novo usuário", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nome)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Idade)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Cidade)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Nome)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Idade)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Cidade)
        </td>
        <td>
            @Html.ActionLink("Editar", "Edit", New With {.id = item.idUsuario}) |
            @Html.ActionLink("Detalhes", "Details", New With {.id = item.idUsuario}) |
            @Html.ActionLink("Excluir", "Delete", New With {.id = item.idUsuario})
        </td>
    </tr>
Next

</table>
