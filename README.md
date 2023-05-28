# Microservice: Компоненти Програмної Інженерії 3

## Let's explore the creation and usage of our Microservice on a Docker container
----
1. ### Docker ***image*** has not been created yet, Docker ***file*** is ready
![pre_image](img/pre_image.png)


2. ### Running the ```docker build -t csvtojson .``` command
![post_image](img/post_image.png)


3. ### Docker ***container*** has not been created yet.
![pre_container](img/pre_container.png)


4. ### `launch_container.bat` is a small batch script that will automatically create a docker image
![post_container](img/post_container.png)


5. ### `open_swagger.bat` is a small batch script that will automatically open swagger UI on the running container for the microservice 
![pre_swagger](img/pre_swagger.png)

6. ### Swagger UI allows for easy testing of HTTP requests to the Microservice
![post_swagger](img/post_swagger.png)

7. ### Press **Try it out** and upload the csv file, then press **Execute** to send the request to the service
![pre_request](img/pre_request.png)


8. ### The *Response body* contains output JSON file and can be downloaded
![post_request](img/post_request.png)

