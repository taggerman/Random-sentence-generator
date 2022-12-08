using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace SentenceGenerator
{
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Sentence Generator");
            Console.WriteLine("This machine can take the choice insted of a judge");
            Console.WriteLine("This means that it dosent cost any money to");
            Console.WriteLine("sentence a crimminal:)");

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("what is your crime/felony?");
            

            Regex regex = new Regex(@"murder");
            /*Match tjekker om regex altså forbrydelse er i stringen,
             du skal have gjordt stringen til brugernes input. 
            Og copy denne funktion indtil at du ikke kan huske flere forbrydelse*/
            Match match = regex.Match("");
            string Input = Console.ReadLine();


            if (match.Success)
            {
                Console.WriteLine(match);
                

            }
            Console.ReadKey();
        }
    }
}
    

/*du er igang med at lave en sentence generator som kan vudere hvilken straf
 krimminælle skal have ud at have hyret en dommer, strafferne er min/Tages personlige holdninger
lige nu sidder du fast på at du ikke ´hved hvordan at "Match" skal læse brugerns input*/
