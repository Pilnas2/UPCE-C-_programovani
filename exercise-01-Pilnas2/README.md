[![Open in Visual Studio Code](https://classroom.github.com/assets/open-in-vscode-c66648af7eb3fe8bc4f294546bfd86ef473780cde1dea487d3c4ff354943c9ae.svg)](https://classroom.github.com/online_ide?assignment_repo_id=10148223&assignment_repo_type=AssignmentRepo)
# Cvičení 1

- Úvod, základní syntaxe, dokumentační komentáře

## Příklad 01 - adresa

Napište aplikaci v C#, která do konzole vypíše naformátovanou adresu, včetně diakritiky.

```
Josef Novák
Jindrišská 16
111 50, Praha 1
```

Využijte **Console.Write/Console.WriteLine** , vyzkoušejte odřádkování přímo v řetězci (**\n**, **\r**), vyzkoušejte _verbatim strings_ (https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/verbatim).

## Příklad 02 - abeceda

Napište aplikaci v C#, která do console pod sebe vytiskne písmena anglické abecedy. Použijte datový typ znak jako řídící proměnnou cyklu.

Otestujte cykly – **for**, **while**, **do-while**.

## Příklad 03 - rodné číslo

Napište program, který na základě zadaného rodného čísla určí, zda se jedná o muže či o ženu.

* Realizujte ověřovací algoritmus jako statickou metodu v hlavní třídě
* Vyzkoušejte předávat rodné číslo jako řetězec (**string**) nebo jako **ulong** (v případě **ulong** varianty zpracujte přímo číselný formát, nepřevádějte číslo na řetězec)

## Příklad 04 – hádání čísla

Počítač na počátku vygeneruje náhodné číslo (v rozsahu 0 – 100) a vy jej máte uhodnout. Po každém tipu po čítač pouze informuje, jestli jeho číslo je větší, menší nebo bylo nalezeno.

* Modifikace 1: Pokud hráč nenajde správné číslo do 10 pokusů, tak prohrál.
* Modifikace 2: Po vyhraném tipování umožn ěte hrá či začít další hru nebo skončit program.

Využijte objekt **Random** a metodu **Next**.

## Příklad 05 – předpověď počasí (volitelný úkol)

Stáhněte předpověď po časí pomocí API - https://api.met.no/weatherapi/locationforecast/2.0/documentation , zpracujte získaná data a vypište do konzole aktuální teplotu, rychlost větru a tlak.
Pro stažení odpovědi serveru z webu lze vytvořit objekt **System.Net.WebClient** a využít metodu **DownloadString**. Zpracování textu lze realizovat pomocí základních operací nad stringem (https://msdn.microsoft.com/en-us/library/system.string(v=vs.110).aspx ) nebo vyzkoušet jiné metody (regulární výrazy - **System.Text.RegularExpressions.Regex.Match** , přímé zpracování XML - **System.Xml.XmlDocument** + metoda **LoadString**)

* Modifikace 1: Na začátku vyzvěte uživatele k zadání umístění, pro které chce počasí vyhledat. Využijte vhodnou webovou službu pro vyhledání GPS souřadnic pro danou lokalitu.



