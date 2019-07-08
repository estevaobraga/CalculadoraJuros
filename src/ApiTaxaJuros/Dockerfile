FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 as runtime
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine3.9 as build
WORKDIR /src
COPY . .
RUN dotnet restore "ApiTaxaJuros.WebApi/ApiTaxaJuros.WebApi.csproj"
WORKDIR "/src/ApiTaxaJuros.WebApi"
RUN dotnet build "ApiTaxaJuros.WebApi.csproj" -c Release -o /out

FROM build as publish
RUN dotnet publish "ApiTaxaJuros.WebApi.csproj" -c Release -o /out

FROM runtime as final
WORKDIR /app
COPY --from=publish /out .
ENTRYPOINT ["dotnet", "ApiTaxaJuros.WebApi.dll"]