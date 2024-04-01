using lab_6;

Astronaut Nova = new Astronaut("Nova Cosmos", 47);
Nova.AddHours(300);
Astronaut secondAstronaut = new Astronaut("Star Voyager", 34);
secondAstronaut.AddHours(200);

int totalSpaceHours = Nova.GetHours() + secondAstronaut.GetHours();
System.Console.WriteLine($"Nova and Star have accumulated a total of {totalSpaceHours} hours!");