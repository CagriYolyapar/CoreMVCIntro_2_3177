var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//MiddleWare: Sistemin calısma mekanizmasını icerisinde bulunmasını istediginiz servisler eklenir...







var app = builder.Build();

//PipeLine

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();



app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Deneme}/{action=Index}/{id?}");

app.Run();












//www.cagri.com

//localhost:7552/ControllerIsmi/ActionIsmi