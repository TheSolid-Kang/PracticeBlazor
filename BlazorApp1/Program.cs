using BlazorApp1.Data;
using BlazorApp1.Data.NewFolder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Threading;

//var dao = new Engine._01.DAO.MSSQL_DAO();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
//2번 방법: inject //의존성 주입
builder.Services.AddScoped<TestClass2>();
builder.Services.AddScoped<ConfigTable>();
builder.Services.AddScoped<TableCall>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error");
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host"); //해당 _Host 라는 페이지를 불러온다.

app.Run();

/*
Mutex mutex;
//프로세스 런 가드
//https://afsdzvcx123.tistory.com/entry/WPF-WPF-%EC%A4%91%EB%B3%B5-%EC%8B%A4%ED%96%89-%EB%B0%A9%EC%A7%80-%ED%95%98%EB%8A%94%EB%B2%95

string mutexName = "program";
bool createNew = false;

mutex = new Mutex(true, mutexName, out createNew);

if (false == createNew)
{
  System.Windows.Forms.MessageBox.Show("이미 실행중입니다.");
  //Shutdown();
}
*/
