using System;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("2Nephi", 4, 16);
        Reference r2 = new Reference("2Nephi", 4, 34, 35);
        Reference r3 = new Reference("Moroni", 10, 27);

        Scripture s1 = new Scripture(r1, "Behold, my soul delighteth in the things of the Lord; and my heart pondereth continually upon the things which I have seen and heard.");
        Scripture s2 = new Scripture(r2, "34: O Lord, wilt thou encircle me around in the robe of thy righteousness! O Lord, wilt thou make a way for mine escape before mine enemies! Wilt thou make my path straight before me! Wilt thou not place a stumbling block in my way—but that thou wouldst clear my way before me, and hedge not up my way, but the ways of mine enemy. 35: O Lord, I have trusted in thee, and I will trust in thee forever. I will not put my trust in the arm of flesh; for I know that cursed is he that putteth his trust in the arm of flesh. Yea, cursed is he that putteth his trust in man or maketh flesh his arm.");
        Scripture s3 = new Scripture(r3, "And I exhort you to remember these things; for the time speedily cometh that ye shall know that I lie not, for ye shall see me at the bar of God; and the Lord God will say unto you: Did I not declare my words unto you, which were written by this man, like as one crying from the dead, yea, even as one speaking out of the dust?");

        List<Scripture> scriptures = new List<Scripture> { s1, s2, s3 };

        Console.WriteLine("The scriptures available for practicing are:");
        Console.WriteLine("1. " + r1.GetDisplayText());
        Console.WriteLine("2. " + r2.GetDisplayText());
        Console.WriteLine("3. " + r3.GetDisplayText());
        Console.WriteLine("Choose the scripture you want to practice with: (1, 2 or 3)");

        int scriptPractice;
        while (!int.TryParse(Console.ReadLine(), out scriptPractice) || scriptPractice < 1 || scriptPractice > 3)
        {
            Console.WriteLine("Choose a valid option: 1, 2, or 3");
        }

        Scripture selectedScripture = scriptures[scriptPractice - 1];

        string choice = "";
        do
        {
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            choice = Console.ReadLine();

            if (choice != "quit")
            {
                selectedScripture.HideRandomWords(3);
                if (selectedScripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All words are hidden!");
                    break;
                }
            }

        } while (choice != "quit");

        Console.WriteLine("Nice practice! Goodbye!");
    }
}
