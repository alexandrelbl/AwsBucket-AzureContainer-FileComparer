# Intro
Command line tool for file quantity commparison between AWS S3 Bucket and an Azure Storage Container.

AWS Code contributed by https://github.com/AlisonFgt

# Case
Useful for double checking when migrating a large amount of storage files between the two clouds since a direct sync command line between the two clouds wasn't available up until the creation of this tool.

# Requirements / Build
* .NET Core 3.1 SDK
* AWS credentials at /users/<user>/.aws/
* dotnet restore
* dotnet build

# Usage
> AwsBucket-AzureContainer-FileComparer.exe "bucket-name" "container-name" "storageaccount-name"  "storageaccount-key"

> AwsBucket-AzureContainer-FileComparer.exe "bucket-name/directory" "container-name" "storageaccount-name" "storageaccount-key"

# TODO
* Add byte or MD5 checksum comparison to enhance comparison reliability
* Exception handling and argument validation
* Cleaner output
* Move auth args to an external file
