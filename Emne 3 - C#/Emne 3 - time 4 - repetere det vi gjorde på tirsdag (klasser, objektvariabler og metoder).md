# Plannen for i dag:
(litt repetisjon om hvordan lage objekter i C# omtrent som Vi gjorde i JavaScript)
(metoder inn i klasser + constructor)
clicker med bestemt bokstav
uten klasse
med klasse
mange objekter
ev. om static vs ikke—static
lese og skrive JSON — save og load clicker

# Del 1

## Clicker eksempel
simple clicker game som kjører i terminalen

Console.Clear() for å tømme skjermen

Console.ReadKey(true)
    true i modulen trenger vi som at ReadKey() ikke viser fram keyen vi har trykket på i terminalen
    
    Du kan lagre denne keyen i en variabel med var cmdKey = Console.ReadKey()
    Og får å sjekke den keyen i variablen, så kan du gjøre det med f.eks cmdKey.KeyChar == 'a' eller cmdKey.Key == ConsoleKey.A


ctrl r + ctrl m, drar ut det du hovrer over til en ny metode

### Variabel syntax regler
    bruker _ når de er private  f.eks int _points
    og stor forbokstav når de er public f.eks Points

### Klasser

alt + shift + c for å lage en ny klasse

static per klasse for hele klasse

ikke static per objekt, kan ikke kalle de uten ett objekt

# Del 2

## Klasser pt. 2

string.ToUpper("Tekst eller variabel") - gjøre alle bokstavenen store

### Constructors
ctor + enter for å lage en contructor raskt

Bruker det til å lage ett nytt objekt, med verdier som du setter

Readonly, veldig likt som const i JS

### Inkappsling

sette private på variablene i klassen

gjøre at du er sikker på at ingenting utenfor klassen ender på de variablene

### Static og ikke-Static pt.2

metoder som er static kan bare lese static variabler og metoder

mens metoder som ikke er static kan lase både static og ikke static variabler og metoder

# Del 3

## JSON

JsonSerializer.Serialize - Er det samme som JSON.stringify i JS - Gjør om hva det tar inn til tekst
    Må bryte innkapsling litt for å bruke det

JsonSerializer.Deserialize<datatype>(variabel, options) - blir som JSON.parse i JS - Gjøre Json tekst om til C# igjen

File.WriteAllText("string", json) - lagrer en variablen som en fil, i dette tilfele Json filen vår.

File.ReadAllText("filepath") - leser gjennom en fil, som du kansje kan lagre det i en variabel senere

Kan finne mange JSON data set på nettet som du kan lage ting med!
    - kan også spøre chat-gpt om det, bare husk å spøre å få det som JSON

shift + f2 kan du bruke til å lage nye filer i VS



