using Bogus;

var faker1 = new Faker();
var faker2 = new Faker();

Leao leaoMacho = new Leao(faker1.Person.FullName, new DateTime(1998, 04, 30), 'M', "Dourado");
Leao leaoFemea = new Leao(faker2.Person.FullName, new DateTime(2000, 01, 16), 'F', "Dourado");

Console.WriteLine("Dados do Leão 1:");
Console.WriteLine($"Nome: {leaoMacho.Nome}. Idade: {leaoMacho.Idade()}. Sexo: {leaoMacho.Sexo}");
leaoMacho.Movimentar();
leaoMacho.Comunicar();
leaoMacho.Alimentar();
leaoMacho.Amamentar();
Console.WriteLine();

Console.WriteLine("Dados do Leão 2:");
Console.WriteLine($"Nome: {leaoFemea.Nome}. Idade: {leaoFemea.Idade()}. Sexo: {leaoFemea.Sexo}");
leaoFemea.Movimentar();
leaoFemea.Comunicar();
leaoFemea.Alimentar();
leaoFemea.Amamentar();
Console.WriteLine();

Chacal chacalMacho = new Chacal(faker1.Person.FullName, new DateTime(1998, 04, 30), 'M', "Dourado e preto");
Chacal chacalFemea = new Chacal(faker2.Person.FullName, new DateTime(2000, 01, 16), 'F', "Dourado e preto");

Console.WriteLine("Dados do Chacal 1:");
Console.WriteLine($"Nome: {chacalMacho.Nome}. Idade: {chacalMacho.Idade()}. Sexo: {chacalMacho.Sexo}");
chacalMacho.Movimentar();
chacalMacho.Comunicar();
chacalMacho.Alimentar();
chacalMacho.Amamentar();
Console.WriteLine();

Console.WriteLine("Dados do Chacal 2:");
Console.WriteLine($"Nome: {chacalFemea.Nome}. Idade: {chacalFemea.Idade()}. Sexo: {chacalFemea.Sexo}");
chacalFemea.Movimentar();
chacalFemea.Comunicar();
chacalFemea.Alimentar();
chacalFemea.Amamentar();
Console.WriteLine();

Lontra LontraMacho = new Lontra(faker1.Person.FullName, new DateTime(1998, 04, 30), 'M', "Marrom");
Lontra LontraFemea = new Lontra(faker2.Person.FullName, new DateTime(2000, 01, 16), 'F', "Marrom");

Console.WriteLine("Dados do Lontra 1:");
Console.WriteLine($"Nome: {LontraMacho.Nome}. Idade: {LontraMacho.Idade()}. Sexo: {LontraMacho.Sexo}");
LontraMacho.Movimentar();
LontraMacho.Comunicar();
LontraMacho.Alimentar();
LontraMacho.Amamentar();
Console.WriteLine();

Console.WriteLine("Dados do Lontra 2:");
Console.WriteLine($"Nome: {LontraFemea.Nome}. Idade: {LontraFemea.Idade()}. Sexo: {LontraFemea.Sexo}");
LontraFemea.Movimentar();
LontraFemea.Comunicar();
LontraFemea.Alimentar();
LontraFemea.Amamentar();
Console.WriteLine();

Ornitorrinco OrnitorrincoMacho = new Ornitorrinco(faker1.Person.FullName, new DateTime(1998, 04, 30), 'M', "Marrom");
Ornitorrinco OrnitorrincoFemea = new Ornitorrinco(faker2.Person.FullName, new DateTime(2000, 01, 16), 'F', "Marrom");

Console.WriteLine("Dados do Ornitorrinco 1:");
Console.WriteLine($"Nome: {OrnitorrincoMacho.Nome}. Idade: {OrnitorrincoMacho.Idade()}. Sexo: {OrnitorrincoMacho.Sexo}");
OrnitorrincoMacho.Movimentar();
OrnitorrincoMacho.Comunicar();
OrnitorrincoMacho.Alimentar();
OrnitorrincoMacho.Amamentar();
Console.WriteLine();

