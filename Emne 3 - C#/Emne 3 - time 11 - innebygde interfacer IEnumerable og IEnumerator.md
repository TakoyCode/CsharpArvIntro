# Planen for i dag
- IEnumerable og IEnumerator
    - to innebygde interfacer
    - fine eksempler på interface
    - sentrale i C#
- LINQ
    - extension methods

plan fremover:
- Dependency inversion
- Service klasser
- Unit testing og mocking
- Arv

# Del 1

## IEnumerable og IEnumerator
IEnumerable og IEnumerator er to interfacer som er bygd inni .net
 
IEnumerable - er noe man kan gå gjennom f.eks en array [1,2,3]
IEnumerator - å gå gjennom det, en gjennomgang av noe f.eks: en løkke

Du kan foreach-e gjennom alt som er IEnumerable
Når du setter i gang en løkke så vil den bruke en IEnumerator

Disse interfacene gjør det mulig å ha klasser som representerer en serie av ting

Kan bruke det som en vannelig interface for klasser, er bare at den er en innebygd interface

### Interface tips
Bedre å bare lage flere små interfacer, enn å en stor enn som ikke passer alt den er brukt i.

Hvordan implementere flere interfacer:
internal class Class_Name : Interface1, Interface2

### Når hadde du laget egne IEnumerable og IEnumerator i den virkelige verden?
Hvis du vil spare minne, f.eks. ved at du ikke trenger å lagre så mye ting i minnet


# Del 2

### Når hadde du laget egne IEnumerable og IEnumerator i den virkelige verden? pt.2
Ett annet tilfelle er at av og til vil du kansje gå gjennom enn array i tilfeldig rekkefølge.
Da kan det være lurt å lage en IEnumerator/IEnumerable klasse for det.

## LINQ
Noen funksjonele extensions som kan bli brukt på alle IEnumerable's

### Forskjellene mellom hvordan JS, LINQ og SQL skriver viktige metoder
Java script     LINQ              SQL
- filter        - Where           - Where
- map           - Select          - Select
- find          - First           - Where
                  FirstOrDefault
                  Single
                  SingleOrDefault

## Lambda uttrykk
Det samme som en "arrow function"
Blir litt som en anonym metode, som kan bare bli brukt på ett sted

Du kan lagre et lambda uttrykk i en variabel slikt:
Func<int, bool> evenNumbers = n => n % 2 == 0;
- Eksemplet over tar inn ett tall(n) og bruker modulus på den for å finne ut om det er ett helt tall.
- Func<int, bool> betyr at den tar inn en "int" og at den returnerer en "bool"

## LINQ eksempeler

IEnumerable.Where("lambda uttrykk") 
- Tar inn ett lambda uttrykk i parameterne og bruker den til å filtrere gjennom IEnumerable'n står foran.
- .Where() metoden blir brukt som en extension metode, som betyr at du bare "lenker" den bak no
- Hvis du lagrer det du får ut fra .Where() i en variabel f.eks: var NumbersLessThan1 = numbers.Where(n => n < 0); 
Vil det da bli lagret som datatypen IEnumerable<int>.

.ToArray() - Gjør IEnumerable'n foran til en array
.ToList() - Gjør IEnumerable'n foran til en list
.ToDictionary() - Gjør IEnumerable'n foran til en dictionary (Har ikke gått gjennom denne datatypen)


