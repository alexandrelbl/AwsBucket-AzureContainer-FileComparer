using System;
using System.Threading.Tasks;
using System.IO;
using  AwsBucket_AzureContainer_FileComparer.AppService;

namespace AwsBucket_AzureContainer_FileComparer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Listing AWS");
            var awsListTask = AwsS3BucketLister.ListObjectsAsync(args[0]);
            Console.WriteLine("Listing Azure");
            var azureListTask = AzureContainerLister.ListAsync(args[1], args[2], args[3]);
            Console.WriteLine("Awaiting both");
            await Task.WhenAll(awsListTask, azureListTask);
            Console.WriteLine("Comparing");
            BucketAndContainerComparer.Compare(awsListTask.Result, azureListTask.Result);
            File.AppendAllLines(System.AppDomain.CurrentDomain.BaseDirectory + "\\aws.txt", awsListTask.Result);
            File.AppendAllLines(System.AppDomain.CurrentDomain.BaseDirectory + "\\az.txt", azureListTask.Result);
            Console.WriteLine("Done");
        }
    }
}