# This is the readme of my individual project Football Goat

Football goat is een website die zich focust op het bezorgen van de laatste voetbal statistieken. 

## requirements

1. Het systeem geeft een lijst met verschillende competities van over Europa.
2. Het systeem geeft een lijst met teams die in een competitie zitten als er op deze competitie geklikt wordt.
3. Het systeem geeft een lijst met spelers van een team als er op een team geklikt wordt.
4. Het systeem geeft verschillende grafieken van de statistieken van een speler, mits er op deze speler geklikt is. 
5. Het systeem geeft live wedstrijd statistieken weer op de pagina van een team.
6. Een gebruiker kan een account aanmaken
7. Een gebruiker kan teams toevoegen aan zijn favorieten
8. Het systeem geeft een lijst van favoriete teams weer op de gebruikerspagina

## Definition of done
1. De CI/CD heeft succesvol de code gebuilt, de docker image geupdate en de tests gerund
2. De testen hebben 60% code coverage. Deze bestaan vooral uit e2e en unit testen.
3. Elke methode in de code heeft ten minste 1 test

## C1 diagram
![C1](design/C1.png?raw=true "C1")

## C2 diagram
![C2](design/C2.png?raw=true "C2")

# Leerdoelen

## 1. Web application
"You design and build user-friendly, full-stack web applications."

## 2. Software quality
"You use software tooling and methodology that continuously monitors and improve the software quality during software development."


## 3. Agile method
"You can implement the software process for your project according to a given agile software development method."
Ik heb dit semester agile gewerkt. Door middel van sprints hebben we elke 3 weken een oplevering met de stakeholders.
De user stories worden bijgehouden in azure devops, waar deze worden toegewezen aan een sprint. Dan worden deze onderverdeeld in work items.
Na elke sprint houden we een retrospective, waarin we bespreken wat er goed en minder goed ging tijdens de sprint. Ook wordt er elke dag een stand up gehouden, waarin we bespreken wat we die dag gaan doen, en waar we tegen aan lopen. 
![Azure board](design/azureboard.png?raw=true "Azure board")

## 4. CI/CD
"You implement a (semi)automated software release process that matches the needs of the project context."
Ik heb voor de CI/CD van mijn project verschillende services geprobeerd. Na circleci en azure pipelines te hebben geprobeerd, heb ik besloten verder te gaan met github actions. Het doel van mijn ci/cd is om mijn applicatie automatisch te testen, en de veranderingen die zijn aangemaakt alleen gepushed te laten worden als deze tests slagen. 
Hier onder een afbeelding van github actions en circleci.
![cicd](design/githubActions.png?raw=true "github actions")
![cicd](design/CircleCi.png?raw=true "circleci")

## 5. Cultural differences and ethics
"You recognize and take into account cultural differences when working with multi-site teams, and are aware of ethical aspects in software development."

## 6. Requirements and design
"You translate (non-functional) requirements to extend existing (architectural) designs and can validate them using multiple types of test techniques."
Zoals boven te zien is, heb ik voor het maken van mijn applicatie requirements opgesteld, en deze omgezet in een c1 en c2 diagram. In deze diagrammen wordt weergegeven hoe de architectuur van mijn applicatie in elkaar zit. Ik test beide de frontend en backend. De frontend test ik doormiddel van component testen, en voor de backend test ik de api doormiddel van unit testen. Deze testen worden ook geinteregeerd in mijn ci/cd, waar ze automatisch uitgevoerd worden. De backend gebruikt voor de testen een in memory database. Hierdoor zijn de testen niet afhankelijk van de database, en kunnen er hierdoor dus geen fouten ontstaan.
![ut](design/unitTest.png?raw=true "unit test")

## 7. Business processes
"You can explain simple business processes and relate them to the development of your software project."

## 8. Professional
"You act in a professional manner during software development and learning."

