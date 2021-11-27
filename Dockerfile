# On part d'une image microsoft pour ASP .NET Core
FROM mcr.microsoft.com/dotnet/aspnet:6.0

# On copie notre résultat de publication dans le conteneur
COPY bin/Release/net6.0/publish/ App/

# On se place là où on a copié
WORKDIR /App

# On expose le port 80
EXPOSE 80

# On lance l'application
ENTRYPOINT ["dotnet", "net-web-tuto.dll"]