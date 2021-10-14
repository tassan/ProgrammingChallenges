FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MadLib/MadLib.csproj", "MadLib/"]
RUN dotnet restore "MadLib/MadLib.csproj"
COPY . .
WORKDIR "/src/MadLib"
RUN dotnet build "MadLib.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MadLib.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MadLib.dll"]
