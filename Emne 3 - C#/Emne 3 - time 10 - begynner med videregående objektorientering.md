# Planen for i dag
1. Intro til interface via tekst—etementer som gjør samme ting på forskjellig måte
    Polymorfisme (arv og Interface — vs JavaScript)

2. kommandostyrt program

Bonus: Hva er OO? Eksempel: Hus
Oppførsel kan også være klasser.

# Del 1

## Padde Text
I stedet for å starte med en blank string også padden den så kan du skrive det slikt:
new string(paddingCharm, padCount)
    paddingChar er hva du skal legge til med 
    padCount blir til hvor lang du vil at stringen skal bli til slutt 

## Object
object er bare en klasse, men alle klasser arver fra object
    Skal gå dyppere inn i dette senere i forhold til arv

## Hvordan loope mellom en array av klasser
Hvis du lager en Array av object, så kan kan den da holde på flere forskjellige klasser. 
f.eks: var Classes = new object[] { new Class1(), new Class2(), new Class3(), };

Du kan da loope mellom alle klassene i Classes arrayen med en foreach løkke
f.eks: foreach(var class in Classes){ Gjør noe med class her }

Men for å da bruke class elementet i løkken som en vannlig klasse igjen, så må du først cast-e den til den riktige klassen først 
f.eks: foreach(var class in Classes){ (Class1)class.GjørNoeVeldigKult() }

Det kan også da hende at du vil sjekke hvem klasse class er før du caster den til en annen klasse da gjør du slikt
f.eks: if(class is Class1){  (Class1)class.GjørNoeVeldigKult() }

Ulempen med denne metoden er at det kan bli tungvint å legge til nye classes inni Classes arrayen i fremtiden,
siden du må legge til nye if sjekker for hver ny klasse du legger til

### Flere eksempler på hvordan man kan caste ett object til en klasse
En variasjon av if sjekken: if(class is Class1 class){ class.GjøreNoeVeldigKult() } - Gjør det samme men syntaxen er litt 

en annen metode å gjøre det på: 
var CastedClass = class as Class1; - Dette caster Class1 på CastedClass vis den er av typen Class1 og vis ikke så blir den null 
if(CastedClass != null){ CastedClass.GjørNoeVeldigKult() } - Så vis Casting-en gikk gjennom, så kaller vi metoden inni Class1

Enda et eksempel men mye kortere syntaks:
(class as Class1)?.GjørNoeVeldigKult() - Den sjekker om class er Klassen Class1 og vis den er det så kaller den metoden

## Brukergrensenitt
Brukergrensenitt åpner opp deler av funksjonaliteten for en bruker

Ett utvalg av metoder som er tilgjengelig utenfra

## Interface
Ett interface definerer på en måte hva som er tilgjenlig fra utsiden

En interface er som en kontrakt, ting som bruker interface må følge den samme "avtalen"

Du kan bruke interface som en datatype i forhold til lister, arrays, osv. 
Men du kan ikke lage objekter med ett interface 

Interface'r sine navn ofte har en I foran navnet til den f.eks: IContracts

Synntaks for Interface: internal interface InterfaceName{}

Syntaks for å bruke ett Interface i en klasse:
internal class ClassName : InterfaceName - Du kan lese dette som ClassName vil innføre kontrakten, jeg vil være en InterfaceName 

Interface er en kontrakt og i den kan du legge til krav f.eks:
internal interface InterfaceName { void Show(); } - Dette betyr at hvis du vil innføre kontrakten med InterfaceName, så må klassen ha metoden "void Show();"

Du kan da bruke metoden Show() på interfacet InterfaceName når du bruker det som en datatype f.eks:
var Objects = new InterfaceName[]{ new Class1(), new Class2(), new Class3(), }; - Vi lager da først en Array av typen InterfaceName som vi kan loope gjennom
foreach(object in Objects) { object.Show(); } - Vi kan da bruke en foreach løkke, å kalle .Show() på alle objektene fordi de alle sammen har innført kontrakten med InterfaceName

Interface hjelper oss med å gjøre koden mer fleksibel

# Del 2

