1. 拿到5个证书：

                服务端证书：
                sslgnatshomecloudhoneywellcomcn.pem
                sslgnatshomecloudhoneywellcomcn.key

                客户端证书：
                device-bundle.pem
                device.key

                根CA：
                HoneywellQAProductPKI.pem
                
2. 根据服务端证书生成 .net client证书：

                —————忽略2.1 ~ 2.3 直接 做2.4—————
                2.4 生成 Nats.Client 需要的证书格式
                openssl pkcs12 -export -out dotnetclientcert.pfx -inkey device.key -in device-bundle.pem 
                
3. 将 HoneywellQAProductPKI.pem,和 dotnetclientcert.pfx 证书导入Windows 受信任列表
                                run command ‘mmc’-> ctrl+m -> certificate->, click 'Ok' to close window
                                install Certification file:  HoneywellQAProductPKI.pem to 'trusted root Certification'...
                                
                                dotnetclientcert.pfx 双击即可，自动导入
                                


                                
4. config 文件内容
port: 4222
net: '0.0.0.0'

tls {
cert_file: "C:/Tool/gnat/tlspkiqa/sslgnatshomecloudhoneywellcomcn.pem"
key_file: "C:/Tool/gnat/tlspkiqa/sslgnatshomecloudhoneywellcomcn.key"
verify:true
ca_file:"C:/Tool/gnat/tlspkiqa/HoneywellQAProductPKI.pem"
timeout: 1
}

authorization {
  user:'home'
  password:'1qaz2wsx'
}
5. 命令行
gnatsd -p 4222 --tls --tlscert=pki/sslgnatshomecloudhoneywellcomcn.pem --tlskey=pki/sslgnatshomecloudhoneywellcomcn.key --tlsverify --tlscacert=pki/HoneywellQAProductPKI.pem --user home --pass 1qaz2wsx
