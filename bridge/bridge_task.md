# Übung 2 – Brücke (Bridge)

## Aufgabenstellung
In  Anlehnung  an  Aufgabe  1  (Prototype)  müssen  sie  vor  der  Verwendung  ihrer  Schwerter  einen passenden Zauberspruch aufsagen, damit das Schwert nicht sofort zerbricht.  Für das lange Schwert brauchen sie einen langen Spruch, für das kurze Schwert, nur einen kurzen Spruch.

Je nach dem, ob sie sich auf der linken oder auf der rechten Seite des Flusses befinden, muss der Spruch in einer anderen Sprache aufgesagt werden. Auf der linken Seite wird _Selkisch_ gesprochen und auf der rechten Seite _Callirisch_.

## Implementierungsdetails 
Wir  benutzen  das Bridge  Pattern  (Brücke),  um  die Abstraktion  von  der Implementierung  zu trennen.

Schreiben   sie   ein   Programm,   bei   welchem   sie   über   eine   Konfiguration   (z. B.   enum-Flag, Kommandozeilenparameter,  etc.)  angeben,  welches  Schwert  sie  benützen  und  wann  und  wo  sie den Zauberspruch aufsagen. \
Erstellen sie ein Szenario nach ihrer Fantasie und geben sie auf der Konsole aus, was passiert.

## Freiwillige Fleißaufgabe 
Verwenden sie zusätzlich das Abstrakte-Fabrik-Pattern, um den Zauberspruch zu erstellen, den sie gerade benötigen
