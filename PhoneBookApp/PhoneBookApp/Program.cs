
using PhoneBookApp;

Console.WriteLine("Phonebook");


Console.WriteLine("Select operation");
Console.WriteLine("1: Add contact");
Console.WriteLine("2: Dispaly contact by number");
Console.WriteLine("3: View all contact");
Console.WriteLine("4: Search for contacts for given name");
Console.WriteLine("Press X to EXIT");

var userInputs = Console.ReadLine();

var phoneBook = new PhoneBook();

while (true)
{
	switch (userInputs)
	{
		case "1":
			Console.WriteLine("Contact name");
			var name = Console.ReadLine();
			Console.WriteLine("Contact number");
			var number = Console.ReadLine();

			var newContact = new Contact(name, number);
			phoneBook.AddContact(newContact);
			break;
		case "2":
			Console.WriteLine("Contact number to search");
			var searchNumber = Console.ReadLine();
			phoneBook.DisplayContact(searchNumber);
			break;
		case "3":
			phoneBook.DisplayAllContact();
			break;
		case "4":
			Console.WriteLine("Name search phase");
			var searchPhase = Console.ReadLine();
			phoneBook.DisplayMatchingContact(searchPhase);
			break;
			case "x":
			return;
			break;
		default:
			Console.WriteLine("Select valid operation");
			break;
	}
	Console.WriteLine("Select operation");
	userInputs = Console.ReadLine();
}
