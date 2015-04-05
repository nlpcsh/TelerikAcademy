
namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FurnitureManufacturer.Interfaces;
    using FurnitureManufacturer.Common;
    using System.Text;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public ICollection<IFurniture> Furnitures
        {
            get { return this.furnitures; }
            private set { this.furnitures = value; }

        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("Registration Number is not 10 symbols!");
                }
                foreach (var ch in value)
                {
                    if (ch - '0' < 0 || ch - '0' > 9)
                    {
                        throw new ArithmeticException("Not only digits int the Registration number!");
                    }
                }

                this.registrationNumber = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfNull(value, "Company Name can not be null");
                Validator.CheckIfLessSymbols(value, 5, "Company name can not be Less than 5 symbols");
                this.name = value;
            }
        }

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.Furnitures = new List<IFurniture>();
        }

        public void Add(IFurniture furniture)
        {
            Furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            Furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            //var findByModel = furnitures.FirstOrDefault(x => x.Model == model);
            //return findByModel;

            var findByModel = furnitures.FirstOrDefault(x => x.Model.ToLower() == model.ToLower());
            return findByModel;

            //foreach (var item in this.furnitures)
            //{
            //    if (string.Compare(item.Model, model, true) == 0)
            //    {
            //        return item;
            //    }
            //}

            //return null;
        }

        public string Catalog()
        {
            var catalogString = string.Format("{0} - {1} - {2} {3}", this.Name, this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture");



            if (this.Furnitures.Count != 0)
            {
                var strWriter = new StringBuilder();

                var sortedCatalog = furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model);

                foreach (var item in sortedCatalog)
                {
                    strWriter.Append(Environment.NewLine + item.ToString());
                }

                return catalogString + strWriter.ToString();
            }
            else
            {
                return catalogString;
            }

        }

        //public override string ToString()
        //{
        //    return string.Format("{0} - {1} {2}");
        //}
    }
}
