using Ex___02;

Gato gato1 = new Gato
{
    Especie = "Mamífero",
};

Porco porco1 = new Porco
{
    Especie = "Mamífero",
};

Capivara capivara1 = new Capivara
{
    Especie = "Mamífero",
};

Console.WriteLine($"Gato: {gato1.Especie}, \nPorco: {porco1.Especie}, \nCapivara: {capivara1.Especie}. ");
gato1.EmitirSom();
porco1.EmitirSom();
capivara1.EmitirSom();

Console.ReadKey();