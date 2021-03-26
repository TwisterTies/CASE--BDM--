# CASE<<BDM>>
 Eindcase Belastingdienst
_______________________________________

Voor het uitvoeren van deze applicatie
1. Installeer de bijgeleverde .bak file middels SQL Server Management Studio door middel van het 'restoren' van een nieuwe database. (EindcaseDB.bak)
deze is te vinden in de ROOT folder van de applicatie.

2. Om de connectie met de database te maken middels de back-end, pas de connectionstring aan in de appsettings.json folder van de back-end solution.

3. Om de connectie met de front-end te maken middels de back-end. Draai eerst de front-end solution, kijk wat het localhost adres in en doe het volgende:
    - Navigeer naar de Startup.cs file
    - Bij de methode Configure pas options.WithOrigins("http://localhost:4200") aan naar het localhost adres van de front-end applicatie

4. Om de connectie met de back-end te maken vanuit de front-end, navigeer naar src/app/file-upload/file-upload.component.ts
    - Binnen deze .ts -> file pas de variabele baseURL aan naar de URL van de back-end localhost. Hierdoor is er een verbinding tussen zowel back-end als front-end.