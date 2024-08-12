# Planenn for i dag:
- Dependency Inversion Principle
    - teorien bak det
    - hvordan bruke det praktiskt


# Del 1

## Dependency Inversion Principle
Er D-en i SOLID prinsipene

Handler om hvordan man ungår sirkulære avhengigheter ved å implementere abstraksjoner
- (abstraksjoner er grensesnitt(interface) eller abstrakte klasser.) 

### Eksempel 1 - Chat server og chat client
Samme eksempel som han går over i moodle vidoen - Introduksjon til interface og Dependency Inversion Principle

Sjeldent at det er sirkulære avhengigheter, men de skjer av og til.

### Class libary
Er bare en komponent i ett større system, er ikke en app i seg selv
Er kode som kan bli kompilert ned til en DDL, som den kan bli inkludert i andre applikasjoner

### .Net versjoner
Når du importerer kode, sjekk at alt deler samme .net versjon
Fordi ting stopper å funke, når de er på forskjellige versjoner

### Prosjekter og sirkulære avhengigheter
Du kan ikke ha sirkulære avhengigheter mellom prosjekter.

Å dele opp ting i prosjekter er enn metode for å beskytte oss selv, fra sirkulære avhengigheter

### Snu avhengighetene
Dependency Inversion Principle handler om å snu avhengighetene fra hverandre opp til en ny abstraksjon

Eksempel:
fra A => B og B => A
til A => B , A => C og B => C


# Del 2 

### Dependecy injection
Det vi driver med over med å snu avhengighetene, heter dependency injection

## Eksempel 2 - Count lines

### Forskjellene mellom å streame og laste ned en fil
Når du streamer en fil, kan du begynne å bruke den når en porsjon av filen er lasta ned
Men når du laster ned en fil, trenger du å laste ned hele filen før du kan bruke den

For programmering:
Gjør at du bare trenger å holde deler av filen i minnet, i stedet for måtte holde på hele filen i minnet

### System Input Output klasser
https://learn.microsoft.com/en-us/dotnet/standard/io/ 

### Bryt på Single responsibility prinsippet
Klassen som ble lagd bryter prinsippet.
Det Gjør det med å gjøre 2 ting samtiddig:
1. Den beregner og henter
2. Den leser gjennom og teller opp

Vi fikser dette ved å dele opp disse forskjellige ansvarene.
Dette gjør vi ved å lage ett interface for hvordan vi skal hente inn daten.
Og lar den nåværende klassen være og lar den lese gjennom og telle opp daten. 

### Constructor injection
Når du lager en ett objekt av en klasse, så sender du inn ett eller flere objekter som implementerer ett interface som parameter.

Med andre ord: Du tar inn som parameter, ett interface for hver underliggende tjenester som du trenger.

f.eks:
internal class LineCountService
{
    private ILineSource _lineSource;

    public LineCountService(ILineSource lineSource)
    {
        _lineSource = lineSource;
    }
}

### Dependency Inversion Principle i praksis
Du lager service klasser som har metoder for å gjøre forskjellig logikk.

Men alle detaljer om hvordan de underliggende tjenestene som klassen bygger på, de abstraktheter du bort med interfacer.

Dette gir deg en del fleksibilitet i koden din.


# Del 3

## Hvorfor bruke det?
Testbar kode er bra kode.

Kan nå mye lettere ha flere variasjoner av det som henter in data.

Hjelper med gjennbruk, fordi du kan bruke den samme logikken til hver variasjon av hvordan du henter inn data.

## WebClient
Er en eldre innebygd klasse, som gjør at du kan lese innhold fra en nettside med:
var webClient = new WebClient();
webClient.OpenRead(url);

## Mock data
Data som er brukt for unit testing av koden.

Hvordan koden er satt opp gjøre det lett å lage data source'r som er lett å lage og teste

## Recap
Terje går gjennom koden han har skrevet en gang til