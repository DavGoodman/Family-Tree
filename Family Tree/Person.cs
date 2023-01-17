using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Family_Tree
{
    public class Person
    {
        public string? FirstName { get;  set; }
        public string? LastName { get;  set; }
        public int? DateOfBirth { get;  set; }
        public int? DateOfDeath { get;  set; }
        public int? Id { get;  set; }
        public Person? Father { get;  set; }
        public Person? Mother { get;  set; }

        public string GetDescription(bool showParents)
        {
            string firstName = FirstName != null ? $"{FirstName} " : "";
            string lastName = LastName != null ? $"{LastName} " : "";
            string id = Id != null ? $"(Id={Id}) " : "";
            string dob = DateOfBirth != null ? $"Født: {DateOfBirth} " : "";
            string dod = DateOfDeath != null ? $"Død: {DateOfDeath} " : "";

            string father = Father != null && Father.FirstName != null ?
                $"Far: {Father.FirstName} " : "";
            string fatherId = Father != null && Father.Id != null ?
                $"(Id={Father.Id}) " : "";
            string? mother = Mother != null && Mother.FirstName != null ?
                $"Mor: {Mother.FirstName} " : "";
            string motherId = Mother != null && Mother.Id != null ?
                $"(Id={Mother.Id})" : "";

            string text = "";
            text += firstName;
            text += lastName;
            text += id;
            text += dob;
            text += dod;
            if (showParents)
            {
                text += father;
                text += fatherId;
                text += mother;
                text += motherId;
            }
            

            return text.Trim();
            //return $"{FirstName} {LastName} (Id={Id}) Født: {DateOfBirth} Død: {DateOfDeath} Far: {Father.FirstName} (Id={Father.Id}) Mor: {Mother.FirstName} (Id={Mother.Id})";
        }
    }
}
