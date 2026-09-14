using WebaruhazTermek;

Termek termek = new Termek("Teszt Termék", 100, 10);
termek.Kiiras();

termek.Egysegar = -50;
termek.Kiiras();

termek.Keszlet = -5;
termek.Kiiras();

