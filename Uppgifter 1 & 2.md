
## Uppgift 1 - Vilka klasser bör ingå i programmet?
- PersonellRegistry - för att hantera skapade intanser av Employee
- Employee - för att hantera namn & lön

## Uppgift 2 - Vilka attribut och metoder bör ingå i dessa klasser?
- AddPersonellRegistry() för att ta in User Input och genom ParsePersonellData() göra om till ett listobjekt och lägga till i PersonellRegistry
- ParsePersonellData() - för att göra om user input från str+int till list objekt 
- CleanInputData() - För att ta hand om felaktig input (ex om användaren försöker skriva in siffror i namnet eller bokstäver i lönen)
- DisplayPersonellRegistries() - För att visa användaren när den lagt till personal vad de heter och vad de har för lön

