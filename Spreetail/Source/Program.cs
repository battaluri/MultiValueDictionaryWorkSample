using System;
using PowerArgs;
using Spreetail.WorkSample.Source.Service;

namespace Spreetail.WorkSample
{
    public class Program
    {
        //public static string CustomUsageTemplate = "{{if HasDescription}}\r\n\r\n{{ Description !}}\r\n\r\n\r\n!{{if}}\r\n{{ifnot HasSpecifiedAction}}\r\nUsage - {{UsageSummary Cyan!}}\r\n!{{ifnot}}\r\n{{if HasGlobalUsageArguments}}\r\n\r\n{{table UsageArguments Syntax>GlobalOption Description+ !}}\r\n!{{if}}\r\n{{if HasActions}}\r\n{{if HasSpecifiedAction}}\r\n\r\n{{SpecifiedAction.DefaultAlias!}} - {{SpecifiedAction.Description!}}\r\n\r\nUsage - {{SpecifiedAction.UsageSummary Cyan!}}\r\n\r\n{{if SpecifiedAction.HasUsageArguments }}\r\n{{SpecifiedAction.DefaultAlias!}} Options\r\n{{table SpecifiedAction.UsageArguments Syntax>Option Description+ !}}\r\n!{{if}}\r\n!{{if}}\r\n{{ifnot HasSpecifiedAction}}\r\n\r\n{{if HasUsageActions}}\r\nActions\r\n{{each action in UsageActions}}\r\n\r\n  {{action.UsageSummary Cyan!}} - {{action.Description!}}\r\n\r\n{{if action.HasUsageArguments }}\r\n    {{table action.UsageArguments Syntax>Option Description+ !}}\r\n!{{if}}\r\n{{if action.HasExamples }}\r\n\r\n    {{action.DefaultAlias!}} Examples{{each example in action.Examples}}\r\n\r\n    {{if example.HasTitle}}{{example.Title Cyan!}} - !{{if}}{{example.Description!}}\r\n    {{example.Example Green!}}!{{each}}\r\n\r\n!{{if}}\r\n!{{each}}\r\n!{{if}}\r\n!{{ifnot}}\r\n!{{if}}\r\n{{if HasExamples }}\r\n\r\nExamples{{each example in Examples}}\r\n\r\n    {{if example.HasTitle}}{{example.Title Cyan!}} - !{{if}}{{example.Description!}}\r\n    {{example.Example Green!}}\r\n!{{each}}\r\n\r\n!{{if}}\r\n";

        static void Main(string[] args)
        {   
            Console.WriteLine(@"Welcome to WorkSample for Spreetail. Please enter your command.");

            while(true)
            {
                Console.Write(">");
                string input = Console.ReadLine();
                //ArgUsage.GenerateUsageFromTemplate<DataService>(CustomUsageTemplate);
                Args.InvokeAction<DataService>(input.Split(' '));
            }
        }

    }
}