Console.WriteLine("Dados do Ornitorrinco 2:");
Console.WriteLine($"Nome: {OrnitorrincoFemea.Nome}. Idade: {OrnitorrincoFemea.Idade()}. Sexo: {OrnitorrincoFemea.Sexo}");
OrnitorrincoFemea.Movimentar();
OrnitorrincoFemea.Comunicar();
OrnitorrincoFemea.Alimentar();
OrnitorrincoFemea.Amamentar();
Console.WriteLine();

Elefante ElefanteMacho = new Elefante(faker1.Person.FullName, new DateTime(1998, 04, 30), 'M');
Elefante ElefanteFemea = new Elefante(faker2.Person.FullName, new DateTime(2000, 01, 16), 'F');

Console.WriteLine("Dados do Elefante 1:");
Console.WriteLine($"Nome: {ElefanteMacho.Nome}. Idade: {ElefanteMacho.Idade()}. Sexo: {ElefanteMacho.Sexo}");
ElefanteMacho.Movimentar();
ElefanteMacho.Comunicar();
ElefanteMacho.Alimentar();
ElefanteMacho.Amamentar();
Console.WriteLine();

Console.WriteLine("Dados do Elefante 2:");
Console.WriteLine($"Nome: {ElefanteFemea.Nome}. Idade: {ElefanteFemea.Idade()}. Sexo: {ElefanteFemea.Sexo}");
ElefanteFemea.Movimentar();
ElefanteFemea.Comunicar();
ElefanteFemea.Alimentar();
ElefanteFemea.Amamentar();
Console.WriteLine();

Morcego morcegoMacho = new Morcego(faker1.Person.FullName, new DateTime(1998, 04, 30), 'M', "Preto");
Morcego morcegoFemea = new Morcego(faker2.Person.FullName, new DateTime(2000, 01, 16), 'F', "Branco");

Console.WriteLine("Dados do Morcego 1:");
Console.WriteLine($"Nome: {morcegoMacho.Nome}. Idade: {morcegoMacho.Idade()}. Sexo: {morcegoMacho.Sexo}. Cor do pelo: {morcegoMacho.CorDoPelo}");
morcegoMacho.Movimentar();
morcegoMacho.Comunicar();
morcegoMacho.Alimentar();
morcegoMacho.Amamentar();
morcegoMacho.Voar();
Console.WriteLine();

Console.WriteLine("Dados do Morcego 2:");
Console.WriteLine($"Nome: {morcegoFemea.Nome}. Idade: {morcegoFemea.Idade()}. Sexo: {morcegoFemea.Sexo}. Cor do pelo: {morcegoFemea.CorDoPelo}");
morcegoFemea.Movimentar();
morcegoFemea.Comunicar();
morcegoFemea.Alimentar();
morcegoFemea.Amamentar();
morcegoFemea.Voar();
Console.WriteLine();

Cisne CisneMacho = new Cisne(faker1.Person.FullName, new DateTime(1998, 04, 30), 'M');
Cisne CisneFemea = new Cisne(faker2.Person.FullName, new DateTime(2000, 01, 16), 'F');

Console.WriteLine("Dados do Cisne 1:");
Console.WriteLine($"Nome: {CisneMacho.Nome}. Idade: {CisneMacho.Idade()}. Sexo: {CisneMacho.Sexo}. Rapina: {CisneMacho.Rapina}. Cor da pena: {CisneMacho.CorPena}. Vive em terra: {CisneMacho.ViveEmTerra}");
CisneMacho.Movimentar();
CisneMacho.Comunicar();
CisneMacho.Alimentar();
CisneMacho.Botar();
CisneMacho.Chocar();
CisneMacho.Voar();
Console.WriteLine();

