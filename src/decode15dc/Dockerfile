FROM microsoft/aspnet:1.0.0-beta4
COPY . /app
WORKDIR /app/approot/src/decode15dc
EXPOSE 5001
ENTRYPOINT ["dnx", ".", "kestrel"]
