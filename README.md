# MANIPULACIÓ DE STRINGS EN C#

## 1. DEFINICIÓ I CARACTERÍSTIQUES

Els strings són cadenes de text en C#. Tenen una característica important: són **IMMUTABLES** (no es poden modificar després de crear-se).

```csharp
string firstString = "hola";
string secondString = "que tal";
```

## 2. RECÓRRER UN STRING

### Amb bucle FOR:
```csharp
for (int i = 0; i < firstString.Length; i++)
{
    Console.WriteLine($"Posició {i}: {firstString[i]}");
}
```

### Amb bucle FOREACH:
```csharp
foreach (char c in firstString)
{
    Console.WriteLine($"Caràcter: {c}");
}
```

## 3. LENGTH - Longitud de la cadena

Retorna el nombre de caràcters d'una cadena.

```csharp
string text = "Hola món!";
Console.WriteLine($"Longitud: {text.Length} caràcters");
// Resultat: Longitud: 9 caràcters
```

## 4. CLONE() - Clonar una cadena

Crea una còpia exacta d'una cadena.

```csharp
string original = "Original";
string clonada = (string)original.Clone();
```

## 5. COMPARETO() - Comparar cadenes

Compara dues cadenes. Retorna:
- **0**: si són iguals
- **diferent de 0**: si són diferents

```csharp
string str1 = "abc";
string str2 = "abc";
string str3 = "xyz";
Console.WriteLine(str1.CompareTo(str2)); // Resultat: 0 (iguals)
Console.WriteLine(str1.CompareTo(str3)); // Resultat: diferent de 0
```

## 6. CONCAT() - Concatenar cadenes

Uneix dues o més cadenes en una sola.

```csharp
string part1 = "Hola ";
string part2 = "món!";
string resultat = string.Concat(part1, part2);
// Resultat: "Hola món!"
```

## 7. CONTAINS() - Comprovar si conté text

Retorna `true` si la cadena conté el text especificat.

```csharp
string frase = "El gat està a la teulada";
Console.WriteLine(frase.Contains("gat")); // true
Console.WriteLine(frase.Contains("gos")); // false
```

## 8. ENDSWITH() - Comprovar final

Comprova si la cadena acaba amb el text especificat.

```csharp
string arxiu = "document.pdf";
Console.WriteLine(arxiu.EndsWith(".pdf")); // true
Console.WriteLine(arxiu.EndsWith(".txt")); // false
```

## 9. EQUALS() - Comparar igualtat

Compara si dues cadenes són exactament iguals (case-sensitive).

```csharp
string password1 = "secret123";
string password2 = "secret123";
string password3 = "Secret123";
Console.WriteLine(password1.Equals(password2)); // true
Console.WriteLine(password1.Equals(password3)); // false (case-sensitive)
```

## 10. GETHASHCODE() - Obtenir hash

Retorna un valor hash numèric de la cadena.

```csharp
string data = "HashTest";
Console.WriteLine(data.GetHashCode());
```

## 11. INDEXOF() - Primera ocurrència

Retorna la posició de la primera ocurrència d'un caràcter o subcadena.

```csharp
string textLlarg = "La programació és fantàstica";
Console.WriteLine(textLlarg.IndexOf('a')); // Primera 'a'
Console.WriteLine(textLlarg.IndexOf("programació")); // Posició de la paraula
```

## 12. INSERT() - Inserir text

Insereix text en una posició específica.

```csharp
string base1 = "Hola món";
string insertat = base1.Insert(5, "bonic ");
// Resultat: "Hola bonic món"
```

## 13. LASTINDEXOF() - Última ocurrència

Retorna la posició de l'última ocurrència d'un caràcter o subcadena.

```csharp
string repetit = "ana té una mana";
Console.WriteLine(repetit.IndexOf('a'));     // Primera 'a'
Console.WriteLine(repetit.LastIndexOf('a')); // Última 'a'
```

