#pragma checksum "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "678fed3f4e54d6f47d464357a9bef4b4af082084"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VerDetalleEquipo), @"mvc.1.0.view", @"/Views/Home/VerDetalleEquipo.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\lkris\TP6\Views\_ViewImports.cshtml"
using TP6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lkris\TP6\Views\_ViewImports.cshtml"
using TP6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"678fed3f4e54d6f47d464357a9bef4b4af082084", @"/Views/Home/VerDetalleEquipo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eee68b3f41481072e20cd15dbb6b2317f1062dc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_VerDetalleEquipo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"jumbotron\">\r\n  <div class=\"container\">\r\n     <div class=\"row\">\r\n        <div class=\"col-md-6 col-12\"><img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 135, "\"", 163, 1);
#nullable restore
#line 4 "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml"
WriteAttributeValue("", 141, ViewBag.Equipo.Escudo, 141, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 164, "\"", 170, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        <div class=\"col-md-6 col-12\"><img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 239, "\"", 269, 1);
#nullable restore
#line 5 "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml"
WriteAttributeValue("", 245, ViewBag.Equipo.Camiseta, 245, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 270, "\"", 276, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n     </div>\r\n  </div>\r\n  <h1 class=\"display-4\">");
#nullable restore
#line 8 "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml"
                   Write(ViewBag.Equipo.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n  <p class=\"lead\">");
#nullable restore
#line 9 "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml"
             Write(ViewBag.Equipo.Continente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n  <hr class=\"my-4\">\r\n  <p>Copas ganadas ");
#nullable restore
#line 11 "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml"
              Write(ViewBag.Equipo.CopasGanadas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n  <a class=\"btn btn-primary btn-lg\"");
            BeginWriteAttribute("href", " href=\'", 521, "\'", 605, 1);
#nullable restore
#line 12 "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml"
WriteAttributeValue("", 528, Url.Action("AgregarJugador","Home", new {IdEquipo=@ViewBag.Equipo.IdEquipo}), 528, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"">
    Agregar Nuevo Jugador
  </a>  
</div>

<table class=""table table-striped"">
  <thead>
    <tr>
      <th scope=""col"">#</th>
      <th scope=""col"">Foto</th>
      <th scope=""col"">Nombre</th>
      <th scope=""col"">Accion</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 27 "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml"
      
        int i=1;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml"
     foreach (Jugador itemJ in ViewBag.Jugadores)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 33 "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml"
                        Write(i++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 1061, "\"", 1079, 2);
            WriteAttributeValue("", 1067, "/", 1067, 1, true);
#nullable restore
#line 34 "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml"
WriteAttributeValue("", 1068, itemJ.Foto, 1068, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\"");
            BeginWriteAttribute("alt", " alt=\"", 1092, "\"", 1098, 0);
            EndWriteAttribute();
            WriteLiteral("> </td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml"
           Write(itemJ.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\'", 1180, "\'", 1284, 1);
#nullable restore
#line 37 "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml"
WriteAttributeValue("", 1187, Url.Action("VerDetalleJugador","Home", new {IdEquipo=itemJ.IdEquipo, IdJugador=itemJ.IdJugador}), 1187, 97, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Ver más Info</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\'", 1346, "\'", 1448, 1);
#nullable restore
#line 38 "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml"
WriteAttributeValue("", 1353, Url.Action("EliminarJugador","Home", new {IdEquipo=itemJ.IdEquipo, IdJugador=itemJ.IdJugador}), 1353, 95, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Eliminar Jugador</a>\r\n                <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#ModalJugador\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1605, "\"", 1647, 3);
            WriteAttributeValue("", 1615, "MostrarJugador(", 1615, 15, true);
#nullable restore
#line 39 "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml"
WriteAttributeValue("", 1630, itemJ.IdJugador, 1630, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1646, ")", 1646, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    Ver Info en Modal\r\n                </button>\r\n                \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\lkris\TP6\Views\Home\VerDetalleEquipo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </tbody>
</table>

<!-- Button trigger modal -->


<!-- Modal -->
<div class=""modal fade"" id=""ModalJugador"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""NombreJugador"">Modal title</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <img class=""img-fluid"" id=""FotoJugador"">
        <div id=""EquipoActual""></div>
        <div id=""FechaNacimiento""></div>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary"">Save changes</button>
      </div>
    </div>
  </div>
</div>

<script>
  function MostrarJugador(IdJ)
  {
    $.ajax(  
        {  ");
            WriteLiteral(@"
            type: 'POST',  
            dataType: 'JSON',  
            url: '/Home/VerDetalleJugadorAjax',  
            data: { IdJugador: IdJ },  
            success:  
                function (response)  
                {  
                    $(""#NombreJugador"").html(response.nombre);
                    $(""#FotoJugador"").attr(""src"", ""/""+response.foto);
                    $(""#EquipoActual"").html(""Equipo Actual: "" + response.equipoActual);
                    $(""#FechaNacimiento"").html(""Fecha de Nacimiento: "" + response.fechaNacimiento.substr(0,9));
                }
        });  
  }
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
