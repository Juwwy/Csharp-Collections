using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ExhibitionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var exhibit1 = new Exhibition("API Generator App", "Paul Jeffrey", "JavaScript", "Auditorium", "Primary");
            var exhibit2 = new Exhibition("UI/Ux Animation project", "McDonald Peters", "UX Design", "Auditorium", "Higher");
            var exhibit3 = new Exhibition("3D Game App", "Samuel Olowu", "C#", "Auditorium", "Primary");
            var exhibit4 = new Exhibition("Django e-commerce website", "Hassan Mariam", "C#", "office", "Labs");
            var exhibit5 = new Exhibition("Agile software development project", "Geena Olivera", "JavaScript", "office", "Primary");
            var exhibit6 = new Exhibition("Chai Software tester", "Ajayi Omotunde", "Chai", "Auditorium", "Higher");
            var exhibit7 = new Exhibition("E-Bot App", "Simon Violet", "JavaScript", "Auditorium", "Labs");
            var exhibit8 = new Exhibition("Weather Analyser App", "Matthew Nelson", "C#", "Auditorium", "Primary");
            var exhibit9 = new Exhibition("Calculator", "Adeyemi Christabel", "Python", "3rd floor", "Primary");
            var exhibit10 = new Exhibition("AWS cloud Hoster App", "Olanrewaju Moses", "C++", "LabGround", "Labs");
            var exhibit11 = new Exhibition("IOS Chatting App", "Stephen Lawan", "C++", "LabGround", "Labs");
            var exhibit12 = new Exhibition("Temperature Measure App", "Olayinka Onaopemipo", "C++", "office", "Labs");
            var exhibit13 = new Exhibition("Blockchain web App", "Obichukwu David", "Python", "LabGround", "Labs");
            var exhibit14 = new Exhibition("Quiz Game App", "Moses Ezinne", "JavaSCript", "LabGround", "Labs");
            var exhibit15 = new Exhibition("E-commerce Web App", "Bernard Oluwafemi", "PHP", "Auditorium", "Primary");
            var exhibit16 = new Exhibition("AngularJs Web App", "Michael Adeoye", "Javascript", "Auditorium", "Higher");
            var exhibit17 = new Exhibition("ASP.Net Mobile App", "Nneka Williams", "Microsoft .Net Core", "Conference Hall", "Labs");

            
            var allExhibition = new ArrayList(){
                exhibit1, exhibit2, exhibit3, exhibit4, exhibit5, exhibit6, exhibit7, exhibit8, exhibit9, exhibit10, exhibit11, exhibit12, exhibit13, exhibit14, exhibit15
            };

            allExhibition.Add(exhibit16);
            allExhibition.Add(exhibit17);
            allExhibition.RemoveAt(6);

            

            foreach (Exhibition exhibit in allExhibition)
            {
                Console.WriteLine($"{exhibit}");
            }
            Console.Write("TopSorer in the last Two Years in Codebits Academy\n");
            var topStudent = new Hashtable();
            topStudent.Add("Martin Joe", "87% in year 2019");
            topStudent.Add("Adewunmi Oluwafemi", "93% in year 2020");
            
            
            

            foreach (DictionaryEntry student in topStudent)
            {
                Console.WriteLine($"\nStudent Name: {student.Key}\nPercentage score: {student.Value}\n");
               
            }

            if(topStudent.ContainsKey("Adewunmi Oluwafemi"))
            {
                Console.Write($"Codebits Top scorer who gain admission into high institution\n with a high score is: Adewunmi Oluwafemi\n");
            }

            Console.Write("\nSubjects Top Scorers in last Two Years in Codebits Academy");
            var subjectBest = new Hashtable();
            subjectBest.Add("Favour Simeon", 75);
            subjectBest.Add("Yekini Abdulateef", 84);
            subjectBest.Add("Cletus Desmond", 68);

            foreach (DictionaryEntry subBest in subjectBest)
            {
                Console.WriteLine($"\nStudent Name: {subBest.Key}\nSubject Score: {subBest.Value}\n");
            }
            

        }
    }
}
