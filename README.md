# Platform Target
Please ensure you set the appropirate bitness depending on your Content Manager client from <i>Project > Properties > Build > Platform Target</i>

*x64 for 64bit and x86 for 32bit

# config.csv
This file should sit in the same directory as the defaultcontaineraddin.dll file

There are two fields
* RecordTypeURI - This is the URI of the Record Type you'd like to default the container for
* ContainerURI - This is the URI of the container you'd like to set as default for the RecordType - <b>NOTE: Must be URI - Not Record Number</b>

You can add as many RecordTypeURIs as you like

# Deploying the defaultcontaineraddin.dll
So you don't have to place it on every users computer you may elect to store it on a shared network drive and configure with the UNC Path

*For example: \\myserver\addins\defaultcontaineraddin.dll

# Setup External Link in Content Manager
1. From CM go to <i>ADMINISTRATION > External Links > Right Click > New Generic .NET Addin</i>
2. <b>Link Name</b> = You may type your own name
3. Under <b>.NET Assembly Name</b> use the kwik select button to select the defaultcontaineraddin.dll (or paste in the UNC Path and then select the file)
4. <b>.NET Class Name</b> = DefaultContainerAddin

