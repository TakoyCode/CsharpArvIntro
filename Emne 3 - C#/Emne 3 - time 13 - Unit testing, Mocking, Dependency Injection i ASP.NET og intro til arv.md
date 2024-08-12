# Planen for i dag
1. Unit testing og mocking av koden fra sist
    (dvs. telling av linjer med og uten søketekst)

2. Dependency Injection i ASP. NET
    jeg viser et oppsett som bruker den innebygde DI—motoren

3. Introduksjon til arv
    kommandostyrt program
    hva kan vi få til med arv som du ikke kan få til med interface


# Del 1

## Recapper programmet fra sist
.Contains() - tar inn verdien du søker etter og hvordan regler den søker etter. Og gir ut true eller false om den fant eller ikke fant verdien.

StringComparison.CurrentCultureIgnoreCase
    En av søkereglene du kan gi til .Contains(), gjør at den ignorer om verdiene er uppercase eller lowercase når den søker etter verdien. 
    Og at den tar hendsynd til lokale skrive regler f.eks at aa blir å

## Unit testing
### Mock
Data som er fleksible / lett å endre på og som gjør det lett å unit teste

## Mock verktøy: Moq
Rammeverk for mocking av unit tests
Gjør at du slipper å lage dinne egne mock klasser


# Del 2

## Mocking av interfacer
Lage service klasser som har logikk/funksjonalitet, men i stedet for å la de f.eks: snakke med en API selv, snakke med en database selv, sende mail selv, osv.
Så abstraktherer man det bort med underligende tjenester, som du tar i mot med Constructor injection.

Gjør det mulig å bruke den samme logikken med flere reelle implementasjoner, og teste den logikken fungerer før du skriver de underligene tjenestene.

## Dependency Injection i ASP .NET
I ASP .NET er det innebygget en Dependency Injection motor, som gjør det vannlig å bruke Dependency Injection der.

Task<>
    Er en Datatype 
    Har med Async programmering i C#
    Fungerer som promises i JS

Bruker C# rammeverket Dapper, sånn man kan gjøre SQL fra C#

Task.FromResult - Gjør at du kan pakke ting inn som en Task, selv om det ikke er en Async operasjon fra før av

### Parameter Injection
Er som constructer injection men i parametere i stedet.

Er at du spør etter interfacer i ett parameter, og bruker den i koden til metoden som spør om det.
Det er da uavhening av hvilket objekt som implementerer interfacet det spør om.

Eksempel:
app.MapGet("/textobjext", async (ITextObjectRespository repo) => 
{
    return await repo.ReadAll();
});
Denne metoden fungerer så lenge den får inn ett object som implementerer ITextObjectRespository interfacet, som gjør det til ett eksempel på Parameter Injection.

### Builder.Services
builder.Services - Er for at du kan registrere nye tjenester(servicer)

builder.Services.AddScoped<Interface, Class_Name>(); - Betyr at når noen spør om "Interface", så skal de få et object av "Class_Name" klassen.
    For at dette skal virke må "Class_Name" ha en blank contructor eller om alle tingene constructorer ber om også er registrert

builder.Services.AddSingelton(new Class_Name()); - Betyr at vi skal bare ha ett enkelt object av "Class_Name"
    Som betyr at alle som ber om ett object av "Class_Name" vil få akkurat det objectet som er deklarert i AddSingelton()

## Intro til arv

### Går gjennom eksemplet før han koder det om til å bruke arv

### Viktigste ting i arv og interface
Viktigste vi trenger interface til er dependency injection og dependency inversion

Mens arv er vi ute etter å modellere med objekt orientert moddelering, og bruke det til å modellere ting som har relasjoner i virkeligheten.

Arv syntax:
internal class Class_Name1 : Class_Name2
{
    // Klasse ting
}
- Her arver Class_Name1 nå fra Class_Name2, så nå vil Class_Name1 få tilgang til tingene som ligger i Class_Name2 klassen

Du kan bare arve fra en klasse, men du kan implementere så mange interfacer som du vil.


# Del 3

## Arv
Poenget med arv er at du definerer noe en gang, også kan andre klasser arve det 

protected - Betyr at det er som private, men du kan forsatt endre det i klasser som arver klassen som har proteced i seg.
f.eks:
proteced string Text;

Med arv så kan du fokusere mer på hva som er unikt mellom klassene, og ha en klasse som de arver alt som de har felles fra.

virtual - Betyr at du KAN override metoden som har virtual i seg
f.eks:
public virtual string Run()
{
    return "bingus bongus";
}

override - Betyr at du kan overstyre hva en metode som du arver skal gjøre
f.eks:
public override int Run()
{
    return 123;
}

abstract - Betyr det er en uferdig metode som ikke har noen kropp, og at du MÅ override den i klassen som arver abstract metoden.
f.eks
public abstract void (Run);

Også hvis du har en abstract metode i en klasse så må klassen også være abstract
f.eks:
internal abstract class Class_Name
{
    // Class things
}

Hvis en arv klasse bare har abstrakte metoder, så er den nesten helt lik ett interface

Vis en klasse er abstract så kan du ikke lage objecter av den

### Arv vs Interface
Ideen til et Interface er at du definerer et grensesnitt ikke oppførsel

Men i Arv kan du ha en miks av grensesnitt og oppførsel som du arver


### Dyppere inn i arv
Alt i C# arver direkte eller indirekte fra klassen "object"

Vis du ikke skriver noe bak constructoren i klassen som arver så legger den til " : base()" til constructorern f.eks:
internal class Class_Name : Arv_Class_Name
{
    public Class_Name() : base()
    {
    }
}

base() - betyr å kalle på constructoren til den klassen du arver fra

Med dette kan du sende videre parametere du får i klassen som arver, til klassen den arver fra.
f.eks:
internal class Arv_Class_Name
{
    private string _text;

    protected Arv_Class_Name(string text)
    {
        _text = text;
    }
}

internal class Class_Name : Arv_Class_Name
{
    public Class_Name(string Message) : base(Message)
    {
    }
}

Fordelen med dette er at vis du skal endre litt logikken med hvordan ting blir gjort i constructoren.
Så kan du bare gjøre den endringen bare i Arv klassen, å du slipper å endre det i contructoren til alle som arver klassen.