## Fordeler med LINQ
Den gjør ingenting før den må. f.eks.
Selv om vi deklarerer variablen her:                          var evenNumbers = number.Where(n => n % 2 == 0);
Så blir den ikke brukt før senere i koden når vi bruker den:  foreach(var number in evenNumbers){ // Do the thing }

Dette gjør det fordi meste parten av tiden, vil dette gi bedre ytelse.

## Chaining av LINQ metoder
Du kan "lenke" sammen LINQ metoder f.eks.
var filterdNumbersArray = numbers.Where(n => n > 0).Where(n => n < 100).ToArray()

Dette er mulig på grunn av interface't "IQueryable".


# Del 3

## Map

### Map uten LINQ
var numbers = new int[] {1, 2, 3, 4, 5}; - En array med tall
var dots = new List<string>(); - Holder på teksten vi ut av løkka under
foreach (var number in numbers) - Gjør om numbers til tekst rader laget av *, som vi lagrer i dots
{
    dots.Add(new string('*', number) + " (" + number + ")" ); 
}

foreach (var text in dots) - Tegner opp de nye * radene som er lagret i dots
{
    Console.WriteLine(text);
}

### Map med LINQ
var numbers = new int[] {1, 2, 3, 4, 5}; 
var dots = numbers.Select(number => new string(('*', number) + " (" + number + ")" )) 
- Gjør om numbers til tekst rader laget av *, som vi da lagrer i variablen
- Med andre ord: Gir .Select() en metode som gjør om hvert element i den opprinlige lista, til den verdien du vil ha i den nye lista.

foreach (var text in dots) - Tegner opp de nye * radene som er lagret i dots
{
    Console.WriteLine(text);
}j


## .First() og .Singel()
.First(metode) - Gir deg det første elementet, som metoden returnerer true til

f.eks:
var numbers = new int[] {1, 2, 3, 4, 5}; 
int dot = numbers.First(n => n < 10) - Da vil dot bli 1

Hvis den ikke finner noe vil den feile
Du kan da bruke .FirstOrDefault(), da vil den ikke feile men returnere null vis den ikke finner noe

.Single() - Gir deg det første elementet, men brukes bare når det ikke skal komme mer enn ett element
f.eks:
var numbers = new int[] {1, 2, 3, 4, 5}; 
int dot = numbers.Single(n => n == 1) - Det burde bare finnes en av 1, så da kan vi bruke .Single()

Samme som .First vil den feile om den ikke finner noe.
Du kan da bruke .SingleOrDefault(), som da vil returnere null om den ikke finner noe.

## Flere LINQ metoder
.OrderBy() - kan putte ting i en rekkefølge basert på metoden i parameterene, funker også ved at du kan velge rekkefølgen til felt inni objekter.

.Skip() - Hopper over de X første i noe

.Take() - Tar X første fra noe og returnerer de

## Extension metoder
Starter med å lage en klasse, navnet har veldig lite å si
klasse må være static, som gjør at alt inni klassen må også være static

extension metode syntax eksempel:
internal static class StringExtensions
{
    public static string Repeat(this string str, int num)
    {
        var newString = "";
        for(int i = 0; i < n; i++)
        {
            newString += str;
        }
        return newString;
    }
}

bruks eksempel:

var text = "Audun";

uten å bruke det som en extension: 
var newText = StringExtensions.Repeat(text, 5) - Tar in "text" og legger det til 5 ganger i en ny string.

med å bruke det som en extension:
var newText = text.Repeat(5); - tar in text forran som parameter og legger det til 5 ganger i en ny string.

I extension metoder kan du legge til nye metoder til datatyper som ikke var der fra før.

## Partial
public partial class ClassName{} 
- partial betyr at klassen kan bli definert i flere filer.
- Veldig fint å bruke vis du genererer kode, som du vil ha i en annen fil

## LINQ hjelpe metode
Enumerable.Repeat(char, repeat times) - tar inn en char og en int. Og returnerer en IEnumerable med så mange char's.

## Builder pattern
Builder pattern er ett design pattern.

LINQ bruker dette, har med hvordan man kan lenke metoder i LINQ.

Ofte i building pattern gjør de at klassene returnerer klassen de er, sånn at det kan bli brukt til å bli "lenka" til andre metoder
Eksempel klasse som bruker builder pattern:
internal Class MultiplyNum
{
    private int _number;

    public MultiplyNum(int num)
    {
        _number = num;
    }

    public MultiplyNum Multiply(int num)
    {
        _number *= num;
        return this;
    }

    De pleier også å ha en metode til slutt, som bygger det du skal bygge og returnerer det.
    public int Build()
    {
        return _number;
    }
}

Hvordan det blir ser ut når det blir brukt:

var MultipliedNumber = new MultiplyNum(1).Multiply(2).Multiply(4).Multiply(8).Multiply(16).Build();
- Og etter alle metodene har kjørt, så burde MultipliedNumber være 1024.
