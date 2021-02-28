using System;
using System.Threading.Tasks.Sources;

namespace Snakecode
{
    public class Counter
    {
        public int score;

        public Counter()
        {
            
        }

        public Counter(int score)
        {
            this.score = score;
        }

        public void ScoreDown()
        {
            score -= 5;
        }
        public void ScoreUp()
        {
            score +=1; 
        }


        public int GetScore()
        {
            return score; 
        }
        
        public void ScoreWrite() 
        {

            int xOffset = 80;
            int yOffset = 22;
            Colors colors = new Colors(score); 
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("Score: "+ score + " ", xOffset, yOffset++);
        }

        static void WriteText( String text, int xOffset, int yOffset )
        {
            Console.SetCursorPosition( xOffset, yOffset );
            Console.WriteLine( text );
        }
    }
}