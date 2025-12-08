# Oefening methode : berekening verkoopsprijs
  
Nadat je de starterscode hebt binnengehaald verschijnen volgende controls op je venster :

![img1](assets/salesprice01.png)  
  
*Tip: waarschijnlijk de eerste keer dat je met een radiobutton (rondjes) aan de slag gaat?  Het standaard event van een radiobutton is het Checked-event : dubbelklik je op dergelijke control dan kom je  automatisch in de Checked event-handler terecht en kan je code beginnen schrijven.  In tegenstelling tot de checkbox kan binnen een container (venster, groupbox, stackpanel ...) slechts 1 radiobutton aangevinkt worden.*  
  
## Wat is de bedoeling ?
  
Dit is een oefening op methoden met optionele parameters (hoewel je deze oefening perfect anders zou kunnen oplossen) die een resultaat retourneren.  
We vertrekken van een standaard verkoopprijs.  We hebben 3 soorten kopers :

- gewone eindgebruiker: krijgt geen korting
- winkelier: krijgt 25 % korting
- groothandelaars: krijgt 35 % korting

Bij opstart staat geen enkele radiobutton aangevinkt en is lblSalesPrice leeg (dit is bij het ontwerp al zo, dus daar hoef je niets voor te doen).  
Klik je op één van de radiobuttons, dan dient de corresponderende verkoopprijs in het label te verschijnen:

![img2](assets/salesprice02.png)  

> *(Winkelier = 25 % korting -> 499,50 - 25 % = 374,63)*
  
Je maakt 1 methode aan met 2 parameters die een decimal waarde retourneert : de eerste parameter van het type decimal is sowieso vereist, de tweede van het type float is optioneel.  
Wordt bij de aanroep van deze methode geen tweede argument meegegeven, dan wordt de waarde van de tweede parameter ingesteld op 0.
  
Call deze methode aan vanuit je drie radiobutton event handlers.  Bij een gewone eindgebruiker zou de aanroep van de methode net iets anders moeten zijn dan bij winkelier of groothandelaar.  

## Uitbreiding

Zorg ervoor dat na een wijziging in txtDefaultSalePrice de prijs wordt herrekend. Die wordt getoond als de textbox verlaten wordt.

- Voorkom dat dit kan gebeuren als er nog geen radiobutton is aangeduid
- Breng de nodige wijzigingen aan in de code onder de radio buttons