Console.WriteLine("Dados do Cisne 2:");
Console.WriteLine($"Nome: {CisneFemea.Nome}. Idade: {CisneFemea.Idade()}. Sexo: {CisneFemea.Sexo}. Rapina: {CisneFemea.Rapina}. Cor da pena: {CisneFemea.CorPena}. Vive em terra: {CisneFemea.ViveEmTerra}");
CisneFemea.Movimentar();
CisneFemea.Comunicar();
CisneFemea.Alimentar();
CisneFemea.Botar();
CisneFemea.Chocar();
CisneFemea.Voar();
Console.WriteLine();

Pinguim PinguimMacho = new Pinguim(faker1.Person.FullName, new DateTime(1998, 04, 30), 'M');
Pinguim PinguimFemea = new Pinguim(faker2.Person.FullName, new DateTime(2000, 01, 16), 'F');

Console.WriteLine("Dados do Pinguim 1:");
Console.WriteLine($"Nome: {PinguimMacho.Nome}. Idade: {PinguimMacho.Idade()}. Sexo: {PinguimMacho.Sexo}. Rapina: {PinguimMacho.Rapina}. Cor da pena: {PinguimMacho.CorPena}. Vive em terra: {PinguimMacho.ViveEmTerra}");
PinguimMacho.Movimentar();
PinguimMacho.Comunicar();
PinguimMacho.Alimentar();
PinguimMacho.Botar();
PinguimMacho.Chocar();
Console.WriteLine();

Console.WriteLine("Dados do Pinguim 2:");
Console.WriteLine($"Nome: {PinguimFemea.Nome}. Idade: {PinguimFemea.Idade()}. Sexo: {PinguimFemea.Sexo}. Rapina: {PinguimFemea.Rapina}. Cor da pena: {PinguimFemea.CorPena}. Vive em terra: {PinguimFemea.ViveEmTerra}");
PinguimFemea.Movimentar();
PinguimFemea.Comunicar();
PinguimFemea.Alimentar();
PinguimFemea.Botar();
PinguimFemea.Chocar();
Console.WriteLine();

Coruja CorujaMacho = new Coruja(faker1.Person.FullName, new DateTime(1998, 04, 30), 'M');
Coruja CorujaFemea = new Coruja(faker2.Person.FullName, new DateTime(2000, 01, 16), 'F');

Console.WriteLine("Dados do Coruja 1:");
Console.WriteLine($"Nome: {CorujaMacho.Nome}. Idade: {CorujaMacho.Idade()}. Sexo: {CorujaMacho.Sexo}. Rapina: {CorujaMacho.Rapina}. Cor da pena: {CorujaMacho.CorPena}");
CorujaMacho.Movimentar();
CorujaMacho.Comunicar();
CorujaMacho.Alimentar();
CorujaMacho.Botar();
CorujaMacho.Chocar();
CorujaMacho.Voar();
Console.WriteLine();

Console.WriteLine("Dados do Coruja 2:");
Console.WriteLine($"Nome: {CorujaFemea.Nome}. Idade: {CorujaFemea.Idade()}. Sexo: {CorujaFemea.Sexo}. Rapina: {CorujaFemea.Rapina}. Cor da pena: {CorujaFemea.CorPena}");
CorujaFemea.Movimentar();
CorujaFemea.Comunicar();
CorujaFemea.Alimentar();
CorujaFemea.Botar();
CorujaFemea.Chocar();
CorujaFemea.Voar();
Console.WriteLine();

Arara AraraMacho = new Arara(faker1.Person.FullName, new DateTime(1998, 04, 30), 'M');
Arara AraraFemea = new Arara(faker2.Person.FullName, new DateTime(2000, 01, 16), 'F');

Console.WriteLine("Dados do Arara 1:");
Console.WriteLine($"Nome: {AraraMacho.Nome}. Idade: {AraraMacho.Idade()}. Sexo: {AraraMacho.Sexo}. Rapina: {AraraMacho.Rapina}. Cor da pena: {AraraMacho.CorPena}");
AraraMacho.Movimentar();
AraraMacho.Comunicar();
AraraMacho.Alimentar();
AraraMacho.Botar();
AraraMacho.Chocar();
AraraMacho.Voar();
Console.WriteLine();

