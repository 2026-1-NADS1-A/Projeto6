# Banco de Dados

## Entidades

* Escola
* Pacote
* Jogo
* IP_Autorizado

## Relacionamentos

* Escola compra Pacote
* Pacote define Jogo
* Escola possui IP_Autorizado

## Regras de Negócio

* Cada escola possui exatamente um pacote ativo
* Um pacote pode estar associado a várias escolas
* Um pacote contém vários jogos
* Um jogo pode pertencer a vários pacotes
* Uma escola pode ter vários IPs autorizados
* Cada IP autorizado pertence a apenas uma escola

## DER

![DER](der.png)
