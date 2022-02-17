namespace Bridge
{
    class Program
    {
        public static void Main()
        {
            ICar volkswagen = new Volkswagen("Седан", "3 серии", "200 км/ч", new Yellow());
            ICar audi = new Audi("Хетчбек", "6 серия", "230 км/ч", new Red());

            volkswagen.ShowInfoOfCar();
            audi.ShowInfoOfCar();

        }
    }
}