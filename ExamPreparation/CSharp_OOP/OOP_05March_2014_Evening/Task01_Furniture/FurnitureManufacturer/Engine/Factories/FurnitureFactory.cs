﻿namespace FurnitureManufacturer.Engine.Factories
{
    using System;

    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class FurnitureFactory : IFurnitureFactory
    {
        private const string Wooden = "Wooden";
        private const string Leather = "Leather";
        private const string Plastic = "Plastic";
        private const string InvalidMaterialName = "Invalid material name: {0}";

        public FurnitureFactory()
        {

        }


        public ITable CreateTable(string model, string material, decimal price, decimal height, decimal length, decimal width)
        {
            var newTable = new Table(model, material, price, height, length, width);
            return newTable;
        }

        public IChair CreateChair(string model, string material, decimal price, decimal height, int numberOfLegs)
        {
            var newChair = new Chair(model, material, price, height, numberOfLegs);
            return newChair;
        }

        public IAdjustableChair CreateAdjustableChair(string model, string material, decimal price, decimal height, int numberOfLegs)
        {
            var newAdjustableChair = new AdjustableChair(model, material, price, height, numberOfLegs);
            return newAdjustableChair;
        }

        public IConvertibleChair CreateConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs)
        {
            var newConvertableChair = new ConvertibleChair(model, material, price, height, numberOfLegs);
            return newConvertableChair;
        }

        private MaterialType GetMaterialType(string material)
        {
            switch (material)
            {
                case Wooden:
                    return MaterialType.Wooden;
                case Leather:
                    return MaterialType.Leather;
                case Plastic:
                    return MaterialType.Plastic;
                default:
                    throw new ArgumentException(string.Format(InvalidMaterialName, material));
            }
        }
    }
}
