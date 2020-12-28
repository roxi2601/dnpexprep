#pragma checksum "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\AddVolume.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a5bccdabe33117d91b3c45c73c21316c0598a3b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\AddVolume.razor"
using VolumeWeb.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\AddVolume.razor"
using VolumeWeb.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddVolume")]
    public partial class AddVolume : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\HUAWEI\dnpexprep\dnpexprep\VolumeWeb\Pages\AddVolume.razor"
       
    private VolumeResult newVolume = new VolumeResult();
    private string errorMessage;

    private async Task AddNewVolume()
    {
        errorMessage = "";
        try
        {
            if (newVolume.Height==0 || newVolume.Radius==0) 
            {
                throw new Exception("Specify height and radius, cannot be 0");
            }
            if (String.IsNullOrEmpty(newVolume.Type))
            {
                throw  new Exception("Specify type, it can be 'cylinder' or 'cone' :)");
            }
            await IVolumesService.AddVolumeAsync(newVolume);
            NavigationManager.NavigateTo("/Volumes");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            errorMessage = e.Message;
        }
        
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVolumesService IVolumesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
