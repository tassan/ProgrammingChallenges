FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["QuoteMaker/QuoteMaker.csproj", "QuoteMaker/"]
RUN dotnet restore "QuoteMaker/QuoteMaker.csproj"
COPY . .
WORKDIR "/src/QuoteMaker"
RUN dotnet build "QuoteMaker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QuoteMaker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QuoteMaker.dll"]
