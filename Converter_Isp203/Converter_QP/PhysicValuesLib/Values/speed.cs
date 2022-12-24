using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicValuesLib.Values
{
    public class speed : IValue
    {
        private double Value { get; set; }
        private string? From { get; set; }
        private string? To { get; set; }

        private string _valueName = "Скорость";

        private List<string> _measureList = new List<string>()
    {
        "Метр в секунду",
        "Километр в час",
        "Узел",
        "Мах"
    };
        public double GetConvertedValue(double value, string from, string to)
        {
            Value = value;
            From = from;
            To = to;

            ToSi();
            ToRequired();
            return Value;
        }

        public List<string> GetMeasureList()
        {
            return _measureList;
        }

        public void ToRequired()
        {
            switch (To)
            {
                case "Метр в секунду":
                    break;
                case "Километр в час":
                    Value /= 1000;
                    Value *= 3600;
                    break;
                case "Узел":
                    Value *= 1.944;
                    break;
                case "Мах":
                    Value /= 340;
                    break;
                
            }

        }

        public void ToSi()
        {
            switch (From)
            {
                case "Метр в секунду":
                    break;
                case "Километр в час":
                    Value *= 1000;
                    Value /= 3600;
                    break;
                case "Узел":
                    Value /= 1.944;
                    break;
                case "Мах":
                    Value *= 340;
                    break;
            }

        }
        public string GetValueName()
        {
            return _valueName;
        }

        private Dictionary<string, double> _coeff = new Dictionary<string, double>()
        {
            
        };

        public Dictionary<string, double> ConvertationCoefficient()
        {
            throw new NotImplementedException();
        }
    }
}
