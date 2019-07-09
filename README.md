# API's Calculadora de Juros

## Tecnologias implementadas:

- ASP.NET Core 2.2 (com .NET Core 2.2)
- ASP.NET WebApi Core
- FluentValidator
- Swagger UI
- XUnit

## Projeto online em

- API 1 - [ApiTaxaJuros](https://apitaxajuros.herokuapp.com/swagger)  
- API 2 - [ApiCalculaJuros](https://apicalculajuros.herokuapp.com/swagger)  

## Para rodar este Projeto
- em /src  
`docker-compose up --build`  

## Executar os testes

- em /test/TestJuros - Teste de unidade  
`dotnet test`  

![Alt Text](/docs/testsUnitarios.PNG)  
_Teste de unidade_  

- em /test/TestIntegracao - Teste de integração  
`dotnet test`  

![Alt Text](/docs/testsIntegracao.PNG)  
_Teste de integração_  