Console.WriteLine("Dados do Arara 2:");
Console.WriteLine($"Nome: {AraraFemea.Nome}. Idade: {AraraFemea.Idade()}. Sexo: {AraraFemea.Sexo}. Rapina: {AraraFemea.Rapina}. Cor da pena: {AraraFemea.CorPena}");
AraraFemea.Movimentar();
AraraFemea.Comunicar();
AraraFemea.Alimentar();
AraraFemea.Botar();
AraraFemea.Chocar();
AraraFemea.Voar();
Console.WriteLine();

DragaoDeComodo DragaoDeComodoMacho = new DragaoDeComodo(faker1.Person.FullName, new DateTime(1998, 04, 30), 'M');
DragaoDeComodo DragaoDeComodoFemea = new DragaoDeComodo(faker2.Person.FullName, new DateTime(2000, 01, 16), 'F');

Console.WriteLine("Dados do DragaoDeComodo 1:");
Console.WriteLine($"Nome: {DragaoDeComodoMacho.Nome}. Idade: {DragaoDeComodoMacho.Idade()}. Sexo: {DragaoDeComodoMacho.Sexo}");
DragaoDeComodoMacho.Movimentar();
DragaoDeComodoMacho.Comunicar();
DragaoDeComodoMacho.Alimentar();
DragaoDeComodoMacho.Botar();
DragaoDeComodoMacho.Chocar();
Console.WriteLine();

Console.WriteLine("Dados do DragaoDeComodo 2:");
Console.WriteLine($"Nome: {DragaoDeComodoFemea.Nome}. Idade: {DragaoDeComodoFemea.Idade()}. Sexo: {DragaoDeComodoFemea.Sexo}");
DragaoDeComodoFemea.Movimentar();
DragaoDeComodoFemea.Comunicar();
DragaoDeComodoFemea.Alimentar();
DragaoDeComodoFemea.Botar();
DragaoDeComodoFemea.Chocar();
Console.WriteLine();

Jacare JacareMacho = new Jacare(faker1.Person.FullName, new DateTime(1998, 04, 30), 'M');
Jacare JacareFemea = new Jacare(faker2.Person.FullName, new DateTime(2000, 01, 16), 'F');

Console.WriteLine("Dados do Jacare 1:");
Console.WriteLine($"Nome: {JacareMacho.Nome}. Idade: {JacareMacho.Idade()}. Sexo: {JacareMacho.Sexo}. Vive em terra: {JacareMacho.ViveEmTerra}");
JacareMacho.Movimentar();
JacareMacho.Comunicar();
JacareMacho.Alimentar();
JacareMacho.Botar();
JacareMacho.Chocar();
Console.WriteLine();

Console.WriteLine("Dados do Jacare 2:");
Console.WriteLine($"Nome: {JacareFemea.Nome}. Idade: {JacareFemea.Idade()}. Sexo: {JacareFemea.Sexo}. Vive em terra: {JacareFemea.ViveEmTerra}");
JacareFemea.Movimentar();
JacareFemea.Comunicar();
JacareFemea.Alimentar();
JacareFemea.Botar();
JacareFemea.Chocar();
Console.WriteLine();

interface IVoar
{
    public int AltitudeMaximaEmMetros { get; }
    public double VelocidadeDeVoo { get; }
    void Voar();
}

interface IAquatico
{
    public bool ViveEmTerra { get; }
    public bool Mergulho { get; }
    public bool AguaDoce { get; }
}

interface IOviparo
{
    void Botar();
    void Chocar();
}

abstract class Animal
{
    public string? Nome { get; init; }
    public DateTime DataDeNascimento { get; init; }
    public char Sexo { get; init; }
    public bool Carnivoro { get; init; }
    public bool Peconhento { get; init; }
    public int Idade()
    {
        return (DateTime.Now.Year - DataDeNascimento.Year - 1) +
        (((DateTime.Now.Month > DataDeNascimento.Month) ||
        ((DateTime.Now.Month == DataDeNascimento.Month) && (DateTime.Now.Day >= DataDeNascimento.Day))) ? 1 : 0);
    }
    public abstract void Movimentar();
    public abstract void Comunicar();
    public abstract void Alimentar();
}

