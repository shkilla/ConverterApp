using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicValuesLib.Values
{
    public class volume : IValue
    {
        private double Value { get; set; }
        private string? From { get; set; }
        private string? To { get; set; }

        private string _valueName = "Объем";

        private List<string> _measureList = new List<string>()
    {
        "Кубический метр",
        "Кубический дециметр",
        "Кубический сантиметр",
        "Кубический миллиметр",
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
                case "Кубический метр":
                    break;
                case "Кубический дециметр":
                    Value *= 1000;
                    break;
                case "Кубический сантиметр":
                    Value *= 1000000;
                    break;
                case "Кубический миллиметр":
                    Value *= 1000000000;
                    break;
            }

        }

        public void ToSi()
        {
            switch (From)
            {
                case "Кубический метр":
                    break;
                case "Кубический дециметр":
                    Value /= 1000;
                    break;
                case "Кубический сантиметр":
                    Value /= 1000000;
                    break;
                case "Кубический миллиметр":
                    Value /= 1000000000;
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

