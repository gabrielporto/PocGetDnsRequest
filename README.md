# PocGetDnsRequest

 docker build -t dnsrequest:data -f ./PocGetDnsRequest/Dockerfile .
 
 docker tag dnsrequest:data gabriellopes/dnsrequest:latest
 
 docker push gabriellopes/dnsrequest:latest
 
 docker run --name dns -p 80:80 -d gabriellopes/dnsrequest:latest

.
