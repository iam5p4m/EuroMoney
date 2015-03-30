using System;

namespace ContentConsole
{
    public static class Program
    {

		/* Story 1 */
        public static void Main(string[] args)
        {
            string bannedWord1 = "swine";
            string bannedWord2 = "bad";
            string bannedWord3 = "nasty";
            string bannedWord4 = "horrible";

            string content =
                "The bad weather in Manchester in winter is bad. It rains all the time which is bad - it must be horrible for people visiting.";
			int count = 0;
            int badWords = 0;
            if (content.Contains(bannedWord1))
            {
				count = ((content.Length - content.Replace(bannedWord1, "").Length) / bannedWord1.Length);
                badWords = badWords + count;
            }
			count = 0;
            if (content.Contains(bannedWord2))
            {
				count = ((content.Length - content.Replace(bannedWord2, "").Length) / bannedWord2.Length);
				badWords = badWords + count;
            }
			count = 0;
            if (content.Contains(bannedWord3))
            {
				count = ((content.Length - content.Replace(bannedWord3, "").Length) / bannedWord3.Length);
				badWords = badWords + count;
            }
			count = 0;
            if (content.Contains(bannedWord4))
            {
				count = ((content.Length - content.Replace(bannedWord4, "").Length) / bannedWord4.Length);
				badWords = badWords + count;
            }

            Console.WriteLine("Scanned the text:");
            Console.WriteLine(content);
            Console.WriteLine("Total Number of negative words: " + badWords);

            Console.WriteLine("Press ANY key to exit.");
            Console.ReadKey();
        }
    }

}