abstract class Mamifero : Animal
{
    public int QtdeMamas { get; init; }
    public bool Pelos { get; init; }
    public string? CorDoPelo { get; init; }

    public abstract void Amamentar();
}

class Leao : Mamifero
{
    new public bool Carnivoro { get; set; } = true;
    new public bool Peconhento { get; set; } = false;
    new public int QtdeMamas { get; set; } = 4;
    new public bool Pelos { get; set; } = true;

    public Leao(string nome, DateTime dataDeNascimento, char sexo, string corDoPelo)
    {
        this.Nome = nome;
        this.DataDeNascimento = dataDeNascimento;
        this.Sexo = Char.ToUpper(sexo);
        this.CorDoPelo = corDoPelo;
    }

    public override void Movimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um leão e caminho!");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um leão falando!");
    }

    public override void Alimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um leão e como carne de zebra!");
    }

    public override void Amamentar()
    {
        if (Sexo.Equals('M'))
        {
            Console.WriteLine($"Eu ({Nome}) sou um leão macho, então não posso amamentar");
            return;
        }

        Console.WriteLine($"Eu ({Nome}) sou uma leoa e posso amamentar até {QtdeMamas} filhotes");
    }
}

class Chacal : Mamifero
{
    public Chacal(string nome, DateTime dataDeNascimento, char sexo, string corDoPelo)
    {
        this.Nome = nome;
        this.DataDeNascimento = dataDeNascimento;
        this.Sexo = Char.ToUpper(sexo);
        this.Carnivoro = true;
        this.Peconhento = false;
        this.QtdeMamas = 6;
        this.Pelos = true;
        this.CorDoPelo = corDoPelo;
    }
    public override void Movimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um chacal e caminho!");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um chacal falando!");
    }

    public override void Alimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um chacal e como galinhas!");
    }

    public override void Amamentar()
    {
        if (Sexo.Equals('M'))
        {
            Console.WriteLine($"Eu ({Nome}) sou um chacal macho, então não posso amamentar");
            return;
        }

        Console.WriteLine($"Eu ({Nome}) sou uma chacal e posso amamentar até {QtdeMamas} filhotes");
    }
}

class Elefante : Mamifero
{
    new public bool Carnivoro { get; set; } = false;
    new public bool Peconhento { get; set; } = false;
    new public int QtdeMamas { get; set; } = 4;
    new public bool Pelos { get; set; } = false;
    new public string CorDoPelo { get; set; } = "Não tem pelos";

    public Elefante(string nome, DateTime dataDeNascimento, char sexo)
    {
        this.Nome = nome;
        this.DataDeNascimento = dataDeNascimento;
        this.Sexo = Char.ToUpper(sexo);
    }

    public override void Movimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um elefante e caminho!");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um elefante falando!");
    }

    public override void Alimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um elefante e como plantas!");
    }

    public override void Amamentar()
    {
        if (Sexo.Equals('M'))
        {
            Console.WriteLine($"Eu ({Nome}) sou um elefante macho, então não posso amamentar");
            return;
        }

        Console.WriteLine($"Eu ({Nome}) sou um elefante fêmea e posso amamentar até {QtdeMamas} filhotes");
    }
}

class Lontra : Mamifero, IAquatico
{
    new public bool Carnivoro { get; set; } = true;
    new public bool Peconhento { get; set; } = false;
    new public int QtdeMamas { get; set; } = 4;
    new public bool Pelos { get; set; } = true;
    public bool ViveEmTerra { get => true; }
    public bool Mergulho { get => true; }
    public bool AguaDoce { get => true; }

    public Lontra(string nome, DateTime dataDeNascimento, char sexo, string corDoPelo)
    {
        this.Nome = nome;
        this.DataDeNascimento = dataDeNascimento;
        this.Sexo = Char.ToUpper(sexo);
        this.CorDoPelo = corDoPelo;
    }

