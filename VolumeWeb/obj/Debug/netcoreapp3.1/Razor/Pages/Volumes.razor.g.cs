#pragma checksum "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\Volumes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9253d70cb4d61a1761cb5cbc8cfc4b0f76a8cbe"
// <auto-generated/>
#pragma warning disable 1591
namespace VolumeWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\_Imports.razor"
using VolumeWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\_Imports.razor"
using VolumeWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\Volumes.razor"
using VolumeWeb.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\Volumes.razor"
using VolumeWeb.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Volumes")]
    public partial class Volumes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 id=\"ListPerson\">Volume List</h3>\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\Volumes.razor"
 if (results == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>\r\n    <em> Loading.. </em>\r\n    </p>\r\n");
#nullable restore
#line 13 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\Volumes.razor"
}
else if (!results.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<p>\r\n        <em>No volumes exist, Please add some.</em>\r\n    </p>\r\n");
#nullable restore
#line 19 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\Volumes.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table");
            __builder.AddMarkupContent(8, "\r\n\r\n        ");
            __builder.AddMarkupContent(9, "<tr>\r\n            <th>Id</th>\r\n            <th>Type</th>\r\n            <th>Height</th>\r\n            <th>Radius</th>\r\n            <th>Volume</th>\r\n        </tr>\r\n\r\n    ");
            __builder.OpenElement(10, "tbody");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 33 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\Volumes.razor"
     foreach (var volume in results)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "        ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 36 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\Volumes.razor"
         volume.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 37 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\Volumes.razor"
         volume.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 38 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\Volumes.razor"
         volume.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 39 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\Volumes.razor"
         volume.Radius

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 40 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\Volumes.razor"
         volume.Volume

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 42 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\Volumes.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 45 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\Volumes.razor"
      
         }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\Volumes.razor"
       
    private IList<VolumeResult> results;
    
    protected override async Task OnInitializedAsync()
    {
        results = await VolumesService.GetVolumes();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVolumesService VolumesService { get; set; }
    }
}
#pragma warning restore 1591
