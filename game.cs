using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yes
{
    internal class game
    {
        public bool isrunning = true;
        private int counter = 0;
        private string input;

        private string getoutput()
        {
            string output = "";
            if (counter >= 0)
            {
                counter++;
                if (input != null)
                {
                    output = "Turn" + counter.ToString() + ".\n" + input;
                }
                else
                {
                    output = "Turn" + counter.ToString();
                }
            }
            return output;
        }
        private void getinput(string input)
        {
            this.input = input;
        }
        public void RunGame()
        {
            while (isrunning)
            {
                Console.Clear();
                Console.WriteLine(getoutput());
                getinput(Console.ReadLine());
            }
        }

    }
}
