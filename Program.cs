using System;

      
    //Programmet väljer en slumptal mellan 1-100.
        Random random = new Random();
        int slumptal = random.Next(1, 101);
        int antalgissning = 0;
        int gissa = 0;

    //Porgrammet ber användaren gissa ett tal och läser vilket tal användaren gissar på
       Console.Write("Gissa ett tal mellan 1 och 100: ");
           int _ = Convert.ToInt32(Console.ReadLine());


    //En while-loop som kollar om gissningen stämmer.
        while (gissa != slumptal)
        {
            //antal gissningar
            antalgissning++; 
           
           //om gissningen är mindre än Slumptalet ska programmet skriva "för lågt".
            if (gissa < slumptal)
                Console.Write("För lågt, gissa igen: ");
                
            //Annars om gissningen är för högt ska programmet skriva "för högt"
            else if (gissa > slumptal)
                Console.Write("För högt, gissa igen: ");
             

            //läsa av gissningen
            gissa = Convert.ToInt32(Console.ReadLine());
           
        }
            //Skriver "rätt" ifall användaren har rätt.
            Console.WriteLine("Rätt, du hade rätt på " + antalgissning + " försök.");
        
