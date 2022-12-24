using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicValuesLib.Values
{
    public class length : IValue
    {
        private double Value { get; set; }
        private string? From { get; set; }
        private string? To { get; set; }

        private string _valueName = "Длина";

        private List<string> _measureList = new List<string>()
    {
        "Метр",
        "Миллиметр",
        "Сантиметр",
        "Дециметр",
        "Километр"
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
                case "Метр":
                    break;
                case "Миллиметр":
                    Value *= 1000;
                    break;
                case "Сантиметр":
                    Value *= 100;
                    break;
                case "Дециметр":
                    Value *= 10;
                    break;
                case "Километр":
                    Value /= 1000;
                    break;

            }

        }

        public void ToSi()
        {
            switch (From)
            {
                case "Метр":
                    break;
                case "Миллиметр":
                    Value /= 1000;
                    break;
                case "Сантиметр":
                    Value /= 100;
                    break;
                case "Дециметр":
                    Value /= 10;
                    break;
                case "Километр":
                    Value *= 1000;
                    break;
            }

        }
        public string GetValueName()
        {
            return _valueName;
        }

        public Dictionary<string, double> ConvertationCoefficient()
        {
            throw new NotImplementedException();
        }
    }
}
