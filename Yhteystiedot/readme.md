# Yhteystietojen Hallintajärjestelmä

## Luo Uusi Windows Forms -Projekti:

- Avaa Visual Studio.
- Valitse "Luo uusi projekti."
- Valitse "Windows Forms App (.NET Core)" tai vastaava malli.
- Anna projektillesi nimi (esim. YhteystietoHallinta) ja valitse sijainti.
- Klikkaa "Luo" luodaksesi projektin.
## Suunnittele Yhteystietojen Hallintajärjestelmän Käyttöliittymä:

- Avaa Form-suunnittelija tuplaklikkaamalla Form1.cs:tä Ratkaisun tutkijassa.
- Käytä Työkalupakettia lisätäksesi ominaisuuksia kuten lisääminen, muokkaaminen ja poistaminen kontakteille.
- Sisällytä kentät kuten nimi, puhelinnumero, sähköposti ja osoite.
- Järjestä komponentit selkeään ja käyttäjäystävälliseen asetteluun.
## Aseta Ominaisuudet Komponenteille:

- Aseta Nimi-ominaisuus kullekin painikkeelle, jotta niihin on helpompi viitata koodissa (esim. btnLisaa, btnMuokkaa, btnPoista).
- Aseta Teksti-ominaisuus näyttääksesi painikkeiden tarkoituksen.
- Lisää ValitsemanneHenkilönKenttä -komponentti, joka näyttää valitun henkilön tiedot.
## Toteuta Tapahtumankäsittelijät:

- Tuplaklikkaa jokaista painiketta luodaksesi klikkaustapahtumankäsittelijät.
- Koodissa päivitä henkilön tiedot kenttään ja tietorakenteeseen (esimerkiksi List<Henkilo>) lisäämisen, muokkaamisen ja poistamisen yhteydessä.
## Tarkista Syöttötiedot:

- Lisää tarkistuksia varmistaaksesi, että sähköposti on oikeassa muodossa ja puhelinnumero on kelvollinen.
- Estä henkilön lisääminen, jos pakollisia tietoja puuttuu.
## Testaa Yhteystietojen Hallintajärjestelmää:

- Rakenna ja käynnistä sovelluksesi (Ctrl + F5).
- Testaa lisäämistä, muokkaamista ja poistamista, varmistaen että tiedot päivittyvät ja näkyvät oikein.
## Tietojen Tallennus ja Lataus:

### Tallennus

1. **Luo Luokka Tiedon Tallennukseen:**
   - Luo uusi luokka (esimerkiksi `TiedonTallennus`) sovelluksesi projektiin.
   - Tässä luokassa voit toteuttaa toiminnallisuuden tietojen tallentamiseksi tiedostoon.

2. **Tallenna Tiedot JSON-muodossa:**
   - Käytä JSON-muotoa, joka on helppo lukea ja kirjoittaa.
   - Käytä esimerkiksi `Newtonsoft.Json`-kirjastoa, joka tarjoaa tehokkaan JSON-toiminallisuuden. Voit lisätä tämän kirjaston NuGet-pakettina Visual Studion Package Managerilla.

3. **Tallennusmetodi:**
   - Luo metodi `TallennaTiedot(List<Henkilo> henkilot, string tiedostonimi)`, joka tallentaa `henkilot`-listan tiedostoon annetulla `tiedostonimi`-nimellä.
   - Käytä `JsonConvert.SerializeObject`-metodia muuntaaksesi listan JSON-muotoon.
   - Tallenna JSON-tieto tiedostoon esimerkiksi `File.WriteAllText`-metodilla.

   ```csharp
   using Newtonsoft.Json;
   using System.Collections.Generic;
   using System.IO;

   public class TiedonTallennus
   {
       public void TallennaTiedot(List<Henkilo> henkilot, string tiedostonimi)
       {
           string json = JsonConvert.SerializeObject(henkilot);
           File.WriteAllText(tiedostonimi, json);
       }
   }
   ## 7. Tietojen Lataus

### Latausmetodi

1. **Luo Luokka Tiedon Lataukseen:**
   - Luo uusi luokka (esimerkiksi `TiedonLataus`) sovelluksesi projektiin.
   - Tässä luokassa voit toteuttaa toiminnallisuuden tallennettujen tietojen lukemiseksi tiedostosta.

2. **Latausmetodi:**
   - Luo metodi `LataaTiedot(string tiedostonimi)`, joka lataa tallennetut tiedot tiedostosta annetulla `tiedostonimi`-nimellä.
   - Käytä `File.ReadAllText`-metodia lukeaksesi JSON-tiedoston sisällön.
   - Käytä `JsonConvert.DeserializeObject`-metodia muuntaaksesi JSON-muotoisen datan takaisin listaan.

   ```csharp
   using Newtonsoft.Json;
   using System;
   using System.Collections.Generic;
   using System.IO;

   public class TiedonLataus
   {
       public List<Henkilo> LataaTiedot(string tiedostonimi)
       {
           try
           {
               string json = File.ReadAllText(tiedostonimi);
               return JsonConvert.DeserializeObject<List<Henkilo>>(json);
           }
           catch (FileNotFoundException)
           {
               // Käsittele tiedoston puuttuminen tarvittaessa
               return new List<Henkilo>();
           }
           catch (Exception ex)
           {
               // Käsittele muut mahdolliset virheet
               Console.WriteLine($"Virhe tiedoston lataamisessa: {ex.Message}");
               return new List<Henkilo>();
           }
       }
   }
## Käytä Latausmetodia Sovelluksessasi

1. **Sovelluksen Pääluokka tai Sopiva Paikka:**
   - etsi sopiva paikka, jossa sovelluksesi käynnistyy.
   - Luo uusi instanssi `TiedonLataus`-luokasta.

   ```csharp
     // Sovelluksen pääluokassa tai muussa sopivassa paikassa
   TiedonLataus lataus = new TiedonLataus();
   
     // Lataa tiedot sovelluksen käynnistyessä
   henkilot = lataus.LataaTiedot("henkilot.json");

