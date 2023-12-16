using System.Net.Mime;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Userouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{conteroller=home}/{action=index}/{id?}"
    );

app.Run();

