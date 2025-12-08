# Methoden gebruiken van het return type void
Maak de volgende methoden en call ze vanop de juiste plaats
- FillLstCities: vul lstCities op met de namen van de 4 steden
- HideButtons: verberg btnENG en btnNL ==> call bij het opstarten
- ShowButtons: toon btnENG en btnNL ==> call bij selectie in lstCities
- ShowDutchFeedback: Zet de titel en de inhoud van lblFavoriteCity in het Nederlands
- ShowEnglishFeedback: Zet de titel en de inhoud van lblFavoriteCity in het Engels 

Bekijk ShowDutchFeedback, ShowEnglishFeedback en LstCities_SelectionChanged. Bepaalde statements komen op alle drie deze plaatsen terug. Dit noemen we code duplicatie.

Los dit probleem op dmv een methode met de naam RefreshFeedback.

# Structuur in de code

De event handler methods en de eigen methoden staan nu door elkaar. Zet de event handler methods bij elkaar en doe hetzelfde met de eigen methoden.
