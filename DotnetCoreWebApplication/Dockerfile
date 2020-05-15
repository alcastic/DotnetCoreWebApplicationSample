FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
EXPOSE 5001
WORKDIR /source-code
COPY . .
RUN dotnet publish -c release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["./DotnetCoreWebApplication"]
