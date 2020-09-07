# ISP — Interface Segregation Principle
No princípio da Segregação de Interfaces (ISP) diz que “muitas interfaces específicas são melhores do que uma interface geral” que se trata da coesão em interfaces, da construção de módulos enxutos, ou seja, com poucos comportamentos. Interfaces que possuem muitos comportamentos são difíceis de manter e evoluir, e devem ser evitadas.

## Implementação do ISP
Perceba que todos os cadastros salvam no banco, e por isso temos uma interface "ICadastro" mais genérica. Porém cada cadastro tem suas particularidades, e assim faz sentidos separar.
Se perceber ambos tem "ValidarDados", onde cabe aqui até criar mais uma interface de validação e colocar como herança nesta interfaces que exigem validação.