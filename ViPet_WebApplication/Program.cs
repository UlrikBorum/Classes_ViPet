using ViPet_opgave_U12_13;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


bool TestData = true;
List<Userstory> userstories = new List<Userstory>();
List<AcceptanceCriteria> ac1 = new List<AcceptanceCriteria>();

UserstoryDetail usd1 = new UserstoryDetail("As a <type of user>\r\nI want <some goal>\r\nso that <some reason>.", ac1);


if (TestData)
{
    Userstory us1 = new Userstory("Skoling i SCRUM",1,usd1);
    Userstory us2 = new Userstory("Homepage", 2, usd1);
    Userstory us3 = new Userstory("Product/sprint backlog", 3, usd1);
    Userstory us4 = new Userstory("Møder i SCRUM", 4, usd1);

    userstories.Add(us1);
    userstories.Add(us2);
    userstories.Add(us3);
    userstories.Add(us4);
}

builder.Services.AddSingleton<Backlog>(new Backlog(userstories));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();


