kubectl create secret docker-registry dotnet2018 --docker-server=dotnet2018.azurecr.io --docker-username=dotnet2018 --docker-password=0rSLHH0t4EqQ2afiDMR4zpAsnxI=k7b4 --docker-email=edu@edu.edu 

kubectl apply -f sql-deployment.yaml
kubectl apply -f sql-service.yaml

kubectl apply -f web-deployment.yaml
kubectl apply -f web-service.yaml

kubectl apply -f webapi-deployment.yaml
kubectl apply -f webapi-service.yaml

kubectl apply -f ingress.yaml