    public override void Movimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou uma lontra, nado e caminho!");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"Eu ({Nome}) sou uma lontra falando!");
    }

    public override void Alimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou uma lontra e como peixes e crustáceos!");
    }

    public override void Amamentar()
    {
        if (Sexo.Equals('M'))
        {
            Console.WriteLine($"Eu ({Nome}) sou uma lontra macho, então não posso amamentar");
            return;
        }

        Console.WriteLine($"Eu ({Nome}) sou uma lontra fêmea e posso amamentar até {QtdeMamas} filhotes");
    }
}

class Morcego : Mamifero, IVoar
{
    new public bool Carnivoro { get; set; } = false;
    new public bool Peconhento { get; set; } = false;
    new public int QtdeMamas { get; set; } = 8;
    new public bool Pelos { get; set; } = true;
    public int AltitudeMaximaEmMetros { get => 40; }
    public double VelocidadeDeVoo { get => 12; }

    public Morcego(string nome, DateTime dataDeNascimento, char sexo, string corDoPelo)
    {
        this.Nome = nome;
        this.DataDeNascimento = dataDeNascimento;
        this.Sexo = Char.ToUpper(sexo);
        this.CorDoPelo = corDoPelo;
    }

    public override void Movimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um morcego e voo!");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um morcego falando!");
    }

    public override void Alimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um morcego e como frutas!");
    }

    public override void Amamentar()
    {
        if (Sexo.Equals('M'))
        {
            Console.WriteLine($"Eu ({Nome}) sou um morcego macho, então não posso amamentar");
            return;
        }

        Console.WriteLine($"Eu ({Nome}) sou uma morcega e posso amamentar até {QtdeMamas} filhotes");
    }

    public void Voar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um morcego e posso voar até {AltitudeMaximaEmMetros} m de altitude a uma velocidade de {VelocidadeDeVoo} de m/s");
    }
}

abstract class Ave : Animal
{
    public bool Rapina { get; set; }
    public bool CorPena { get; set; }   
}

class Cisne : Ave, IVoar, IOviparo, IAquatico
{
    new public bool Rapina { get; set; } = false;
    new public bool CorPena { get; set; } = false;
    new public bool Carnivoro { get; set; } = false;
    new public bool Peconhento { get; set; } = false;
    public int AltitudeMaximaEmMetros { get => 15; }
    public double VelocidadeDeVoo { get => 6; }
    public bool ViveEmTerra { get => true; }
    public bool Mergulho { get => false; }
    public bool AguaDoce { get => true; }

    public Cisne(string nome, DateTime dataDeNascimento, char sexo)
    {
        this.Nome = nome;
        this.DataDeNascimento = dataDeNascimento;
        this.Sexo = Char.ToUpper(sexo);
    }

    public override void Movimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um cisne, nado na superfície, caminho e voo!");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um cisne se comunicando!");
    }

    public override void Alimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um cisne e me alimento de plantas!");
    }

    public void Voar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um cisne e posso voar até {AltitudeMaximaEmMetros} m de altitude a uma velocidade de {VelocidadeDeVoo} de m/s");
    }

    public void Botar()
    {
        if (Sexo.Equals('M'))
        {
            Console.WriteLine($"Eu ({Nome}) sou um cisne macho, então não posso botar ovos");
            return;
        }
        Console.WriteLine($"Eu ({Nome}) sou um cisne fêmea e estou botando um ovo");
    }

    public void Chocar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um cisne e estou chocando um ovo");
    }
}

class Arara : Ave, IVoar, IOviparo
{
    new public bool Rapina { get; set; } = false;
    new public bool CorPena { get; set; } = true;
    new public bool Carnivoro { get; set; } = false;
    new public bool Peconhento { get; set; } = false;
    public int AltitudeMaximaEmMetros { get => 40; }
    public double VelocidadeDeVoo { get => 9; }

