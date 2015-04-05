
namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;

    using FurnitureManufacturer.Interfaces;
    using FurnitureManufacturer.Common;


    public abstract class Furniture : IFurniture
    {
        protected string model;
        protected string material;
        protected decimal price;
        protected decimal height;

        public string Model
        {
            get { return this.model; }
            protected set 
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Model can not be Null");
                Validator.CheckIfLessSymbols(value, 3, "Model can not be less than 3 symbols");
                this.model = value; 
            }
        }

        public string Material
        {
            get { return this.material; }

            protected set 
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Material can not be Null");
                //this.material = value;
                string firstLetter = value.ToUpper();
                string theRestOfLetters = value.Substring(1);
                string result = firstLetter[0] + theRestOfLetters;
                this.material = result; 

            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                Validator.CheckIfLessThanZero(value, "Furniture Price can not be 0 or negative!");
                this.price = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                Validator.CheckIfLessThanZero(value, "Furniture Height can not be 0 or negative!");
                this.height = value;
            }
        }

        public Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material;
            this.Price = price;
            this.Height = height;
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}
