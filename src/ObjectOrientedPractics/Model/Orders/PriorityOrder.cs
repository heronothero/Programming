using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Приоритетный заказ с возможностью выбора даты и времени доставки
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Дата доставки приоритетного заказа
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Желаемый диапазон времени доставки
        /// </summary>
        public DeliveryTimeRange DeliveryTimeRange { get; set; }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public PriorityOrder() : base()
        {
            DeliveryDate = DateTime.Now;
            DeliveryTimeRange = DeliveryTimeRange.NineToEleven;
        }

        /// <summary>
        /// Конструктор по всем полям
        /// </summary>
        /// <param name="id">ID заказа</param>
        /// <param name="creationTime">Время создания</param>
        /// <param name="status">Статус заказа</param>
        /// <param name="deliveryAddress">Адрес доставки</param>
        /// <param name="items">Список товаров</param>
        /// <param name="deliveryDate">Желаемая дата доставки</param>
        /// <param name="deliveryTimeRange">Желаемый диапазон времени доставки</param>
        public PriorityOrder(int id, DateTime creationTime, OrderStatus status, Address deliveryAddress, 
            List<Item> items, DateTime deliveryDate, DeliveryTimeRange deliveryTimeRange) 
            : base(id, creationTime, status, deliveryAddress, items)
        {
            DeliveryDate = deliveryDate;
            DeliveryTimeRange = deliveryTimeRange;
        }

        /// <summary>
        /// Переопределяем ToString для отображения приоритетного заказа
        /// </summary>
        public override string ToString()
        {
            return $"{base.ToString()} | Дата доставки: {DeliveryDate.ToShortDateString()} | Время: {DeliveryTimeRange}";
        }

    }
}
