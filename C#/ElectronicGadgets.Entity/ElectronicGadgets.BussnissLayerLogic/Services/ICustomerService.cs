using ElectronicGadgets.Models;
namespace ElectronicGadgets.BussnissLayerLogic.Repository;


    internal interface IBookingService
    {
        int CalculateTotalOrders(Customers customer);
        void GetCustomerDetails(Customers customer);
        void UpdateCustomerInfo(Customers customer, string newEmail, string newPhone, string newAddress);
    }

