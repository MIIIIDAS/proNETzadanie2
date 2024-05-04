Zadanie 2. Proszę zrealizować aplikację obiektową, która powinna odznaczać się następującymi cechami:
 Do wykonania zadania 2 konieczne jest uprzednie wykonanie zadania 1.  Aplikacja z zadania 1 ma zostać uzupełniona o klasę „Garaz”.  Klasa „Garaz” ma przechowywać następujące informacje dotyczące garażu: adres, pojemność, liczba garażowanych samochodów, informacje dotyczące garażowanych samochodów.
 Klasa „Garaz” ma umożliwiać dodawanie do kolekcji przechowywanych samochodów nowego samochodu oraz wyprowadzanie z tej kolekcji ostatnio wprowadzonego samochodu.
 Kolekcja samochodów ma zostać zrealizowana za pomocą dynamicznej tablicy.  Uwagi:
 Dynamiczną tablicę tworzymy według schematu:
<typ> [ ] nazwaTablicy = new <typ> [ rozmiar];
 Reprezentacja klas na diagramie UML:
13
14
Aby zrealizować zadanie należy wykonać następujące kroki:
 Proszę o utworzenie klasy „Garaz”.  Proszę o utworzenie prywatnych pól klasy „Garaz” o nazwie: „adres”, „pojemnosc”, „liczbaSamochodow”, „samochody”. Pole „samochody” powinno posiadać typ tablicowy, przechowujący obiekty klasy „Samochod”:
private Samochod[] samochody;
Pole „liczbaSamochodow” powinno być zainicjowane wartością „0”:
private int liczbaSamochodow = 0;
 Proszę o utworzenie właściwości dostępowych do pól „adres” i „pojemnosc”. Właściwość „Set” pola „pojemność” powinna przydzielać także pamięć polu „samochody”:
set {
}
pojemnosc = value; samochody = new Samochod[pojemnosc];
 Proszę o utworzenie konstruktora domyślnego, który wszystkim polom przyporządkowuje wartości: „nieznana” lub „nieznany” dla pól typu string, „0” dla pól typu int, „null” dla pól typu tablicowego. Proszę pamiętać o tym, że konstruktor domyślny nie przyjmuje żadnych parametrów. Proszę zauważyć, że pole „liczbaSamochodow” zostało już zainicjowane i nie jest konieczne przypisanie mu wartości w ciele konstruktora.
 Proszę o utworzenie konstruktora, przyjmującego następujące parametry: „adres_”, „pojemnosc_”. Typy parametrów powinny odpowiadać typom pól klasy „Garaz”. Konstruktor ma przekazywać wartości parametrów polom. Wywołanie konstruktora powinno przydzielić pamięć polu „samochody”, tworząc tablicę o rozmiarze odpowiadającym wartości pola „pojemnosc”.
 Proszę o utworzenie publicznej metody „WprowadzSamochod”, zwracającej wartość typu void i przyjmującej parametr typu Samochod. Metoda ta ma sprawdzać, czy garaż jest zapełniony. Jeśli tak, ma wypisywać na ekranie konsoli odpowiedni komunikat. Jeśli nie jest zapełniony, ma wprowadzić do niego dany samochód. Nowy samochód powinien być dodany do tablicy za znajdującymi się w niej obiektami typu Samochod. Do określenia tej pozycji ma służyć wartość pola „liczbaSamochodow”, która po wprowadzeniu nowego samochodu powinna być odpowiednio zmodyfikowana.
 Proszę o utworzenie publicznej metody „WyprowadzSamochod”, zwracającej wartość typu
15
Samochod i nie przyjmującej żadnych parametrów. Metoda ta ma sprawdzać, czy garaż jest pusty. Jeśli tak, ma wypisywać na ekranie konsoli odpowiedni komunikat. Jeśli nie jest pusty, ma wyprowadzić z niego ostatnio wprowadzony samochód. Do określenia pozycji samochodu w tablicy ma służyć wartość pola „liczbaSamochodow”, która po wyprowadzeniu nowego samochodu powinna być odpowiednio zmodyfikowana. Po wyłuskaniu obiektu typu Samochod z tablicy, do pozycji na której się znajdował należy podstawić wartość „null”.
 Proszę o utworzenie publicznej metody „WypiszInfo” zwracającej wartość typu void i nie przyjmującej żadnych parametrów. Metoda ta ma wypisywać na ekranie konsoli wartości wszystkich pól typu prostego klasy „Samochod”. Dodatkowo ma wyświetlać wszystkie informacje dotyczące garażowanych samochodów. Realizacja wyświetlania informacji o samochodach ma opierać się na zastosowaniu pętli „for” oraz metodzie „WypiszInfo” zaimplementowanej w klasie „Samochod”.
 Proszę o przetestowanie poprawności wykonania zadania za pomocą kodu testowego:
16
Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0); Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
Garaz g1 = new Garaz(); g1.Adres = "ul. Garażowa 1"; g1.Pojemnosc = 1; Garaz g2 = new Garaz("ul. Garażowa 2", 2); g1.WprowadzSamochod(s1); g1.WypiszInfo(); g1.WprowadzSamochod(s2);
g2.WprowadzSamochod(s2); g2.WprowadzSamochod(s1); g2.WypiszInfo();
g2.WyprowadzSamochod(); g2.WypiszInfo();
g2.WyprowadzSamochod(); g2.WyprowadzSamochod();
Console.ReadKey();
