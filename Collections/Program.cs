
// === COLLECTIONS ===
// Esempio di utilizzo delle principali collections in .NET
// ===================


// Array
// non sono ridimensionabili
int[] arrayNumeri = new int[] { 1, 2, 3 };
int primoNumeroArray = arrayNumeri[0];
arrayNumeri[0] = 10;


// List
// equivalenti agli array, ma sono ridimensionabili
List<int> listNumeri = new List<int> { 1, 2, 3 };
int primoNumeroList = listNumeri[0];
listNumeri[0] = 10;
listNumeri.Add(4);
listNumeri.RemoveAt(1);  // rimuove il 2


// HashSet
// gli elementi non hanno un ordine, ridimensionabili
HashSet<int> setNumeri = new HashSet<int> { 1, 2, 3 };
setNumeri.Add(4);
setNumeri.Remove(2);
bool setContiene3 = setNumeri.Contains(3);


// Dictionary
// permette di associare una chiave ad un valore
Dictionary<int, string> dicNumeri = new Dictionary<int, string> {
    [1] = "Uno",
    [2] = "Due",
    [3] = "Tre"
};
string tre = dicNumeri[3];
dicNumeri[4] = "Quattro";
dicNumeri.Remove(2);
