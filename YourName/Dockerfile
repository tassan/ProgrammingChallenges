FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["YourName/YourName.csproj", "YourName/"]
RUN dotnet restore "YourName/YourName.csproj"
COPY . .
WORKDIR "/src/YourName"
RUN dotnet build "YourName.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "YourName.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YourName.dll"]
