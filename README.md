## Instrucciones de ejecución

1. Clonar el repositorio:
    
    ```bash
    git clone https://github.com/davidmarbar/ChallengeAPI.git
    cd ChallengeAPI
    cd ApiChallenges
    dotnet restore
    dotnet run
    ```
    - Acceder a http://localhost:5000/swagger

## Decisiones adoptadas

- He utilizado **arquitectura por capas** para separar responsabilidades:
  - **Presentación**: controladores y DTOs
  - **Aplicación**: servicios
  - **Repositorio**: modelos

- He implementado **Swagger** para documentar y probar la API de forma interactiva.

- He definido un **servicio singleton** (`ChallengeService`) para mantener los retos en memoria durante la ejecución.

- He empleado **DTOs** para separar la entrada del cliente de los modelos internos, para evitar que se modifiquen campos como `Id` o `CreatedAt`.

- He decidido mantener la **persistencia en memoria**

## Breve explicación sobre qué se investigó o consultó

- Documentación oficial de Microsoft sobre **ASP.NET Core Web API** para entender las capas y como hacer la API 
- Guías de **Swagger / Swashbuckle** para integrar documentación automática en la API.   

Links: 
- https://learn.microsoft.com/es-es/aspnet/core/web-api/?view=aspnetcore-8.0
- https://learn.microsoft.com/es-es/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-8.0&tabs=visual-studio
- https://learn.microsoft.com/es-es/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures
