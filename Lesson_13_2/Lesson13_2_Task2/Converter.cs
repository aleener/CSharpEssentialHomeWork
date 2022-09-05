using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_2_Task2
{
    //    Создать класс Converter.
    //    В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, 
    //    и инициализирует поля соответствующие курсу 3-х основных валют,
    //    по отношению к гривне – public Converter(double usd, double eur, double rub). 
    //    Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, 
    //    также программа должна производить конвертацию из указанных валют в гривну.
    internal class Converter
    {
        private double usd, eur, rub;
        /*
        public decimal Usd
        {
            get { return usd; }
        }
        public decimal Eur
        {
            get { return usd; }
        }
        public decimal Rub
        {
            get { return usd; }
        }*/
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public double HrnToUsd(double value)
        {
            return Math.Round(value / usd, 2);
        }
        public double HrnToEur(double value)
        {
            return Math.Round(value / eur, 2);
        }
        public double HrnToRub(double value)
        {
            return Math.Round(value / rub, 2);
        }
        public double UsdToHrn(double value)
        {
            return Math.Round (value * usd, 2);
        }
        public double EurToHrn(double value)
        {
            return Math.Round(value * eur, 2);
        }
        public double RubToHrn(double value)
        {
            return Math.Round(value * rub, 2);
        }

    }
}
