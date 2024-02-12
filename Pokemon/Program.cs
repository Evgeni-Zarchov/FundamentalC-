namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PokemonPower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int divider = int.Parse(Console.ReadLine());
            int pokeCount = 0;
            int power = PokemonPower;

            while (PokemonPower >= distance)
            {
                PokemonPower -= distance;
                pokeCount++;

                if (power * 0.5 ==  PokemonPower && divider > 0)
                {
                    PokemonPower /= divider;
                }
            }
            Console.WriteLine(PokemonPower);
            Console.WriteLine(pokeCount);
        }
    }
}
