# SOLID – Definição e Exemplos Simplificados

O acrônimo SOLID foi criado por Michael Feathers e ele consiste em cinco princípios de design, que são:


S = Single Responsibility Principle (Princípio da Responsabilidade Única)

O = Open/Closed Principle (Princípio Aberto/Fechado)

L = Liskov Substitution Principle (Princípio da Substituição de Liskov)

I = Interface Segregation Principle (Princípio da Segregação de Interface)

D = Dependency Inversion Principle (Princípio da Inversão de Dependência)

Atentem-se que o SOLID são princípios e não padrões!


Significado de cada princípio:

# Princípio da Responsabilidade Única

O princípio da responsabilidade única tem como regra que uma classe deve possuir uma, e apenas uma, responsabilidade. Por exemplo: A classe cozinheiro deve apenas preparar a refeição, não é responsabilidade da classe cobrar ou recolher os pratos das mesas. 

# Princípio Aberto/Fechado

O princípio aberto/fechado diz que as entidades de software (classes, módulos, funções, etc.) devem estar abertas para extensão, mas fechadas para modificação, ou seja, deve ser possível estender o comportamento de uma classe, mas não a modificar.

# Princípio da Substituição de Liskov

O Princípio de Substituição de Liskov diz que classes derivadas podem ser substituídas por suas classes base.

# Princípio da Segregação de Interface

O Princípio de Segregação de Interface diz que o cliente não deve ser forçado a implementar métodos que ele não irá utilizar. Em resumo, interfaces específicas são melhores do que uma única interface de propósito geral.

# Princípio da Inversão de Dependência

O Princípio de Inversão de Dependência possui duas definições: 

Módulos de alto nível não devem depender de módulos de baixo nível e ambos devem depender de abstrações;

Abstrações não devem depender de detalhes, mas detalhes devem depender de abstrações.

Módulos de alto nível: são as rotinas mais fáceis de entender, mais próximas da realidade de qualquer programador. Tendem a exigir menos carga mental para serem usadas;

Módulos de baixo nível: são as rotinas mais complexas e difíceis de entender. Geralmente são compostas de implementações de cálculos ou comportamentos específicos.

Detalhes: são os artefatos que não devem fazer parte da arquitetura de forma acoplada, mas são necessários para um sistema funcionar. O acesso ao banco de dados, por exemplo, é um detalhe; assim como o gerenciamento de arquivos.
