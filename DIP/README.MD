# DIP — Dependency Inversion Principle
O princípio da Inversão de Dependências (DIP), diz que devemos “depender de abstrações e não de classes concretas”. 
 - “Módulos de alto nível não devem depender de módulos de baixo nível.”
 - “As abstrações não devem depender de detalhes. Os detalhes devem depender das abstrações.”

E isso se dá porque abstrações mudam menos e facilitam a mudança de comportamento e as futuras evoluções do código.

## Implementação do DIP — Dependency Inversion Principle
Neste exemplo separamos de forma estrutural usando inclusive o ISP.
Observe o desacoplamento entre Interruptor e os dispositivos, isto é possível através de uso de interfaces, e observe a inversão de dependência para dentro da classe Interruptor, recebendo um IDispositivo.

Agora não importa o device que o interruptor vai receber, desde que seja um dispositivo, ele conseguirá executar suas ações.