# Platform Target
Please ensure you set the appropirate bitness depending on your Content Manager client from <i>Project > Properties > Build > Platform Target</i>

*x64 for 64bit and x86 for 32bit

# config.csv
This file should sit in the same directory as the defaultcontaineraddin.dll file

There are two fields
* RecordTypeURI - This is the URI of the Record Type you'd like to default the container for
* ContainerURI - This is the URI of the container you'd like to set as default for the RecordType - <b>NOTE: Must be URI - Not Record Number</b>

# Deploying the defaultcontaineraddin.dll
So you don't have to place it on every users computer you may elect to store it on a shared network drive and configure with the UNC Path

*For example: \\myserver\addins\defaultcontaineraddin.dll


