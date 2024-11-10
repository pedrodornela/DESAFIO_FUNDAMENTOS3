# DIO - Trilha .NET - Fundamentos 
## Desafio de Projeto: Abstraindo um Celular com POO em C#
### Contexto
- E fui responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que eu fizesse uma abstração de um celular e disponibilizasse maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

### Regras e validações
- 1 - A classe Smartphone deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
- 2 - A classe Nokia e Iphone devem ser classes filhas de Smartphone.
- 3 - O método InstalarAplicativo deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.


### Solução
- Classes "Smartphone", "Nokia" e "Iphone" contruídas de acordo com o diagrama abaixo:
  
![image](https://github.com/user-attachments/assets/3285bba1-2245-4ecc-b0eb-289f86534c17)


#### Pré-requisitos:
- Lógica de Programação e POO;
- Conhecimentos Básico(C#, .NET, Git, GitHub);
