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
var output1 = automovils.GetBrand("Mercedes-Benz");
Console.WriteLine(output1);

//Returns the cars in a range of years
Console.WriteLine("Returns the cars in a range of years: ");
var output2 = automovils.GetYear(2021, 2022);
Console.WriteLine(output2);

// Returns the cars depending on the criteria. 
// Note if in the brand, color and model criteria is sent * means that they are all of them

Console.WriteLine("Returns the cars with all of the criteries: ");
var output3 = automovils.GetSeveralFilters("Mazda", "Van", "Gray", 2022, 150000000);
Console.WriteLine(output3);

Console.WriteLine("Returns the cars with the criteries brand=* y model=*: ");
var output4 = automovils.GetSeveralFilters("*", "*", "Gray", 2021, 100000000);
Console.WriteLine(output4);

Console.WriteLine("Returns the cars with the criteries model=* y color=*: ");
var output5 = automovils.GetSeveralFilters("Mazda", "*", "*", 2022, 150000000);
Console.WriteLine(output5);

Console.WriteLine("Returns the cars with the criteries brand=* y color=*: ");
var output6 = automovils.GetSeveralFilters("*", "Van", "*", 2022, 150000000);
Console.WriteLine(output6);

Console.WriteLine("Returns the cars with the criterion brand=*: ");
var output7 = automovils.GetSeveralFilters("*", "Van", "Gray", 2022, 150000000);
Console.WriteLine(output7);

Console.WriteLine("Returns the cars with the criterion model=*: ");
var output8 = automovils.GetSeveralFilters("Mazda", "*", "Gray", 2022, 150000000);
Console.WriteLine(output8);

Console.WriteLine("Returns the cars with the criterion color=*: ");
var output9 = automovils.GetSeveralFilters("Mazda", "Van", "*", 2022, 150000000);
Console.WriteLine(output9);

Console.WriteLine("Returns the cars with the criteries brand=*, model=* y color=*: ");
var output10 = automovils.GetSeveralFilters("*", "*", "*", 2022, 150000000);
Console.WriteLine(output10);

//// To array
//Console.WriteLine("List with min and mas Price converted to array =>");
//var output11 = automovils.GetMinMax();
//Console.WriteLine(output11);

