using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame
{
    public class Revolver
    {
        private int[] chambers;
        
        public Revolver()
        {
            // number of chambers in revolver
            chambers = new int[6];
        }

        public void LoadTheBullet()
        {
            // chamber with one bullet loaded
            chambers[0] = 1;
        }

        public void SpinChambers()
        {
            // spin the loaded one button here
            RotateChamber(new Random().Next(1, 13));
        }


        private void RotateChamber(int times)
        {
            for( int i = 1; i <= times; i++ )
            {
                // it will rotate the chamber with loaded 1 bullet
                int temp = chambers[5];
                for( int j = 5; j > 0; j-- )
                {
                    chambers[j] = chambers[j - 1];
                }
                chambers[0] = temp;
            }
        }

        public bool Fire(int pos)
        {
            // fire the buler if you are lucky you will be saved or you will be shoot dead
            return chambers[pos] == 1;
        }

    }
}
