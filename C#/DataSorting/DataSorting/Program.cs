using System.Text.RegularExpressions;

string filePath = "C:\\Users\\kanaiana\\Documents\\Ausbildungsnachweise\\DatumSortieren\\AN_3_November_2022.txt"; // Dateinamen umändern für neuen Monatsnachweis!

StreamReader streamReader = File.OpenText(filePath);
string content = streamReader.ReadToEnd(); // zuerst wird die ganze Datei gelesen
streamReader.Close();

string line40 = File.ReadLines(filePath).Skip(39).Take(1).First(); // die Zeile 40 beinhaltet zugleich das Anfangs- und Enddatum des jeweiligen Berichtsheftes
string[] line40Array; // also wird genau danach gefiltert
line40Array = line40.Split("vom ");
string nearDate = line40Array[1];
string[] closeDates;
closeDates = nearDate.Split(" bis ");
string firstFullDate = closeDates[0];
string almostLastDate = closeDates[1];
string[] nonsense2ndDate;
nonsense2ndDate = almostLastDate.Split(" ");
string lastFullDate = nonsense2ndDate[0];
string[] firstDateChains;
firstDateChains = firstFullDate.Split('.');
string first2DigitDateOfFirstDate = firstDateChains[0]; // erster Datumstag;
string[] lastDateChains;
lastDateChains = lastFullDate.Split('.');
string first2DigitDateOfLastDate = lastDateChains[0]; // letzter Datumstag;

Console.WriteLine("Report from " + first2DigitDateOfFirstDate + " until " + first2DigitDateOfLastDate + " of given month;"); // split worked well!

/* we now build the pattern for reversed Regex-groups w/ a for-loop */
string patternBuilder = ""; // since this var is being used in a loop, it's declared and initialized parent to use after the loop as well

string datePattern = @"((\d{2}).\d{2}.\d{4} </t)"; // 2nd-group -pattern made to take only first 2 digits of report day later on
int counter = Regex.Matches(content, datePattern).Count(); // counts #(report days)
Console.WriteLine(counter);
MatchCollection matches = Regex.Matches(content, datePattern); // in var. matches, all above values above are being stored
foreach (Match match in matches) // w/ a foreach-loop, we receive every value Wert individually, which shall be stored / printed out
{
    patternBuilder = patternBuilder + "(<tr><td> " + match.Groups[2].Value + ".+</tr>)";
    // a pattern-string is constructed w/ all <tr>s as a whole expression
}
Console.WriteLine(patternBuilder);

/* now we build the substitution w/ the reversed RegExp-#-groups using a for-loop */
string fullRegexGroups = "";
for (int i = counter; i >= 1; i--) // loop from highest matched counter until 1
{
    fullRegexGroups = fullRegexGroups + "$" + i.ToString();
}
Console.WriteLine(fullRegexGroups); // corresponds to the substitution containing all groups in reverse

string pattern = @"" + patternBuilder; // monthly-variable pattern
string substitution = @"" + fullRegexGroups; // group-substitution
content = Regex.Replace(content, pattern, substitution); // now can the essential part of the file be replaced

string titleOfInitialFile;
string monthNumber;
string monthString;
string yearStringWithTXT;
string yearString;

string[] pathChains;
pathChains = filePath.Split('\\');
titleOfInitialFile = pathChains[6];

string[] titleChains;
titleChains = titleOfInitialFile.Split('_');
monthNumber = titleChains[1];
monthString = titleChains[2];
yearStringWithTXT = titleChains[3];

string[] partTitleChains;
partTitleChains = yearStringWithTXT.Split('.');
yearString = partTitleChains[0];

StreamWriter outputStreamWriter = File.CreateText(@"C:\Users\kanaiana\Documents\Ausbildungsnachweise\DatumSortieren\AN_new_" + monthNumber + "_" + monthString + "_" + yearString + ".html");

outputStreamWriter.WriteLine(content); // Hier wird endlich der Inhalt der HTML-generierten Datei hineingeschrieben.

outputStreamWriter.Close(); // Natürlich muss der Schreiber seine Aufgabe danach beenden und somit aufhören zu schreiben.

Console.WriteLine("Done!"); // Letztlich wird auf der Konsole die Beschreibung angegeben.
Console.WriteLine("Report number " + monthNumber + " of " + monthString + " " + yearString + " has been formatted.");
Console.WriteLine("File Path: C:\\Users\\kanaiana\\Documents\\Ausbildungsnachweise\\DatumSortieren\\\n"); // gibt an, wo sich das Archiv befindet
Console.WriteLine("// Description: HTML-sorting for own reports\n" +
                  "                created with Visual Studio\n" +
                  "                made for the purpose of opticality;");

Console.ReadLine();