using ListaIndirizzi;
string Path = "C:/Users/genna/OneDrive/Desktop/C#/ListaIndirizzi/addresses.csv";
List<Indirizzo> listaDiIndirizzi = new List<Indirizzo>();
StreamReader file = File.OpenText(Path);
string rigaDaButtare = file.ReadLine();
while (!file.EndOfStream)
{
    string riga=file.ReadLine();
    string[] Info=riga.Split(',');
    

    if(Info.Length==6)
    {
        string nome=Info[0];
        string cognome=Info[1];
        string via=Info[2];
        string citta=Info[3];
        string provincia=Info[4];
        int CodicePostale=int.Parse(Info[5]);

        Indirizzo Indirizzi = new Indirizzo(nome, cognome, via, citta, provincia, CodicePostale);
        listaDiIndirizzi.Add(Indirizzi);
        Console.WriteLine(riga);
    }

}
file.Close();
foreach (Indirizzo indirizzo in listaDiIndirizzi)
{
   Console.WriteLine(indirizzo.ToString());
}
