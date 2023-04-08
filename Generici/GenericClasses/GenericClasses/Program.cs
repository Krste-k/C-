
using GenericClasses.DataBase;
using GenericClasses.Entities;

Dog sarko = new Dog()
{
    Id = 1,
    IsSeperd = true,
    Name = "Sharko"
};

Dog donco = new Dog()
{
    Id = 2,
    IsSeperd = false,
    Name = "Donco"
};

Cat Zika = new Cat()
{
    Id = 3,
    IsNice = true,
    Name = "Zika"
};

Cat Karolina = new Cat()
{
    Id = 4,
    IsNice = false,
    Name = "Karolina"
};

BaseEntity Mache = new Cat()
{
    Id = 5,
    IsNice = false,
    Name = "Bes Ime"
};
Console.WriteLine();

GenericDB<Dog>.Insert(sarko);
GenericDB<Dog>.Insert(donco);

GenericDB<Cat>.Insert(Zika);
GenericDB<Cat>.Insert(Karolina);

Console.WriteLine("\n");
GenericDB<Dog>.PrintAll();
Console.WriteLine("\n");
GenericDB<Cat>.PrintAll();



