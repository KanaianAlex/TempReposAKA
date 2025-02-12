namespace ModusProjekt
{
    public class ModusBerechnen
    {
        public static void Mdsccl()
        {
            // Liste instanziieren
            List<int> liWerte = [1, 2, 3, 7, 3, 4];

            // ein Wörterbuch als Definition kategorisiert zum Wertigkeitszählen anlegen
            Dictionary<int, int> counter = [];

            // den häufigsten Wert (Modus) initialisieren
            string maxCountValue = "";

            // den Counter zum Ermitteln des Modus initialisieren
            int maxCount = 0;

            // für jeden Eintrag in der Liste den größten counter und den zugehörigen Modus ermitteln
            foreach (int entry in liWerte)
            {
                // Check if the entry exists in the dictionary
                if (counter.TryGetValue(entry, out int value))
                {
                    // Increment the counter by 1 if the entry exists
                    counter[entry] = ++value;
                }

                else
                {
                    // If the entry doesn't exist, add it to the dictionary with a counter of 1
                    counter.Add(entry, 1);
                }

                if (counter[entry] > maxCount) // Compare the count with the maximum count
                {
                    maxCountValue = entry.ToString(); // Update the value associated with the maximum count
                    maxCount = counter[entry]; // Update the maximum count if necessary
                }
            }

            // Display the entry with the biggest counter-number
            Console.WriteLine("Die meiste Häufigkeit vom Wert von " + maxCountValue + " (Modus) beträgt: " + maxCount + ".");
        }
    }
}