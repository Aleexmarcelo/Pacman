using System;

namespace Pacman
{
    public class Pacman
    {
        public int StartXCoordinate = 0;
        public int StartYCoordinate = 0;
        private int xStart = 0;
        private int yStart = 0;

        public Pacman();
        public void CreatePacman(int StartXCoordinate,int StartYCoordinate)
        {

            int StartXCoordinate;
            int StartYCoordinate;

            xStart = StartXCoordinate;
            yStart = StartYCoordinate;
        }
    }
}