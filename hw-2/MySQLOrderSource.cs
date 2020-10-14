namespace hw_2
{
    class MySQLOrderSource: IOrderSource
    {
        public void Delete(Order order) { }

        public Order Load(int orderId) => null;

        public void Save(Order order) { }

        public void Update(Order order) { }
    }
}
