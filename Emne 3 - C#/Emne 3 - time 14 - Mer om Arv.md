# Plannen for i dag
1. TextElements (BulletPoint, CenteredHeader, Indented Paragraph og Inverted Text)
    Skrive om fra interface til arv
2. Ukeplan for Start IT som eksempel på arv
    Vi Tegner arvehierarki med planttext, for å forstå disse relasjonene
    Vi kan implementere noe av dette, men antar vi ikke gjør det ferdig.
3. Stjerner med ulik oppførsel.
    Et ferdig eksempel. Vi går gjennom og prøver å forstå.
    Så kan vi eventuelt legge til noen nye varianter.

# Del 1

## Eksempel 1 - TextElements - Fra interface til arv

Super klasse / Super class - klassen du arver fra
Sub klasse / Base class - klassen som arver

### base
Når vi overrider metoder, men vi vil bare legge til noe til den og ikke endre alt.
Da kan man bruke "base.MetodeNavn()", det gjør at du kan kalle på en metode som ligger i Super klassen.
Dette betyr at vi kan beholde det som ligger der fra før av, mens vi forsatt overrider og legger til den nye funksjonaliteten vi trenger.
f.eks:
internal class SuperClass_Name
{
    public virtual void Show()
    {
        Console.Writeline("Her Skjer det mye kult");
    }
}

internal class SubClass_Name : SuperClass_Name
{
    public override void Show()
    {
        Console.Write(" * ");
        base.Show();
    }
}

SuperClass_Name.Show() hadde gitt: "Her Skjer det mye kult".
SubClass_Name hadde gitt: " * Her Skjer det mye kult".

Så her får vi brukt metoden vi arver som er Show(), men vi får forsatt bruke override som at vi kan legge til " * " foran teksten.

base.Show() kan ligge hvor som helst inni override metoden, så du kunne ha kalt base.Show() også lagt til noe tekst etter den i stedet enn foran.

### this
this - Er selve klassen, klassen det er skrevet i.
f.eks:
internal class Class_Name
{
    private string _text;

    public void Show()
    {
        Console.Writeline(this.Text);
    }
}
Hadde vært dette objektet sitt "Text".

Du trenger ikke å bruke "this" når du snakker om ting som allerede ligger i klassen. Som i eksemplet over ^^.

Men når det kan være bra å bruke det er når du må sende videre objektet du er i til et annet sted. 
f.eks:
public void Send()
{
    Class_Name.SaveObject(this);
}
Her skal vi lagre objektet, så da kan vi lett bare gjøre at den sender seg selv videre som parameter.


# Del 2

## Eksempel 2 - Arvehierarki tegning av Start IT Ukeplan
Dette eksemplet var veldig visuell og mesteparten er bare Terje som stiller spørsmål til klassen.
Syns det forklarte tankegangen på hvordan man skal tenke ut ett arvehierarki ganske bra.

Foreslår å se den igjen vis jeg blir forvirret av arvehierarki.


# Del 3

## Forsetter på Eksempel 2
Viser fram ett kode eksempel til en uke plan, men matcher ikke veldig med det som ble tegnet

DayOfWeek - Er en innebygd enum datatype som inneholder alle dagene i en uke

## Eksempel 3 - Stars

Console.OutputEncoding = Encoding.UTF8; - Gjør at du kan bruke unicode karakterer i programet

Console.CursorVisible = true - Gjør at du kan gjemme eller vise cursoren

Er diskusjoner om man skal ha en abstrakt klasse å arve fra eller om arve klassen skal representere en enkel variant.
    Noen ganger er en fornuftig, andre ganger er den andre.

### Composition over inheritance
https://en.wikipedia.org/wiki/Composition_over_inheritance

Handler om at det er mange tilfeller hvor du burde bruke composition(interface) over inheritance(arv)

### Liskov substitution principle - L-en i SOLID
https://en.wikipedia.org/wiki/Liskov_substitution_principle

Handler om arv
