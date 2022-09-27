# PottencialDesafios
Aqui ficaram os desafios relacionados ao Bootcamp da Pottencial



DESAFIO 1 - ESTACIONAMENTO

Construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

A classe contém três variáveis, sendo:

- precoInicial: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.
- precoPorHora: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.
- veiculos: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

- AdicionarVeiculo: Método responsável por receber uma placa digitada pelo usuário e guardar na variável veiculos.
- RemoverVeiculo: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: precoInicial * precoPorHora, exibindo para o usuário.
- ListarVeiculos: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:

- Cadastrar veículo
- Remover veículo
- Listar veículos
- Encerrar

DESAFIO 2 - HOSPEDAGEM

Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos.

O seu programa deverá cálcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

Regras e validações

Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.


DESAFIO 03 - CRIANDO UM SISTEMA E ABSTRAINDO UM CELULAR COM POO EM C#

Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. Você deve criar as suas classes de acordo com o diagrama abaixo:

Diagrama classes
https://github.com/digitalinnovationone/trilha-net-poo-desafio/blob/main/Imagens/diagrama.png

Regras e validações
A classe Smartphone deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
A classe Nokia e Iphone devem ser classes filhas de Smartphone.
O método InstalarAplicativo deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