    public Arara(string nome, DateTime dataDeNascimento, char sexo)
    {
        this.Nome = nome;
        this.DataDeNascimento = dataDeNascimento;
        this.Sexo = Char.ToUpper(sexo);
    }

    public override void Movimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou uma arara, caminho e voo!");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"Eu ({Nome}) sou uma arara se comunicando!");
    }

    public override void Alimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou uma arara e me alimento de plantas!");
    }

    public void Voar()
    {
        Console.WriteLine($"Eu ({Nome}) sou uma arara e posso voar até {AltitudeMaximaEmMetros} m de altitude a uma velocidade de {VelocidadeDeVoo} de m/s");
    }

    public void Botar()
    {
        if (Sexo.Equals('M'))
        {
            Console.WriteLine($"Eu ({Nome}) sou uma arara macho, então não posso botar ovos");
            return;
        }
        Console.WriteLine($"Eu ({Nome}) sou uma arara fêmea e estou botando um ovo");
    }

    public void Chocar()
    {
        Console.WriteLine($"Eu ({Nome}) sou uma arara e estou chocando um ovo");
    }
}

class Coruja : Ave, IVoar, IOviparo
{
    new public bool Rapina { get; set; } = true;
    new public bool CorPena { get; set; } = true;
    new public bool Carnivoro { get; set; } = true;
    new public bool Peconhento { get; set; } = false;
    public int AltitudeMaximaEmMetros { get => 40; }
    public double VelocidadeDeVoo { get => 10; }

    public Coruja(string nome, DateTime dataDeNascimento, char sexo)
    {
        this.Nome = nome;
        this.DataDeNascimento = dataDeNascimento;
        this.Sexo = Char.ToUpper(sexo);
    }

    public override void Movimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou uma coruja, caminho e voo!");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"Eu ({Nome}) sou uma coruja se comunicando!");
    }

    public override void Alimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou uma coruja e me alimento de roedores, marsupiais, insetos, aves e morcegos!");
    }

    public void Voar()
    {
        Console.WriteLine($"Eu ({Nome}) sou uma coruja e posso voar até {AltitudeMaximaEmMetros} m de altitude a uma velocidade de {VelocidadeDeVoo} de m/s");
    }

    public void Botar()
    {
        if (Sexo.Equals('M'))
        {
            Console.WriteLine($"Eu ({Nome}) sou uma coruja macho, então não posso botar ovos");
            return;
        }
        Console.WriteLine($"Eu ({Nome}) sou uma coruja fêmea e estou botando um ovo");
    }

    public void Chocar()
    {
        Console.WriteLine($"Eu ({Nome}) sou uma coruja e estou chocando um ovo");
    }
}

class Pinguim : Ave, IOviparo, IAquatico
{
    new public bool Rapina { get; set; } = false;
    new public bool CorPena { get; set; } = true;
    new public bool Carnivoro { get; set; } = false;
    new public bool Peconhento { get; set; } = false;
    public bool ViveEmTerra { get => true; }
    public bool Mergulho { get => true; }
    public bool AguaDoce { get => false; }

    public Pinguim(string nome, DateTime dataDeNascimento, char sexo)
    {
        this.Nome = nome;
        this.DataDeNascimento = dataDeNascimento;
        this.Sexo = Char.ToUpper(sexo);
    }

    public override void Movimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou pinguim, nado e caminho!");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"Eu ({Nome}) sou pinguim se comunicando!");
    }

    public override void Alimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou pinguim e me alimento de plantas!");
    }

    public void Botar()
    {
        if (Sexo.Equals('M'))
        {
            Console.WriteLine($"Eu ({Nome}) sou pinguim macho, então não posso botar ovos");
            return;
        }
        Console.WriteLine($"Eu ({Nome}) sou pinguim fêmea e estou botando um ovo");
    }

    public void Chocar()
    {
        Console.WriteLine($"Eu ({Nome}) sou pinguim e estou chocando um ovo");
    }
}

abstract class Reptil : Animal
{
    
}

