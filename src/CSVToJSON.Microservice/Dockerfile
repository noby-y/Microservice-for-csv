FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY CSVToJSON.Microservice.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c release -o /app

ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "CSVToJSON.Microservice.dll", "--environment=Development"]