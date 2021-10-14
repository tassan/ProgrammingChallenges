FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SimpleMath/SimpleMath.csproj", "SimpleMath/"]
RUN dotnet restore "SimpleMath/SimpleMath.csproj"
COPY . .
WORKDIR "/src/SimpleMath"
RUN dotnet build "SimpleMath.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SimpleMath.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SimpleMath.dll"]
