# ARV
**Arv** refererer til konseptet med å oprette nye klasser basert på eksisterende klasser.

Hovedklassen kalles en **grunnleggende klasse (base class)** eller **foreldreklassen (parent class)**,
mens den klassen som arver fra *foreldreklassen* er kaldt for en **avledede klasse, child class** eller **subclass**.

Arv er en viktig del av objektorientert programmering og gir mullighet for gjenbruk av kode og hierarkisk organisering av klasser.


I *foreldreklassen* har du basis og det generelle, mens i den *avladede* klassen kan man legge til ekstra om det trengs,
uten å endre på *foreldreklassen*.

Eksempel:

**Parent:**
```
class Figur
{
	public int Bredde { get; set;}
	public int Høyde { get; set;}

	public void VisInfo()
	{
		Console.WriteLine($"Bredde: {Bredde}, Høyde: {Høyde}");
	}
}
```

**Child:**
```
class Rektangel : Figur
{
	public int BeregnAreal()
	{
		return Bredde * Høyde;
	}
}
```

Her oppretter vi et objekt av subklassen og bruker egenskapene og metodene fra både foreldreklassen og subklassen:
```
	public void ShowInfo()
	{
		Rektangel rektangel = new Rektangel();
		rektangel.Bredde = 5;
		rektangel.Høyde = 10;
		rektangel.VisInfo();
		Console.WriteLine($"Areal: {rektangel.BeregnAreal()}");
	}
```

Her er Figur **foreldreklassen** og Rektangel **subklassen**.
Subklassen **arver** bredde og høyde fra foreldreklassen og legger til sin egen metode BeregnAreal.
Når du da oppretter et objekt / instans av subklassen, kan du brukke *både* egenskapene og metodene fra både foreldre- og subklasser.