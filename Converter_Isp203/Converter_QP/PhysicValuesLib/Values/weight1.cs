using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicValuesLib.Values
{
    public class weight1 : IValue
    {
        private double Value { get; set; }
        private string? From { get; set; }
        private string? To { get; set; }

        private string _valueName = "Масса";

        private List<string> _measureList = new List<string>()
    {
        "Килограмм",
        "Грамм",
        "Миллиграмм",
        "Тонна",
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
                case "Килограмм":
                    break;
                case "Грамм":
                    Value *= 1000;
                    break;
                case "Миллиграмм":
                    Value *= 1000000;
                    break;
                case "Тонна":
                    Value /= 1000;
                    break;
            }

        }

        public void ToSi()
        {
            switch (From)
            {
                case "Килограмм":
                    break;
                case "Грамм":
                    Value /= 1000;
                    break;
                case "Миллиграмм":
                    Value /= 1000000;
                    break;
                case "Тонна":
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
