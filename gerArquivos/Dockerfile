FROM microsoft/dotnet:2.1-aspnetcore-runtime
LABEL version="1.0.1" descrition="Gerenciador de Arquivos"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "gerArquivos.dll"]