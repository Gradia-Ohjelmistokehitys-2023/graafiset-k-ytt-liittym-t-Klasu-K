# Miinaharava – Graafiset käyttöliittymät -kurssin lopputyö

## Projektin kuvaus
Tämä on kurssin *Graafiset käyttöliittymät* lopputyö, jossa toteutin klassisen **Miinaharava-pelin** käyttäen **WinForms** GUI:ta. Projekti on rakennettu **Model-View-Presenter (MVP)** -arkkitehtuurimallin mukaisesti, keskittyen selkeään ja helposti ylläpidettävään koodiin.

> **⚠️ HUOM!**  
> Repositorion viimeisimmät kommitit on revertattu, koska testasin siirtyä WPF:ään harjoituksen vuoksi, mutta muutos jäi kesken kurssin päättyessä, joten päätin pysyä alkuperäisessä WinForms-versiossa.

## Tavoitteet
- Toteuttaa täysin toimiva Miinaharava-peli.
- Noudattaa **MVP-arkkitehtuuria** rakenteen selkeyttämiseksi.
- Toteuttaa kaikki perusominaisuudet, kuten ruutujen avaaminen ja merkitseminen.
- Tehdä pelistä mahdollisimman bugiton ja vakaa.

## Ominaisuudet
- Ruutujen avaaminen ja miinojen paljastaminen.  
- Ruutujen merkitseminen lipulla.  
- Kentän koon valinta ennen pelin alkua.  
- Ensimmäinen avaus avaa suuremman alueen.

## Kehitysmahdollisuudet
- **Ulkoasun parannus** – Ulkoasu näyttää hirveltä, sillä keskityin enemmän toiminnallisuuteen.  
- **Siirtyminen WPF:ään** – Tämä jäi kesken, mutta olisi hyvä testi siitä kuinka hyvin olen eriyttänyt "View:in" MVP arkkitehtuurin mukaan. Suurimmaksi puutteeksi eriyttämisessä huomasin sen, että määrittelin Model-osiossa WinForms-sidonnaiset napit, kun olisin voinut tehdä sen esimerkiksi luomalla oman nappi luokan tai rajapinnan.

## Teknologiat ja työkalut
- **Kieli:** C#
- **UI-framework:** WinForms
- **Arkkitehtuuri:** MVP (Model-View-Presenter)
