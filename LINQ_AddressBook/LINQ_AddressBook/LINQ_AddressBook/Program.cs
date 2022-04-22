using System;

namespace LINQ_AddressBook
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LINQ AddressBookSystem!");
            //Create Object for DataTable
            ContactDataManager contactDataManager = new ContactDataManager();
            ContactDataManager contactDataManagers = new ContactDataManager();
            DataTableManager dataTableManger = new DataTableManager();
            dataTableManger.CreateDataTable();

            //Insert Values into Table
            contactDataManager.FirstName = "Anmol";
            contactDataManager.LastName = "Rajput";
            contactDataManager.PhoneNumber = 8969211868;
            contactDataManager.Email = "anmol999rajput@gmail.com";
            contactDataManager.Address = "Bishnpur Taraura,Patna,Bihar";
            contactDataManager.City = "Bihar";
            contactDataManager.State = "B";
            contactDataManager.zip = 844122;
            dataTableManger.InsertintoDataTable(contactDataManager);

            //Insert Values into Table
            contactDataManagers.FirstName = "Raksha";
            contactDataManagers.LastName = "Parthiban";
            contactDataManagers.PhoneNumber = 7742905050;
            contactDataManagers.Email = "Raksha@gmail.com";
            contactDataManagers.Address = "sasthri street,ambattur";
            contactDataManagers.City = "chennai";
            contactDataManagers.State = "TN";
            contactDataManagers.zip = 123001;
            dataTableManger.InsertintoDataTable(contactDataManagers);
            dataTableManger.Display();
            //Modify
            int varl = dataTableManger.EditDataTable("lalita", "Lastname");
            Console.WriteLine("Success" + varl);
            //Delete
            int var2 = dataTableManger.DeleteRowInDataTable("lalita");
            Console.WriteLine("Success" + varl);
            //Retrieve based on city or state
            string var3 = dataTableManger.RetrieveBasedOnCityorState("Bareilly", "UP");
            Console.WriteLine("Success" + varl);
            //count based on city or state
            string var4 = dataTableManger.RetrieveCountBasedOnCityorState();
            Console.WriteLine("Success" + varl);
            //sort based on name in data table
            string var5 = dataTableManger.SortBasedOnNameInDataTable("chennai");
            Console.WriteLine("Success" + varl);
        }
    }
}
