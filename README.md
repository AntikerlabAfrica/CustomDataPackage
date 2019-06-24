# CustomDataPackage
Customized Data Package Lib for use with NetTCP

# How to use
To use CDP simply initialize it with this API Call
```cs
CreateDataPackage DataPackageName = new CreateDataPackage(byte Header, "string Version", byte Auth, "string Payload");
```
then create the Package like this
```cs
var data = DataPackageName.CreatePackage();
```

To Read Data from the Created Package use this API Call
```cs
ReadDataFromPackage Data = new ReadDataFromPackage(data);
```
to get the Header byte use
```cs
Data.GetHeader();
```
to get the Version string use
```cs
Data.GetVersion();
```
to get the Auth byte use
```cs
Data.GetAuth();
```
to get the Payload string use
```cs
Data.GetPayload();
```

# License
This Projects is published under the Antikerlab Africa Public Source License (AAPSL).
Feel Free to use/contribute to this Project under the Terms & Conditions of the License.
