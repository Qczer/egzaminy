string MaleLitery = "abcdefghijklmnopqrstuvwxyz";
string WielkieLitery = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string PolskieZnaki = "ąęłńóśżźĄĘŁŃÓŚŻŹ";
string Cyfry = "0123456789";
string ZnakiSpecjalne = "!@#$%^&*()_+";

Random random = new Random();

/*
    nazwa funkcji:       LosujZnak
    opis funkcji:        Losuje i zwraca znak z stringu podanego jako argument
    parametry:           znaki - string znakow z ktorego chcemy by wylosowano znak

    zwracany typ i opis: zwraca znak, ktory jest losowany z stringa ktory dostajemy jako argument
    autor:               pesel
 */
char LosujZnak(string znaki)
{
    int indeks = random.Next(znaki.Length);
    return znaki[indeks];
}

/*
    nazwa funkcji:       GenerujHaslo
    opis funkcji:        Generuje 12 znakowe haslo ktore sklada sie z 3 malych liter, 3 duzych liter, 2 polskich znakow, 2 cyfr i 2 znakow specjalnych
    parametry:           brak

    zwracany typ i opis: zwraca string, jest to wygenerowane haslo
    autor:               pesel
 */
string GenerujHaslo()
{
    string haslo = "";

    for (int i = 0; i < 3; i++)
    {
        haslo += LosujZnak(MaleLitery);
        haslo += LosujZnak(WielkieLitery);
    }
    for (int i = 0; i < 2; i++)
    {
        haslo += LosujZnak(PolskieZnaki);
        haslo += LosujZnak(Cyfry);
        haslo += LosujZnak(ZnakiSpecjalne);
    }

    char[] tablica = haslo.ToCharArray();

    for (int i = 0; i < tablica.Length; i++)
    {
        int losowyIndeks = random.Next(tablica.Length);

        char temp = tablica[i];
        tablica[i] = tablica[losowyIndeks];
        tablica[losowyIndeks] = temp;
    }

    return new string(tablica);
}

Console.WriteLine("Wygenerowane hasła:");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i+1}. {GenerujHaslo()}");
}
