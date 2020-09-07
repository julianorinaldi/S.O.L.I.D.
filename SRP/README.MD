# Princípio: SRP -  Single Responsability Principle

 -  Uma classe deve ter apenas um motivo para mudar, ou seja, deve ter uma única responsabilidade. 
 - Esse princípio trata especificamente a coesão.
 - A coesão é definida como a afinidade funcional dos elementos de um módulo.
 - Se refere ao relacionamento que os membros desse módulo possuem, 
se possuem uma relação mais direta e importante. 
 - Dessa forma, quanto mais bem definido o que sua classe faz, mais coesa ela é.


## Características do SRP nestas classes
 - Separamos a responsabilidade de cada objeto
 - Na conexão com banco de dados, usamos repositório, o qual está ferindo o DIP por ter uma conexão direta com banco, mas não trataremos disto aqui.
 - Criamos um ClientService para representar as ações para o cliente
