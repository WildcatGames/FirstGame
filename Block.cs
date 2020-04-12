using System;
using System.Drawing;

namespace _2048{
    class Block{
        //Static Variables
        readonly private static int EdgeSize = 100;

        //Properties
        public Color Col{ get; private set; }
        public int Value{ get; private set; }
        public int XLocation{ get; private set; }
        public int YLocation{ get; private set; }

        //Constructor(s)
        public Block(int val, int xLoc, int yLoc){
            this.Value = val;
            this.XLocation = xLoc;
            this.YLocation = yLoc;
            if(val == 2){
                this.Col = Color.Tan;
            } else {
                this.Col = Color.Yellow;
            }
        }
    }
}