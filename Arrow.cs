//Emilynn Molesky 
//2/15/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinFletcher2
{
    enum ArrowheadType { Steel, Wood, Obsidian }
    enum FletchingType { Plastic, TurkeyFeathers, GooseFeathers }

    public class Arrow
    {
        // class varibles
        private string _arrowheadType;
        private string _fletchingType;
        private float _length;

        public string ArrowheadType
        {
            get { return _arrowheadType; }
            set { _arrowheadType = value; }
        }

        public string FletchingType
        {
            get { return _fletchingType; }
            set { _fletchingType = value; }
        }

        public float Length
        {
            get { return _length; }
            set
            {
                if (Length >= 60 && Length <= 100)
                {
                    _length = value;
                }


            }
        }

        //constructor

        public Arrow(string arrowheadType, string fletchingType, float length)
        {
            _arrowheadType = arrowheadType;
            _fletchingType = fletchingType;
            _length = length;
        }

        //method
        public float GetCost()
        {
            float arrowheadCost = _arrowheadType switch
            {
                _arrowheadType.Steel => 10,
                _arrowheadType.Wood => 3,
                _arrowheadType.Obsideian => 5,

            };
            float fletchingCost = _fletchingType switch
            {
                _fletchingType.Plastic => 10,
                _fletchingType.TurkeyFeathers => 5,
                _fletchingType.GooseFeathers => 3,

            };
            float shaftCost = _length * 0.05f;

            return arrowheadCost + fletchingCost + shaftCost;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"ArrowHead: {ArrowheadType},Fletching: {FletchingType}, Length{Length}cm ");
            Console.WriteLine($"Total Cost:{GetCost()} gold");
        }
    }
}
