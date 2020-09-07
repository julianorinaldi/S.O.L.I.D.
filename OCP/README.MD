# OCP — Open-Closed Principle (Princípio do Aberto/Fechado)

No princípio do Open-Closed Principle diz que “as entidades de software (classes, módulos, funções etc.) devem ser abertas para ampliação, mas fechadas para modificação”. De forma mais detalhada, diz que podemos estender o comportamento de uma classe, quando for necessário, por meio de herança, interface e composição, mas não podemos permitir a abertura dessa classe para fazer pequenas modificações


# Implementação do OCP
Na classe DebitoConta abstrata, perceba que é possível estruturar para que a casse DebitoConta não conheça as regras de cada conta, mas sim, mantenha apenas o que é necessário para todas elas.
Se precisar mudar algo na conta corrente ou polpança, isso não afetará a DebitoConta

**Se perceber, representa o designer pattern STRATEGY**