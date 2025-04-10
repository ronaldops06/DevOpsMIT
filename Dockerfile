FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Somnia.API/Somnia.API.csproj", "Somnia.API/"]
RUN dotnet restore "Somnia.API/Somnia.API.csproj"
COPY . .

WORKDIR "/src/Somnia.API"
RUN dotnet build "Somnia.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Somnia.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Somnia.API.dll"]
