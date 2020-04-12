using System;
using System.Drawing;

namespace FirstGame{
    class Block{
        //Static Variables
        readonly private static int EdgeSize = 100;

        //Properties
        public Color Col{ get; private set; }
        public int Value{ get; private set; }
        public int XLocation{ get; set; }
        public int YLocation{ get; set; }

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

        //Methods
        public void changeColor(){
            switch(this.Col.ToString){
                case "Tan":
                    this.Col = Color.Yellow;
                case "Yellow":
                    this.Col = Color.Gold;
                case "Gold":
                    this.Col = Color.Orange;
                case "Orange":
                    this.Col = Color.OrangeRed;
                case "OrangeRed":
                    this.Col = Color.Red;
                case "Red":
                    this.Col = Color.LightBlue;
                case "LightBlue":
                    this.Col = Color.SkyBlue;
                case "SkyBlue":
                    this.Col = Color.RoyalBlue;
                case "RoyalBlue":
                    this.Col = Color.Blue;
                case "Blue":
                    this.Col = Color.Gray;
                default:
            }
        }

        public void doubleValue(){
            this.Value *= 2;
        }
    }
}