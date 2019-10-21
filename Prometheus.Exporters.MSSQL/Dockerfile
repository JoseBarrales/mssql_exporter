FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Prometheus.Exporters.MSSQL/Prometheus.Exporters.MSSQL.csproj", "Prometheus.Exporters.MSSQL/"]
RUN dotnet restore "Prometheus.Exporters.MSSQL/Prometheus.Exporters.MSSQL.csproj"
COPY . .
WORKDIR "/src/Prometheus.Exporters.MSSQL"
RUN dotnet build "Prometheus.Exporters.MSSQL.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Prometheus.Exporters.MSSQL.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Prometheus.Exporters.MSSQL.dll"]