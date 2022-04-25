using System;
using System.Collections.Generic;

namespace BarcodeGen
{
    class Barcode
    {
        public string Index { get; private set; }
        public List<string> ShiRpo { get; private set; }
        private readonly Random rnd = new Random();
        private readonly int[] weights = { 8, 6, 4, 2, 3, 5, 9, 7, 8 };

        public Barcode(string index,  bool isWaybill, int amount)
        {
            Index = index;
            ShiRpo = new List<string>();
            GenerateRpo(amount, isWaybill);
        }

        public Barcode(string firstChars, string secondChars, int amount)
        {
            ShiRpo = new List<string>();
            GenerateInternationalRpo(firstChars, secondChars, amount);           
        }
        
        //Генерируем ШК из трех частей: индекс ОПС и две случайные последовательности
        private void GenerateRpo(int amount, bool isWaybill)
        {
            for(int k = 0; k < amount; k++)
            {
                string firstSector = rnd.Next(10, 100).ToString();
                string secondSector;
                secondSector = isWaybill ? rnd.Next(1000000, 10000000).ToString() : rnd.Next(10000, 100000).ToString();                 
                ShiRpo.Add(Index + firstSector + secondSector);               
                ShiRpo[k] += CalculateControlBit(ShiRpo[k]).ToString();
            }           
        }

        //Рассчитываем контролькый знак для ШК
        private int CalculateControlBit(string shiRpo)
        {
            var resultSum = 0;
            for (int i = 0; i < shiRpo.Length; i++)
            {
                resultSum += i % 2 == 0 ? (int)Char.GetNumericValue(shiRpo, i) * 3 : (int)Char.GetNumericValue(shiRpo, i);
            }
            var checkSum = resultSum - (int)(resultSum / 10) * 10;
            return (10 - (checkSum == 0 ? 10 : checkSum));
        }

        //Генерируем международный ШК
        private void GenerateInternationalRpo(string firstChars, string secondChars, int amount)
        {
            for (int k = 0; k < amount; k++)
            {
                ShiRpo.Add(firstChars);
                string numbers = rnd.Next(10000000, 100000000).ToString();
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += (int)Char.GetNumericValue(numbers, i) * weights[i];
                }
                int c = 11 - sum % 11;
                string checkSum;
                if (c == 11)
                    checkSum = "5";
                else if (c == 10)
                    checkSum = "0";
                else
                    checkSum = c.ToString();
                ShiRpo[k] += numbers + checkSum + secondChars;
            }
        }
    }
}
