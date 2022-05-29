using RPG_com_POO.src.Entities;

Knight arus = new Knight("Arus",12,"Knight","Espada");
Ninja wedge = new Ninja("Wedge", 15, "Ninja","Adaga");
Wizard jennica  = new Wizard("Jennica",18,"White Wizard","Magia");
BlackWizard topapa = new BlackWizard("Topapa",18,"Black Wizard","Magia Negra");

Console.WriteLine(arus.ToString());
Console.WriteLine(wedge.ToString());
Console.WriteLine(jennica.ToString());
Console.WriteLine(topapa.ToString());

Console.WriteLine("----------------");

Console.WriteLine(arus.Attack());
Console.WriteLine(wedge.Attack());
Console.WriteLine(jennica.Attack());
Console.WriteLine(topapa.Attack());

Console.WriteLine("----------------");

Console.WriteLine(arus.Attack(10));
Console.WriteLine(wedge.Attack(20));
Console.WriteLine(jennica.Attack(4));
Console.WriteLine(topapa.Attack(15));