class DragaoDeComodo : Reptil, IOviparo
{
    new public bool Carnivoro { get; set; } = true;
    new public bool Peconhento { get; set; } = false;
    public DragaoDeComodo(string nome, DateTime dataDeNascimento, char sexo)
    {
        this.Nome = nome;
        this.DataDeNascimento = dataDeNascimento;
        this.Sexo = Char.ToUpper(sexo);
    }

    public override void Movimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou dragão de comodo qualquer e rastejo!");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"Eu ({Nome}) sou dragão de comodo qualquer se comunicando!");
    }

    public override void Alimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou dragão de comodo qualquer se alimentando!");
    }

    public void Botar()
    {
        if (Sexo.Equals('M'))
        {
            Console.WriteLine($"Eu ({Nome}) sou um dragão de comodo macho, então não posso botar ovos");
            return;
        }
        Console.WriteLine($"Eu ({Nome}) sou um dragão de comodo fêmea e estou botando um ovo");
    }

    public void Chocar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um dragão de comodo e estou chocando um ovo");
    }
}

class Jacare : Reptil, IOviparo, IAquatico
{
    new public bool Carnivoro { get; set; } = true;
    new public bool Peconhento { get; set; } = false;
    public bool ViveEmTerra { get => true; }
    public bool Mergulho { get => true; }
    public bool AguaDoce { get => true; }
    public Jacare(string nome, DateTime dataDeNascimento, char sexo)
    {
        this.Nome = nome;
        this.DataDeNascimento = dataDeNascimento;
        this.Sexo = Char.ToUpper(sexo);
    }

    public override void Movimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou dragão de comodo qualquer e rastejo!");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"Eu ({Nome}) sou dragão de comodo qualquer se comunicando!");
    }

    public override void Alimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou dragão de comodo qualquer se alimentando!");
    }

    public void Botar()
    {
        if (Sexo.Equals('M'))
        {
            Console.WriteLine($"Eu ({Nome}) sou um dragão de comodo macho, então não posso botar ovos");
            return;
        }
        Console.WriteLine($"Eu ({Nome}) sou um dragão de comodo fêmea e estou botando um ovo");
    }

    public void Chocar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um dragão de comodo e estou chocando um ovo");
    }
}

class Ornitorrinco : Mamifero, IAquatico, IOviparo
{
    new public bool Carnivoro { get; set; } = true;
    new public bool Peconhento { get; set; } = false;
    new public int QtdeMamas { get; set; } = 4;
    new public bool Pelos { get; set; } = false;
    public bool ViveEmTerra { get => true; }
    public bool Mergulho { get => true; }
    public bool AguaDoce { get => true; }

    public Ornitorrinco(string nome, DateTime dataDeNascimento, char sexo, string corDoPelo)
    {
        this.Nome = nome;
        this.DataDeNascimento = dataDeNascimento;
        this.Sexo = Char.ToUpper(sexo);
        this.CorDoPelo = corDoPelo;
    }

    public override void Movimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um ornitorrinco, nado e caminho!");
    }

    public override void Comunicar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um ornitorrinco falando!");
    }

    public override void Alimentar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um ornitorrinco e como pequenos peixes, camarões, caranguejos e alguns insetos aquáticos!");
    }

    public override void Amamentar()
    {
        if (Sexo.Equals('M'))
        {
            Console.WriteLine($"Eu ({Nome}) sou um ornitorrinco macho, então não posso amamentar");
            return;
        }

        Console.WriteLine($"Eu ({Nome}) sou um ornitorrinco fêmea e posso amamentar até {QtdeMamas} filhotes");
    }

    public void Botar()
    {
        if (Sexo.Equals('M'))
        {
            Console.WriteLine($"Eu ({Nome}) sou um ornitorrinco macho, então não posso botar ovos");
            return;
        }
        Console.WriteLine($"Eu ({Nome}) sou um ornitorrinco fêmea e estou botando um ovo");
    }

    public void Chocar()
    {
        Console.WriteLine($"Eu ({Nome}) sou um ornitorrinco e estou chocando um ovo");
    }
}
