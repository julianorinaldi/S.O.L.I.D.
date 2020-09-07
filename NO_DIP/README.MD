# DIP — Dependency Inversion Principle
O princípio da Inversão de Dependências (DIP), diz que devemos “depender de abstrações e não de classes concretas”. 
 - “Módulos de alto nível não devem depender de módulos de baixo nível.”
 - “As abstrações não devem depender de detalhes. Os detalhes devem depender das abstrações.”

E isso se dá porque abstrações mudam menos e facilitam a mudança de comportamento e as futuras evoluções do código.

## Violação do princípio DIP — Dependency Inversion Principle
No exemplo, estamos violando o princípio DIP, pois existe uma dependência direta entre o Interruptor e o Ventilador, sendo assim não podemos extender interruptor para reusar em outro dispositivo, além das classes não serem abstraídas.

O Interruptor deveria ser capaz de acionar qualquer dispositivo independente de ser um ventilador uma lâmpada ou até mesmo um carro.