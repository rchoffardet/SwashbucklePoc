using SwashbucklePoc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<Microsoft.AspNetCore.Mvc.JsonOptions>(options => { 
    options.JsonSerializerOptions.IncludeFields = true; 
});

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => { 
    options.SerializerOptions.IncludeFields = true; 
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.MapGet("foo", () => new Greeting("foo"));

app.Run();