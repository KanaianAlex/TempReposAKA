using System.Text.RegularExpressions;

Console.WriteLine("Servus Alex, hier dein formatierter Ausbildungsnachweis!");

// App: HTML-formating of txt-reports for HTML-file view(, e.g. from Azubi-Plattform)

string filePath = @"C:\Users\KanaianA\OneDrive - Fichtner GmbH & Co. KG\AzubiNachweiseBackUps\Ausbildungsnachweis\Azubi-Nachweis30_Februar_2025.txt"; /* change month within the file-path for every new month! */
StreamReader streamReader = File.OpenText(filePath);
string content = streamReader.ReadToEnd();

/* replacing all the text-symbols with shape-symbols for hirarchy-structure */
content = Regex.Replace(content, @"(rmbP )", @"◆ ", RegexOptions.Multiline);
content = Regex.Replace(content, @"(\t\. )", @"• ", RegexOptions.Multiline);
content = Regex.Replace(content, @"(\t\t\-> )", @"→ ", RegexOptions.Multiline);
content = Regex.Replace(content, @"(\t\t\t- )", @"- ", RegexOptions.Multiline);
content = Regex.Replace(content, @"(\t\t\t\t-- )", @"▸ ", RegexOptions.Multiline);

/* removing the ugly lines between weeks */
content = Regex.Replace(content, @"(-){50,}", @"", RegexOptions.Multiline);

/* replacing first parent-tags and remember using always w/ "\r\n" f. WIN-Syst. */
content = Regex.Replace(content, @"(\w{2}\., (\d{2}\.){2}\d{4}\s*\r\n)(◆ |• )(.+\r\n?)((?:.+\r\n?)*)?", @"$1<ul style = ""list-style-type: '$3';""><li>$4$5</li></ul>" + "\n", RegexOptions.Multiline); // optionally matches all ◆tags and •tags @ the beginning of the date and, if either shape-symbols were found, adds them within the beginning <ul>-tag // Zeile 25 zuletzt bearbeitet
content = Regex.Replace(content, @"(<ul style = ""list-style-type: '◆ ';""><li>.+\r\n)(• )(.+\r\n?)((?:.+\r\n?)*)?(</li></ul>)", @"$1<ul style = ""list-style-type: '$2';""><li>$3$4$5$5", RegexOptions.Multiline); // matches and replaces all •tags @ the end of the parent ◆tag // check
content = Regex.Replace(content, @"^(• )(.+)", @"</li><li>$1$2", RegexOptions.Multiline); // matches and replaces all •tags in bt/w, in case there are any // check
content = Regex.Replace(content, @"^(→ )(.+\r\n)((?:^[^<].+\r\n)*)?(</li>)", @"<ul style = ""list-style-type: '$1';""><li>$2$3$4</ul>$4", RegexOptions.Multiline); // matches and replaces all →tags @ the beginning of the parent •tags // check
content = Regex.Replace(content, @"^(→ )(.+)", @"</li><li>$1$2", RegexOptions.Multiline); // matches and replaces all →tags in bt/w, in case there are any // check
content = Regex.Replace(content, @"^(- )(.+\r\n)((?:^[^<].+\r\n)*)?(</li>)", @"<ul style = ""list-style-type: '$1';""><li>$2$3$4</ul>$4", RegexOptions.Multiline); // matches and replaces all -tags @ the beginning of the parent →tags // check
content = Regex.Replace(content, @"^(- )(.+)", @"</li><li>$1$2", RegexOptions.Multiline); // matches and replaces all -tags in bt/w, in case there are any // check
content = Regex.Replace(content, @"^(▸ )(.+\r\n)((?:^[^<].+\r\n)*)?(</li>)", @"<ul style = ""list-style-type: '$1';""><li>$2$3$4</ul>$4", RegexOptions.Multiline); // matches and replaces all ▸tags @ the beginning of the parent -tags // check
content = Regex.Replace(content, @"^(▸ )(.+)", @"</li><li>$1$2", RegexOptions.Multiline); // matches and replaces all ▸tags in bt/w, in case there are any // check

/* now, remove all unnecessary tags */
content = Regex.Replace(content, @"(</li><li>)(. )(.+)", @"$1$3", RegexOptions.Multiline); // check, but what is it for if the 2nd group is the same as the 3rd group?!

/* now, remove all new-lines only bt/w the dates */
content = Regex.Replace(content, @"(Deutsch|Wirtschaft|Englisch|GK|(BfK-(|S|L|I|B)))([^a-zA-Z])", @"<u>$1</u>$4", RegexOptions.Multiline); // appends all underlining-<u>-tags to the school subjects // check
content = Regex.Replace(content, @"\r\n", @"", RegexOptions.Multiline); // removes all new line characters from the file // check
content = Regex.Replace(content, @"(\n|--)([MDF][oir]\., )", @"$1" + "\n" + "$2", RegexOptions.Multiline);
content = Regex.Replace(content, @"^(-)+", @"", RegexOptions.Multiline); // ?: the ugly line is already gone in line 22
content = Regex.Replace(content, @"^(\w{2}\., [\d.]{10})(.+)", @"$1" + "\n" + "$2", RegexOptions.Multiline); // separates the date one line from the first line of date-entry

streamReader.Close();

string titleOfInitialFile;
string numberWithReportString;
string numberOfReport;
string monthString;
string yearStringWithTXT;
string yearString;
string monthOfGivenYear;

string[] pathChains;
pathChains = filePath.Split('\\');
titleOfInitialFile = pathChains[6];

string[] titleChains;
titleChains = titleOfInitialFile.Split('_');
numberWithReportString = titleChains[0];
string[] reportIDChains;
reportIDChains = numberWithReportString.Split('s');
numberOfReport = reportIDChains[1];
monthString = titleChains[1];
yearStringWithTXT = titleChains[2];

string[] partTitleChains;
partTitleChains = yearStringWithTXT.Split('.');
yearString = partTitleChains[0];

monthOfGivenYear = monthString + " " + yearString;

StreamWriter outputStreamWriter = File.CreateText(@"C:\Users\KanaianA\OneDrive - Fichtner GmbH & Co. KG\AzubiNachweiseBackUps\Azubi-Nachweis-als-HTML\" + "HTML-Azubi-Nachweis_" + monthString + "_" + yearString + ".txt");

outputStreamWriter.WriteLine(content);
outputStreamWriter.Close();

Console.WriteLine("Done!");
Console.WriteLine("Report #: " + numberOfReport + " of " + monthOfGivenYear + " has been formatted.\n");
Console.WriteLine("File Path: C:\\Users\\KanaianA\\OneDrive - Fichtner GmbH & Co.KG\\AzubiNachweiseBackUps\\Azubi-Nachweis-als-HTML\\"); // shows where the archive is to be found
Console.WriteLine("// Description: HTML-formatting for own reports\n" +
                  "                created with Visual Studio\n" +
                  "                made for the purpose of saving time;");

Console.ReadLine();