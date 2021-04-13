using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DictionarySortTask
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> promotionList = new Dictionary<string, string>();
            promotionList.Add("Tom Lee", "Training");
            promotionList.Add("James Anderson", "HR");
            promotionList.Add("Michael Chan", "Content Development");
            promotionList.Add("Jackie Jackson", "Training");
            promotionList.Add("Bruce Douglas", "Graphics");
            promotionList.Add("Kim Date", "HR");
            promotionList.Add("Joseph Mathews", "Content Development");
            promotionList.Add("Andrew Stephan", "Graphics");

            SortedList<string, string> promotionListArr = new SortedList<string, string>();
           promotionListArr.Add("Tom Lee", "\tTraining");
           promotionListArr.Add("James Anderson", "HR");
           promotionListArr.Add("Michael Chan", "Content Development");
           promotionListArr.Add("Jackie Jackson", "Training");
           promotionListArr.Add("Bruce Douglas", "Graphics");
           promotionListArr.Add("Kim Date", "HR");
           promotionListArr.Add("Joseph Mathews", "Content Development");
           promotionListArr.Add("Andrew Stephan", "Graphics");
            Console.Write("Name \t\t\t Department\n");
           

            if(promotionListArr.ContainsValue("Graphics"))
            {
                promotionListArr.Remove("Andrew Stephan");
            }

             foreach (var promote in promotionListArr)
            {
                Console.WriteLine($"{promote.Key}\t\t{promote.Value}");
            }
        }
    }
}
