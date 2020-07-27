using System;

namespace ONeuralNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            ONeuralNetwork net = new ONeuralNetwork(new int[] { 3, 3, 3, 1 });
            float[] values = new float[3] { 15, 25, 30 };
            float[] result = net.FeedForward(values);
            Console.WriteLine(result[0]);
        }
    }
}
