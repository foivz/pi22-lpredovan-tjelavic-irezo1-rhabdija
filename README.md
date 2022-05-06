# FoundIT

## Projektni tim
Ime i prezime | E-mail adresa (FOI) | JMBAG | GitHub korisničko ime
------------  | ------------------- | ----- | ---------------------
Lara Predovan | lpredovan@foi.hr | 0016143713 | lpredovan
Tea Jelavić | tjelavic@foi.hr | 0016142074 | tjelavic5
Iva Rezo | irezo1@foi.hr | 0066310652 | irezo1
Robert Habdija | rhabdija@foi.hr | 0016142191 | HabacJr

## Opis domene
Cilj ove aplikacije sa korisničke strane je olakšana kupovina knjiga i stripova preko aplikacije. Korisnicima se na izbor daje žele li osobno pokupiti naručene knjige ili žele da se knjige njima dostave. Sa administratorske strane, ova bi aplikacija olakšala vođenje evidencije knjiga, prikazivanje promjena u radnom vremenu te objava nadolazećih događaja u poslovnici.

## Specifikacija projekta
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Registracija i login | Korisnik se mora registrirati kako bi mogao pristupiti aplikaciji. Admini ne moraju odraditi registraciju te imaju pre-made račune. Korisnik aplikacije se također mora prijaviti kao kupac ili admin. | Iva Rezo
F02 | Pretraživanje i sortiranje dostupnih i nedostupnih knjiga | Kupac može pretraživati knjige po autorima, žanrovima, ključnoj riječi, vrsti uveza i sl. te ih sortirati prema abecedi, relevantnosti i sl. | Lara Predovan
F03 | Kupnja i dostava knjiga | Kupac može kupiti proizvoljan broj knjiga koje prije plaćanja ulaze u košaricu. Također može birati vrstu plaćanja, npr. karticom ili pouzećem. Uz svaku provedenu kupnju, izdaje se račun koji se šalje na e-mail adresu kupca. Admini imaju uvid u popis kupljenih knjiga te u popis naručenih knjiga. Pri zaprimanju kupčeve uplate, kupcu se uz račun šalje i potvrda o narudžbi unutar koje se nalazi link na PDF datoteku naručene knjige ili stripa. Postoji mogućnost dostave knjiga preko više različitih dostavnih službi, ali i mogućnost da kupac osobno pokupi naručene knjige. | Robert Habdija
F04 | Upravljanje zalihama | Pregled zaliha knjiga i stripova. Ukoliko je broj određenih knjiga i stripova na zalihama manji od prije definirane vrijednosti, prikazuju se crvenom bojom. | Robert Habdija
F05 | Recenziranje knjiga | Kupac može recenzirati knjigu nakon kupnje. Recenzija se sastoji od ocjene i komentara od strane korisnika. Ocjena svake knjige i stripa je vidljiva u katalogu, te se klikom na iste korisnik odmah preusmjerava na cjelokupne recenzije (uključujući tekst). | Tea Jelavić
F06 | Favoriti i lista želja | Korisnik ima mogućnost staviti knjige u favorite ili na listu želja te ostali korisnici mogu vidjeti favorite i liste želja ostalih korisnika. Kraj svake knjige i stripa piše koliko puta su oni u favoritima i listi želja ostalih korisnika. Po tome se na početnoj stranici formira lista top 10 knjiga po izboru korisnika. | Tea Jelavić
F07 | Novosti | Aplikacija na početnoj stranici prikazuje novosti vezane uz poslovnicu te događaje koji se održavaju u istoj. Ukoliko korisnik to odabere, svaka objavljena novost može mu biti proslijediti mailom, kao i dodatni mailovi vezani uz ostale pogodnosti. | Iva Rezo
F08 | Korisnička podrška | Korisnicima stoji na raspolaganju forum na kojem mogu objavljivati sve probleme koje mogu imati s PDF dokumentima i/ili fizičkim izdanjima knjiga. | Lara Predovan
F09 | Izrada kataloga knjiga i stripova | Omogućuje vlasnicima unos, izmjenu i brisanje knjiga i stripova iz baze podataka. | Lara Predovan
F10 | Izrada i uređivanje korisničkog profila | Korisnik ima mogućnost mijenjanja profilne slike, e-mail adrese, spremljenih načina plaćanja te pregled kupljenih knjiga i stripova u odjeljku "Moje knjige". | Iva Rezo
F11 | Interna statistika | Admini mogu vidjeti detaljnu internu statistiku što se tiče vremena kupnje, najčešćih kupaca, najpopularnijih žanrova itd. u svrhu operativnog izvještavanja. | Tea Jelavić
F12 | Statistika | Korisnici mogu vidjeti podatke o najprodavanijim knjigama općenito, najprodavanijim knjigama po žanrovima, najbolje ocijenjenim knjigama i sl. | Robert Habdija

## Tehnologije i oprema
Visual Studio Community 2019, draw.io, GitHub, GitHub Classroom, MS SQL, MS SQL Server Management Studio, Visual Paradigm, MS Word
