namespace Lab_5
{
    class RunProgram
    {
        public void GoProgram()
        {
            float[] userInput = new float[3];
            int userChoice;
            
            Console.WriteLine("Välj vad du vill göra: \n1. Räkna ut arean på en cirkel. \n2. Räkna ut omkretsen på en cirkel. \n3. Räkna ut arean på en triangel. \n4. Räkna ut omkretsen på en triangel.");

            while (true) // Infinit loop that will run untill the user picks a valid option.
            {
                while (!int.TryParse(Console.ReadLine(), out userChoice))
                {
                        Console.WriteLine("Använd bara siffror.");
                     // Checks so the user only uses diggets.
                }

                if (userChoice <= 4 && userChoice != 0) // Will only run this part if the user picks a number that's valid.
                {
                    switch (userChoice)
                    {
                        case 1:

                            Console.WriteLine("Skriv ett värde för radien.");

                            while (!float.TryParse(Console.ReadLine(), out userInput[0]))
                            {
                                Console.WriteLine("Använd bara siffror.");
                            }// Checks so the user only uses diggets.

                            Circle resultCircelRadius = new Circle(userInput[0]); // Calls the Circle class and make a new variable.

                            Console.WriteLine($"Cirkelns area är: {resultCircelRadius.GetCircelArea()}"); // Calls the method from another class and insert the users input.

                            break; // Case 1 that will run and ask for a value for radius and calculate it.

                        case 2:
                            Console.WriteLine("Skriv ett värde för diametern.");

                            while (!float.TryParse(Console.ReadLine(), out userInput[0]))
                            {
                                Console.WriteLine("Använd bara siffror.");

                            }// Checks so the user only uses diggets.  
                            Circle resultCircelCircumference = new Circle(userInput[0]); // Calls the Circle class and make a new variable.
                            
                            Console.WriteLine($"Cirkelns omkrets är: {resultCircelCircumference.GetCircelCircumference()}"); // Calls the method from another class and insert the users input.

                            break; // Case 2 that will run and ask for a value for diameter and calculate it.

                        case 3:
                            Console.WriteLine("Skriv in triangelns bas värde och höjden på triangeln. \nBörja med värdet på basen på triangeln. Tryck enter efter varje inmatning.");
                            for (int inputCounter = 0; inputCounter < userInput.Length-1; inputCounter++)
                            {
                                while (!float.TryParse(Console.ReadLine(), out userInput[inputCounter]))
                                {
                                    Console.WriteLine("Använd bara siffror.");

                                }// Checks so the user only uses diggets.  
                            }
                            Triangel resultTriangelArea = new Triangel(userInput[0], userInput[1]); // Calls the Circle class and make a new variable.
                            Console.WriteLine($"Triangels area är: {resultTriangelArea.GetTriangelArea()}"); // Calls the method from another class and insert the users input.

                            break;

                        case 4:
                            Console.WriteLine("Skriv ett värde för varje sida på triangeln. Tryck enter efter varje inmatning.");
                            for (int inputCounter = 0; inputCounter < userInput.Length; inputCounter++)
                            {
                                while (!float.TryParse(Console.ReadLine(), out userInput[inputCounter]))
                                {
                                    Console.WriteLine("Använd bara siffror.");

                                }// Checks so the user only uses diggets.  
                            }
                            Triangel resultTriangelCircumference = new Triangel(userInput[0], userInput[1], userInput[2]); // Calls the Circle class and make a new variable.
                            Console.WriteLine($"Triangels omkrets är: {resultTriangelCircumference.GetTriangelCircumference()}"); // Calls the method from another class and insert the users input.

                            break; // Case 2 that will run and ask for a value for diameter and calculate it.
                    }
                    break;
                }
                    Console.WriteLine("Välj ett alternativ mellan 1 och 4.");
            }
        }
    }
}