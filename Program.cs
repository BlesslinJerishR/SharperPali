using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanarysPali
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
      ___           ___           ___           ___           ___                       ___     
     /\__\         /\  \         /\  \         /\  \         /\  \                     /\__\    
    /:/  /        /::\  \        \:\  \       /::\  \       /::\  \         ___       /:/ _/_   
   /:/  /        /:/\:\  \        \:\  \     /:/\:\  \     /:/\:\__\       /|  |     /:/ /\  \  
  /:/  /  ___   /:/ /::\  \   _____\:\  \   /:/ /::\  \   /:/ /:/  /      |:|  |    /:/ /::\  \ 
 /:/__/  /\__\ /:/_/:/\:\__\ /::::::::\__\ /:/_/:/\:\__\ /:/_/:/__/___    |:|  |   /:/_/:/\:\__\
 \:\  \ /:/  / \:\/:/  \/__/ \:\~~\~~\/__/ \:\/:/  \/__/ \:\/:::::/  /  __|:|__|   \:\/:/ /:/  /
  \:\  /:/  /   \::/__/       \:\  \        \::/__/       \::/~~/~~~~  /::::\  \    \::/ /:/  / 
   \:\/:/  /     \:\  \        \:\  \        \:\  \        \:\~~\      ~~~~\:\  \    \/_/:/  /  
    \::/  /       \:\__\        \:\__\        \:\__\        \:\__\          \:\__\     /:/  /   
     \/__/         \/__/         \/__/         \/__/         \/__/           \/__/     \/__/    
                                                
                                [ Developer : Blesslin Jerish R ]
                                     [ Stack : c# & .net ]
                              ");
            Console.WriteLine("Enter a word to check palindrome : ");
            string word = Console.ReadLine();
            string tenet = "";
            for (int i = word.Length-1; i >= 0; i--)
            {
                tenet += word[i].ToString();
            }
            if(tenet == word)
            {
                Console.WriteLine("The Given word is a Palindrome");
            }
            else
            {
                Console.WriteLine("The Given word is not a Palindrome");
            }
            Console.ReadLine();
        }
    }
}
