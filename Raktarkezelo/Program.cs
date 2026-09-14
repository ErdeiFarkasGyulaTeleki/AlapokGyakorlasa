using Raktarkezelo;

RaktarElem elem = new RaktarElem("Alma", 10);

elem.Bevetelezes(5);
elem.Bevetelezes(-4);

elem.Kiadas(-7);
elem.Kiadas(99);
elem.Kiadas(4);

int almaAr = 80;
Console.WriteLine($"Tetszőleges brutto ár, {almaAr} Forinttal számítva: {RaktarElem.BruttoArSzamitas(almaAr)}");