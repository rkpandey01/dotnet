
conatiners are like empty machines -- images run in conatiners
first image is created and then it is containerized -- for eg to run node get node images and run -- 
create images for your application. it includes all required apps like node, core.net, mongodb, redis etc 
same images run in different conatiners

port mapping -- containers have its own port nos, need to expose them so they can be accessed from outside. 
docker run -p 80:8080 my-web-server

Dockerfile without extension -- has cofiguration for creating an image
-- create a base image 

docker networking -- way to communiocate with other dockers and external networks 
-- it has several drivers like Bridge, Host, Overlay, Macvlan 
by default it uses Bridge, so port mapping is required but in case of Host port mapping is not required as both are same 	


Docker volumes -- when container shuts down -- its data is lost -- to keep data use data volumes 
this acts as permanent data

whan change in a layer all below layes are rebuild while above layers are cached 
-- order of layers matters 

copy . . -- copies all files -- to excude files like docker-compose etc add in .dockerignore

Docker multisatge build 



cmd -->
docker pull <image_name eg:ubuntu> -- Download the Ubuntu image from the Docker Hub
docker run -it <image_name eg:ubuntu> -- it will create ubuntu container -- if container not found it will download 
docker container ls -- shows active conatiners
docker container ls -a --shows all conatiners
docker start <con_name> -- 
docker stop <con_name>
docker run -p <80:8080 my-web-server> --8080 is container port 

docker images
docker build -t <ur_image_name> <path of Dockerfile>

docker compose up -- it will run all conatiners
docker compose up -d -- runs in background
docker compose down --removes all containers

docker run -it -v <host_machime:path> <image_name>-- volume mapping 
