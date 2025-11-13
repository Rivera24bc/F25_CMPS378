using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialHelperBeta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0, plan = 0;
            double income = 0.0, rent = 0.0, necessities = 0.0, totalNeeds = 0.0, needsPercent = 0.0, wantsPercent = 0.0, savingsPercent = 0.0;
            double needsTotal = 0.0, wantsTotal = 0.0, savingsTotal = 0.0;

            Console.Write("Hello to out Financial Helper!\n");
            Console.Write("1. Financial Tips\n");
            Console.Write("2. Improve your credit score\n");
            Console.Write("3. Advise for future home\n");
            Console.Write("4. Budget Calculator\n");
            Console.Write("Which option would you like: (1-4)\n");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Welcome to Financial Tips!\n");
                Console.Write("What Day are you on: (1-31)\n");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Everyone dies someday. If you don't want the state to decide what happens to your stuff, your kids, and financial legacy, create a will before you die.");
                        break;
                    case 2:
                        Console.WriteLine("It will eventually rain. Always carry at least 3 to 6 month worth of expensive money for an emergency.");
                        break;
                    case 3:
                        Console.WriteLine("Most people go to college for years and their education ends. No matter what job profession you choose to do, you should always strive to increase your financial education.");
                        break;
                    case 4:
                        Console.WriteLine("When it comes to money and financial advice, be cautious on who is teaching you. Friends and family may mean well, but experience and background matter.");
                        break;
                    case 5:
                        Console.WriteLine("Its not how much money you make. Its how much money you keep that matters.");
                        break;
                    case 6:
                        Console.WriteLine("Money without financial intelligence is money that will soon be gone.");
                        break;
                    case 7:
                        Console.WriteLine("Learn to know the difference between an asset and a liability, and try to buy assets.");
                        break;
                    case 8:
                        Console.WriteLine("Its great to be highly educated and professionally successful, buy remember that financial literacy is just as important.");
                        break;
                    case 9:
                        Console.WriteLine("Assets don't always mean stocks and real estate. Having friends or peers who are specialists such as attorneys, accountants, and bankers are assets too.");
                        break;
                    case 10:
                        Console.WriteLine("If you're not in a high paying field or building a successful business, you may need to rely more on your retirement accounts in the future. Plan accordingly.");
                        break;
                    case 11:
                        Console.WriteLine("Robert Kiyosaki defines wealth by how long you can live without working. Know your number and strive toward financial independence.");
                        break;
                    case 12:
                        Console.WriteLine("Waiting for the right time to invest is like waiting for every light to be green before you drive, it never happen.");
                        break;
                    case 13:
                        Console.WriteLine("Your mind is your most powerful asset. Train it with financial literacy.");
                        break;
                    case 14:
                        Console.WriteLine("Instead of just saving, learn how and where to invest wisely");
                        break;
                    case 15:
                        Console.WriteLine("Investing with knowledge is not gambling. Not knowing what your invested in is similar to gambling. It becomes more of a speculation and investment.");
                        break;
                    case 16:
                        Console.WriteLine("Check where your hard work is taking you. Are you just surviving or building a financial future?");
                        break;
                    case 17:
                        Console.WriteLine("Many smart people remain poor, not because of what they know, but what they don't know");
                        break;
                    case 18:
                        Console.WriteLine("Blindly putting money in unfamiliar companies isn't investing, its speculating.");
                        break;
                    case 19:
                        Console.WriteLine("Hyped investments are risky. Just because a fast plan works doesn't make it safe or smart.");
                        break;
                    case 20:
                        Console.WriteLine("Invest in what understand, not based on daily price changes or what the hype or what the hype or news is telling you.");
                        break;
                    case 21:
                        Console.WriteLine("Dollar cost averaging is a time tested way to build wealth gradually and wisely.");
                        break;
                    case 22:
                        Console.WriteLine("Day trading is taxed more. If you buy a good fundamental company or ETF (Exchange Traded Fund) and hold it for over a year, you will be taxed lower.");
                        break;
                    case 23:
                        Console.WriteLine("For beginners, investing into ETFs (Exchange Traded Fund) are safer than picking individual stocks. Start there.)");
                        break;
                    case 24:
                        Console.WriteLine("Falling stock prices are a gift for long term investors. Learn to accept the fall of stock prices.");
                        break;
                    case 25:
                        Console.WriteLine("Past performance isn't everything. Think forward and assess future growth potential of companies.");
                        break;
                    case 26:
                        Console.WriteLine("Don't let temporary good times mask overspending habits.");
                        break;
                    case 27:
                        Console.WriteLine("Track your finances now. Just like your health, you don't want to wait till you get a heart attack to change your habits. You don't want to wait till you're are 50 years to start saving for retirement.");
                        break;
                    case 28:
                        Console.WriteLine("A cheaper, reliable used car may be a smarter financial move than buying new one.");
                        break;
                    case 29:
                        Console.WriteLine("0% interest on a brand new car doesn't make it a good deal. After you drive it off the lot, massive depreciation still happens within the first 5 years.");
                        break;
                    case 30:
                        Console.WriteLine("Mobile home appreciation depends on the land, not the trailer. Know what you're buying.");
                        break;
                    case 31:
                        Console.WriteLine("Changing money habits is like dieting. No one can do it for you. You must take responsibility.");
                        break;
                    default:
                        Console.WriteLine("You have done all financial tips for this month!");
                        break;
                }
            }
            else if (option == 2)
            {
                Console.WriteLine("Welcome to ways to increase your credit score!");
                Console.WriteLine("1. Utilize your credit as low as possible. Try to keep it below 10% of your credit limit.");
                Console.WriteLine("2. Always pay off your credit card(s) on time. Set up auto-pay because one missed payment can drop your score a lot.");
                Console.WriteLine("3. Don'e close out any old credit cards. Your payment history affects your credit score by 35%");
                Console.Writeline("4. Increase your limit whenever you can. This will help your spending ratio, keeping your credit utilization below 10%");
                Console.WriteLine("5. Diversify the types of credit you have. Credit cards, car loans, student loan, margage, etc. Open accounts as needed, don't take out unnecessary loans");
                Console.Writeline("6. Be an authorized user. You can set your children up for success by placing him/her as an authorized user on your credit card(s). This will help him/her with their credit before they are allowed to have a credit card on their own. Currently, a child can immediately be placed as an authorized when an SSN is issued to the child.");
            }
            else if (option == 3)
            {
                while (true)
                {
                    Console.WriteLine("\n--- Home ---");
                    Console.WriteLine("1) How to save up for a home");
                    Console.WriteLine("2) Things to consider before buying");
                    Console.Write("Choose (1-2): ");

                    switch (choice)
                    {
                        case 1:
                            ShowSavingIdeas(
                            Console.WriteLine("\n--- Ideas on how to save money for a house ---");
                            Console.WriteLine("• Set a timeframe and estimate down payment, repairs, and closing costs.");
                            Console.WriteLine("• Down payment can range ~3%–20%; closing costs ~2%–5%; set aside ~1%–2% for repairs/unforeseen.");
                            Console.WriteLine("• Consider growth & access: High‑Yield Savings (liquid, variable rate), CD (fixed rate, penalty if early), investing (highest potential, not guaranteed).");
                            Console.WriteLine("• Automate monthly contributions until you hit the target.");
                            );
                            break;
                        case 2:
                            ShowBuyingConsiderations(

                            Console.WriteLine("\n--- Things to consider before buying a house ---");
                            Console.WriteLine("• Use your own inspector; bring an experienced friend; research repair costs.");
                            Console.WriteLine("• Location, commute, crime, nearby stores, future development.");
                            Console.WriteLine("• Budget fit: mortgage + maintenance, HOA, emergency fund left after closing.");
                            Console.WriteLine("• Roof age/type—full replacement can be costly (plan ahead).");

                                );
                            break;
                        default;
                            Console.Write("There no more input!")
                            break;
                    }
                }
            }


            else if (option == 4)
            {
                Console.Write("Enter your monthly after tax income: $");
                income = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter your rent/mortgage: $");
                rent = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter other necessities (bills, groceries, gas, etc.): $");
                necessities = Convert.ToDouble(Console.ReadLine());

                totalNeeds = rent + necessities;

                Console.WriteLine("\nChoose a Budget Plan:");
                Console.WriteLine("1. 70 / 20 / 10");
                Console.WriteLine("2. 80 / 10 / 10");
                Console.Write("Select a plan (1 or 2): ");
                plan = Convert.ToInt32(Console.ReadLine());

                if (plan == 1)
                {
                    needsPercent = 0.70;
                    wantsPercent = 0.20;
                    savingsPercent = 0.10;
                }
                else
                {
                    needsPercent = 0.80;
                    wantsPercent = 0.10;
                    savingsPercent = 0.10;
                }

                needsTotal = income * needsPercent;
                wantsTotal = income * wantsPercent;
                savingsTotal = income * savingsPercent;

                Console.WriteLine("\n------ Budget Summary ------");
                Console.WriteLine($"Monthly Income: ${income:F2}");
                Console.WriteLine($"Needs ({needsPercent * 100}%): ${needsTotal}");
                Console.WriteLine($"Wants ({wantsPercent * 100}%): ${wantsTotal}");
                Console.WriteLine($"Savings ({savingsPercent * 100}%): ${savingsTotal}");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
