//Root Certificate:
makecert.exe -r -n "CN=Student Root Authority,O=Student,OU=Development,L=Pune,S=MH,C=IN" -pe -ss Root -sr LocalMachine -sky signature -m 120 -a sha256 -len 2048 -sv StudentRootAuthority.pvk StudentRootAuthority.cer

//Server Certificate:
makecert -pe -n "CN=*.student.com" -a sha256 -len 2048 -sky exchange -eku 1.3.6.1.5.5.7.3.1 -sp "Microsoft RSA SChannel Cryptographic Provider" -sy 12 -in "Student Root Authority" -is Root -ir LocalMachine -ss My -sr LocalMachine -m 13 -sv studentSoftServerCert.pvk studentSoftServerCert.cer

//Client Certificate:
makecert -pe -n "CN=ClientCertificate" -a sha256 -len 2048 -sky exchange -eku 1.3.6.1.5.5.7.3.2 -sp "Microsoft RSA SChannel Cryptographic Provider" -sy 12 -in "Student Root Authority" -is Root -ir LocalMachine -ss My -sr LocalMachine -m 13 -sv studentSoftClientCert.pvk studentSoftClientCert.cer 

//Create pfx file for client and server certificate
pvk2pfx -pvk studentSoftServerCert.pvk  -spc studentSoftServerCert.cer  -pfx studentSoftServerCert.pfx  -pi 12345 -f
pvk2pfx -pvk studentSoftClientCert.pvk  -spc studentSoftClientCert.cer  -pfx studentSoftClientCert.pfx  -pi 12345 -f

