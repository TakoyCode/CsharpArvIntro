# Access modifiers

**Tilgangsmodifikatorer (access modifiers)** er *nøkkelord* som spesifiserer synlighet eller tilgjenelighet til
typer og deres medlemmer (felt, metoder, egenskaper, osv) innenfor et program.
Det er flerer typer *access modifiers* som styrer hvordan ulike deler av koden kan samhandle med hverandre.

*Noen av disse er nevt tidligere og som dere sikker er vant med å bruke nå, men her er noen av de viktigste:*

**Public** - De som er *public* er tilgjenelig fra annen kode i samme assembly (samling av koder som blir bygget
sammen, "bibliotek") eller prosjekt, samt fra andre assemblyer som refererer til assemblyet som inneholder det
offentlige medlemmet.

**Private** - De som bruker *private* er bare tilgjengelig innenfor samme klasse eller struktur og subklasser.
De er ikke tilgjenlige fra utsiden av klassen.

**Protected** - De som bruker *protected* er tilgjenlige innenfor samme klasse eller struktur og subklasser.
De er ikke tilgjengelige fra utsiden av klassen eller strukturen.

**Internal** - De som bruker *internal* er tilgjengelig innenfor samme assembly og blir skjult for kode fra andre
assemblies.

**Protected Internal** - De som bruker *protected internal* får tilgang til medlemmer fra samme assembly eller
fra subklasser, selv om de er i en annen assembly.

**Private Protected** - De som bruker *private protected* er tilgjenlige innenfor samme klasse og kan også nås av
subklasser, men kun hvis disse subklassene befinner seg i samme assembly.