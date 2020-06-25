using System;
using System.Collections.Generic;
using System.Linq;

namespace AwsBucket_AzureContainer_FileComparer.AppService
{
    public class BucketAndContainerComparer
    {
        public static void Compare(List<string> awsList, List<string> azList)
        {
            var diff = awsList.Except(azList).Distinct().ToArray();
            Console.WriteLine($"Missing on Azure: {diff.Count()}");
            foreach (var item in diff)
            {
                Console.WriteLine($"Diff: {item}");
            }

            diff = azList.Except(awsList).Distinct().ToArray();
            Console.WriteLine($"Missing on AWS: {diff.Count()}");
            foreach (var item in diff)
            {
                Console.WriteLine($"Diff: {item}");
            }
        }
    }
}