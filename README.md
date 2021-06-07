# VaccineApp
Vaccine App with Front-end in Angular and back-end REST API


FRONT END

Angular Building blocks
o Componenten
o Services
o Imports in App.ts
- Angular Routing
o Routes worden opgesteld in app-routing
o Routes worden weergegeven in header of gelijkaardige component.
o Extra: Voorzie een route met een parameter, zoals een detailview.
- Angular Directives
o NgFor
o NgIf
- Binding
o One way binding
o NgModel 2 way binding
o Angular Forms binding -> Zie onder
- Components
o Componenten kunnen communiceren met elkaar
o Clear Seperation of concerns
▪ CSS, typescript en html in de juiste onderdelen van een component
- Security
o Login via JWT Tokens
- Services
o Deze classes zijn de business Layer van een Angular app.
o Gebruik Services om o.a. te communiceren met Api’s
o Maak gebruik van Dependency Injection
- Observables
o Subscribe
o Error handling
- Angular Forms
o Voorzie form binding in een Angular form
o Implementeer validatie.
▪ Minstens 1 veld is vereist
▪ Minstens 1 veld heeft een min / max lengte
o Toon duidelijke foutboodschappen / hints als er niet juist is
o Formulier kan niet verzonden worden tenzij aan alle vereisten is voldaan.
o Extra: Front-end validatie kan gebypassd worden. Toon de back-end errors als deze er zijn.
- Pipes
o Gebruik een pipe om de data opgemaakt te tonen aan de gebruikers.
▪ Als je bv een lower caps zin wilt omzetten naar Title case, doe dat dan niet in code, maar gebruik pipes
o Extra: Schrijf je eigen pipes.
- Unit Testing


BACK END:

Api
Het andere team zal zich bezig houden met het maken van een API. Deze levert de data af die de Angular app nodig heeft, en zal zich zo nodig bezig houden met berekeningen. De server side kant van een applicatie is doorgaans het brein, secuur en krachtig.
Probeer berekeningen en gevoelige info zoveel mogelijk uit de Front-End te houden. De Angular app zou idealiter enkel requests sturen en zich over het algemeen bezighouden met Front-End functionaliteit. Alle ‘zware’ berekeningen en security checks worden langs de back-end kant afgehandeld.
- Api
o Maak zoveel mogelijk gebruik van ActionResults
▪ D.w.z. returneer code 201 bij nieuw element, 200 bij correcte call, etc.
o Laat de API duidelijke foutboodschappen geven als er iets misgaat.
▪ Probeer een 500 'something went wrong' zoveel mogelijk te vermijden
o Api Routes bevatten steeds Api/…
o Correct gebruik van Http attributen met logische routes
▪ Get, Post, Delete etc.
o Data wordt zo generiek mogelijk aangeleverd.
- Security
o Passwoorden worden geëncrypteerd opgeslagen
o Gebruik Hashing & Salting
o Sommige methoden zijn niet toegankelijk voor anonieme gebruikers
o Wachtwoorden, connection strings, sleutels etc. worden niet in code opgeslagen
o Autorisatie wordt afgehandeld via JWT tokens
▪ Er moet geen onderscheid gemaakt worden tussen rollen( bv. Geen admins, enkel ingelogd of anoniem)
▪ Voorbeeldcode: Added JWT Security for Back-End by MichWouters · Pull Request #1 · MichWouters/IntroductionToAPI (github.com)
- Validatie
o Back-end doet dezelfde validatie checks als de front-end
▪ Bv. Als een wachtwoord in de FE maar 8 karakter mag hebben, mag die ook enkel 8 karakters hebben in de back-end
o Gebruikt Attributen om validatie toe te voegen
▪ Bv. [Required], [MinLength(X)] …
- Dependency Injection wordt toegepast
o Correct gebruik van Interface Segregation
o Database wordt via Dependency Injection aangesproken
o Geen onnodige ‘new’ creators
- Publieke methodes in de Business Layer hebben Unit Testing
o Mock de data laag met Moq
o Gebruik van Test en TestCase
- Data
o Communicatie via Entity Framework
o Database wordt gegenereerd met Migrations
o Seed data wordt voorzien
o Geen Nvarchar(Max) in DB
o Gebruik van relaties
▪ One to one, one to many, many to many
- AutoMapper
o Map data tussen Entities en DTO’S
o Maak gebruik van een Profile class
o Voorzie impliciete en expliciete mappings
o Geen business logica in Profile
- Clear Seperation of Concerns
- SOLID
- Defensive programming
