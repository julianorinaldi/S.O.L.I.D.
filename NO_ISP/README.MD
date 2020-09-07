# ISP — Interface Segregation Principle
No princípio da Segregação de Interfaces (ISP) diz que “muitas interfaces específicas são melhores do que uma interface geral” que se trata da coesão em interfaces, da construção de módulos enxutos, ou seja, com poucos comportamentos. Interfaces que possuem muitos comportamentos são difíceis de manter e evoluir, e devem ser evitadas.

## Violação do princípio ISP
Em um cenário fictício para criação de programa de e commerce, verificamos que as classes CadastroProduto e CadastroCliente herdam a mesma interface que possui mesmos métodos, porém metódo EnviarEmail() não corresponde para a classe CadastroProduto, pois produto não tem e-mail! essa forma, estamos violando o Interface Segregation Principle — E o LSP também!