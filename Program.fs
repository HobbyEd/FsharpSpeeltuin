// wat voorbeeld code fragementen in F#. 
// deze heb ik kort gemaakt na het doorlezen van "The book of F#" Dave Fancher 
// erg goed boek om inzicht in de taal te krijgen.


//mutable
let mutable naam = "Ed";; //standaard zijn waarde immutable. Mutable keyword beperkt gebruiken.
naam = "Edwin";;

//functie signature 
let add a b = a + b
add 1 1 |> printf "de som is %d \n"  

// curring voorbeeld 
let addTen = add 10 // geef aan de functie add een variabele mee. Dus in dit geval een waarde voor a
addTen 12 |> ignore // expliciet ignore, omdat een functie altijd een unit oplevert

//fibonaci onder een waarden  
let rec fib a b =                   // fib is een recursieve functie (rec) 
    let current = a + b             // leg de huidige fibonaci waarde vast. 
    match current with              // pattern match 
    | _ when current >= 640 -> []   // als current groter dan 640 dan return een list 
    | _ -> current :: fib b current // current is kleiner dus roep fib aan.  

let testFib = fib 1 2;


//data type definitie 
type Resultaat = {Leerling : string; Klas : string; Vak : string; Cijfer: float }

//instantie van het type (laat de compiler het type bepalen)
let resultaten = [{Leerling = "Tim"; Klas = "3HE"; Vak = "NL"; Cijfer = 6.3}
                  {Leerling = "Tim"; Klas = "3HE"; Vak = "EN"; Cijfer = 7.1}
                  {Leerling = "Tim"; Klas = "3HE"; Vak = "WI"; Cijfer = 9.1}
                  {Leerling = "Tim"; Klas = "3HE"; Vak = "NT"; Cijfer = 8.3}]

//loop over de lijst 
for {Leerling = l; Klas = k; Vak = v; Cijfer = c} in resultaten do  
    printfn "%s -- %s -- %s -- (%f) "l k v c 

//definitie van een object type
type Result (voornaam: string, achternaam : string,  klas : string, vak : string, cijfer : float) = 
    let volledigeNaam =  voornaam + " " + achternaam
    member x.Voornaam = voornaam
    member x.Achternaam = achternaam 
    member x.Klas = klas
    member x.Vak = vak
    member x.Cijfer = cijfer
    
let res = Result("Tim", "Jansen", "3HE", "NL", 6.3)

