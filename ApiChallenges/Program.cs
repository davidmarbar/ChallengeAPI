using Aplicacion;

var builder = WebApplication.CreateBuilder(args);

//Registro del servicio ChallengeService como singleton
builder.Services.AddSingleton<ChallengeService>();

//Endpoints y documentación automática
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Crea la aplicación con lo que he configurado
var app = builder.Build();

//Para usar la API desde el navegador
app.UseSwagger();
app.UseSwaggerUI();

//Conecta la ApiController con las rutas HTTP
app.MapControllers();

//Ejecuta la aplicación
app.Run();
