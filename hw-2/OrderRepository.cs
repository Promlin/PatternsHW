namespace hw_2
{
    class OrderRepository
    {
        private IOrderSource source;
        public OrderRepository(IOrderSource source) => this.source = source;
        public Order Load(int orderId) { return source.Load(orderId); }
        public void Save(Order order) { }
        public void Update(Order order) { }
        public void Delete(Order order) { }
    }
}
