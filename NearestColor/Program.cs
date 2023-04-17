///
///https://codingdojo.org/kata/NearestColor/
///

using NearestColor;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Saisir une couleur :");

            string couleur = Console.ReadLine().ToUpper();

            string[] couleursTab = SplitInBytes(couleur);

            string result = "";
            foreach (string color in couleursTab)
            {
                var nearestColor = new NearestSingleColor(color);

                result += nearestColor.Value;
            }

            Console.WriteLine("Résultat : " + result);
            Console.WriteLine();
        }
    }

    private static string[] SplitInBytes(string couleur)
    {
        int maxLength = 6;
        string[] splitted = new string[3];

        for (int i = 0; i < 3; i++)
        {
            splitted[i] = couleur.Substring(i * 2, 2);
        }

        return splitted;
    }
}