## Interface repitisjon
Å bruke interface's hjelper med å ungå spaghetti kode, fordi ting blir i mindre grad påvirket av endringer

## Polymorfisme
Polymorfisme - betyr at noe er mangeformet

Hva det gjør er det samme men, hvordan det gjør det er forskjellig

To mekanismer av polyformise som vi lærer er arv og interface 

## Nytt eksempel - To-do liste
Console.ResetColor() - Innebygd metode i Console som reseter fargende tilbake til default

## Overloading av constructorer
Eksempel av overloading av en constructor:

public Person(string name) : this(name, 18) {}
Dette gjør at vis du bare sender inn "name" til constructoren, så setter den "age" til 18 for deg.
Det gjør dette ved å kalle opp constructoren under, med "name" som er verdien du sendte inn og 18 som verdien til "age" som blir satt for deg.

public Person(string name, int age) {} 

## Default parametere
For å bruke default parametere må en datatype være null-able.
Så vis den ikke er det må du bruke ett ? etter datatypen for å gjøre den null-able, slik at du kan da legge til en default parameter.
f.eks: Datatype? variabelName

## Overlapping Class names
Det kan hende at av å til at du lagger en ny klasse med ett navn som er allerede i bruk.
For å ungå det må du enten endre navn på klassen eller så kan du velge hvem av de som blir brukt med:

using ClassName = Namespace.ClassName;

På toppen av filen du skal bruke det i.

## Overloading av constructorer pt.2 
Vannlig feil med hvordan å overloade constructorer er å skrive de slikt:

Public Person(string name)
{
    Name = name;
    Age = 18;
}

i stedet for slikt:
public Person(string name) : this(name, 18) 
{ 

}

Og dette er fordi vis du skriver det som number 1, så blir det vannskligere å vedlikeholde koden over tid.
Fordi når du skal endre noe i enn annen constructor, så må du endre på number 1 også.
    Og dette kan bli vannskelig å huske overtid, når du har flere constructorer. 


# Del 3

Ha en lav terskel for å lage nye klasser
Heller overdriv laging av nye klasser i en periode, enn å underdrive det i lengre tid.

## Interface pt.3
Kan være nytting å dra ut kommandoer inn i sine egene klasser, og "koble" disse klassene sammen med ett interface

Iden til ett interface er at den bare kan holde metoder.

I utgangspunktet kan man ikke egentlig ha object variabler i ett interface, men du kan komme litt rundt det med å bruke properties.
Siden properties er metoder, så kan du bruke det til å "kreve" at klassen har visse fields.

### Fast List tip
.Clear() - for å fjerne alt i en liste

## SOLID
Til langtids lista de: prøv å lære SOLID prinsipene

### Interface segregation principle
Interface segregation principle - Handler om at det er bedre å ha mange flere interfacer, som representerer ulike roller ett objekt kan ha.

### Single responsibility principle
Ett eksempel på kode som bryter Single responsibility prinsippet:
foreach (var command in commands)
{
    if(command == correctCommand)
    {
        command.Run();
    }
}

Grunnene til at denne kode bryter prinsippet er at den gjør to ting i en metode:
1. Den søker etter den rette kommandoen
2. Den sier hva vi skal gjøre med den rette kommandoen

Så får å fikse for å følge prinsippet, må vi bare dele denne koden i to. f.eks:

Del 1: søke etter riktig kommando

ICommand theCommand = null;
foreach (var command in commands)
{
    if(command.char == userinput)
    {
        theCommand = command;
    }
}

Del 2: si hva vi skal gjør med den kommandoen

if(theCommand != null){ theCommand.Run(); }

#### Eksempel SRP kode refactoring
Denne koden kan også bli skrevet som dette:
ICommand? FindCommand(ICommand[] commands, char userinput)
{
    foreach (var command in commands)
    {
        if(command.char == userinput)
        {
            return command;
        }
    }
    return null;
}

var theCommand = FindCommand(commands, userinput);
TheCommand?.Run();

### Antipattern
Hvis du har mye antipattern(mye scoping) kan det blir vanskelig å lese koden.
Så prøv å linjal-iser koden så mye som mulig.