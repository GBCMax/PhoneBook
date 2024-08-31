using PhoneBook;

internal class Program
{
  private static void Main(string[] args)
  {
    var phoneBook = new List<Contact>();

    phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
    phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
    phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
    phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
    phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
    phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));
    phoneBook.Add(new Contact("Максим", "Иванов", 79843453743, "maks@example.com"));
    phoneBook.Add(new Contact("Криштиано", "Рональдо", 79843453743, "ronaldo@example.com"));
    phoneBook.Add(new Contact("Алексей", "Никитин", 78347663482742, "alexey@example.com"));
    phoneBook.Add(new Contact("Артем", "Дзюба", 435634895345, "dzyuba@example.com"));
    phoneBook.Add(new Contact("Лев", "Яшин", 435634895345, "dzyuba@example.com"));

    Console.WriteLine("Неотсортированный список:");

    Console.WriteLine();

    foreach(var contact in phoneBook)
    {
      Console.WriteLine($"Имя: {contact.Name}, фамилия: {contact.LastName}");
    }

    Console.WriteLine();

    phoneBook = [.. phoneBook.OrderBy(c => c.Name).ThenBy(c => c.LastName)];

    Console.WriteLine("Отсортированный список:");

    Console.WriteLine();

    foreach (var contact in phoneBook)
    {
      Console.WriteLine($"Имя: {contact.Name}, фамилия: {contact.LastName}");
    }

    var pages = Math.Ceiling((double)phoneBook.Count() / 3);

    Console.WriteLine();

    Console.WriteLine("Введите номер страницы:");

    while (true)
    {
      var input = Console.ReadKey().KeyChar;

      var parsed = Int32.TryParse(input.ToString(), out int pageNumber);

      if (!parsed || pageNumber < 1 || pageNumber > pages)
      {
        Console.WriteLine();
        Console.WriteLine("Страницы не существует");
      }
      else
      {
        var pageContent = phoneBook.Skip((pageNumber - 1) * 3).Take(3);
        Console.WriteLine();

        foreach (var entry in pageContent)
          Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber);

        Console.WriteLine();
      }
    }
  }
}