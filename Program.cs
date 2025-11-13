using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== MANIPULACIÓ DE STRINGS EN C# ===\n");

        // 1. DEFINICIÓ I CARACTERÍSTIQUES
        // ---------------------------------
        Console.WriteLine("1. DEFINICIÓ I CARACTERÍSTIQUES");
        Console.WriteLine("--------------------------------");
        string firstString = "hola";
        string secondString = "que tal";
        Console.WriteLine($"firstString: {firstString}");
        Console.WriteLine($"secondString: {secondString}");
        Console.WriteLine("Els strings són IMMUTABLES (no es poden modificar després de crear-se)\n");

        // 2. RECÓRRER UN STRING COM UN ARRAY
        // -----------------------------------
        Console.WriteLine("2. RECÓRRER UN STRING");
        Console.WriteLine("---------------------");
        
        Console.WriteLine("Amb bucle FOR:");
        for (int i = 0; i < firstString.Length; i++)
        {
            Console.WriteLine($"  Posició {i}: {firstString[i]}");
        }

        Console.WriteLine("\nAmb bucle FOREACH:");
        foreach (char c in firstString)
        {
            Console.WriteLine($"  Caràcter: {c}");
        }
        Console.WriteLine();

        // 3. LENGTH - Longitud de la cadena
        // ----------------------------------
        Console.WriteLine("3. LENGTH - Longitud");
        Console.WriteLine("--------------------");
        string text = "Hola món!";
        Console.WriteLine($"Text: '{text}'");
        Console.WriteLine($"Longitud: {text.Length} caràcters\n");

        // 4. CLONE() - Clonar una cadena
        // -------------------------------
        Console.WriteLine("4. CLONE() - Clonar");
        Console.WriteLine("-------------------");
        string original = "Original";
        string clonada = (string)original.Clone();
        Console.WriteLine($"Original: {original}");
        Console.WriteLine($"Clonada: {clonada}\n");

        // 5. COMPARETO() - Comparar cadenes
        // ----------------------------------
        Console.WriteLine("5. COMPARETO() - Comparar");
        Console.WriteLine("-------------------------");
        string str1 = "abc";
        string str2 = "abc";
        string str3 = "xyz";
        Console.WriteLine($"'{str1}'.CompareTo('{str2}'): {str1.CompareTo(str2)} (0 = iguals)");
        Console.WriteLine($"'{str1}'.CompareTo('{str3}'): {str1.CompareTo(str3)} (diferent de 0 = diferents)\n");

        // 6. CONCAT() - Concatenar cadenes
        // ---------------------------------
        Console.WriteLine("6. CONCAT() - Concatenar");
        Console.WriteLine("------------------------");
        string part1 = "Hola ";
        string part2 = "món!";
        string resultat = string.Concat(part1, part2);
        Console.WriteLine($"Concat('{part1}', '{part2}'): '{resultat}'\n");

        // 7. CONTAINS() - Comprovar si conté text
        // ----------------------------------------
        Console.WriteLine("7. CONTAINS() - Comprovar si conté");
        Console.WriteLine("----------------------------------");
        string frase = "El gat està a la teulada";
        Console.WriteLine($"Frase: '{frase}'");
        Console.WriteLine($"Conté 'gat': {frase.Contains("gat")}");
        Console.WriteLine($"Conté 'gos': {frase.Contains("gos")}\n");

        // 8. ENDSWITH() - Comprovar final
        // --------------------------------
        Console.WriteLine("8. ENDSWITH() - Comprovar final");
        Console.WriteLine("-------------------------------");
        string arxiu = "document.pdf";
        Console.WriteLine($"Arxiu: '{arxiu}'");
        Console.WriteLine($"Acaba amb '.pdf': {arxiu.EndsWith(".pdf")}");
        Console.WriteLine($"Acaba amb '.txt': {arxiu.EndsWith(".txt")}\n");

        // 9. EQUALS() - Comparar igualtat
        // --------------------------------
        Console.WriteLine("9. EQUALS() - Comparar igualtat");
        Console.WriteLine("-------------------------------");
        string password1 = "secret123";
        string password2 = "secret123";
        string password3 = "Secret123";
        Console.WriteLine($"'{password1}'.Equals('{password2}'): {password1.Equals(password2)}");
        Console.WriteLine($"'{password1}'.Equals('{password3}'): {password1.Equals(password3)} (case-sensitive)\n");

        // 10. GETHASHCODE() - Obtenir hash
        // ---------------------------------
        Console.WriteLine("10. GETHASHCODE() - Hash");
        Console.WriteLine("------------------------");
        string data = "HashTest";
        Console.WriteLine($"Hash de '{data}': {data.GetHashCode()}\n");

        // 11. INDEXOF() - Primera ocurrència
        // -----------------------------------
        Console.WriteLine("11. INDEXOF() - Primera ocurrència");
        Console.WriteLine("----------------------------------");
        string textLlarg = "La programació és fantàstica";
        Console.WriteLine($"Text: '{textLlarg}'");
        Console.WriteLine($"IndexOf('a'): {textLlarg.IndexOf('a')} (primera 'a')");
        Console.WriteLine($"IndexOf('programació'): {textLlarg.IndexOf("programació")}\n");

        // 12. INSERT() - Inserir text
        // ----------------------------
        Console.WriteLine("12. INSERT() - Inserir text");
        Console.WriteLine("---------------------------");
        string base1 = "Hola món";
        string insertat = base1.Insert(5, "bonic ");
        Console.WriteLine($"Original: '{base1}'");
        Console.WriteLine($"Després d'inserir 'bonic ' a la posició 5: '{insertat}'\n");

        // 13. LASTINDEXOF() - Última ocurrència
        // --------------------------------------
        Console.WriteLine("13. LASTINDEXOF() - Última ocurrència");
        Console.WriteLine("-------------------------------------");
        string repetit = "ana té una mana";
        Console.WriteLine($"Text: '{repetit}'");
        Console.WriteLine($"IndexOf('a'): {repetit.IndexOf('a')} (primera)");
        Console.WriteLine($"LastIndexOf('a'): {repetit.LastIndexOf('a')} (última)\n");

        // 14. REMOVE() - Eliminar caràcters
        // ----------------------------------
        Console.WriteLine("14. REMOVE() - Eliminar");
        Console.WriteLine("-----------------------");
        string original2 = "Hola món cruel";
        string eliminat = original2.Remove(9); // Elimina des de la posició 9
        Console.WriteLine($"Original: '{original2}'");
        Console.WriteLine($"Remove(9): '{eliminat}'\n");

        // 15. REPLACE() - Substituir text
        // --------------------------------
        Console.WriteLine("15. REPLACE() - Substituir");
        Console.WriteLine("--------------------------");
        string textOriginal = "El gat és negre";
        string textSubstituït = textOriginal.Replace("gat", "gos");
        Console.WriteLine($"Original: '{textOriginal}'");
        Console.WriteLine($"Replace('gat', 'gos'): '{textSubstituït}'\n");

        // 16. SPLIT() - Dividir cadena
        // -----------------------------
        Console.WriteLine("16. SPLIT() - Dividir");
        Console.WriteLine("---------------------");
        string llista = "poma,pera,plàtan,taronja";
        string[] fruites = llista.Split(',');
        Console.WriteLine($"Text original: '{llista}'");
        Console.WriteLine("Després de Split(','):");
        foreach (string fruita in fruites)
        {
            Console.WriteLine($"  - {fruita}");
        }
        Console.WriteLine();

        // 17. STARTSWITH() - Comprovar inici
        // -----------------------------------
        Console.WriteLine("17. STARTSWITH() - Comprovar inici");
        Console.WriteLine("----------------------------------");
        string url = "https://www.exemple.com";
        Console.WriteLine($"URL: '{url}'");
        Console.WriteLine($"Comença amb 'https': {url.StartsWith("https")}");
        Console.WriteLine($"Comença amb 'http': {url.StartsWith("http")}\n");

        // 18. SUBSTRING() - Extreure subcadena
        // -------------------------------------
        Console.WriteLine("18. SUBSTRING() - Extreure subcadena");
        Console.WriteLine("------------------------------------");
        string complet = "Barcelona és una ciutat preciosa";
        string subcadena1 = complet.Substring(0, 9); // Des de 0, 9 caràcters
        string subcadena2 = complet.Substring(13); // Des de 13 fins al final
        Console.WriteLine($"Text: '{complet}'");
        Console.WriteLine($"Substring(0, 9): '{subcadena1}'");
        Console.WriteLine($"Substring(13): '{subcadena2}'\n");

        // 19. TOCHARARRAY() - Convertir a array de caràcters
        // ---------------------------------------------------
        Console.WriteLine("19. TOCHARARRAY() - Array de caràcters");
        Console.WriteLine("---------------------------------------");
        string paraula = "Codi";
        char[] lletres = paraula.ToCharArray();
        Console.WriteLine($"Paraula: '{paraula}'");
        Console.WriteLine("ToCharArray():");
        for (int i = 0; i < lletres.Length; i++)
        {
            Console.WriteLine($"  [{i}] = '{lletres[i]}'");
        }
        Console.WriteLine();

        // 20. TOLOWER() i TOUPPER() - Canviar majúscules/minúscules
        // ----------------------------------------------------------
        Console.WriteLine("20. TOLOWER() i TOUPPER()");
        Console.WriteLine("-------------------------");
        string mixt = "HoLa MóN";
        Console.WriteLine($"Original: '{mixt}'");
        Console.WriteLine($"ToLower(): '{mixt.ToLower()}'");
        Console.WriteLine($"ToUpper(): '{mixt.ToUpper()}'\n");

        // 21. TRIM() - Eliminar espais
        // -----------------------------
        Console.WriteLine("21. TRIM() - Eliminar espais");
        Console.WriteLine("----------------------------");
        string ambEspais = "   Hola món   ";
        Console.WriteLine($"Original: '{ambEspais}' (longitud: {ambEspais.Length})");
        Console.WriteLine($"Trim(): '{ambEspais.Trim()}' (longitud: {ambEspais.Trim().Length})\n");

        // 22. EXEMPLE PRÀCTIC: VALIDACIÓ D'EMAIL
        // ---------------------------------------
        Console.WriteLine("22. EXEMPLE PRÀCTIC: Validació d'email");
        Console.WriteLine("---------------------------------------");
        string email = "usuari@exemple.com";
        bool esValid = email.Contains("@") && email.Contains(".");
        Console.WriteLine($"Email: '{email}'");
        Console.WriteLine($"Conté '@': {email.Contains("@")}");
        Console.WriteLine($"Conté '.': {email.Contains(".")}");
        Console.WriteLine($"És vàlid: {esValid}\n");

        // 23. EXEMPLE PRÀCTIC: PROCESSAMENT DE TEXT
        // ------------------------------------------
        Console.WriteLine("23. EXEMPLE PRÀCTIC: Processament de text");
        Console.WriteLine("------------------------------------------");
        string entrada = "  Això és UN   text AMB format    estrany  ";
        Console.WriteLine($"Entrada: '{entrada}'");
        
        // Processar: eliminar espais, convertir a minúscules, comptar paraules
        string processada = entrada.Trim().ToLower();
        string[] paraules = processada.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        Console.WriteLine($"Processada: '{processada}'");
        Console.WriteLine($"Número de paraules: {paraules.Length}");
        Console.WriteLine("Paraules:");
        foreach (string p in paraules)
        {
            Console.WriteLine($"  - {p}");
        }
        Console.WriteLine();

        // 24. EXEMPLE PRÀCTIC: MÀSCARA DE TARGETA
        // ----------------------------------------
        Console.WriteLine("24. EXEMPLE PRÀCTIC: Màscara de targeta");
        Console.WriteLine("----------------------------------------");
        string numTargeta = "1234567890123456";
        string mascara = numTargeta.Substring(0, 4) + "********" + numTargeta.Substring(12);
        Console.WriteLine($"Número original: {numTargeta}");
        Console.WriteLine($"Amb màscara: {mascara}\n");

        Console.WriteLine("=== FI DEL PROGRAMA ===");
    }
}
