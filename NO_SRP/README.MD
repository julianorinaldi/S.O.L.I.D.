# Princípio: SRP -  Single Responsability Principle

 -  Uma classe deve ter apenas um motivo para mudar, ou seja, deve ter uma única responsabilidade. 
 - Esse princípio trata especificamente a coesão.
 - A coesão é definida como a afinidade funcional dos elementos de um módulo.
 - Se refere ao relacionamento que os membros desse módulo possuem, 
se possuem uma relação mais direta e importante. 
 - Dessa forma, quanto mais bem definido o que sua classe faz, mais coesa ela é.

## Quebra do SRP nesta classe
- Falta de coesão — uma classe não deve assumir responsabilidades que não são suas;
- Alto acoplamento — Mais responsabilidades geram um maior nível de dependências, 
deixando o sistema engessado e frágil para alterações;
- Dificuldades na implementação de testes automatizados — É difícil de “mockar” esse tipo de classe;
- Dificuldades para reaproveitar o código;
*/
