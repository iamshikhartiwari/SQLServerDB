using ElectronicGadgets.Models;

namespace ElectronicGadgets.BussnissLayerLogic.Repository;

public interface IOrderDetailRepository
{
    decimal CalculateSubtotal(OrderDetail orderDetail);
    void GetOrderDetailInfo(OrderDetail orderDetail);
    void UpdateQuantity(OrderDetail orderDetail, int newQuantity);
    void AddDiscount(OrderDetail orderDetail, decimal discountAmount);
}