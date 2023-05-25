start cmd.exe /c .\open_swagger.bat
cd .\src\CSVToJSON.Microservice\
docker run -it --rm -p 3000:80 --name csvtojsoncontainer csvtojson