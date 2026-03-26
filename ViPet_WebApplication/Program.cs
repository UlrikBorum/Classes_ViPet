using System.Collections.Generic;
using System.Reflection;
using ViPet_opgave_U12_13;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


bool TestData = true;
List<Userstory> userstories = new List<Userstory>();
List<Userstory> userstoriesSprint = new List<Userstory>();
List<AcceptanceCriteria> ac1 = new List<AcceptanceCriteria>();

AcceptanceCriteria acA = new AcceptanceCriteria("Display a webpage with 2 collums");
AcceptanceCriteria acB = new AcceptanceCriteria("Collum with product backlog");
AcceptanceCriteria acC = new AcceptanceCriteria("Collum with sprint backlog");
ac1.Add(acA);
ac1.Add(acB);
ac1.Add(acC);


// Can´t move this to TestData, our AddSingleton.Userstory can´t find it otherwise. Test if we can call a userstory from TestData.
UserstoryDetail usd1 = new UserstoryDetail("As a teacher \r\n I want to be able to show my students visually how a Scrum Board  looks. So that i can teach them how to work", ac1);


if (TestData)
{

    Userstory us1 = new Userstory("Scooling in SCRUM",1,usd1);
    Userstory us2 = new Userstory("Homepage", 2, usd1);
    Userstory us3 = new Userstory("Product/sprint backlog", 3, usd1);
    Userstory us4 = new Userstory("Meetings in SCRUM", 4, usd1);
	Userstory us5 = new Userstory("Scooling in SCRUM", 5, usd1);
	Userstory us6 = new Userstory("Homepage", 6, usd1);
	Userstory us7 = new Userstory("Product/sprint backlog", 7, usd1);
	Userstory us8 = new Userstory("Meetings in SCRUM", 8, usd1);
	Userstory us9 = new Userstory("Product/sprint backlog", 9, usd1);
	Userstory us10 = new Userstory("Meetings in SCRUM", 10, usd1);
	Userstory us11 = new Userstory("Scooling in SCRUM", 11, usd1);
	Userstory us12 = new Userstory("Homepage", 12, usd1);
	Userstory us13 = new Userstory("Product/sprint backlog", 13, usd1);
	Userstory us14 = new Userstory("Meetings in SCRUM", 14, usd1);
	Userstory us15 = new Userstory("Scooling in SCRUM", 15, usd1);
	Userstory us16 = new Userstory("Homepage", 16, usd1);
	Userstory us17 = new Userstory("Product/sprint backlog", 17, usd1);
	Userstory us18 = new Userstory("Meetings in SCRUM", 18, usd1);
	Userstory us19 = new Userstory("Product/sprint backlog", 19, usd1);
	Userstory us20 = new Userstory("Meetings in SCRUM", 20, usd1);

	userstories.Add(us1);
    userstories.Add(us2);
    userstories.Add(us3);
    userstories.Add(us4);
    userstories.Add(us5);
    userstories.Add(us6);
    userstories.Add(us7);
    userstories.Add(us8);
    userstories.Add(us9);
    userstories.Add(us10);
	userstories.Add(us11);
	userstories.Add(us12);
	userstories.Add(us13);
	userstories.Add(us14);
	userstories.Add(us15);
	userstories.Add(us16);
	userstories.Add(us17);
	userstories.Add(us18);
	userstories.Add(us19);
	userstories.Add(us20);

}

// Created a list from Backlog and a list from SprintBacklog so we can use them in AddSingleton (tests)
Backlog product = new Backlog(userstories);
Backlog sprint = new Backlog(userstoriesSprint);

// When creating Backlogs, you need to have product object first in the parameters. This makes it so our method for MoveUserstory works as intended.
Backlogs backlogs = new Backlogs(product, sprint);

// Move userstories from product to sprint - make a button for user input?
backlogs.MoveUserstory(1);
backlogs.MoveUserstory(2);




builder.Services.AddSingleton<Backlogs>(backlogs);

builder.Services.AddSingleton<Userstory>(new Userstory("Scooling in SCRUM", 1, usd1));

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