## 14. REMOVE() - Eliminar caràcters

Elimina caràcters des d'una posició específica.

```csharp
string original2 = "Hola món cruel";
string eliminat = original2.Remove(9); // Elimina des de la posició 9
// Resultat: "Hola món"
```

## 15. REPLACE() - Substituir text

Substitueix totes les ocurrències d'un text per un altre.

```csharp
string textOriginal = "El gat és negre";
string textSubstituït = textOriginal.Replace("gat", "gos");
// Resultat: "El gos és negre"
```

## 16. SPLIT() - Dividir cadena

Divideix una cadena en un array segons un separador.

```csharp
string llista = "poma,pera,plàtan,taronja";
string[] fruites = llista.Split(',');
// Resultat: ["poma", "pera", "plàtan", "taronja"]
```

## 17. STARTSWITH() - Comprovar inici

Comprova si la cadena comença amb el text especificat.

```csharp
string url = "https://www.exemple.com";
Console.WriteLine(url.StartsWith("https")); // true
Console.WriteLine(url.StartsWith("http"));  // true
```

## 18. SUBSTRING() - Extreure subcadena

Extreu una part de la cadena.

```csharp
string complet = "Barcelona és una ciutat preciosa";
string subcadena1 = complet.Substring(0, 9);  // "Barcelona"
string subcadena2 = complet.Substring(13);    // "una ciutat preciosa"
```

## 19. TOCHARARRAY() - Convertir a array de caràcters

Converteix la cadena en un array de caràcters.

```csharp
string paraula = "Codi";
char[] lletres = paraula.ToCharArray();
// Resultat: ['C', 'o', 'd', 'i']
```

## 20. TOLOWER() i TOUPPER() - Canviar majúscules/minúscules

Converteix tota la cadena a minúscules o majúscules.

```csharp
string mixt = "HoLa MóN";
Console.WriteLine(mixt.ToLower()); // "hola món"
Console.WriteLine(mixt.ToUpper()); // "HOLA MÓN"
```

## 21. TRIM() - Eliminar espais

Elimina els espais en blanc al principi i al final de la cadena.

```csharp
string ambEspais = "   Hola món   ";
Console.WriteLine(ambEspais.Trim()); // "Hola món"
```

## 22. EXEMPLE PRÀCTIC: Validació d'email

```csharp
string email = "usuari@exemple.com";
bool esValid = email.Contains("@") && email.Contains(".");
Console.WriteLine($"És vàlid: {esValid}"); // true
```

## 23. EXEMPLE PRÀCTIC: Processament de text

```csharp
string entrada = "  Això és UN   text AMB format    estrany  ";

// Processar: eliminar espais, convertir a minúscules, comptar paraules
string processada = entrada.Trim().ToLower();
string[] paraules = processada.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"Número de paraules: {paraules.Length}");
// Resultat: 6 paraules
```

## 24. EXEMPLE PRÀCTIC: Màscara de targeta

```csharp
string numTargeta = "1234567890123456";
string mascara = numTargeta.Substring(0, 4) + "********" + numTargeta.Substring(12);
Console.WriteLine($"Amb màscara: {mascara}");
// Resultat: 1234********3456
```

---

## Resum de mètodes principals

| Mètode | Descripció |
|--------|------------|
| `Length` | Retorna la longitud |
| `Contains()` | Comprova si conté text |
| `StartsWith()` | Comprova l'inici |
| `EndsWith()` | Comprova el final |
| `IndexOf()` | Primera ocurrència |
| `LastIndexOf()` | Última ocurrència |
| `Substring()` | Extreu una part |
| `Replace()` | Substitueix text |
| `Split()` | Divideix la cadena |
| `Trim()` | Elimina espais |
| `ToLower()` | Converteix a minúscules |
| `ToUpper()` | Converteix a majúscules |
| `Insert()` | Insereix text |
| `Remove()` | Elimina caràcters |
