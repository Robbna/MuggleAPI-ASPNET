using Newtonsoft.Json;

using Model;

WebApplication app = WebApplication.Create();

List<Character> ?characters  = JsonConvert.DeserializeObject<List<Character>>(File.ReadAllText(Path.Combine("src", "data", "characters.json")));
List<Spell>? spells          = JsonConvert.DeserializeObject<List<Spell>>(File.ReadAllText(Path.Combine("src", "data", "spells.json")));
List<Book>? books            = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(Path.Combine("src", "data", "books.json")));
List<Potion>? potions        = JsonConvert.DeserializeObject<List<Potion>>(File.ReadAllText(Path.Combine("src", "data", "potions.json")));

app.MapGet("/characters", () =>
{
  return characters;
});

app.MapGet("/spells", () =>
{
  return spells;
});

app.MapGet("/books", () =>
{
  return books;
});

app.MapGet("/potions", () =>
{
  return potions;
});

app.Run();