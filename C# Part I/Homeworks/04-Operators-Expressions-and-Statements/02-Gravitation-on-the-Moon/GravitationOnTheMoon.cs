using System;
class GravitationOnTheMoon
{
    static void Main()
    {
        // * The gravitational field of the Moon is approximately 17% of that on the Earth.
        // * Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

        float weightEarth = float.Parse(Console.ReadLine());
        float weightMoon = weightEarth * 0.17f;
        Console.WriteLine(weightMoon);
    }
}