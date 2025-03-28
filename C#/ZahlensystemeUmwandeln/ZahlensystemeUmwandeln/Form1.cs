using Accessibility;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace ZahlensystemeUmwandeln
{
    public partial class Formular : Form
    {
        public Formular()
        {
            InitializeComponent();
        }
        private void Dec2Bin_Click(object sender, EventArgs e)
        {
            string decNumber2String = txtBxDec.Text; // die Zahl wird aus der Textbox entlesen
            string binaryDec = "";
            int counter = 0;
            string pattern = "";
            string substitution = "";
            string dollar = "$";

            int dec = Convert.ToInt32(decNumber2String);
            while (dec != 0)
            {
                binaryDec += dec % 2; // hängt den Rest des Quotienten nacheinander an
                dec /= 2; // entspricht: dec = dec / 2;
                counter++; // jeder Durchgang der while-Schleife entspricht der höchsten Anzahl der RegEx-Gruppe

                pattern += "(\\d)"; // entspricht: pattrn = pattern + "(\\d)"; // pro loop wird derselbe string hintereinander erbaut
            }

            for (int i = counter; i >= 1; i--)
            {
                substitution = substitution + dollar + i.ToString(); // mithilfe der for-Schleife wird das Ersetzen der RegEx-Gruppen gebildet
            }

            binaryDec = Regex.Replace(binaryDec, @"" + pattern, @"" + substitution); // die Binärzahl
            /* nun werden die 0er vorne angehängt, wenn nötig, und fürs Oktett zumindest! */

            if (decNumber2String == "0")
            {
                lblResult.Text = "Binärzahl: 0";
            }

            if (Convert.ToInt32(binaryDec.Length) % 4 == 1)
            {
                binaryDec = "000" + binaryDec;
            }
            if (Convert.ToInt32(binaryDec.Length) % 4 == 2)
            {
                binaryDec = "00" + binaryDec;
            }
            if (Convert.ToInt32(binaryDec.Length) % 4 == 3)
            {
                binaryDec = "0" + binaryDec;
            }
            else if (Convert.ToInt32(binaryDec.Length) == 4)
            {
                binaryDec = "0000" + binaryDec;
            }
            /* nun wird ein Punkt zwischen allen 4er-Packs hinzugefügt */

            binaryDec = Regex.Replace(binaryDec, @"(\d{4})(?(\z)\s|)", @"$1."); // Punkt nach $-Symbol

            lblResult.Text = "Binärzahl: " + binaryDec;
        }

        private void Bin2Dec_Click(object sender, EventArgs e)
        {
            string bin2String = txtBxBin.Text;
            int digitCounter = bin2String.Length; // gibt die Gesamtzahl an Ziffern an
            int highestExponentNumber = digitCounter - 1; // gibt den höchsten Exponenten an

            bin2String = Regex.Replace(bin2String, @"(.){1}", @"$1a"); // platziert ein a nach jedem Zeichen

            string[] binaryArray = bin2String.Split("a");
            string lastBitOfBinary = binaryArray[highestExponentNumber]; // gibt das erste Zeichen an; daher fängt der Counter vom letzten Index an zu zählen

            int basis = 2;
            int counter = 0;
            int wertigkeiten = 0;

            for (int potency = 0; potency <= highestExponentNumber; potency++)
            {
                counter++;
                if (counter == digitCounter) // da es sein kann, dass der counter den Array-Index unterschreitet, wird vorher eine simple Bedingung eingebaut
                {
                    counter = 0; // so kann der Array[index] zumindest nie unter 0 liegen
                }
                wertigkeiten += Convert.ToInt32(lastBitOfBinary) * ((int)Math.Pow(basis, potency));
                lastBitOfBinary = binaryArray[highestExponentNumber - counter];
            }

            string binary2DecString = Convert.ToString(wertigkeiten);

            /* nun werden Dezimaltrennpunkte zwischen 3er-Schritten v.r.n.l hinzugefügt */
            binary2DecString = Regex.Replace(binary2DecString, @"(?<!\.\d*)(\d)(?=(?:\d{3})+(?:\.|$))", @"$1."); // achtet, dass anfänglichst kein Punkt eingesetzt wird

            lbl_Dec.Text = "Dezimalzahl: " + Convert.ToString(binary2DecString);

            //if (bin2String == String.Empty)
            //{
            //    lbl_Dec.Text = "0";
            //}
        }

        private void Dec2Hexadec_Click(object sender, EventArgs e)
        {
            string decNumber2String = txtBxDec.Text; // die Zahl wird aus der Textbox entlesen
            string hexaDec = "";
            int counter = 0;
            string pattern = "";
            string substitution = "";
            string dollar = "$";

            int dec = Convert.ToInt32(decNumber2String);
            while (dec != 0)
            {
                int restDec = dec % 16;
                string restDec2String = Convert.ToString(restDec);

                if (restDec2String == "15")
                {
                    restDec2String = "F"; // nee, erst, wie 2bin, aneinanderordnen, dann die 6 alpha-Zustände anpassen, und dann mit RegEx umkehren, da jeder Wert eh nur mit einem einzigen Symbol beschrieben ist!
                }
                else if (restDec2String == "14")
                {
                    restDec2String = "E";
                }
                else if (restDec2String == "13")
                {
                    restDec2String = "D";
                }
                else if (restDec2String == "12")
                {
                    restDec2String = "C";
                }
                else if (restDec2String == "11")
                {
                    restDec2String = "B";
                }
                else if (restDec2String == "10")
                {
                    restDec2String = "A";
                }

                hexaDec += restDec2String;
                dec /= 16; // entspricht: dec = dec / 16;
                counter++; // jeder Durchgang der while-Schleife entspricht der höchsten Anzahl der RegEx-Gruppe

                pattern += "(.)";
            }

            for (int i = counter; i >= 1; i--)
            {
                substitution = substitution + dollar + i.ToString(); // mithilfe der for-Schleife wird das Ersetzen der RegEx-Gruppen gebildet
            }

            hexaDec = Regex.Replace(hexaDec, @"" + pattern, @"" + substitution);

            lblHexaResult.Text = "Hexadezimalzahl: " + hexaDec;

            if (decNumber2String == "0")
            {
                lblHexaResult.Text = "Hexadezimalzahl: 0";
            }
        }

        private void Dec2WhatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_DecNumbSpace.Visible = true;
        }

        private void Bin2Hexadec_Click(object sender, EventArgs e)
        {
            string bin2String = txtBxBin.Text;
            int digitCounter = bin2String.Length; // gibt die Gesamtzahl an Binär-Ziffern an
            /* nun unterteilen wir die Zahl in 4er-Packete */

            // nun die 3 Bedingungen, dass die 4er-Packs auch wirklich als 4er-Packs behandelt werden können
            if (digitCounter % 4 == 3) // bei einem Rest von 3 aus einem gewollten 4er-Pack muss nur eine 0 angefügt werden
            {
                bin2String = "0" + bin2String; // eine null wird vor dem Binär-string angehängt
                digitCounter++; // der digitCounter wird mitgezählt
            }
            else if (digitCounter % 4 == 2)
            {
                bin2String = "00" + bin2String;
                digitCounter += 2;
            }
            else if (digitCounter % 4 == 1)
            {
                bin2String = "000" + bin2String;
                digitCounter += 3;
            }

            /* nun trennen wir jede Ziffer mit einem Punkt */
            bin2String = Regex.Replace(bin2String, @"(.)(?(\z)\s|)", @"$1."); // achtet darauf, dass am Ende kein unnötiger Punkt eingefügt wird

            string[] binaryArray = bin2String.Split('.'); // splittet die Kette am '.'

            int highestIndex = digitCounter - 1; // gibt den höchstmöglichen Index des Binär-Arrays an

            string currentBit; // gibt anfänglichst das erste Zeichen an

            int indexCounter = 0; // dieser Index-Zähler soll später mal um 1 addiert werden
            int bitHexaWertigkeit; // entspricht einem später potenzierten Bit
            int quartWertigkeit = 0; // bildet die Summe eines binären 4er-Packs
            int counter = 0; // zum Zählen in 4er-Schritten, um eine Bedingung einzubauen, dass bestimmte Zahlen zusammengezählt und andere angehängt werden
            string quartPartString = ""; // bildet jeweils ein Symbol des Binär-4er-Packs ab
            string hexaDecString = ""; // bildet später die Summe aller 4er-Packs als string

            int potency = 3;

            for (int i = indexCounter; i <= highestIndex; i++) // v.l.n.r. sollen die Bits potenziert werden
            {
                counter++;
                currentBit = binaryArray[indexCounter]; // es wird um einen Index-Schritt im Array fortgezählt, um aufs nächste Bit zuzugreifen

                bitHexaWertigkeit = Convert.ToInt32(currentBit) * ((int)Math.Pow(2, potency)); // da die Wertigkeiten nicht addiert sondern angehängt werden, wird in string umgewandelt
                quartWertigkeit += bitHexaWertigkeit; // ein 4er-Pack wird in Hexadezimal konvertiert/* vorher unterteilt Bedingung einbauen, dass 10 = A ist, ... und 15 = F ist */
                
                if (potency == 0)
                {
                    potency = 3;
                }
                else if (potency > 0)
                {
                    potency--;
                }

                if (counter % 4 == 0)
                {
                    quartPartString = Convert.ToString(quartWertigkeit);

                    if (quartWertigkeit == 10 && counter % 4 == 0)
                    {
                        quartPartString = "A";
                    }
                    if (quartWertigkeit == 11 && counter % 4 == 0)
                    {
                        quartPartString = "B";
                    }
                    if (quartWertigkeit == 12 && counter % 4 == 0)
                    {
                        quartPartString = "C";
                    }
                    if (quartWertigkeit == 13 && counter % 4 == 0)
                    {
                        quartPartString = "D";
                    }
                    if (quartWertigkeit == 14 && counter % 4 == 0)
                    {
                        quartPartString = "E";
                    }
                    if (quartWertigkeit == 15 && counter % 4 == 0)
                    {
                        quartPartString = "F";
                    }

                    quartWertigkeit = 0;
                    hexaDecString += quartPartString;
                }
                indexCounter++;
            }

            /* nun entfernen wir die führenden 0en */
            hexaDecString = Regex.Replace(hexaDecString, @"(0)*(.*)", @"$2"); // mögliche 0er werden entfernt, der Rest aber wird unabhängig vorderer 0en mitgenommen

            lbl_HexaDec.Text = "Hexadezimalzahl: " + hexaDecString;
        }

        private void Hexadec2Dec_Click(object sender, EventArgs e)
        {
            string hexaDec = txtBxHex.Text;
            int charCounter = hexaDec.Length; // die Zeichenlänge der Hexadezimalzahl

            hexaDec = Regex.Replace(hexaDec, @"(.)", @"$1."); // dient zum erkennbarem Trennen einzelner Zeichen
            hexaDec = hexaDec.Replace("A", "10"); // ab hier wird tabellarisch mathematisch definiert
            hexaDec = hexaDec.Replace("B", "11");
            hexaDec = hexaDec.Replace("C", "12");
            hexaDec = hexaDec.Replace("D", "13");
            hexaDec = hexaDec.Replace("E", "14");
            hexaDec = hexaDec.Replace("F", "15");

            string[] arrayHexa = hexaDec.Split('.'); // dient zum Zugriff einzelner Hexa-Zeichen
            string singleHexaStringSign = arrayHexa[0];
            int singleHexaSign = Convert.ToInt32(singleHexaStringSign);
            string binString = "";
            string fullBinaryString = "";

            int indexer = 1; // erster Array-Wert

            string singleSignPattern = "(.)(.)(.)(.)"; // pro loop wird derselbe string 4x hintereinander erbaut
            string singleSignSubstitution = "";

            for (int i = 0; i <= charCounter; i++) // ein und derselbe Prozess muss für alle Zahlen durchlaufen
            {
                if (singleHexaSign == 0) // falls 0 vorhanden ist, wird vorher schon das 4er-Pack gefüllt
                {
                    binString += "0000";
                }

                while (singleHexaSign != 0)
                {
                    binString += singleHexaSign % 2; // hängt den Rest des Quotienten nacheinander an
                    singleHexaSign /= 2; // das neue Hexa-Symbol wird halbiert
                }
                if (binString.Length % 4 == 1)
                {
                    binString += "000";
                }
                if (binString.Length % 4 == 2)
                {
                    binString += "00";
                }
                if (binString.Length % 4 == 3)
                {
                    binString += "0";
                }

                singleSignSubstitution += "$4$3$2$1"; // jedes 4er-Pack soll somit umgekehrt werden
                binString = Regex.Replace(binString, @"" + singleSignPattern, @"" + singleSignSubstitution); // gibt die Binärzahl in korrekter Reihenfolge an
                singleSignSubstitution = ""; // für ein neues 4er-Pack muss die Ersetzungsfunktion gleich-neu gebildet werden, aber erst nach der Ersetzung ofc!

                fullBinaryString += binString; // das nächste 4er-Pack wird an die Binärzahl angehängt
                binString = ""; // für das neue 4er-Pack ohne die vorherigen mitzunehmen!

                singleHexaStringSign = arrayHexa[indexer++];
                if (indexer > charCounter)
                {
                    break;
                }
                singleHexaSign = Convert.ToInt32(singleHexaStringSign);
            }

            int digitCounter = fullBinaryString.Length; // gibt die Gesamtzahl an Ziffern an
            int highestExponentNumber = digitCounter - 1; // gibt den höchsten Exponenten an

            fullBinaryString = Regex.Replace(fullBinaryString, @"(.){1}", @"$1a"); // platziert ein a nach jedem Zeichen

            string[] binaryArray = fullBinaryString.Split("a");
            string lastBitOfBinary = binaryArray[highestExponentNumber]; // gibt das erste Zeichen an; daher fängt der Counter vom letzten Index an zu zählen

            int counter = 0;
            int binWertigkeiten = 0;

            for (int potency = 0; potency <= highestExponentNumber; potency++)
            {
                counter++;
                if (counter == digitCounter) // da es sein kann, dass der counter den Array-Index unterschreitet, wird vorher eine simple Bedingung eingebaut
                {
                    counter = 0; // so kann der Array[index] zumindest nie unter 0 liegen
                }
                binWertigkeiten += Convert.ToInt32(lastBitOfBinary) * ((int)Math.Pow(2, potency)); // addiert die Wertigkeiten aller Index-Werte
                lastBitOfBinary = binaryArray[highestExponentNumber - counter];
            }

            string decimalString = Regex.Replace(Convert.ToString(binWertigkeiten), @"(?(\A)\s|)(.{3})", @".$1", RegexOptions.Multiline | RegexOptions.RightToLeft); // fügt ein Trennpunkt in der Dezimalzahl hinzu

            lbl_DecFromHex.Text = decimalString;
        }

        private void Hexadec2Bin_Click(object sender, EventArgs e)
        {
            string hexaDec = txtBxHex.Text;
            int charCounter = hexaDec.Length; // die Zeichenlänge der Hexadezimalzahl

            hexaDec = Regex.Replace(hexaDec, @"(.)", @"$1."); // dient zum erkennbarem Trennen einzelner Zeichen
            hexaDec = hexaDec.Replace("A", "10"); // ab hier wird tabellarisch mathematisch definiert
            hexaDec = hexaDec.Replace("B", "11");
            hexaDec = hexaDec.Replace("C", "12");
            hexaDec = hexaDec.Replace("D", "13");
            hexaDec = hexaDec.Replace("E", "14");
            hexaDec = hexaDec.Replace("F", "15");

            string[] arrayHexa = hexaDec.Split('.'); // dient zum Zugriff einzelner Hexa-Zeichen
            string singleHexaStringSign = arrayHexa[0];
            int singleHexaSign = Convert.ToInt32(singleHexaStringSign);
            string binString = "";
            string fullBinaryString = "";

            int indexer = 1;

            string singleSignPattern = "(.)(.)(.)(.)"; // pro loop wird derselbe string 4x hintereinander erbaut
            string singleSignSubstitution = "";

            for (int i = 0; i <= charCounter; i++) // ein und derselbe Prozess muss für alle Zahlen durchlaufen
            {
                if (singleHexaSign == 0) // falls 0 vorhanden ist, wird vorher schon das 4er-Pack gefüllt
                {
                    binString += "0000";
                }

                while (singleHexaSign != 0)
                {
                    binString += singleHexaSign % 2; // hängt den Rest des Quotienten nacheinander an
                    singleHexaSign /= 2; // das neue Hexa-Symbol wird halbiert
                }
                if (binString.Length % 4 == 1)
                {
                    binString += "000";
                }
                if (binString.Length % 4 == 2)
                {
                    binString += "00";
                }
                if (binString.Length % 4 == 3)
                {
                    binString += "0";
                }

                singleSignSubstitution += "$4$3$2$1"; // jedes 4er-Pack soll somit umgekehrt werden
                binString = Regex.Replace(binString, @"" + singleSignPattern, @"" + singleSignSubstitution); // gibt die Binärzahl in korrekter Reihenfolge an
                singleSignSubstitution = ""; // für ein neues 4er-Pack muss die Ersetzungsfunktion gleich-neu gebildet werden, aber erst nach der Ersetzung ofc!

                fullBinaryString += binString; // das nächste 4er-Pack wird an die Binärzahl angehängt
                binString = ""; // für das neue 4er-Pack ohne die vorherigen mitzunehmen!

                singleHexaStringSign = arrayHexa[indexer++];
                if (indexer > charCounter)
                {
                    break;
                }
                singleHexaSign = Convert.ToInt32(singleHexaStringSign);
            }

            /* nun verschwinden alle 0er vor der Binärzahl */
            fullBinaryString = Regex.Replace(fullBinaryString, @"^(0000)*", @""); // das ^-Symbol setzt voraus, dass es nur 0er am Anfang des Binärsstrings sind
            /* nun wird ein Punkt zwischen allen 4er-Packs hinzugefügt */

            fullBinaryString = Regex.Replace(fullBinaryString, @"(\d{4})(?(\z)\s|)", @"$1."); // Punkt nach $-Symbol
            
            lbl_BinFromHex.Text = fullBinaryString;
        }

        private void Binary2WhatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_BinNumbSpace.Visible = true;
        }

        private void Hexadec2WhatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_HexDecNumbSpace.Visible = true;
        }

        private void Formular_Load(object sender, EventArgs e)
        {
            /* beim Starten soll vorher ein Fenster erscheinen, das auf die 'Optionen' hinweist */
            string caption = "Info";
            MessageBox.Show("Klicke oben links im Menü auf \"Optionen\", um in bestimmten Zahlensystemen umwandeln zu können!", caption, MessageBoxButtons.OK);
        }
    }
}

