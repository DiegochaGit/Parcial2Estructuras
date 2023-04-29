using LinkedLists.Logic;

Console.WriteLine("*** Car Linked Lists ***");

var mbSedan = new Automovil { Brand = "Mercedes-Benz", Model = "Sedan", Year = 2020, Price = 50000000, Color = "Blue" };
var mbVan = new Automovil { Brand = "Mercedes-Benz", Model = "Van", Year = 2021, Price = 100000000, Color = "Gray" };
var mbFamily = new Automovil { Brand = "Mercedes-Benz", Model = "Familiar", Year = 2022, Price = 150000000, Color = "Black" };

var renaultLogan = new Automovil { Brand = "Renault", Model = "Sedan", Year = 2020, Price = 45000000, Color = "Red" };
var renaultKwid = new Automovil { Brand = "Renault", Model = "Van", Year = 2021, Price = 110000000, Color = "Gray" };
var renaultDuster = new Automovil { Brand = "Renault", Model = "Sport", Year = 2022, Price = 170000000, Color = "Black" };

var toyotaHilux = new Automovil { Brand = "Toyota", Model = "Sedan", Year = 2021, Price = 40000000, Color = "Blue" };
var toyotaCorola = new Automovil { Brand = "Toyota", Model = "Sport", Year = 2022, Price = 115000000, Color = "Red" };
var toyota4Runner = new Automovil { Brand = "Toyota", Model = "Familiar", Year = 2023, Price = 180000000, Color = "Black" };

var mazdaCX30 = new Automovil { Brand = "Mazda", Model = "Sport", Year = 2021, Price = 55000000, Color = "Red" };
var mazda3 = new Automovil { Brand = "Mazda", Model = "Van", Year = 2022, Price = 105000000, Color = "Gray" };
var mazda2Sport = new Automovil { Brand = "Mazda", Model = "Familiar", Year = 2023, Price = 200000000, Color = "Blue" };

var automovils = new DoubleList<Automovil>();
automovils.Add(mbSedan);
automovils.Add(mbVan);
automovils.Add(mbFamily);
automovils.Add(renaultLogan);
automovils.Add(renaultKwid);
automovils.Add(renaultDuster);
automovils.Add(toyotaHilux);
automovils.Add(toyotaCorola);
automovils.Add(toyota4Runner);
automovils.Add(mazdaCX30);
automovils.Add(mazda3);
automovils.Add(mazda2Sport);
Console.WriteLine("Cars List =>");
Console.WriteLine(automovils);

//Returns the cars of a brand
Console.WriteLine("Returns the cars of a brand: ");
var output = automovils.GetBrand("Mercedes-Benz");
Console.WriteLine(output);

//Returns the cars in a range of years
Console.WriteLine("Returns the cars in a range of years: ");
var output2 = automovils.GetYear(2021, 2022);
Console.WriteLine(output2);

// Retorna los carros dependiendo de los siguientes criterios. 
// Nota si en los criterios de marca, color y modelo 
// se envía * significa que son todos 
Console.WriteLine("Returns the cars depend of criteries: ");
var output3 = automovils.GetSeveralFilters("Mazda", "Van", "Gray", 2022, 150000000);
Console.WriteLine(output3);

