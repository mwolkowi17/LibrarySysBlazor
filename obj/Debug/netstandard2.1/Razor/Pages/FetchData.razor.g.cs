#pragma checksum "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1946864cb7b8e5ed61d1e79a7f11a71590c5fe8"
// <auto-generated/>
#pragma warning disable 1591
namespace LibrarySysClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\_Imports.razor"
using LibrarySysClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\_Imports.razor"
using LibrarySysClient.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Books</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This is the list of Books in the library.</p>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>Ttitle</th>\r\n                <th>Author</th>\r\n                <th>Rented</th>\r\n                <th>Reader ID</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 25 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 28 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\Pages\FetchData.razor"
                         forecast.BookCID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 29 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\Pages\FetchData.razor"
                         forecast.TitleC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 30 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\Pages\FetchData.razor"
                         forecast.AuthorC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 31 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\Pages\FetchData.razor"
                         forecast.Rented

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 32 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\Pages\FetchData.razor"
                         forecast.RentedbyReader

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 34 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 37 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\Pages\FetchData.razor"
       
    private BookList[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<BookList[]>("https://localhost:44381/api/BookCs");
    }

    public class BookList
    {
        public int BookCID { get; set; }
        public string TitleC { get; set; }
        public string AuthorC { get; set; }
        public bool Rented { get; set; }
        public int RentedbyReader { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
