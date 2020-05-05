#pragma checksum "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\Pages\Find.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f8e3be71610083f24032838c0e6e2f89ae4e87c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/find")]
    public partial class Find : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\Marcin\source\repos\LibrarySysClient\LibrarySysClient\Pages\Find.razor"
       
    private BookList[] listofbooks;
    private ReadersList[] listofreaders;
    protected override async Task OnInitializedAsync()
    {
        listofbooks = await Http.GetFromJsonAsync<BookList[]>("https://localhost:44381/api/BookCs");
        listofreaders = await Http.GetFromJsonAsync<ReadersList[]>("https://localhost:44381/api/Readers");
    }

    public class BookList
    {
        public int BookCID { get; set; }
        public string TitleC { get; set; }
        public string AuthorC { get; set; }
        public bool Rented { get; set; }
    }
    
    public BookList roboczyszukacz=new BookList();
    
    public BookList[] searchbook=new BookList[]{};
    public ReadersList[] searchreader=new ReadersList[]{};
    public string tytułroboczy="Pan Tadeusz";
   
   private string CurrentValue { get; set; }
   private string CurrentValueReader {get; set;}
   public BookList roboczabook{get;set;}
   public ReadersList roboczyreader {get; set;}
   public void searchtitle (){
       
       
       foreach (var n in listofbooks){
         if(n.TitleC==CurrentValue){
          roboczabook= n;
         }
       }
       if(roboczabook!=null){
       searchbook=new BookList[1];
       searchbook[0]=roboczabook;
       }
   }

   public void searchuser(){
       foreach(var m in listofreaders){
           if(m.Alias==CurrentValueReader){
               roboczyreader=m;
           }
       }
       if(roboczyreader!=null){
           searchreader=new ReadersList[1];
           searchreader[0]=roboczyreader;
       }
   }




    public class ReadersList
    {
        public int ReaderID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Alias {get;set;}
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
