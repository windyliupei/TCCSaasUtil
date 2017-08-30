请将 rootcert.pem 导入到 Windows 证书信任列表：

Start->run->MMC->press 'Ctrl+M'->select 'Certificates'->click 'Add' button->'Computer Account'->'Local Computer'->click 'OK' button

--证书制作过程--

----Create root certification file----
openssl genrsa -out rootkey.pem 2048
openssl req -new -x509 -nodes -days 3600 -key rootkey.pem -out rootcert.pem -subj /C=CN/ST=TJ/L=TJ/O=HON/OU=HBT/CN=【XXX】/emailAddress=root@hon.com

----client----
openssl genrsa -out clientkey.pem 2048
openssl req -new -key clientkey.pem -out client.csr -subj /C=CN/ST=TJ/L=TJ/O=HON/OU=HBT/CN=【XXX】/emailAddress=client@hon.com
openssl x509 -req -in client.csr -CA rootcert.pem -CAkey rootkey.pem -CAcreateserial -days 3650 -out clientcert.pem

----serve----
openssl genrsa -out serverkey.pem 2048
openssl req -new -key serverkey.pem -out server.csr -subj /C=CN/ST=TJ/L=TJ/O=HON/OU=HBT/CN=【XXX】/emailAddress=server@hon.com
openssl x509 -req -in server.csr -CA rootcert.pem -CAkey rootkey.pem -CAcreateserial -days 3650 -out servercert.pem

----verify cert file----
openssl verify -CAfile rootcert.pem clientcert.pem servercert.pem


----For .net client : generate pfx file----
openssl pkcs12 -export -out clientcert.pfx -inkey clientkey.pem -in clientcert.pem

	----local machine operate----
		run command ‘mmc’-> ctrl+m -> certificate->, click 'Ok' to close window
		install Certification file: rootcert.pem to 'trusted root Certification'...
----For Java client :
openssl pkcs12 -export -in clientcert.pem -inkey clientkey.pem -out client.pkcs12
openssl pkcs12 -export -in rootcert.pem -inkey rootkey.pem -out root.pkcs12

keytool -importkeystore -srckeystore client.pkcs12 -destkeystore client.jks -srcstoretype pkcs12 -deststoretype jks
keytool -importkeystore -srckeystore root.pkcs12 -destkeystore root.jks -srcstoretype pkcs12 -deststoretype jks
keytool -export -alias 1 -keystore root.jks -rfc -file root.cer
keytool -import -file root.cer  -keystore troot.jks
把client.jks和troot.jks以及密码拷贝给客户端供客户端代码使用

----NOET------------------------------------------------------------------------------------------------------------------------
.net 端访问的域名一定要和 生成root证书时的 CN 一致。Java这方面相对比较宽松。