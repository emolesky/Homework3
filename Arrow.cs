//Emilynn Molesky
//2/11/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinFletchers
{
    enum ArrowheadType { Steel, Wood, Obsidian }
    enum FletchingType {  Plastic, TurkeyFeathers, GooseFeathers }

    public class Arrow
    {
        // class varibles
        private string arrowheadType = "n\a";
        private string fletchingType = "n\a";
        private float length = 0;

        public string ArrowheadType
        {
            get { return this.arrowheadType; }
            set { this.arrowheadType = value; }
        }

        public string FletchingType
        {
            get { return this.fletchingType; }
            set { this.fletchingType = value; }
        }

        public float Length
        {
            get { return this.length; }
            set
            {
                if (Length >= 60 && Length <= 100)
                {
                    this.length = value;
                }
              
                   
            }
        }

        //constructor

        public Arrow(string aArrowheadType, string aFletchingType, double aLength)
        {
            this.arrowheadType = aArrowheadType;
            this.fletchingType = aFletchingType;
            this.length = aLength;
        }

        //method
        public float GetCost()
        {
            float arrowheadCost = arrowheadType switch
            {
                ArrowheadType.Steel => 10,
                ArrowheadType.Wood => 3,
                ArrowheadType.Obsideian => 5,
                
            };
            float fletchingCost = fletchingCost switch
            {
                FletchingType.Plastic => 10,
                FletchingType.TurkeyFeathers => 5,
                FletchingType.GooseFeathers => 3,

            };
            float shaftCost = length * 0.05f;

            return arrowheadCost + fletchingCost + shaftCost;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"ArrowHead: {ArrowheadType},Fletching: {FletchingType}, Length{Length}cm ");
            Console.WriteLine($"Total Cost:{GetCost()} gold");
        }
    }
}
