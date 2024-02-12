using WebApplication1;

var builder = WebApplication.CreateBuilder();

builder.Configuration
    .AddJsonFile("personalinfo.json")
    .AddJsonFile("config.json")
    .AddXmlFile("config.xml")
    .AddIniFile("config.ini");

var app = builder.Build();

var service = new CompanyAnalysisService(app.Configuration);

app.Map("/personal/", (IConfiguration appConfig) => {
    var me = appConfig.Get<Person>();
    return me.ToString();
});

app.Map("/company/", (IConfiguration appConfig) => {
    return service.GetCompanyWithMoreEmployees();
}); 

app.Run();