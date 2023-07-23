using System;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string message = "I am so happy today!";
            string endpoint = "https://westus2.api.cognitive.microsoft.com/text/analytics/v3.0-preview.1/sentiment";
            string apiKey = "YOUR_API_KEY_HERE";
        }
}
