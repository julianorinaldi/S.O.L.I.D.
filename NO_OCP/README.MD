# OCP — Open-Closed Principle (Princípio do Aberto/Fechado)

No princípio do Open-Closed Principle diz que “as entidades de software (classes, módulos, funções etc.) devem ser abertas para ampliação, mas fechadas para modificação”. De forma mais detalhada, diz que podemos estender o comportamento de uma classe, quando for necessário, por meio de herança, interface e composição, mas não podemos permitir a abertura dessa classe para fazer pequenas modificações


# Violação do OCP
Na classe DebitoConta concreta, caso necessite implementar novas contas, será necessário alterar toda a classe, e colocar mais código arriscando e  possibilitando a inserção de bugs.