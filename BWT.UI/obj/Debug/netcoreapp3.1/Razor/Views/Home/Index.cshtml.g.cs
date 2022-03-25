#pragma checksum "C:\Users\carna\Documents\GitHub\BWT.UI\BWT.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5518c3c9a01a9f3624cd0a82d55550ca169c558e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\carna\Documents\GitHub\BWT.UI\BWT.UI\Views\_ViewImports.cshtml"
using BWT.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carna\Documents\GitHub\BWT.UI\BWT.UI\Views\_ViewImports.cshtml"
using BWT.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5518c3c9a01a9f3624cd0a82d55550ca169c558e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eb82a96f1e83ec36c8809708bf4ef116213c1cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\carna\Documents\GitHub\BWT.UI\BWT.UI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5518c3c9a01a9f3624cd0a82d55550ca169c558e3403", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Black Warriors Team</title>
    <!--Favicons-->
    <link rel=""icon"" type=""image/png"" sizes=""32x32"" href=""./img/favicon.ico"">
    <!--CDN Font awesome-->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css"" />
    <!--CSS Bootstrap-->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""./css/style.css"">


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5518c3c9a01a9f3624cd0a82d55550ca169c558e5142", async() => {
                WriteLiteral(@"
    <!--Navbar-->
    <!--<section class=""navbar fixed-top navbar-expand-lg navbar-dark p-md-2"">
        <div class=""container"">
            <a href=""#"" class=""navbar-brand"">
                <img src=""./img/logo2.0.svg"" alt=""Brand Black Warriors Team"">
            </a>
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#mainNav"" aria-controls=""mainNav"" aria-expanded=""false"" aria-label=""Barra de navegación"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""mainNav"">
                <div class=""nav ms-auto"">
                    <a href=""#menu"" class=""nav-link active"">Inicio</a>
                    <a href=""#colaboradores"" class=""nav-link"">Colaboradores</a>
                    <a href=""#patrocinadores"" class=""nav-link"">Patrocinadores</a>
                    <a href=""#faq"" class=""nav-link"">FAQ</a>
                    <a href=""#"" class=""nav-link"">Login</a>
         ");
                WriteLiteral(@"       </div>
            </div>
        </div>
    </section>-->
    <!--Banner Image NO-->
    <!--<div>
        <div class=""banner-image w-100 vh-100 d-flex justify-content-center align-items-center"">
            <div class=""content text-center"">
                <h2 class=""frase""><span class=""typed""></span></h2>
            </div>
        </div>
        <div>
            <img class=""logoimg"" src=""/img/Black Warriors Team.png"">
        </div>
    </div>-->
    <!--BANNER FINAL-->
    <section id=""menu"">
        <div class=""banner-image vh-100 justify-content-center"">
            <div class=""bprueba"">
                <h2 class=""btext""><span class=""typed""></span></h2>
                <p class=""btext"">

                </p>
                <div id=""carouselExampleSlidesOnly"" class=""carousel slide carousel-fade logoimg"" data-bs-ride=""carousel"">
                    <div class=""carousel-inner"">
                        <div class=""carousel-item active"">
                            <img sr");
                WriteLiteral(@"c=""./img/codm.png"" class=""d-block w-100"" alt=""..."">
                        </div>
                        <div class=""carousel-item"">
                            <img src=""./img/clash.png"" class=""d-block w-100"" alt=""..."">
                        </div>
                        <div class=""carousel-item"">
                            <img src=""./img/wz.png"" class=""d-block w-100"" alt=""..."">
                        </div>
                        <div class=""carousel-item"">
                            <img src=""./img/lol2.png"" class=""d-block w-100"" alt=""..."">
                        </div>
                    </div>
                </div>
                <button class=""boton btn btn-warning"" type=""button"">Descubrelo</button>
            </div>
        </div>
    </section>

    <!-- Colaboradores -->
    <section class=""mt-5"" id=""colaboradores"">
        <p class=""text-center titulo"">Colaboradores</p>
        <div class=""container my-5 d-grid gap-3"">
            <div class=""card-group text-bla");
                WriteLiteral(@"ck"">
                <div class=""card"">
                    <img src=""./img/ded.jpg"" class=""card-img-top"" alt=""..."">
                    <div class=""card-img-overlay"">
                        <h5 class=""card-title ctext"">Ded</h5>
                    </div>
                </div>
                <div class=""card"">
                    <img src=""./img/vegetta.jpg"" class=""card-img-top"" alt=""..."">
                    <div class=""card-img-overlay"">
                        <h5 class=""card-title ctext"">Vegetta777</h5>
                    </div>
                </div>
                <div class=""card"">
                    <img src=""./img/juan.png"" class=""card-img-top"" alt=""..."">
                    <div class=""card-img-overlay"">
                        <h5 class=""card-title ctext"">JuanSGuarnizo</h5>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Clients-->
    <section class="" mt-5"" id=""patrocinadores"">
        <!--Brands-->
        ");
                WriteLiteral(@"<div class=""container-fluid"">
            <div class=""row"">
                <p class=""text-center titulo"">Patrocinadores</p>
                <!-- Elements-->
                <a href=""#"" class=""col-sm-5 col-md-3 top-50 text-center"">
                    <img class=""bsponsors"" src=""./img/nvidia.png"" alt=""Nvidia"" class=""w-25"">
                </a>
                <a href=""#"" class=""col-sm-5 col-md-3 top-50 text-center"">
                    <img class=""bsponsors"" src=""./img/intel.png"" alt=""Intel"" class=""w-25"">
                </a>
                <a href=""#"" class=""col-sm-5 col-md-3 top-50 text-center"">
                    <img class=""bsponsors"" src=""./img/hp.png"" alt=""Hp"" class=""w-25"">
                </a>
                <a href=""#"" class=""col-sm-5 col-md-3 top-50 text-center"">
                    <img class=""bsponsors"" src=""./img/tencent.png"" alt=""tencent"" class=""w-25"">
                </a>
            </div>

        </div>
    </section>
    <!--FAQ-->
    <section id=""faq"" class=""contain");
                WriteLiteral(@"er"">
        <div>
            <div class=""row"">
                <!--Titulo-->
                <p class=""text-center titulo col-12"">FAQ</p>

                <p class=""text-left wtext col-6"">¿Cómo puedo unirme?</p>
                <p class=""text-left qtext"">Simplemente registrate y forma parte de nuestra comunidad</p>
                <p class=""text-left wtext col-6"">¿Puedo crear mi propio clan?</p>
                <p class=""text-left qtext"">Sí, tenemos diferentes juegos en los cuales puedes crear tus clanes.</p>
                <p class=""text-left wtext col-6"">¿Cuantas miembros pueden pertenecer a las alianzas?</p>
                <p class=""text-left qtext"">El número de miembros depende de la cantidad que permita cada juego.</p>
            </div>
        </div>
    </section>
    <!--Footer-->
    <footer class=""text-white"">
        <div class=""container-fluid "">
            <nav class=""row foo"">
                <!--Logo-->
                <a href=""#"" class=""col-3 text-reset text-uppercase");
                WriteLiteral(@" d-flex align-items-center"">
                    <img src=""./img/Black Warriors Team.png"" alt=""Logo Black Warriors Team"" class=""logoimg"">
                </a>
                <!--Menu-->
                <!--<ul class=""col-3 list-unstyled"">
                    <li class=""font-weight-bold text-uppercase"">
                        Recursos
                    </li>-->
");
                WriteLiteral(@"                <!--</ul>-->
                <!--Menu-->
                <ul class=""col-3 list-unstyled"">
                    <li class=""font-weight-bold text-uppercase"">
                        Vendedores Oficiales
                    </li>
                    <li><a href=""#"" class=""text-resert"">HyperX</a></li>
                    <li><a href=""#"" class=""text-resert"">Razer</a></li>
                    <li><a href=""#"" class=""text-resert"">GameCraft</a></li>
                    <li><a href=""#"" class=""text-resert"">LogiTech</a></li>
                    <li><a href=""#"" class=""text-resert"">HP</a></li>
                </ul>
                <!--Redes-->
                <ul class=""col-3 list-unstyled"">
                    <li class=""font-weight-bold text-uppercase"">
                        Redes sociales
                    </li>
                    <li>
                        <!--FB-->
                        <a href=""#"" class=""text-resert""><i class=""fa-brands fa-facebook-f""></i></a>
             ");
                WriteLiteral(@"           <!--Twitter-->
                        <a href=""#"" class=""text-resert""><i class=""fa-brands fa-twitter""></i></a>
                        <!--Youtube-->
                        <a href=""#"" class=""text-resert""><i class=""fa-brands fa-youtube""></i></a>
                        <!--Discord-->
                        <a href=""#"" class=""text-resert""><i class=""fa-brands fa-discord""></i></a>
                        <!--Instagram-->
                        <a href=""#"" class=""text-resert""><i class=""fa-brands fa-instagram""></i></a>
                    </li>
                </ul>
            </nav>
        </div>
    </footer>


    <!--Script Bootstrap-->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/typed.js@2.0.12""></script>
    <script src=""./js/main.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
