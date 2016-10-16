class Program {
    static void Main(string[] args) {

        // create a new Product object
        ProcessProduct(new Product() {
            ProductID = 100, Name = "Kayak",
            Description = "A boat for one person",
            Price = 275M, Category = "Watersports"
        });
    }

    private static void ProcessProduct(Product prodParam) {
        //...statements to process product in some way
    }
}
