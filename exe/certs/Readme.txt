1. �õ�5��֤�飺

                �����֤�飺
                sslgnatshomecloudhoneywellcomcn.pem
                sslgnatshomecloudhoneywellcomcn.key

                �ͻ���֤�飺
                device-bundle.pem
                device.key

                ��CA��
                HoneywellQAProductPKI.pem
                
2. ���ݷ����֤������ .net client֤�飺

                ��������������2.1 ~ 2.3 ֱ�� ��2.4����������
                2.4 ���� Nats.Client ��Ҫ��֤���ʽ
                openssl pkcs12 -export -out dotnetclientcert.pfx -inkey device.key -in device-bundle.pem 
                
3. �� HoneywellQAProductPKI.pem,�� dotnetclientcert.pfx ֤�鵼��Windows �������б�
                                run command ��mmc��-> ctrl+m -> certificate->, click 'Ok' to close window
                                install Certification file:  HoneywellQAProductPKI.pem to 'trusted root Certification'...
                                
                                dotnetclientcert.pfx ˫�����ɣ��Զ�����
                                


                                
4. config �ļ�����
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
5. ������
gnatsd -p 4222 --tls --tlscert=pki/sslgnatshomecloudhoneywellcomcn.pem --tlskey=pki/sslgnatshomecloudhoneywellcomcn.key --tlsverify --tlscacert=pki/HoneywellQAProductPKI.pem --user home --pass 1qaz2wsx
