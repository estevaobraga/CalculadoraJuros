FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 as runtime
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine3.9 as build
WORKDIR /src
COPY . .
RUN dotnet restore "ApiCalculaJuros.WebApi/ApiCalculaJuros.WebApi.csproj"
WORKDIR "/src/ApiCalculaJuros.WebApi"
RUN dotnet build "ApiCalculaJuros.WebApi.csproj" -c Release -o /out

FROM build as publish
RUN dotnet publish "ApiCalculaJuros.WebApi.csproj" -c Release -o /out

FROM runtime as final
WORKDIR /app
COPY --from=publish /out .
ENTRYPOINT ["dotnet", "ApiCalculaJuros.WebApi.dll"]